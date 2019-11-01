---
title: "IEnumDebugExtendedPropertyInfo::Next | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumDebugExtendedPropertyInfo.Next"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IEnumDebugExtendedPropertyInfo::Next"
ms.assetid: ac41c9a3-19d1-4596-8a87-01c10b131be3
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumDebugExtendedPropertyInfo::Next
Retrieves a specified number of`ExtendedDebugPropertyInfo` structures in an enumeration sequence.  
  
## Syntax  
  
```cpp
HRESULT Next (  
   ULONGcelt,  
   ExtendedDebugPropertyInfo *rgelt,  
   ULONG* pceltFetched  
);  
```  
  
#### Parameters  
 `celt`  
 [in] The number of `ExtendedDebugPropertyInfo`structures to be retrieved.  
  
 `rgelt`  
 [out] An array of `ExtendedDebugPropertyInfo` structures retrieved.  
  
 `pceltFetched`  
 [out] The number of `ExtendedDebugPropertyInfo` structures actually retrieved.  
  
## Return Value  
 Returns a valid `HRESULT`, typically `S_OK`.  
  
## See also  
 [IEnumDebugExtendedPropertyInfo Interface](../../winscript/reference/ienumdebugextendedpropertyinfo-interface.md)   
 [ExtendedDebugPropertyInfo Structure](../../winscript/reference/extendeddebugpropertyinfo-structure.md)