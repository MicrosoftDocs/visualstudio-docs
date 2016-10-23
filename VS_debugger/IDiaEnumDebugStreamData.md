---
title: "IDiaEnumDebugStreamData"
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
ms.assetid: e2023c32-4c05-4d0c-a0be-f016a230c788
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
# IDiaEnumDebugStreamData
Provides access to the records in a debug data stream.  
  
## Syntax  
  
```  
IDiaEnumDebugStreamData : IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaEnumDebugStreamData`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaEnumDebugStreamData::get__NewEnum](../VS_debugger/IDiaEnumDebugStreamData--get__NewEnum.md)|Retrieves the [IEnumVARIANT Interface](assetId:///139e3c93-faef-4003-9079-e0e94494db3e) version of this enumerator.|  
|[IDiaEnumDebugStreamData::get_Count](../VS_debugger/IDiaEnumDebugStreamData--get_Count.md)|Retrieves the number of records in the debug data stream.|  
|[IDiaEnumDebugStreamData::get_name](../VS_debugger/IDiaEnumDebugStreamData--get_name.md)|Retrieves the name of the debug data stream.|  
|[IDiaEnumDebugStreamData::Item](../VS_debugger/IDiaEnumDebugStreamData--Item.md)|Retrieves the specified record.|  
|[IDiaEnumDebugStreamData::Next](../VS_debugger/IDiaEnumDebugStreamData--Next.md)|Retrieves the specified number of records  from the enumerated sequence.|  
|[IDiaEnumDebugStreamData::Skip](../VS_debugger/IDiaEnumDebugStreamData--Skip.md)|Skips a specified number of records in an enumerated sequence.|  
|[IDiaEnumDebugStreamData::Reset](../VS_debugger/IDiaEnumDebugStreamData--Reset.md)|Resets the enumerated sequence to the beginning.|  
|[IDiaEnumDebugStreamData::Clone](../VS_debugger/IDiaEnumDebugStreamData--Clone.md)|Creates an enumerator that contains the same enumerated sequence as the current enumerator.|  
  
## Remarks  
 This interface represents a stream of records in a debug data stream. The size and interpretation of each record is dependent on the data stream the record comes from. This interface effectively provides access to the raw data bytes in the symbol file.  
  
## Notes for Callers  
 Call the [IDiaEnumDebugStreams::Item](../VS_debugger/IDiaEnumDebugStreams--Item.md) or [IDiaEnumDebugStreams::Next](../VS_debugger/IDiaEnumDebugStreams--Next.md) methods to obtain an `IDiaEnumDebugStreamData` object.  
  
## Example  
 This example shows how to access a single data stream and its records.  
  
```cpp#  
void PrintStreamData(IDiaEnumDebugStreamData* pStream)  
{  
    BSTR  wszName;  
    LONG  dwElem;  
    ULONG celt    = 0;  
    DWORD cbData;  
    DWORD cbTotal = 0;  
    BYTE  data[1024];  
  
    if(pStream->get_name(&wszName) != S_OK)  
    {  
        wprintf_s(L"ERROR - PrintStreamData() get_name\n");  
    }  
    else  
    {  
        wprintf_s(L"Stream: %s", wszName);  
        SysFreeString(wszName);  
    }  
    if(pStream->get_Count(&dwElem) != S_OK)  
    {  
        wprintf(L"ERROR - PrintStreamData() get_Count\n");  
    }  
    else  
    {  
        wprintf(L"(%d)\n", dwElem);  
    }  
    while(pStream->Next(1, sizeof(data), &cbData, (BYTE *)&data, &celt) == S_OK)  
    {  
        DWORD i;  
        for (i = 0; i < cbData; i++)  
        {  
            wprintf(L"%02X ", data[i]);  
            if(i && i % 8 == 7 && i+1 < cbData)  
            {  
                wprintf(L"- ");  
            }  
        }  
        wprintf(L"| ");  
        for(i = 0; i < cbData; i++)  
        {  
            wprintf(L"%c", iswprint(data[i]) ? data[i] : '.');  
        }  
        wprintf(L"\n");  
        cbTotal += cbData;  
    }  
    wprintf(L"Summary :\n\tSizeof(Elem) = %d\n\tNo of Elems = %d\n\n",  
            cbTotal/dwElem, dwElem);  
}  
```  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../VS_debugger/Interfaces--Debug-Interface-Access-SDK-.md)   
 [IDiaEnumDebugStreams::Item](../VS_debugger/IDiaEnumDebugStreams--Item.md)   
 [IDiaEnumDebugStreams::Next](../VS_debugger/IDiaEnumDebugStreams--Next.md)