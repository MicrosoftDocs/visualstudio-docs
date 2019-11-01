---
title: "IEnumDebugPropertyInfo::Skip | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumDebugPropertyInfo.Skip"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IEnumDebugPropertyInfo::Skip"
ms.assetid: 2f6361fb-d66d-4fc0-8fe0-c859593a183f
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumDebugPropertyInfo::Skip
Skips a specified number of `DebugPropertyInfo` structures in an enumeration sequence.  
  
## Syntax  
  
```cpp
HRESULT Skip(  
   ULONGcelt  
);  
```  
  
#### Parameters  
 `celt`  
 [in] The number of `DebugPropertyInfo` structures in the enumeration sequence to skip.  
  
## Return Value  
 Returns a valid `HRESULT`, typically `S_OK`. Returns `S_FALSE` and sets the current element pointer to the end of the enumeration if `celt` is greater than the number of elements left in the enumerator.  
  
## See also  
 [IEnumDebugPropertyInfo Interface](../../winscript/reference/ienumdebugpropertyinfo-interface.md)   
 [DebugPropertyInfo Structure](../../winscript/reference/debugpropertyinfo-structure.md)