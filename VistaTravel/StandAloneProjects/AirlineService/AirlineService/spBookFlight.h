// spBookFlight.h : Declaration of the CspBookFlight

#pragma once

class CspBookFlightAccessor
{
public:



	LONG m_RETURNVALUE;
	TCHAR m_CustomerName[51];
	TCHAR m_BillingAddress[51];
	TCHAR m_BillingCity[51];
	TCHAR m_BillingState[11];
	TCHAR m_BillingZip[11];
	TCHAR m_FFNumber[26];
	LONG m_FlightID;
	double m_Cost;
	TCHAR m_Seat[9];


	void GetRowsetProperties(CDBPropSet* pPropSet)
	{
		pPropSet->AddProperty(DBPROP_CANFETCHBACKWARDS, true, DBPROPOPTIONS_OPTIONAL);
		pPropSet->AddProperty(DBPROP_CANSCROLLBACKWARDS, true, DBPROPOPTIONS_OPTIONAL);
		pPropSet->AddProperty(DBPROP_IRowsetChange, false);
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

	DEFINE_COMMAND(CspBookFlightAccessor, "{ ? = CALL dbo.spBookFlight(?,?,?,?,?,?,?,?,?) }")

	BEGIN_COLUMN_MAP(CspBookFlightAccessor)
	END_COLUMN_MAP()

	BEGIN_PARAM_MAP(CspBookFlightAccessor)
		SET_PARAM_TYPE(DBPARAMIO_OUTPUT)
		COLUMN_ENTRY(1, m_RETURNVALUE)
		SET_PARAM_TYPE(DBPARAMIO_INPUT)
		COLUMN_ENTRY(2, m_CustomerName)
		SET_PARAM_TYPE(DBPARAMIO_INPUT)
		COLUMN_ENTRY(3, m_BillingAddress)
		SET_PARAM_TYPE(DBPARAMIO_INPUT)
		COLUMN_ENTRY(4, m_BillingCity)
		SET_PARAM_TYPE(DBPARAMIO_INPUT)
		COLUMN_ENTRY(5, m_BillingState)
		SET_PARAM_TYPE(DBPARAMIO_INPUT)
		COLUMN_ENTRY(6, m_BillingZip)
		SET_PARAM_TYPE(DBPARAMIO_INPUT)
		COLUMN_ENTRY(7, m_FFNumber)
		SET_PARAM_TYPE(DBPARAMIO_INPUT)
		COLUMN_ENTRY(8, m_FlightID)
		SET_PARAM_TYPE(DBPARAMIO_INPUT)
		COLUMN_ENTRY(9, m_Cost)
		SET_PARAM_TYPE(DBPARAMIO_INPUT)
		COLUMN_ENTRY(10, m_Seat)
	END_PARAM_MAP()
};

class CspBookFlight : public CCommand<CAccessor<CspBookFlightAccessor> >
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
		HRESULT hr = Open(m_session, "{ ? = CALL dbo.spBookFlight(?,?,?,?,?,?,?,?,?) }", pPropSet);
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


