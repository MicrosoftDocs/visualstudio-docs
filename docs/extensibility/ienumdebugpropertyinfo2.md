---
title: "IEnumDebugPropertyInfo2"
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
  - "IEnumDebugPropertyInfo2"
helpviewer_keywords: 
  - "IEnumDebugPropertyInfo2"
ms.assetid: fdea8262-40b8-473e-88ba-639e4c4648e6
caps.latest.revision: 11
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
# IEnumDebugPropertyInfo2
This interface enumerates [DEBUG_PROPERTY_INFO](../extensibility/debug_property_info.md) structures.  
  
## Syntax  
  
```  
IEnumDebugPropertyInfo2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface to represent information for a particular property.  
  
## Notes for Callers  
 Call [EnumChildren](../extensibility/idebugproperty2--enumchildren.md) to obtain this interface representing the children of a particular property. Call [EnumProperties](../extensibility/idebugstackframe2--enumproperties.md) to obtain this interface representing the properties of a particular stack frame.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IEnumDebugPropertyInfo2`.  
  
|Method|Description|  
|------------|-----------------|  
|[Next](../extensibility/ienumdebugpropertyinfo2--next.md)|Retrieves a specified number of [DEBUG_PROPERTY_INFO](../extensibility/debug_property_info.md) structures in an enumeration sequence.|  
|[Skip](../extensibility/ienumdebugpropertyinfo2--skip.md)|Skips a specified number of [DEBUG_PROPERTY_INFO](../extensibility/debug_property_info.md) structures in an enumeration sequence.|  
|[Reset](../extensibility/ienumdebugpropertyinfo2--reset.md)|Resets an enumeration sequence to the beginning.|  
|[Clone](../extensibility/ienumdebugpropertyinfo2--clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
|[GetCount](../extensibility/ienumdebugpropertyinfo2--getcount.md)|Gets the number of [DEBUG_PROPERTY_INFO](../extensibility/debug_property_info.md) structures in an enumerator.|  
  
## Remarks  
 In general, a property is a hierarchy of information that can include a name, value, address, and type, as well as any other information appropriate to the associated property object or stack frame. See [IDebugProperty2](../extensibility/idebugproperty2.md) for more details.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../extensibility/core-interfaces.md)   
 [DEBUG_PROPERTY_INFO](../extensibility/debug_property_info.md)   
 [IDebugProperty2](../extensibility/idebugproperty2.md)   
 [EnumChildren](../extensibility/idebugproperty2--enumchildren.md)   
 [EnumProperties](../extensibility/idebugstackframe2--enumproperties.md)