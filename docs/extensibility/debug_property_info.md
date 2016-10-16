---
title: "DEBUG_PROPERTY_INFO"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "DEBUG_PROPERTY_INFO"
helpviewer_keywords: 
  - "DEBUG_PROPERTY_INFO structure"
ms.assetid: 5a085d18-62c6-4740-b9e9-3f5db6bfdf7f
caps.latest.revision: 8
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# DEBUG_PROPERTY_INFO
Contains information about a debug property.  
  
## Syntax  
  
```cpp#  
typedef struct tagDEBUG_PROPERTY_INFO {   
   DEBUGPROP_INFO_FLAGS dwValidFields;  
   BSTR                 bstrFullName;  
   BSTR                 bstrName;  
   BSTR                 bstrType;  
   BSTR                 bstrValue;  
   IDebugProperty2*     pProperty;  
   DBG_ATTRIB_FLAGS     dwAttrib;  
} DEBUG_PROPERTY_INFO;  
```  
  
```c#  
public struct DEBUG_PROPERTY_INFO {   
   public uint            dwValidFields;  
   public string          bstrFullName;  
   public string          bstrName;  
   public string          bstrType;  
   public string          bstrValue;  
   public IDebugProperty2 pProperty;  
   public ulong           dwAttrib;  
};  
```  
  
## Members  
 dwValidFields  
 A combination of flags from the [DEBUGPROP_INFO_FLAGS](../extensibility/debugprop_info_flags.md) enumeration that specifies which fields are filled in.  
  
 bstrFullName  
 The full name of the property.  
  
 bstrName  
 The property name within a context.  
  
 bstrType  
 The property type as a formatted string.  
  
 bstrValue  
 The property value as a formatted string.  
  
 pProperty  
 The [IDebugProperty2](../extensibility/idebugproperty2.md) object described by this structure.  
  
 dwAttrib  
 A combination of flags from the [DBG_ATTRIB_FLAGS](../extensibility/dbg_attrib_flags.md) enumeration describing the attributes of this property.  
  
## Remarks  
 A property is an object of a hierarchical nature that has a name, type, and value. For example, a property can describe local variables, parameters, watch variables and expressions, and registers.  
  
 This structure is passed to the [GetPropertyInfo](../extensibility/idebugproperty2--getpropertyinfo.md) method where it is filled in. This structure is also returned as part of a list of this structure from the [IEnumDebugPropertyInfo2](../extensibility/ienumdebugpropertyinfo2.md) interface which, in turn, is returned from a call to the [EnumChildren](../extensibility/idebugproperty2--enumchildren.md) and [EnumProperties](../extensibility/idebugstackframe2--enumproperties.md) methods.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../extensibility/structures-and-unions.md)   
 [DEBUGPROP_INFO_FLAGS](../extensibility/debugprop_info_flags.md)   
 [DBG_ATTRIB_FLAGS](../extensibility/dbg_attrib_flags.md)   
 [IDebugProperty2](../extensibility/idebugproperty2.md)   
 [GetPropertyInfo](../extensibility/idebugproperty2--getpropertyinfo.md)   
 [IEnumDebugPropertyInfo2](../extensibility/ienumdebugpropertyinfo2.md)   
 [EnumChildren](../extensibility/idebugproperty2--enumchildren.md)   
 [EnumProperties](../extensibility/idebugstackframe2--enumproperties.md)