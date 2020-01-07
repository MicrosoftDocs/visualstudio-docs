---
title: "IDebugExtendedProperty::GetExtendedPropertyInfo | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugExtendedProperty.GetExtendedPropertyInfo"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDebugExtendedProperty::GetExtendedPropertyInfo"
ms.assetid: 56edf538-5082-4653-82b6-e6640d6f61ba
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugExtendedProperty::GetExtendedPropertyInfo
Fetches extended information for an extended property, which is more information than the simpler `IDebugProperty`.  
  
## Syntax  
  
```cpp
HRESULT GetExtendedPropertyInfo(  
   EX_DBGPROP_INFO_FLAGS  dwFieldSpec,  
   UINT  nRadix,  
   ExtendedDebugPropertyInfo*  pExtendedPropertyInfo  
);  
```  
  
#### Parameters  
 `dwFieldSpec`  
 [in] Specifies the EX_DBGPROP_INFO_FLAGS constants that determine the fields to be filled out in the `ExtendedDebugPropertyInfo` structure.  
  
 `nRadix`  
 [in] Radix to be used in interpreting any numerical information.  
  
 `pExtendedPropertyInfo`  
 [out] Returns the `ExtendedDebugPropertyInfo` structure that describes the property.  
  
## Return Value  
 Returns a valid `HRESULT`, typically `S_OK`.  
  
## See also  
 [IDebugExtendedProperty Interface](../../winscript/reference/idebugextendedproperty-interface.md)   
 [EX_DBGPROP_INFO_FLAGS](../../winscript/reference/ex-dbgprop-info-flags.md)   
 [ExtendedDebugPropertyInfo Structure](../../winscript/reference/extendeddebugpropertyinfo-structure.md)