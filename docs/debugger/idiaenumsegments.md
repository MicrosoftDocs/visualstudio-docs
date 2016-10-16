---
title: "IDiaEnumSegments"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumSegments interface"
ms.assetid: 0c9edd5e-b9ce-43e1-a791-cd4c5d16d923
caps.latest.revision: 10
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# IDiaEnumSegments
Enumerates the various segments contained in the data source.  
  
## Syntax  
  
```  
IDiaEnumSegments : IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaEnumSegments`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaEnumSegments::get__NewEnum](../debugger/idiaenumsegments--get__newenum.md)|Retrieves the [IEnumVARIANT Interface](assetId:///139e3c93-faef-4003-9079-e0e94494db3e) version of this enumerator.|  
|[IDiaEnumSegments::get_Count](../debugger/idiaenumsegments--get_count.md)|Retrieves the number of segments.|  
|[IDiaEnumSegments::Item](../debugger/idiaenumsegments--item.md)|Retrieves a segment by means of an index.|  
|[IDiaEnumSegments::Next](../debugger/idiaenumsegments--next.md)|Retrieves a specified number of segments in the enumeration sequence.|  
|[IDiaEnumSegments::Skip](../debugger/idiaenumsegments--skip.md)|Skips a specified number of segments in an enumeration sequence.|  
|[IDiaEnumSegments::Reset](../debugger/idiaenumsegments--reset.md)|Resets an enumeration sequence to the beginning.|  
|[IDiaEnumSegments::Clone](../debugger/idiaenumsegments--clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
  
## Remarks  
  
## Notes for Callers  
 Obtain this interface by calling the `QueryInterface` method on an [IDiaTable](../debugger/idiatable.md) object. See the example for details.  
  
## Example  
 This example shows how to obtain the `IDiaEnumSections` interface from a table. For a more complete example of using segments, see the [IDiaSegment](../debugger/idiasegment.md) interface.  
  
```cpp#  
void ShowSegments(IDiaTable *pTable, IDiaSession *pSession)  
{  
    CComPtr<IDiaEnumSegments> pSegments;  
    if ( SUCCEEDED( pTable->QueryInterface(  
                                __uuidof( IDiaEnumSegments ),  
                                (void**)&pSegments )  
                  )  
       )  
    {  
        // Do something with this enumeration  
    }  
}  
```  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../debugger/interfaces--debug-interface-access-sdk-.md)   
 [IDiaTable](../debugger/idiatable.md)   
 [IDiaSegment](../debugger/idiasegment.md)