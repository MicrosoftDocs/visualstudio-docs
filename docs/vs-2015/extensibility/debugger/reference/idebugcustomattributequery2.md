---
title: "IDebugCustomAttributeQuery2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugCustomAttributeQuery2"
helpviewer_keywords: 
  - "IDebugCustomAttributeQuery interface"
  - "IDebugCustomAttributeQuery2 interface"
ms.assetid: 7cfa23e4-a05a-47a3-af6c-bd40c655014b
caps.latest.revision: 14
ms.author: gregvanl
manager: jillfra
---
# IDebugCustomAttributeQuery2
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Determines the existence of a custom attribute for this field and, if it exists, returns the attribute information.  
  
## Syntax  
  
```  
IDebugCustomAttributeQuery2 : IDebugCustomAttributeQuery  
```  
  
## Notes for Implementers  
 A symbol provider implements this interface on the same object that implements [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) in order to support custom attributes.  
  
## Notes for Callers  
 Use [QueryInterface](https://msdn.microsoft.com/library/62fce95e-aafa-4187-b50b-e6611b74c3b3) to obtain this interface from the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of the **IDebugCustomAttributeQuery** interface.  
  
|Method|Description|  
|------------|-----------------|  
|[IsCustomAttributeDefined](../../../extensibility/debugger/reference/idebugcustomattributequery2-iscustomattributedefined.md)|Determines whether a custom attribute exists by name.|  
|[GetCustomAttributeByName](../../../extensibility/debugger/reference/idebugcustomattributequery2-getcustomattributebyname.md)|Gets the attribute information for the given custom attribute.|  
  
 In addition to the **IDebugCustomAttributeQuery** methods, `IDebugCustomAttributeQuery2` implements the following method:  
  
|Method|Description|  
|------------|-----------------|  
|[EnumCustomAttributes](../../../extensibility/debugger/reference/idebugcustomattributequery2-enumcustomattributes.md)|Gets an enumerator for all custom attributes attached to this field.|  
  
## Remarks  
 The [IEnumDebugCustomAttributes](../../../extensibility/debugger/reference/ienumdebugcustomattributes.md) method can return an enumerator for all custom attributes defined for this field.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../../../extensibility/debugger/reference/symbol-provider-interfaces.md)   
 [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)   
 [IEnumDebugCustomAttributes](../../../extensibility/debugger/reference/ienumdebugcustomattributes.md)
