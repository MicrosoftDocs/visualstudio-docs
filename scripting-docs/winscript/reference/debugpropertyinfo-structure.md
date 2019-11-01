---
title: "DebugPropertyInfo Structure | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "DebugPropertyInfo"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "DebugPropertyInfo structure"
ms.assetid: 3246efbc-c212-4024-8f07-6414c2f85e75
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# DebugPropertyInfo Structure
Describes an object of a hierarchical nature that has name, type, and value. It is used to describe the debug properties of local variables, parameters, watch variables and expressions, and registers.  
  
## Syntax  
  
```cpp
typedef struct DebugPropertyInfo{  
   DBGPROP_INFO_FLAGS  dwValidFields;  
   BSTR  bstrName;  
   BSTR  bstrType;  
   BSTR  bstrValue;  
   BSTR  bstrFullName;  
   DBGPROP_ATTRIB_FLAGS  dwAttrib;  
   IDebugProperty*  pDebugProp;  
};  
```  
  
## Members  
 dwValidFields  
 An enumerated data type used to specify which fields are initialized.  
  
 bstrName  
 The property name within a context.  
  
 bstrType  
 The property type, as formatted string.  
  
 bstrValue  
 The property value, as formatted string.  
  
 bstrFullName  
 The full name of the property.  
  
 dwAttrib  
 An enumeration that specifies the flags for the debug property attributes.  
  
 pDebugProp  
 The `IDebugProperty` described by the information in this `DebugPropertyInfo` structure.  
  
## See also  
 [IDebugProperty Interface](../../winscript/reference/idebugproperty-interface.md)   
 [DBGPROP_ATTRIB_FLAGS](../../winscript/reference/dbgprop-attrib-flags.md)   
 [DBGPROP_INFO_FLAGS](../../winscript/reference/dbgprop-info-flags.md)