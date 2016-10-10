---
title: "IDiaEnumSegments"
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
ms.assetid: 0c9edd5e-b9ce-43e1-a791-cd4c5d16d923
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
|[IDiaEnumSegments::get__NewEnum](../VS_debugger/IDiaEnumSegments--get__NewEnum.md)|Retrieves the [IEnumVARIANT Interface](assetId:///139e3c93-faef-4003-9079-e0e94494db3e) version of this enumerator.|  
|[IDiaEnumSegments::get_Count](../VS_debugger/IDiaEnumSegments--get_Count.md)|Retrieves the number of segments.|  
|[IDiaEnumSegments::Item](../VS_debugger/IDiaEnumSegments--Item.md)|Retrieves a segment by means of an index.|  
|[IDiaEnumSegments::Next](../VS_debugger/IDiaEnumSegments--Next.md)|Retrieves a specified number of segments in the enumeration sequence.|  
|[IDiaEnumSegments::Skip](../VS_debugger/IDiaEnumSegments--Skip.md)|Skips a specified number of segments in an enumeration sequence.|  
|[IDiaEnumSegments::Reset](../VS_debugger/IDiaEnumSegments--Reset.md)|Resets an enumeration sequence to the beginning.|  
|[IDiaEnumSegments::Clone](../VS_debugger/IDiaEnumSegments--Clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
  
## Remarks  
  
## Notes for Callers  
 Obtain this interface by calling the `QueryInterface` method on an [IDiaTable](../VS_debugger/IDiaTable.md) object. See the example for details.  
  
## Example  
 This example shows how to obtain the `IDiaEnumSections` interface from a table. For a more complete example of using segments, see the [IDiaSegment](../VS_debugger/IDiaSegment.md) interface.  
  
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
 [Interfaces (Debug Interface Access SDK)](../VS_debugger/Interfaces--Debug-Interface-Access-SDK-.md)   
 [IDiaTable](../VS_debugger/IDiaTable.md)   
 [IDiaSegment](../VS_debugger/IDiaSegment.md)