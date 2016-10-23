---
title: "IDiaEnumDebugStreams"
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
ms.assetid: 611caf4f-7a5f-4aa4-b909-52feeb3cc752
caps.latest.revision: 10
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
# IDiaEnumDebugStreams
Enumerates the various debug streams contained in the data source.  
  
## Syntax  
  
```  
IDiaEnumDebugStreams : IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaEnumDebugStreams`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaEnumDebugStreams::get__NewEnum](../VS_debugger/IDiaEnumDebugStreams--get__NewEnum.md)|Retrieves the `IEnumVARIANT` version of this enumerator.|  
|[IDiaEnumDebugStreams::get_Count](../VS_debugger/IDiaEnumDebugStreams--get_Count.md)|Retrieves the number of debug streams.|  
|[IDiaEnumDebugStreams::Item](../VS_debugger/IDiaEnumDebugStreams--Item.md)|Retrieves a debug stream by means of an index.|  
|[IDiaEnumDebugStreams::Next](../VS_debugger/IDiaEnumDebugStreams--Next.md)|Retrieves a specified number of debug streams in the enumeration sequence.|  
|[IDiaEnumDebugStreams::Skip](../VS_debugger/IDiaEnumDebugStreams--Skip.md)|Skips a specified number of debug streams in an enumeration sequence.|  
|[IDiaEnumDebugStreams::Reset](../VS_debugger/IDiaEnumDebugStreams--Reset.md)|Resets an enumeration sequence to the beginning.|  
|[IDiaEnumDebugStreams::Clone](../VS_debugger/IDiaEnumDebugStreams--Clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
  
## Remarks  
 The content of debug streams is implementation-dependent and the data formats are undocumented.  
  
## Notes for Callers  
 Call the [IDiaSession::getEnumDebugStreams](../VS_debugger/IDiaSession--getEnumDebugStreams.md) method to obtain an `IDiaEnumDebugStreams` object.  
  
## Example  
 This example shows how to access the data streams available from this interface. See the [IDiaEnumDebugStreamData](../VS_debugger/IDiaEnumDebugStreamData.md) interface for an implementation of the `PrintStreamData` function.  
  
```cpp#  
void DumpAllDebugStreams( IDiaSession* pSession)  
{  
    IDiaEnumDebugStreams* pEnumStreams;  
  
    wprintf(L"\n\n*** DEBUG STREAMS\n\n");  
    // Retrieve an enumerated sequence of debug data streams  
    if(pSession->getEnumDebugStreams(&pEnumStreams) == S_OK)  
    {  
        IDiaEnumDebugStreamData* pStream;  
        ULONG celt = 0;  
  
        for(; pEnumStreams->Next(1, &pStream, &celt) == S_OK; pStream = NULL)  
        {  
            PrintStreamData(pStream);  
            pStream->Release();  
        }  
        pEnumStreams->Release();  
    }  
    else  
    {  
      wprintf(L"Failed to get any debug streams!\n");  
    }  
    wprintf(L"\n");  
}  
```  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../VS_debugger/Interfaces--Debug-Interface-Access-SDK-.md)   
 [IDiaEnumDebugStreamData](../VS_debugger/IDiaEnumDebugStreamData.md)   
 [IDiaSession::getEnumDebugStreams](../VS_debugger/IDiaSession--getEnumDebugStreams.md)