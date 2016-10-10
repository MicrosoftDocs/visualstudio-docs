---
title: "IDiaEnumSourceFiles"
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
ms.assetid: 5c0779a6-a2ea-408a-90da-ebdecf2b83c0
caps.latest.revision: 12
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
# IDiaEnumSourceFiles
Enumerates the various source files contained in the data source.  
  
## Syntax  
  
```  
IDiaEnumSourceFiles : IUknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaEnumSourceFiles`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaEnumSourceFiles::get__NewEnum](../VS_debugger/IDiaEnumSourceFiles--get__NewEnum.md)|Retrieves the `IEnumVARIANT Interface` version of this enumerator.|  
|[IDiaEnumSourceFiles::get_Count](../VS_debugger/IDiaEnumSourceFiles--get_Count.md)|Retrieves the number of source files.|  
|[IDiaEnumSourceFiles::Item](../VS_debugger/IDiaEnumSourceFiles--Item.md)|Retrieves a source file by means of an index.|  
|[IDiaEnumSourceFiles::Next](../VS_debugger/IDiaEnumSourceFiles--Next.md)|Retrieves a specified number of source files in the enumeration sequence.|  
|[IDiaEnumSourceFiles::Skip](../VS_debugger/IDiaEnumSourceFiles--Skip.md)|Skips a specified number of source files in an enumeration sequence.|  
|[IDiaEnumSourceFiles::Reset](../VS_debugger/IDiaEnumSourceFiles--Reset.md)|Resets an enumeration sequence to the beginning.|  
|[IDiaEnumSourceFiles::Clone](../VS_debugger/IDiaEnumSourceFiles--Clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
  
## Remarks  
  
## Notes for Callers  
 Obtain this interface by calling the `QueryInterface` method on an [IDiaTable](../VS_debugger/IDiaTable.md) object. See the example for details.  
  
## Example  
 This example shows how to obtain the `IDiaEnumSourceFiles` interface from the list of tables in a DIA session object. For an example of accessing source file information, see the [IDiaSourceFile](../VS_debugger/IDiaSourceFile.md) interface.  
  
```cpp#  
  
IDiaEnumSourceFiles* GetEnumSourceFiless(IDiaSession *pSession)  
{  
    IDiaEnumSourceFiles * pUnknown    = NULL;  
    REFIID                iid         = __uuidof(IDiaEnumSourceFiles);  
    IDiaEnumTables*       pEnumTables = NULL;  
    IDiaTable*            pTable      = NULL;  
    ULONG                 celt        = 0;  
  
    if (pSession->getEnumTables(&pEnumTables) != S_OK)  
    {  
        wprintf(L"ERROR - GetTable() getEnumTables\n");  
        return NULL;  
    }  
    while (pEnumTables->Next(1, &pTable, &celt) == S_OK && celt == 1)  
    {  
        // There is only one table that matches the given iid  
        HRESULT hr = pTable->QueryInterface(iid, (void**)&pUnknown);  
        pTable->Release();  
        if (hr == S_OK)  
        {  
            break;  
        }  
    }  
    pEnumTables->Release();  
    return pUnknown;  
}  
```  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../VS_debugger/Interfaces--Debug-Interface-Access-SDK-.md)   
 [IDiaSession::findFile](../VS_debugger/IDiaSession--findFile.md)   
 [IDiaSession::findLinesByLinenum](../VS_debugger/IDiaSession--findLinesByLinenum.md)   
 [IDiaTable](../VS_debugger/IDiaTable.md)