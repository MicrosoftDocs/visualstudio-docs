---
description: Provides a query context for debug symbols.
title: IDiaSession
ms.date: "07/03/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession interface"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSession

Provides a query context for debug symbols.

## Syntax

`IDiaSession : IUnknown`

## Methods
The following table shows the methods of `IDiaSession`.

|Method|Description|
|------------|-----------------|
|[`IDiaSession::get_loadAddress`](../../debugger/debug-interface-access/idiasession-get-loadaddress.md)|Retrieves the load address for the executable file that corresponds to the symbols in this symbol store. This is the same value that was passed to the `put_loadAddress` method.|
|[`IDiaSession::put_loadAddress`](../../debugger/debug-interface-access/idiasession-put-loadaddress.md)|Sets the load address for the executable file that corresponds to the symbols in this symbol store. **Note:**  It is important to call this method when you get an `IDiaSession` object and before you start using the object.|
|[`IDiaSession::get_globalScope`](../../debugger/debug-interface-access/idiasession-get-globalscope.md)|Retrieves a reference to the global scope.|
|[`IDiaSession::getEnumTables`](../../debugger/debug-interface-access/idiasession-getenumtables.md)|Retrieves an enumerator for all tables contained in the symbol store.|
|[`IDiaSession::getSymbolsByAddr`](../../debugger/debug-interface-access/idiasession-getsymbolsbyaddr.md)|Retrieves an enumerator for all named symbols at static locations.|
|[`IDiaSession::findChildren`](../../debugger/debug-interface-access/idiasession-findchildren.md)|Retrieves all children of a specified parent identifier that match the name and symbol type.|
|[`IDiaSession::findChildrenEx`](../../debugger/debug-interface-access/idiasession-findchildrenex.md)|Retrieves all children of a specified parent identifier that match the name and symbol type, including optimized locals.|
|[`IDiaSession::findChildrenExByAddr`](../../debugger/debug-interface-access/idiasession-findchildrenexbyaddr.md)|Retrieves all children of a specified parent identifier that match the name and symbol type, including optimized locals, that contains, or is closest to, a specified address.|
|[`IDiaSession::findChildrenExByVA`](../../debugger/debug-interface-access/idiasession-findchildrenexbyva.md)|Retrieves all children of a specified parent identifier that match the name and symbol type, including optimized locals, that contains, or is closest to, a specified virtual address (VA).|
|[`IDiaSession::findChildrenExByRVA`](../../debugger/debug-interface-access/idiasession-findchildrenexbyrva.md)|Retrieves all children of a specified parent identifier that match the name and symbol type, including optimized locals, that contains, or is closest to, a specified relative virtual address (RVA).|
|[`IDiaSession::findSymbolByAddr`](../../debugger/debug-interface-access/idiasession-findsymbolbyaddr.md)|Retrieves a specified symbol type that contains, or is closest to, a specified address.|
|[`IDiaSession::findSymbolByRVA`](../../debugger/debug-interface-access/idiasession-findsymbolbyrva.md)|Retrieves a specified symbol type that contains, or is closest to, a specified relative virtual address (RVA).|
|[`IDiaSession::findSymbolByVA`](../../debugger/debug-interface-access/idiasession-findsymbolbyva.md)|Retrieves a specified symbol type that contains, or is closest to, a specified virtual address (VA).|
|[`IDiaSession::findSymbolByToken`](../../debugger/debug-interface-access/idiasession-findsymbolbytoken.md)|Retrieves the symbol that contains a specified metadata token.|
|[`IDiaSession::symsAreEquiv`](../../debugger/debug-interface-access/idiasession-symsareequiv.md)|Checks to see if two symbols are equivalent.|
|[`IDiaSession::symbolById`](../../debugger/debug-interface-access/idiasession-symbolbyid.md)|Retrieves a symbol by its unique identifier.|
|[`IDiaSession::findSymbolByRVAEx`](../../debugger/debug-interface-access/idiasession-findsymbolbyrvaex.md)|Retrieves a specified symbol type that contains, or is closest to, a specified relative virtual address and offset.|
|[`IDiaSession::findSymbolByVAEx`](../../debugger/debug-interface-access/idiasession-findsymbolbyvaex.md)|Retrieves a specified symbol type that contains, or is closest to, a specified virtual address and offset.|
|[`IDiaSession::findFile`](../../debugger/debug-interface-access/idiasession-findfile.md)|Retrieves a source file by compiland and name.|
|[`IDiaSession::findFileById`](../../debugger/debug-interface-access/idiasession-findfilebyid.md)|Retrieves a source file by source file identifier.|
|[`IDiaSession::findLines`](../../debugger/debug-interface-access/idiasession-findlines.md)|Retrieves line numbers within a specified compiland and source file identifier.|
|[`IDiaSession::findLinesByAddr`](../../debugger/debug-interface-access/idiasession-findlinesbyaddr.md)|Retrieves the lines in a specified compiland that contain a specified address.|
|[`IDiaSession::findLinesByRVA`](../../debugger/debug-interface-access/idiasession-findlinesbyrva.md)|Retrieves the lines in a specified compiland that contain a specified relative virtual address.|
|[`IDiaSession::findLinesByVA`](../../debugger/debug-interface-access/idiasession-findlinesbyva.md)|Finds the line number information for lines contained in a specified address range.|
|[`IDiaSession::findLinesByLinenum`](../../debugger/debug-interface-access/idiasession-findlinesbylinenum.md)|Retrieves the lines in a specified compiland by source file and line number.|
|[`IDiaSession::findInjectedSource`](../../debugger/debug-interface-access/idiasession-findinjectedsource.md)|Retrieves a source that has been placed into the symbol store by attribute providers or other components of the compilation process.|
|[`IDiaSession::getEnumDebugStreams`](../../debugger/debug-interface-access/idiasession-getenumdebugstreams.md)|Retrieves an enumerated sequence of debug data streams.|
|[`IDiaSession::findInlineFramesByAddr`](../../debugger/debug-interface-access/idiasession-findinlineframesbyaddr.md)|Retrieves an enumeration that allows a client to iterate through all of the inline frames on a given address.|
|[`IDiaSession::findInlineFramesByRVA`](../../debugger/debug-interface-access/idiasession-findinlineframesbyrva.md)|Retrieves an enumeration that allows a client to iterate through all of the inline frames on a specified relative virtual address (RVA).|
|[`IDiaSession::findInlineFramesByVA`](../../debugger/debug-interface-access/idiasession-findinlineframesbyva.md)|Retrieves an enumeration that allows a client to iterate through all of the inline frames on a specified virtual address (VA).|
|[`IDiaSession::findInlineeLines`](../../debugger/debug-interface-access/idiasession-findinlineelines.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, by the specified parent symbol.|
|[`IDiaSession::findInlineeLinesByAddr`](../../debugger/debug-interface-access/idiasession-findinlineelinesbyaddr.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, by the specified parent symbol and are contained within the specified address range.|
|[`IDiaSession::findInlineeLinesByRVA`](../../debugger/debug-interface-access/idiasession-findinlineelinesbyrva.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, by the specified parent symbol and are contained within the specified relative virtual address (RVA).|
|[`IDiaSession::findInlineeLinesByVA`](../../debugger/debug-interface-access/idiasession-findinlineelinesbyva.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, by the specified parent symbol and are contained within the specified virtual address (VA).|
|[`IDiaSession::findInlineeLinesByLinenum`](../../debugger/debug-interface-access/idiasession-findinlineelinesbylinenum.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, in the specified source file and line number.|
|[`IDiaSession::findInlineesByName`](../../debugger/debug-interface-access/idiasession-findinlineesbyname.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all inlined functions that match a specified name.|
|[`IDiaSession::findAcceleratorInlineesByLinenum`](../../debugger/debug-interface-access/idiasession-findacceleratorinlineesbylinenum.md)|Returns an enumeration of symbols for inline frames that correspond to the specified source location.|
|[`IDiaSession::findSymbolsForAcceleratorPointerTag`](../../debugger/debug-interface-access/idiasession-findsymbolsforacceleratorpointertag.md)|Returns an enumeration of symbols for the variable that the specified tag value corresponds to in the parent Accelerator stub function.|
|[`IDiaSession::findSymbolsByRVAForAcceleratorPointerTag`](../../debugger/debug-interface-access/idiasession-findsymbolsbyrvaforacceleratorpointertag.md)|Given a corresponding tag value, this method returns an enumeration of symbols that are contained in a specified parent Accelerator stub function at a specified relative virtual address.|
|[`IDiaSession::findAcceleratorInlineesByName`](../../debugger/debug-interface-access/idiasession-findacceleratorinlineesbyname.md)|Returns an enumeration of symbols for inline frames corresponding to the specified inline function name.|
|[`IDiaSession::addressForVA`](../../debugger/debug-interface-access/idiasession-addressForVA.md)|Returns the equivalent address for the specified virtual address (VA).|
|[`IDiaSession::addressForRVA`](../../debugger/debug-interface-access/idiasession-addressforrva.md)|Returns the equivalent address for the specified relative virtual address (RVA).|
|[`IDiaSession::findILOffsetsByAddr`](../../debugger/debug-interface-access/idiasession-findiloffsetsbyaddr.md)|Retrieves an enumeration that allows a client to iterate through the MSIL offsets within a specified address range.|
|[`IDiaSession::findILOffsetsByRVA`](../../debugger/debug-interface-access/idiasession-findiloffsetsbyrva.md)|Retrieves an enumeration that allows a client to iterate through the MSIL offsets within a specified relative virtual address (RVA) range.|
|[`IDiaSession::findILOffsetsByVA`](../../debugger/debug-interface-access/idiasession-findiloffsetsbyva.md)|Retrieves an enumeration that allows a client to iterate through the MSIL offsets within a specified virtual address (VA) range.|
|[`IDiaSession::findInputAssemblyFiles`](../../debugger/debug-interface-access/idiasession-findinputassemblyfiles.md)|Retrieves an enumeration that allows a client to iterate through the .NET Native input assembly files.|
|[`IDiaSession::findInputAssembly`](../../debugger/debug-interface-access/idiasession-findinputassembly.md)|Retrieves a .NET Native input assembly file by index.|
|[`IDiaSession::findInputAssemblyById`](../../debugger/debug-interface-access/idiasession-findinputassemblybyid.md)|Retrieves .NET Native input assembly file by unique identifier.|
|[`IDiaSession::getFuncMDTokenMapSize`](../../debugger/debug-interface-access/idiasession-getfuncmdtokenmapsize.md)|Retrieves the size, in bytes, of the .NET Native metadata function token map.|
|[`IDiaSession::getFuncMDTokenMap`](../../debugger/debug-interface-access/idiasession-getfuncmdtokenmap.md)|Retrieves the contents of the .NET Native metadata function token map.|
|[`IDiaSession::getTypeMDTokenMapSize`](../../debugger/debug-interface-access/idiasession-gettypemdtokenmapsize.md)|Retrieves the size, in bytes, of the .NET Native metadata type token map.|
|[`IDiaSession::getTypeMDTokenMap`](../../debugger/debug-interface-access/idiasession-gettypemdtokenmap.md)|Retrieves the contents of the .NET Native metadata type token map.|
|[`IDiaSession::getNumberOfFunctionFragments_VA`](../../debugger/debug-interface-access/idiasession-getnumberoffunctionfragments_va.md)|Retrieves the number of discontiguous fragments for the function at the specified virtual address (VA).|
|[`IDiaSession::getNumberOfFunctionFragments_RVA`](../../debugger/debug-interface-access/idiasession-getnumberoffunctionfragments_rva.md)|Retrieves the number of discontiguous fragments for the function at the specified relative virtual address (RVA).|
|[`IDiaSession::getFunctionFragments_VA`](../../debugger/debug-interface-access/idiasession-getfunctionfragments_va.md)|Retrieves the addresses and lengths of discontiguous fragments for the function at the specified virtual address (VA).|
|[`IDiaSession::getFunctionFragments_RVA`](../../debugger/debug-interface-access/idiasession-getfunctionfragments_rva.md)|Retrieves the addresses and lengths of discontiguous fragments for the function at the specified relative virtual address (RVA).|
|[`IDiaSession::getExports`](../../debugger/debug-interface-access/idiasession-getexports.md)|Retrieves an enumerator for all exported symbols.|
|[`IDiaSession::getHeapAllocationSites`](../../debugger/debug-interface-access/idiasession-getheapallocationsites.md)|Retrieves an enumerator for all `SymTagHeapAllocationSite` symbols.|
|[`IDiaSession::findInputAssemblyFile`](../../debugger/debug-interface-access/idiasession-findinputassemblyfile.md)|Retrieves the .NET Native input assembly file that is the parent of the specified symbol.|

## Remarks

It is important to call the [`IDiaSession::put_loadAddress`](../../debugger/debug-interface-access/idiasession-put-loadaddress.md) method after creating the `IDiaSession` object — and the value passed to the `put_loadAddress` method must be non-zero — for any virtual address (VA) properties of symbols to be accessible. The load address comes from whatever program loaded the executable being debugged. For example, you can call the Win32 function `GetModuleInformation` to retrieve the load address for the executable, given a handle to the executable.

## Example

This example shows how to obtain the `IDiaSession` interface as part of a general initialization of the Debug Interface Access (DIA) SDK.

```C++
CComPtr<IDiaDataSource> pSource;
ComPtr<IDiaSession> psession;

void InitializeDIA(const char *szFilename)
{
    HRESULT hr = CoCreateInstance( CLSID_DiaSource,
                                   NULL,
                                   CLSCTX_INPROC_SERVER,
                                   __uuidof( IDiaDataSource ),
                                  (void **) &pSource);
    if (FAILED(hr))
    {
        Fatal("Could not CoCreate CLSID_DiaSource. Register msdia80.dll." );
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
    if ( FAILED( pSource->openSession( &psession ) ) )
    {
        Fatal( "openSession" );
    }
}
```

## Requirements
Header: Dia2.h

Library: diaguids.lib

DLL: msdia80.dll

## See also
- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [Overview](../../debugger/debug-interface-access/overview-debug-interface-access-sdk.md)
- [Exe](../../debugger/debug-interface-access/exe.md)
- [`IDiaAddressMap`](../../debugger/debug-interface-access/idiaaddressmap.md)
- [`IDiaDataSource`](../../debugger/debug-interface-access/idiadatasource.md)
- [`IDiaDataSource::openSession`](../../debugger/debug-interface-access/idiadatasource-opensession.md)
- [`IDiaSymbol::findChildren`](../../debugger/debug-interface-access/idiasymbol-findchildren.md)
- [Querying the .Pdb File](../../debugger/debug-interface-access/querying-the-dot-pdb-file.md)
