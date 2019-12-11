---
title: "IEnumDebugPropertyInfo::Next | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumDebugPropertyInfo.Next"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IEnumDebugPropertyInfo::Next"
ms.assetid: 052837ac-1599-49cc-9a5a-ba90f992eeff
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumDebugPropertyInfo::Next
Retrieves a specified number of `DebugPropertyInfo` structures in an enumeration sequence.  
  
## Syntax  
  
```cpp
HRESULT Next (  
   ULONGcelt,  
   DebugPropertyInfo*rgelt,  
   ULONG* pceltFetched  
);  
```  
  
#### Parameters  
 `celt`  
 [in] The number of `DebugPropertyInfo`structures to be retrieved.  
  
 `rgelt`  
 [out] An array of `DebugPropertyInfo` structures retrieved.  
  
 `pceltFetched`  
 [out] Returns the number of `DebugPropertyInfo` structures actually retrieved.  
  
## Return Value  
 Returns a valid `HRESULT`, typically `S_OK`.  
  
## See also  
 [IEnumDebugPropertyInfo Interface](../../winscript/reference/ienumdebugpropertyinfo-interface.md)   
 [DebugPropertyInfo Structure](../../winscript/reference/debugpropertyinfo-structure.md)