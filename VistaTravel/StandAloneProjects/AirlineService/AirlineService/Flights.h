// Flights.h : Declaration of the CFlights

#pragma once

class CFlightsAccessor
{
public:

	// The following wizard-generated data members contain status
	// values for the corresponding fields in the column map. You
	// can use these values to hold NULL values that the database
	// returns or to hold error information when the compiler returns
	// errors. See "Field Status Data Members in Wizard-Generated
	// Accessors" in the Visual C++ documentation for more information
	// on using these fields.

	DWORD m_dwFlightIDStatus;
	DWORD m_dwAirlineStatus;
	DWORD m_dwFlightNumberStatus;
	DWORD m_dwDepartureTimeStatus;
	DWORD m_dwDepartureAirportStatus;
	DWORD m_dwDepartureCityStatus;
	DWORD m_dwArrivalAirportStatus;
	DWORD m_dwArrivalCityStatus;
	DWORD m_dwCostStatus;
	DWORD m_dwFlightTimeStatus;
	DWORD m_dwFlightMilesStatus;

	// The following wizard-generated data members contain length
	// values for the corresponding fields in the column map.

	DWORD m_dwFlightIDLength;
	DWORD m_dwAirlineLength;
	DWORD m_dwFlightNumberLength;
	DWORD m_dwDepartureTimeLength;
	DWORD m_dwDepartureAirportLength;
	DWORD m_dwDepartureCityLength;
	DWORD m_dwArrivalAirportLength;
	DWORD m_dwArrivalCityLength;
	DWORD m_dwCostLength;
	DWORD m_dwFlightTimeLength;
	DWORD m_dwFlightMilesLength;

	LONG m_FlightID;
	TCHAR m_Airline[51];
	TCHAR m_FlightNumber[11];
	DBTIMESTAMP m_DepartureTime;
	TCHAR m_DepartureAirport[11];
	TCHAR m_DepartureCity[51];
	TCHAR m_ArrivalAirport[11];
	TCHAR m_ArrivalCity[51];
	double m_Cost;
	LONG m_FlightTime;
	LONG m_FlightMiles;

	void GetRowsetProperties(CDBPropSet* pPropSet)
	{
		pPropSet->AddProperty(DBPROP_CANFETCHBACKWARDS, true, DBPROPOPTIONS_OPTIONAL);
		pPropSet->AddProperty(DBPROP_CANSCROLLBACKWARDS, true, DBPROPOPTIONS_OPTIONAL);
		pPropSet->AddProperty(DBPROP_IRowsetChange, true);
	}

	HRESULT OpenDataSource()
	{
		CDataSource _db;
		HRESULT hr;
		hr = _db.OpenFromInitializationString(L"Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=AirlineService;Data Source=(local);Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=local;Use Encryption for Data=False;Tag with column collation when possible=False");
		if (FAILED(hr))
		{
#ifdef _DEBUG
			AtlTraceErrorRecords(hr);
#endif
			return hr;
		}
		return m_session.Open(_db);
	}

	void CloseDataSource()
	{
		m_session.Close();
	}

	operator const CSession&()
	{
		return m_session;
	}

	CSession m_session;

	DEFINE_COMMAND(CFlightsAccessor, " \
	SELECT \
		FlightID, \
		Airline, \
		FlightNumber, \
		DepartureTime, \
		DepartureAirport, \
		DepartureCity, \
		ArrivalAirport, \
		ArrivalCity, \
		Cost, \
		FlightTime, \
		FlightMiles \
		FROM dbo.Flights")

	BEGIN_COLUMN_MAP(CFlightsAccessor)
		COLUMN_ENTRY_LENGTH_STATUS(1, m_FlightID, m_dwFlightIDLength, m_dwFlightIDStatus)
		COLUMN_ENTRY_LENGTH_STATUS(2, m_Airline, m_dwAirlineLength, m_dwAirlineStatus)
		COLUMN_ENTRY_LENGTH_STATUS(3, m_FlightNumber, m_dwFlightNumberLength, m_dwFlightNumberStatus)
		COLUMN_ENTRY_LENGTH_STATUS(4, m_DepartureTime, m_dwDepartureTimeLength, m_dwDepartureTimeStatus)
		COLUMN_ENTRY_LENGTH_STATUS(5, m_DepartureAirport, m_dwDepartureAirportLength, m_dwDepartureAirportStatus)
		COLUMN_ENTRY_LENGTH_STATUS(6, m_DepartureCity, m_dwDepartureCityLength, m_dwDepartureCityStatus)
		COLUMN_ENTRY_LENGTH_STATUS(7, m_ArrivalAirport, m_dwArrivalAirportLength, m_dwArrivalAirportStatus)
		COLUMN_ENTRY_LENGTH_STATUS(8, m_ArrivalCity, m_dwArrivalCityLength, m_dwArrivalCityStatus)
		COLUMN_ENTRY_LENGTH_STATUS(9, m_Cost, m_dwCostLength, m_dwCostStatus)
		COLUMN_ENTRY_LENGTH_STATUS(10, m_FlightTime, m_dwFlightTimeLength, m_dwFlightTimeStatus)
		COLUMN_ENTRY_LENGTH_STATUS(11, m_FlightMiles, m_dwFlightMilesLength, m_dwFlightMilesStatus)
	END_COLUMN_MAP()
};

class CFlights : public CCommand<CAccessor<CFlightsAccessor> >
{
public:
	HRESULT OpenAll()
	{
		HRESULT hr;
		hr = OpenDataSource();
		if (FAILED(hr))
			return hr;
		__if_exists(GetRowsetProperties)
		{
			CDBPropSet propset(DBPROPSET_ROWSET);
			__if_exists(HasBookmark)
			{
				propset.AddProperty(DBPROP_IRowsetLocate, true);
			}
			GetRowsetProperties(&propset);
			return OpenRowset(&propset);
		}
		__if_not_exists(GetRowsetProperties)
		{
			__if_exists(HasBookmark)
			{
				CDBPropSet propset(DBPROPSET_ROWSET);
				propset.AddProperty(DBPROP_IRowsetLocate, true);
				return OpenRowset(&propset);
			}
		}
		return OpenRowset();
	}

	HRESULT OpenRowset(DBPROPSET *pPropSet = NULL)
	{
		HRESULT hr = Open(m_session, " \
	SELECT \
		FlightID, \
		Airline, \
		FlightNumber, \
		DepartureTime, \
		DepartureAirport, \
		DepartureCity, \
		ArrivalAirport, \
		ArrivalCity, \
		Cost, \
		FlightTime, \
		FlightMiles \
		FROM dbo.Flights", pPropSet);
#ifdef _DEBUG
		if(FAILED(hr))
			AtlTraceErrorRecords(hr);
#endif
		return hr;
	}

	void CloseAll()
	{
		Close();
		CloseDataSource();
		m_spCommand.Release();
	}
};


