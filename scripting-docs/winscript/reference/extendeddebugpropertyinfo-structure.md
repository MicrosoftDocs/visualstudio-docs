---
title: "ExtendedDebugPropertyInfo Structure | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "ExtendedDebugPropertyInfo"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "ExtendedDebugPropertyInfo structure"
ms.assetid: f2cf6477-454b-4d13-95da-ae4c90daa175
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# ExtendedDebugPropertyInfo Structure
Extends the `DebugPropertyInfo` structure with additional members to characterize the extended property.  
  
## Syntax  
  
```cpp
typedef struct ExtendedDebugPropertyInfo{  
   DBGPROP_INFO_FLAGS  dwValidFields;  
   LPOLESTR  bstrName;  
   LPOLESTR  bstrType;  
   LPOLESTR  bstrValue;  
   LPOLESTR  bstrFullName;  
   DBGPROP_ATTRIB_FLAGS  dwAttrib;  
   IDebugProperty*  pDebugProp;  
   DWORD  nDISPID;  
   DWORD  nType;  
   VARIANT  varValue;  
   ILockBytes*  plbValue;  
   IDebugExtendedProperty*  pDebugExtProp;  
};  
```  
  
## Members  
 `dwValidFields`  
 An enumerated data type used to specify which fields are initialized.  
  
 `bstrName`  
 The property name within a context.  
  
 `bstrType`  
 The property type as formatted string.  
  
 `bstrValue`  
 The property value as a formatted string.  
  
 `bstrFullName`  
 The full name of the property.  
  
 `dwAttrib`  
 An enumeration that specifies the flags for the debug property attributes.  
  
 `pDebugProp`  
 `IDebugProperty` object corresponding to this `ExtendedDebugPropertyInfo`.  
  
 `nDISPID`  
 The dispatch id.  
  
 `nType`  
 The extended property type.  
  
 `varValue`  
 The extended property value if it can fit in VARIANT.  
  
 `plbValue`  
 The actual data bytes of the property value.  
  
 `pDebugExtProp`  
 `IDebugExtendedProperty` object corresponding to this `ExtendedDebugPropertyInfo`.  
  
## See also  
 [DebugPropertyInfo Structure](../../winscript/reference/debugpropertyinfo-structure.md)   
 [IDebugProperty Interface](../../winscript/reference/idebugproperty-interface.md)   
 [IDebugExtendedProperty Interface](../../winscript/reference/idebugextendedproperty-interface.md)   
 [DBGPROP_ATTRIB_FLAGS](../../winscript/reference/dbgprop-attrib-flags.md)   
 [DBGPROP_INFO_FLAGS](../../winscript/reference/dbgprop-info-flags.md)