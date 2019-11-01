---
title: "IDebugProperty::GetPropertyInfo | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugProperty.GetPropertyInfo"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDebugProperty::GetPropertyInfo"
ms.assetid: b201c0c4-bff6-4285-880f-67be90584c5f
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugProperty::GetPropertyInfo
Gets the value of an `IDebugProperty` that describes a method or an indexed property.  
  
## Syntax  
  
```cpp
HRESULT GetPropertyInfo (  
   DBGPROP_INFO_FLAGSdwFields,  
   UINT nRadix,  
   DebugPropertyInfo* pPropertyInfo  
);  
```  
  
#### Parameters  
 `dwFields`  
 [in] Specifies the `DBGPROP_INFO_FLAGS` constants that determine the fields to be filled out in the `DebugPropertyInfo` structure.  
  
 `nRadix`  
 [in] Radix to be used in formatting any numerical information.  
  
 `pPropertyInfo`  
 [out] Returns the `DebugPropertyInfo` structure that describes the property.  
  
## Return Value  
 Returns a valid `HRESULT`, typically `S_OK`.  
  
## See also  
 [IDebugProperty Interface](../../winscript/reference/idebugproperty-interface.md)   
 [DBGPROP_INFO_FLAGS](../../winscript/reference/dbgprop-info-flags.md)   
 [DebugPropertyInfo Structure](../../winscript/reference/debugpropertyinfo-structure.md)