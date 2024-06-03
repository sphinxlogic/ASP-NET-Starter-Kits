// getConfNo.h : Declaration of the CgetConfNo

#pragma once

class CgetConfNoAccessor
{
public:

	// The following wizard-generated data members contain status
	// values for the corresponding fields in the column map. You
	// can use these values to hold NULL values that the database
	// returns or to hold error information when the compiler returns
	// errors. See "Field Status Data Members in Wizard-Generated
	// Accessors" in the Visual C++ documentation for more information
	// on using these fields.

	DWORD m_dwRecordStatus;

	// The following wizard-generated data members contain length
	// values for the corresponding fields in the column map.

	DWORD m_dwRecordLength;

	LONG m_RETURNVALUE;
	LONG m_Record;

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

	DEFINE_COMMAND(CgetConfNoAccessor, "{ ? = CALL dbo.getConfNo }")

	BEGIN_COLUMN_MAP(CgetConfNoAccessor)
		COLUMN_ENTRY_LENGTH_STATUS(1, m_Record, m_dwRecordLength, m_dwRecordStatus)
	END_COLUMN_MAP()

	BEGIN_PARAM_MAP(CgetConfNoAccessor)
		SET_PARAM_TYPE(DBPARAMIO_OUTPUT)
		COLUMN_ENTRY(1, m_RETURNVALUE)
	END_PARAM_MAP()
};

class CgetConfNo : public CCommand<CAccessor<CgetConfNoAccessor> >
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
		HRESULT hr = Open(m_session, "{ ? = CALL dbo.getConfNo }", pPropSet);
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


