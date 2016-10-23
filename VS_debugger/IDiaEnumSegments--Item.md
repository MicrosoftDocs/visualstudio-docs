---
title: "IDiaEnumSegments::Item"
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
ms.assetid: ee44dd55-39a0-4b7b-97ff-2e1226eeb2bd
caps.latest.revision: 7
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
# IDiaEnumSegments::Item
Retrieves a segment by means of an index.  
  
## Syntax  
  
```cpp#  
HRESULT Item (   
   DWORD         index,  
   IDiaSegment** segment  
);  
```  
  
#### Parameters  
 index  
 [in] Index of the [IDiaSegment](../VS_debugger/IDiaSegment.md) object to be retrieved. The index is in the range 0 to `count`-1, where `count` is returned by the [IDiaEnumSegments::get_Count](../VS_debugger/IDiaEnumSegments--get_Count.md) method.  
  
 segment  
 [out] Returns an [IDiaSegment](../VS_debugger/IDiaSegment.md) object representing the desired segment.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumSegments](../VS_debugger/IDiaEnumSegments.md)   
 [IDiaSegment](../VS_debugger/IDiaSegment.md)