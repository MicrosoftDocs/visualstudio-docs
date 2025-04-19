---
description: Provides an extended query context for debug symbols.
title: IDiaSessionEx
ms.date: "07/05/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSessionEx interface"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSessionEx

Provides an extended query context for debug symbols.

## Syntax

`IDiaSessionEx : IDiaSession`

## Methods
The following table shows the methods of `IDiaSessionEx`.

|Method|Description|
|------------|-----------------|
|[`IDiaSessionEx::isFastLinkPDB`](../../debugger/debug-interface-access/idiasessionex-isfastlinkpdb.md)|Retrieves a Boolean indicating that the source debug information was produced with `/DEBUG:fastlink`.|
|[`IDiaSessionEx::isPortablePDB`](../../debugger/debug-interface-access/idiasessionex-isportablepdb.md)|Retrieves a Boolean indicating that the source debug information is using the [Portable PDB format](https://github.com/dotnet/runtime/blob/main/docs/design/specs/PortablePdb-Metadata.md).|
|[`IDiaSessionEx::getSourceLinkInfo'](../../debugger/debug-interface-access/idiasessionex-getsourcelinkinfo.md)|Retrieves an enumeration of source link information.|

## Remarks

It is important to call the [`IDiaSession::put_loadAddress`](../../debugger/debug-interface-access/idiasession-put-loadaddress.md) method after creating the `IDiaSession` object — and the value passed to the `put_loadAddress` method must be non-zero — for any virtual address (VA) properties of symbols to be accessible. The load address comes from whatever program loaded the executable being debugged. For example, you can call the Win32 function `GetModuleInformation` to retrieve the load address for the executable, given a handle to the executable.

Because `IDiaSessionEx` inherits from `IDiaSession`, it alos has all the same methods, and can be passed to any function that accepts an `IDiaSession`.

## Example

This example shows how to obtain the `IDiaSessionEx` interface as part of a general initialization of the Debug Interface Access (DIA) SDK.

```C++
CComPtr<IDiaDataSource> pSource;
ComPtr<IDiaSessionEx> psessionex;

void InitializeDIA(const char *szFilename)
{
    HRESULT hr = CoCreateInstance( CLSID_DiaSource,
                                   NULL,
                                   CLSCTX_INPROC_SERVER,
                                   __uuidof( IDiaDataSource ),
                                  (void **) &pSource);
    if (FAILED(hr))
    {
        Fatal("Could not CoCreate CLSID_DiaSource. Register msdia140.dll." );
    }
    wchar_t wszFilename[ _MAX_PATH ];
    mbstowcs( wszFilename,
              szFilename,
              sizeof( wszFilename )/sizeof( wszFilename[0] ) );
    if ( FAILED( pSource->loadDataFromPdb( wszFilename ) ) )
    {
        if ( FAILED( pSource->loadDataForExe( wszFilename, NULL, NULL ) ) )
        {
            Fatal( "loadDataFromPdb/Exe" );
        }
    }

    ComPtr<IDiaSession> psession;
    if ( FAILED( pSource->openSession( &psession ) ) )
    {
        Fatal( "openSession" );
    }

    if ( FAILED( psession.QueryInterface(&psessionex) ) )
    {
        Fatal( "Failed to upgrade from IDiaSession to IDiaSessionEx, are you using an older version of msdia140.dll?" );
    }
}
```

## Requirements

Header: Dia2.h

Library: diaguids.lib

DLL: msdia140.dll

## See also
- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [Overview](../../debugger/debug-interface-access/overview-debug-interface-access-sdk.md)
- [Exe](../../debugger/debug-interface-access/exe.md)
- [`IDiaAddressMap`](../../debugger/debug-interface-access/idiaaddressmap.md)
- [`IDiaDataSource`](../../debugger/debug-interface-access/idiadatasource.md)
- [`IDiaDataSource::openSession`](../../debugger/debug-interface-access/idiadatasource-opensession.md)
- [Querying the .Pdb File](../../debugger/debug-interface-access/querying-the-dot-pdb-file.md)
