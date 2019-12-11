---
title: "IEnumDebugExtendedPropertyInfo::GetCount | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumDebugExtendedPropertyInfo.GetCount"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IEnumDebugExtendedPropertyInfo::GetCount"
ms.assetid: 2c862f62-b57c-4cd4-ac4e-7d372fbda9a4
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumDebugExtendedPropertyInfo::GetCount
Gets the number of `ExtendedDebugPropertyInfo` structures in the enumerator.  
  
## Syntax  
  
```cpp
HRESULT GetCount (  
   ULONG* pcelt  
);  
```  
  
#### Parameters  
 `pcelt`  
 [out] Returns the number of `ExtendedDebugPropertyInfo` structures in the enumerator.  
  
## Return Value  
 Returns a valid `HRESULT`, typically `S_OK`.  
  
## See also  
 [IEnumDebugExtendedPropertyInfo Interface](../../winscript/reference/ienumdebugextendedpropertyinfo-interface.md)   
 [ExtendedDebugPropertyInfo Structure](../../winscript/reference/extendeddebugpropertyinfo-structure.md)