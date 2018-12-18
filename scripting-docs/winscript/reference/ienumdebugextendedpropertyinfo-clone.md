---
title: "IEnumDebugExtendedPropertyInfo::Clone | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumDebugExtendedPropertyInfo.Clone"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IEnumDebugExtendedPropertyInfo::Clone"
ms.assetid: dd645cf6-bfb3-486c-829e-bb91a6639665
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumDebugExtendedPropertyInfo::Clone
Creates an enumerator that contains the same enumeration state as the current enumerator.  
  
## Syntax  
  
```cpp
HRESULT Clone (  
   IEnumDebugExtendedPropertyInfo** ppEnum  
);  
```  
  
#### Parameters  
 `ppEnum`  
 [out] Returns the cloned `IEnumDebugExtendedPropertyInfo` interface.  
  
## Return Value  
 Returns a valid `HRESULT`, typically `S_OK`.  
  
## See also  
 [IEnumDebugExtendedPropertyInfo Interface](../../winscript/reference/ienumdebugextendedpropertyinfo-interface.md)