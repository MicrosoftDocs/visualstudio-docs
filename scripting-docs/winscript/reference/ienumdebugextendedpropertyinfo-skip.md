---
title: "IEnumDebugExtendedPropertyInfo::Skip | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumDebugExtendedPropertyInfo.Skip"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IEnumDebugExtendedPropertyInfo::Skip"
ms.assetid: a0b4a9fc-e122-482b-9384-b83c460b61fe
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumDebugExtendedPropertyInfo::Skip
Skips a specified number of `ExtendedDebugPropertyInfo` structures in an enumeration sequence.  
  
## Syntax  
  
```cpp
HRESULT Skip(  
   ULONG celt  
);  
```  
  
#### Parameters  
 `celt`  
 [in] The number of `ExtendedDebugPropertyInfo` structures in the enumeration sequence to skip.  
  
## Return Value  
 Returns a valid `HRESULT`, typically `S_OK`. Returns `S_FALSE` and sets the current element pointer to the end of the enumeration if `celt` is greater than the number of elements left in the enumerator.  
  
## See also  
 [IEnumDebugExtendedPropertyInfo Interface](../../winscript/reference/ienumdebugextendedpropertyinfo-interface.md)   
 [ExtendedDebugPropertyInfo Structure](../../winscript/reference/extendeddebugpropertyinfo-structure.md)