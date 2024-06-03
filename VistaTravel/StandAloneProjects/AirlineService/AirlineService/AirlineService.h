// AirlineService.h : Defines the ATL Server request handler class
//
#pragma once


/////////////////////////////////////////////////////////////////////////////
// IAirlineServiceService - web service interface declaration
//
[
	uuid("643E20E1-0DC6-44DD-B6E3-01A2C28BBDF6"), 
	object
]
__interface IAirlineServiceService
{
	[id(1)] HRESULT FindFlight([in] BSTR DepartCity, [in] BSTR Destination, [in] BSTR Airline, [out, retval] BSTR *bstrFlightInfo);
	[id(2)] HRESULT BookFlight([in] int FlightID, [in] BSTR CustomerName, [in] BSTR BillingAddress,
								[in] BSTR BillingCity, [in] BSTR BillingState, [in] BSTR BillingZip,
								[in] BSTR FFNumber, [in] double Cost, [in] BSTR Seat,
								[out, retval] long* ConfirmationNumber);
	// TODO: Add additional web service methods here
};

/////////////////////////////////////////////////////////////////////////////
// AirlineServiceService - web service implementation
//
[
	coclass,
	request_handler(name="Default", sdl="GenAirlineServiceServiceSDL"),
	soap_handler(
		name="AirlineServiceServiceService", 
		namespace="urn:AirlineServiceService-service",
		protocol="soap"
	),
	uuid("68E15C92-46AB-4FE7-9408-A41FD838D310"), 
	default("IAirlineServiceService")
]
class CAirlineServiceService :
	public IAirlineServiceService
{
public:
	// This is a sample web service method that shows how to use the 
	// soap_method attribute to expose a method as a web method

	[ soap_method ]
	HRESULT FindFlight(/*[in]*/ BSTR DepartCity, /*[in]*/ BSTR Destination, /*[in]*/ BSTR Airline, /*[out, retval]*/ BSTR *FlightInfo);

	[ soap_method ]
	HRESULT BookFlight(/*[in]*/ int FlightID, /*[in]*/ BSTR CustomerName, /*[in]*/ BSTR BillingAddress,
								/*[in]*/ BSTR BillingCity, /*[in]*/ BSTR BillingState, /*[in]*/ BSTR BillingZip,
								/*[in]*/ BSTR FFNumber, /*[in]*/ double Cost, /*[in]*/ BSTR Seat,
								/*[out, retval]*/ long* ConfirmationNumber);

	// necessary to work around a bug in the PDC technology preview release
	void EscapeXML(CComBSTR input, CComBSTR& output)
	{
		USES_CONVERSION;
		CStringA sOutput = OLE2T(input);

		// escape the < and >
		sOutput.Replace(">", "&gt;");
		sOutput.Replace("<", "&lt;");

		output = CComBSTR(sOutput);

	}
}; // class CAirlineServiceService
