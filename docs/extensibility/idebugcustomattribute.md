---
title: "IDebugCustomAttribute"
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
  - "IDebugCustomAttribute"
helpviewer_keywords: 
  - "IDebugCustomAttribute interface"
ms.assetid: c5ae41e9-00b9-4cca-871d-b8de9ef390d1
caps.latest.revision: 13
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
# IDebugCustomAttribute
This interface represents a custom attribute, and it can provide the name, parent, and class type of the attribute.  
  
## Syntax  
  
```  
IDebugCustomAttribute : IUnknown  
```  
  
## Notes for Implementers  
 A symbol provider implements this interface in order to support custom attributes associated with a symbol. It is typically implemented on its own object.  
  
## Notes for Callers  
 A call to [Next](../extensibility/ienumdebugcustomattributes--next.md) returns this interface. A call to the [EnumCustomAttributes](../extensibility/idebugcustomattributequery2--enumcustomattributes.md) method returns the [IEnumDebugCustomAttributes](../extensibility/ienumdebugcustomattributes.md) interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugCustomAttribute`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetParentField](../extensibility/idebugcustomattribute--getparentfield.md)|Gets the field to which the current attribute is attached.|  
|[GetAttributeTypeField](../extensibility/idebugcustomattribute--getattributetypefield.md)|Gets the custom attribute class type.|  
|[GetName](../extensibility/idebugcustomattribute--getname.md)|Gets the name of the custom attribute.|  
|[GetAttributeBytes](../extensibility/idebugcustomattribute--getattributebytes.md)|Gets the attribute information as a blob of bytes.|  
  
## Remarks  
 A custom attribute is a structure for C# that supplies custom metadata associated with a particular class or method.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../extensibility/symbol-provider-interfaces.md)   
 [IDebugField](../extensibility/idebugfield.md)   
 [IDebugCustomAttributeQuery2](../extensibility/idebugcustomattributequery2.md)   
 [IEnumDebugCustomAttributes](../extensibility/ienumdebugcustomattributes.md)