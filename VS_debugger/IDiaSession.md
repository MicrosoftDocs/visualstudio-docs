---
title: "IDiaSession"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 69dab9bf-2c68-4f70-9678-3b50fba3e6fa
caps.latest.revision: 19
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# IDiaSession
Provides a query context for debug symbols.  
  
## Syntax  
  
```  
IDiaSession : IUnknown  
```  
  
## Methods  
 The following table shows the methods of `IDiaSession`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaSession::get_loadAddress](../VS_debugger/IDiaSession--get_loadAddress.md)|Retrieves the load address for the executable file that corresponds to the symbols in this symbol store. This is the same value that was passed to the `put_loadAddress` method.|  
|[IDiaSession::put_loadAddress](../VS_debugger/IDiaSession--put_loadAddress.md)|Sets the load address for the executable file that corresponds to the symbols in this symbol store. **Note:**  It is important to call this method when you get an `IDiaSession` object and before you start using the object.|  
|[IDiaSession::get_globalScope](../VS_debugger/IDiaSession--get_globalScope.md)|Retrieves a reference to the global scope.|  
|[IDiaSession::getEnumTables](../VS_debugger/IDiaSession--getEnumTables.md)|Retrieves an enumerator for all tables contained in the symbol store.|  
|[IDiaSession::getSymbolsByAddr](../VS_debugger/IDiaSession--getSymbolsByAddr.md)|Retrieves an enumerator for all named symbols at static locations.|  
|[IDiaSession::findChildren](../VS_debugger/IDiaSession--findChildren.md)|Retrieves all children of a specified parent identifier that match the name and symbol type.|  
|[IDiaSession::findSymbolByAddr](../VS_debugger/IDiaSession--findSymbolByAddr.md)|Retrieves a specified symbol type that contains, or is closest to, a specified address.|  
|[IDiaSession::findSymbolByRVA](../VS_debugger/IDiaSession--findSymbolByRVA.md)|Retrieves a specified symbol type that contains, or is closest to, a specified relative virtual address (RVA).|  
|[IDiaSession::findSymbolByVA](../VS_debugger/IDiaSession--findSymbolByVA.md)|Retrieves a specified symbol type that contains, or is closest to, a specified virtual address (VA).|  
|[IDiaSession::findSymbolByToken](../VS_debugger/IDiaSession--findSymbolByToken.md)|Retrieves the symbol that contains a specified metadata token.|  
|[IDiaSession::symsAreEquiv](../VS_debugger/IDiaSession--symsAreEquiv.md)|Checks to see if two symbols are equivalent.|  
|[IDiaSession::symbolById](../VS_debugger/IDiaSession--symbolById.md)|Retrieves a symbol by its unique identifier.|  
|[IDiaSession::findSymbolByRVAEx](../VS_debugger/IDiaSession--findSymbolByRVAEx.md)|Retrieves a specified symbol type that contains, or is closest to, a specified relative virtual address and offset.|  
|[IDiaSession::findSymbolByVAEx](../VS_debugger/IDiaSession--findSymbolByVAEx.md)|Retrieves a specified symbol type that contains, or is closest to, a specified virtual address and offset.|  
|[IDiaSession::findFile](../VS_debugger/IDiaSession--findFile.md)|Retrieves a source file by compiland and name.|  
|[IDiaSession::findFileById](../VS_debugger/IDiaSession--findFileById.md)|Retrieves a source file by source file identifier.|  
|[IDiaSession::findLines](../VS_debugger/IDiaSession--findLines.md)|Retrieves line numbers within a specified compiland and source file identifier.|  
|[IDiaSession::findLinesByAddr](../VS_debugger/IDiaSession--findLinesByAddr.md)|Retrieves the lines in a specified compiland that contain a specified address.|  
|[IDiaSession::findLinesByRVA](../VS_debugger/IDiaSession--findLinesByRVA.md)|Retrieves the lines in a specified compiland that contain a specified relative virtual address.|  
|[IDiaSession::findLinesByVA](../VS_debugger/IDiaSession--findLinesByVA.md)|Finds the line number information for lines contained in a specified address range.|  
|[IDiaSession::findLinesByLinenum](../VS_debugger/IDiaSession--findLinesByLinenum.md)|Retrieves the lines in a specified compiland by source file and line number.|  
|[IDiaSession::findInjectedSource](../VS_debugger/IDiaSession--findInjectedSource.md)|Retrieves a source that has been placed into the symbol store by attribute providers or other components of the compilation process.|  
|[IDiaSession::getEnumDebugStreams](../VS_debugger/IDiaSession--getEnumDebugStreams.md)|Retrieves an enumerated sequence of debug data streams.|  
|[IDiaSession::findInlineFramesByAddr](../VS_debugger/IDiaSession--findInlineFramesByAddr.md)|Retrieves an enumeration that allows a client to iterate through all of the inline frames on a given address.|  
|[IDiaSession::findInlineFramesByRVA](../VS_debugger/IDiaSession--findInlineFramesByRVA.md)|Retrieves an enumeration that allows a client to iterate through all of the inline frames on a specified relative virtual address (RVA).|  
|[IDiaSession::findInlineFramesByVA](../VS_debugger/IDiaSession--findInlineFramesByVA.md)|Retrieves an enumeration that allows a client to iterate through all of the inline frames on a specified virtual address (VA).|  
|[IDiaSession::findInlineeLines](../VS_debugger/IDiaSession--findInlineeLines.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, by the specified parent symbol.|  
|[IDiaSession::findInlineeLinesByAddr](../VS_debugger/IDiaSession--findInlineeLinesByAddr.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, by the specified parent symbol and are contained within the specified address range.|  
|[IDiaSession::findInlineeLinesByRVA](../VS_debugger/IDiaSession--findInlineeLinesByRVA.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, by the specified parent symbol and are contained within the specified relative virtual address (RVA).|  
|[IDiaSession::findInlineeLinesByVA](../VS_debugger/IDiaSession--findInlineeLinesByVA.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, by the specified parent symbol and are contained within the specified virtual address (VA).|  
|[IDiaSession::findInlineeLinesByLinenum](../VS_debugger/IDiaSession--findInlineeLinesByLinenum.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, in the specified source file and line number.|  
|[IDiaSession::findInlineesByName](../VS_debugger/IDiaSession--findInlineesByName.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all inlined functions that match a specified name.|  
|[IDiaSession::findSymbolsForAcceleratorPointerTag](../VS_debugger/IDiaSession--findSymbolsForAcceleratorPointerTag.md)|Returns an enumeration of symbols for the variable that the specified tag value corresponds to in the parent Accelerator stub function.|  
|[IDiaSession::findSymbolsByRVAForAcceleratorPointerTag](../VS_debugger/IDiaSession--findSymbolsByRVAForAcceleratorPointerTag.md)|Given a corresponding tag value, this method returns an enumeration of symbols that are contained in a specified parent Accelerator stub function at a specified relative virtual address.|  
|[IDiaSession::findAcceleratorInlineesByName](../VS_debugger/IDiaSession--findAcceleratorInlineesByName.md)|Returns an enumeration of symbols for inline frames corresponding to the specified inline function name.|  
|[IDiaSession::findAcceleratorInlineesByLinenum](../VS_debugger/IDiaSession--findAcceleratorInlineesByLinenum.md)|Returns an enumeration of symbols for inline frames that correspond to the specified source location.|  
  
## Remarks  
 It is important to call the [IDiaSession::put_loadAddress](../VS_debugger/IDiaSession--put_loadAddress.md) method after creating the `IDiaSession` object — and the value passed to the `put_loadAddress` method must be non-zero — for any virtual address (VA) properties of symbols to be accessible. The load address comes from whatever program loaded the executable being debugged. For example, you can call the Win32 function `GetModuleInformation` to retrieve the load address for the executable, given a handle to the executable.  
  
## Example  
 This example shows how to obtain the `IDiaSession` interface as part of a general initialization of the DIA SDK.  
  
```cpp#  
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
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../VS_debugger/Interfaces--Debug-Interface-Access-SDK-.md)   
 [Overview](../VS_debugger/Overview--Debug-Interface-Access-SDK-.md)   
 [Exe](../VS_debugger/Exe.md)   
 [IDiaAddressMap](../VS_debugger/IDiaAddressMap.md)   
 [IDiaDataSource](../VS_debugger/IDiaDataSource.md)   
 [IDiaDataSource::openSession](../VS_debugger/IDiaDataSource--openSession.md)   
 [IDiaSymbol::findChildren](../VS_debugger/IDiaSymbol--findChildren.md)   
 [Querying the .Pdb File](../VS_debugger/Querying-the-.Pdb-File.md)