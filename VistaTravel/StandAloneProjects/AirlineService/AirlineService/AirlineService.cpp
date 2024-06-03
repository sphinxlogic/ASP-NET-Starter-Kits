// AirlineService.cpp : Defines the entry point for the DLL application.
//

#include "stdafx.h"
#include <ctype.h>

// For custom assert and trace handling with WebDbg.exe
#ifdef _DEBUG
CDebugReportHook g_ReportHook;
#endif

#include "AirlineService.h"
#include "Flights.h"
#include "spBookFlight.h"
#include "getconfno.h"

[ module(name="AirlineService") ];
HRESULT CAirlineServiceService::FindFlight(/*[in]*/ BSTR DepartCity, /*[in]*/ BSTR Destination, /*[in]*/ BSTR Airline, /*[out, retval]*/ BSTR *FlightInfo)
{
	USES_CONVERSION;

	CComBSTR bstrFlightInfo("<DocumentElement>");
	CString strTmp;
	CString strDate;

	CFlights m_Flights;
	CDBPropSet m_propset(DBPROPSET_ROWSET);

	CString strCommand;
	strCommand.Format("SELECT * FROM Flights WHERE DepartureCity = '%s' AND ArrivalCity = '%s' AND Airline = '%s' ORDER BY Cost ", W2A(DepartCity), W2A(Destination), W2A(Airline));

	HRESULT hr;
	hr = m_Flights.OpenDataSource();
	if (FAILED(hr))
		return hr;

	m_Flights.GetRowsetProperties(&m_propset);
	hr = m_Flights.Open(m_Flights.m_session, strCommand, &m_propset);

	if(FAILED(hr))
		return hr;

	do
	{
		// Make sure we have data
		if ( m_Flights.m_FlightID > 0 ) {
			bstrFlightInfo.Append("<Flights>");

			bstrFlightInfo.Append("<FlightID>");
			strTmp.Format("%d", m_Flights.m_FlightID);
			bstrFlightInfo.Append(strTmp);
			bstrFlightInfo.Append("</FlightID>");

			bstrFlightInfo.Append("<Airline>");
			bstrFlightInfo.Append(CString(m_Flights.m_Airline));
			bstrFlightInfo.Append("</Airline>");

			bstrFlightInfo.Append("<FlightNumber>");
			bstrFlightInfo.Append(CString(m_Flights.m_FlightNumber));
			bstrFlightInfo.Append("</FlightNumber>");
	
			// strDate.Format("%.2d", m_Flights.m_DepartureTime.month);
			// strDate += "/";
			// strTmp.Format("%.2d", m_Flights.m_DepartureTime.day);
			// strDate += strTmp;
			// strDate += "/";
			// strTmp.Format("%d", m_Flights.m_DepartureTime.year);
			// strDate += strTmp;
			// strDate += " ";
			strTmp.Format("%.2d", m_Flights.m_DepartureTime.hour);
			strDate += strTmp;
			strDate += ":";
			strTmp.Format("%.2d", m_Flights.m_DepartureTime.minute);
			strDate += strTmp;
			// strDate += ":";
			// strTmp.Format("%.2d", m_Flights.m_DepartureTime.second);
			// strDate += strTmp;
			bstrFlightInfo.Append("<DepartureTime>");
			bstrFlightInfo.Append(strDate);
			bstrFlightInfo.Append("</DepartureTime>");
		
			bstrFlightInfo.Append("<DepartureAirport>");
			bstrFlightInfo.Append(CString(m_Flights.m_DepartureAirport));
			bstrFlightInfo.Append("</DepartureAirport>");

			bstrFlightInfo.Append("<DepartureCity>");
			bstrFlightInfo.Append(CString(m_Flights.m_DepartureCity));
			bstrFlightInfo.Append("</DepartureCity>");

			bstrFlightInfo.Append("<ArrivalAirport>");
			bstrFlightInfo.Append(CString(m_Flights.m_ArrivalAirport));
			bstrFlightInfo.Append("</ArrivalAirport>");

			bstrFlightInfo.Append("<ArrivalCity>");
			bstrFlightInfo.Append(CString(m_Flights.m_ArrivalCity));
			bstrFlightInfo.Append("</ArrivalCity>");

			strTmp.Format("%.2f", m_Flights.m_Cost);
			bstrFlightInfo.Append("<Cost>");

			bstrFlightInfo.Append(strTmp);
			bstrFlightInfo.Append("</Cost>");

			strTmp.Format("%d", m_Flights.m_FlightTime);
			bstrFlightInfo.Append("<FlightTime>");
			bstrFlightInfo.Append(strTmp);
			bstrFlightInfo.Append("</FlightTime>");

			strTmp.Format("%d", m_Flights.m_FlightMiles);
			bstrFlightInfo.Append("<FlightMiles>");
			bstrFlightInfo.Append(strTmp);
			bstrFlightInfo.Append("</FlightMiles>");

			bstrFlightInfo.Append("</Flights>");
		}
	} 
	while (m_Flights.MoveNext() == S_OK);
	
	bstrFlightInfo.Append("</DocumentElement>");
	
	// Escape the XML string - this is to get around a bug
    EscapeXML(bstrFlightInfo, bstrFlightInfo);

	*FlightInfo = bstrFlightInfo.Detach();

	return S_OK;
}

HRESULT CAirlineServiceService::BookFlight(/*[in]*/ int FlightID, /*[in]*/ BSTR CustomerName, /*[in]*/ BSTR BillingAddress,
								/*[in]*/ BSTR BillingCity, /*[in]*/ BSTR BillingState, /*[in]*/ BSTR BillingZip,
								/*[in]*/ BSTR FFNumber, /*[in]*/ double Cost, /*[in]*/ BSTR Seat,
								/*[out, retval]*/ long* ConfirmationNumber)
{
	*ConfirmationNumber = 0;

	CspBookFlight bookFlight;

	bookFlight.m_FlightID = FlightID;
	_tcscpy(bookFlight.m_CustomerName, CString(CustomerName));
	_tcscpy(bookFlight.m_BillingAddress, CString(BillingAddress));
	_tcscpy(bookFlight.m_BillingCity, CString(BillingCity));
	_tcscpy(bookFlight.m_BillingState, CString(BillingState));
	_tcscpy(bookFlight.m_BillingZip, CString(BillingZip));
	_tcscpy(bookFlight.m_FFNumber, CString(FFNumber));
	bookFlight.m_Cost = Cost;
	_tcscpy(bookFlight.m_Seat, CString(Seat));

	HRESULT hr = bookFlight.OpenAll();

	CgetConfNo confno;
	hr = confno.OpenAll();
	
	if (FAILED(hr))
		return hr;

	// this should be only one record!
	if (confno.MoveNext() == S_OK)
		*ConfirmationNumber = confno.m_Record;

	return hr;
}