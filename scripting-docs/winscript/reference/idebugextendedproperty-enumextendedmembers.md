---
title: "IDebugExtendedProperty::EnumExtendedMembers | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugExtendedProperty.EnumExtendedMembers"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDebugExtendedProperty::EnumExtendedMembers"
ms.assetid: 27cdb091-da4e-44d2-a631-31ae00468b98
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugExtendedProperty::EnumExtendedMembers
Enumerates the members of an extended property.  
  
## Syntax  
  
```cpp
HRESULT EnumExtendedMembers(  
   EX_DBGPROP_INFO_FLAGS  dwFieldSpec,  
   UINT  nRadix,  
   IEnumDebugExtendedPropertyInfo**  ppeepi  
);  
```  
  
#### Parameters  
 `dwFieldSpec`  
 [in] Specifies the EX_DBGPROP_INFO_FLAGS constants that determine the fields in the enumerated extended debug property structures that are to be filled in.  
  
 `nRadix`  
 [in] Radix to be used in interpreting any numerical information.  
  
 `ppeepi`  
 [out] Returns the `IEnumDebugExtendedPropertyInfo` interface that enumerates the member properties.  
  
## Return Value  
 Returns a valid `HRESULT`, typically `S_OK`.  
  
## See also  
 [IDebugExtendedProperty Interface](../../winscript/reference/idebugextendedproperty-interface.md)   
 [EX_DBGPROP_INFO_FLAGS](../../winscript/reference/ex-dbgprop-info-flags.md)   
 [ExtendedDebugPropertyInfo Structure](../../winscript/reference/extendeddebugpropertyinfo-structure.md)