---
title: "DEBUG_PROPERTY_INFO | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "DEBUG_PROPERTY_INFO"
helpviewer_keywords: 
  - "DEBUG_PROPERTY_INFO structure"
ms.assetid: 5a085d18-62c6-4740-b9e9-3f5db6bfdf7f
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# DEBUG_PROPERTY_INFO
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

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
  
```csharp  
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
 A combination of flags from the [DEBUGPROP_INFO_FLAGS](../../../extensibility/debugger/reference/debugprop-info-flags.md) enumeration that specifies which fields are filled in.  
  
 bstrFullName  
 The full name of the property.  
  
 bstrName  
 The property name within a context.  
  
 bstrType  
 The property type as a formatted string.  
  
 bstrValue  
 The property value as a formatted string.  
  
 pProperty  
 The [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) object described by this structure.  
  
 dwAttrib  
 A combination of flags from the [DBG_ATTRIB_FLAGS](../../../extensibility/debugger/reference/dbg-attrib-flags.md) enumeration describing the attributes of this property.  
  
## Remarks  
 A property is an object of a hierarchical nature that has a name, type, and value. For example, a property can describe local variables, parameters, watch variables and expressions, and registers.  
  
 This structure is passed to the [GetPropertyInfo](../../../extensibility/debugger/reference/idebugproperty2-getpropertyinfo.md) method where it is filled in. This structure is also returned as part of a list of this structure from the [IEnumDebugPropertyInfo2](../../../extensibility/debugger/reference/ienumdebugpropertyinfo2.md) interface which, in turn, is returned from a call to the [EnumChildren](../../../extensibility/debugger/reference/idebugproperty2-enumchildren.md) and [EnumProperties](../../../extensibility/debugger/reference/idebugstackframe2-enumproperties.md) methods.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)   
 [DEBUGPROP_INFO_FLAGS](../../../extensibility/debugger/reference/debugprop-info-flags.md)   
 [DBG_ATTRIB_FLAGS](../../../extensibility/debugger/reference/dbg-attrib-flags.md)   
 [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)   
 [GetPropertyInfo](../../../extensibility/debugger/reference/idebugproperty2-getpropertyinfo.md)   
 [IEnumDebugPropertyInfo2](../../../extensibility/debugger/reference/ienumdebugpropertyinfo2.md)   
 [EnumChildren](../../../extensibility/debugger/reference/idebugproperty2-enumchildren.md)   
 [EnumProperties](../../../extensibility/debugger/reference/idebugstackframe2-enumproperties.md)
