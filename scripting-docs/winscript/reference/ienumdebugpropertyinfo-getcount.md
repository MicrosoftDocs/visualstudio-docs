---
title: "IEnumDebugPropertyInfo::GetCount | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumDebugPropertyInfo.GetCount"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IEnumDebugPropertyInfo::GetCount"
ms.assetid: 83a3becd-8533-4880-9c4f-193227ff25a9
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumDebugPropertyInfo::GetCount
Gets the number of `DebugPropertyInfo` structures in the enumerator.  
  
## Syntax  
  
```cpp
HRESULT GetCount (  
   ULONG* pcelt  
);  
```  
  
#### Parameters  
 `pcelt`  
 [out] Returns the number of `DebugPropertyInfo` structures in the enumerator.  
  
## Return Value  
 Returns a valid `HRESULT`, typically `S_OK`.  
  
## See also  
 [IEnumDebugPropertyInfo Interface](../../winscript/reference/ienumdebugpropertyinfo-interface.md)   
 [DebugPropertyInfo Structure](../../winscript/reference/debugpropertyinfo-structure.md)