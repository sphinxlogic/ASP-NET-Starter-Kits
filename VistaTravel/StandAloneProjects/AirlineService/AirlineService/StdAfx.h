// stdafx.h : include file for standard system include files,
// or project specific include files that are used frequently, but
// are changed infrequently
//

#pragma once

#define WIN32_LEAN_AND_MEAN		// Exclude rarely-used stuff from Windows headers
#define _ATL_ATTRIBUTES
#define _ATL_APARTMENT_THREADED
#ifndef _WIN32_WINNT
#define _WIN32_WINNT 0x0403
#endif

#include <atlisapi.h>
#include <atlsoap.h>
#include <atldbcli.h>

// TODO: reference additional headers your program requires here
