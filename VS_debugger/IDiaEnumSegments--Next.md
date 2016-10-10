---
title: "IDiaEnumSegments::Next"
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
ms.assetid: 53f61874-d821-47ab-a1f5-27e982804a6a
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
# IDiaEnumSegments::Next
Retrieves a specified number of segments in the enumeration sequence.  
  
## Syntax  
  
```cpp#  
HRESULT Next (   
   ULONG         celt,   
   IDiaSegment** rgelt,  
   ULONG*        pceltFetched  
);  
```  
  
#### Parameters  
 celt  
 [in] The number of segments in the enumerator to be retrieved.  
  
 rgelt  
 [out] An array that is to be filled in with the desired [IDiaSegment](../VS_debugger/IDiaSegment.md) objects that represent the segments.  
  
 pceltFetched  
 [out] Returns the number of segments in the fetched enumerator.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if there are no more segments. Otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumSegments](../VS_debugger/IDiaEnumSegments.md)   
 [IDiaSegment](../VS_debugger/IDiaSegment.md)