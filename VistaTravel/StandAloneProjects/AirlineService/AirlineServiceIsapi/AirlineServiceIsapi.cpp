// AirlineServiceIsapi.cpp : Defines the entry point for the DLL application.
//

#include "stdafx.h"
// For custom assert and trace handling with WebDbg.exe
#ifdef _DEBUG
CDebugReportHook g_ReportHook;
#endif
CComModule _Module;

BEGIN_OBJECT_MAP(ObjectMap)
END_OBJECT_MAP()


typedef CIsapiExtension<> ExtensionType;

// The ATL Server ISAPI extension
ExtensionType theExtension;
/////////////////////////////////////////////////////////////////////////////
// Delegate ISAPI exports to theExtension
//
extern "C" DWORD WINAPI HttpExtensionProc(LPEXTENSION_CONTROL_BLOCK lpECB)
{
	return theExtension.HttpExtensionProc(lpECB);
}

extern "C" BOOL WINAPI GetExtensionVersion(HSE_VERSION_INFO* pVer)
{
	return theExtension.GetExtensionVersion(pVer);
}

extern "C" BOOL WINAPI TerminateExtension(DWORD dwFlags)
{
	return theExtension.TerminateExtension(dwFlags);
}

/////////////////////////////////////////////////////////////////////////////
// DLL Entry Point
//
extern "C"
BOOL WINAPI DllMain(HINSTANCE hInstance, DWORD dwReason, LPVOID lpReserved)
{
	return _Module.DllMain(hInstance, dwReason, lpReserved, ObjectMap, NULL); 
}
