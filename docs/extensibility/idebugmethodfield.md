---
title: "IDebugMethodField"
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
  - "IDebugMethodField"
helpviewer_keywords: 
  - "IDebugMethodField interface"
ms.assetid: a7dc9030-fc98-4cf1-b943-37a4003300b6
caps.latest.revision: 12
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
# IDebugMethodField
This interface describes a method.  
  
## Syntax  
  
```  
IDebugMethodField : IDebugContainerField  
```  
  
## Notes for Implementers  
 A symbol provider implements this interface on the same object that implements the [IDebugContainerField](../extensibility/idebugcontainerfield.md) interface. This interface is a specialization that presents a method.  
  
## Notes for Callers  
 Use [QueryInterface](../Topic/QueryInterface.md) to obtain this interface from the [IDebugContainerField](../extensibility/idebugcontainerfield.md) interface if [GetKind](../extensibility/idebugfield--getkind.md) returns `FIELD_TYPE_METHOD`. In addition, the methods, [GetPropertyGetter](../extensibility/idebugpropertyfield--getpropertygetter.md), [GetPropertySetter](../extensibility/idebugpropertyfield--getpropertysetter.md), and [EnumConstructors](../extensibility/idebugclassfield--enumconstructors.md), all return the `IDebugMethodField` interface.  
  
## Methods in Vtable Order  
 In addition to the methods on the [IDebugField](../extensibility/idebugfield.md) and [IDebugContainerField](../extensibility/idebugcontainerfield.md) interfaces, this interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[EnumParameters](../extensibility/idebugmethodfield--enumparameters.md)|Creates an enumerator for the parameters of the method.|  
|[GetThis](../extensibility/idebugmethodfield--getthis.md)|Gets the "this" pointer of the object containing the method.|  
|[EnumAllLocals](../extensibility/idebugmethodfield--enumalllocals.md)|Creates an enumerator for all local variables of the method.|  
|[EnumLocals](../extensibility/idebugmethodfield--enumlocals.md)|Creates an enumerator for selected local variables of the method.|  
|[IsCustomAttributeDefined](../extensibility/idebugmethodfield--iscustomattributedefined.md)|Determines whether a specific custom attribute has been defined.|  
|[EnumStaticLocals](../extensibility/idebugmethodfield--enumstaticlocals.md)|Creates an enumerator for static local variables of the method.|  
|[GetGlobalContainer](../extensibility/idebugmethodfield--getglobalcontainer.md)|Gets the global container of the method.|  
|[EnumArguments](../extensibility/idebugmethodfield--enumarguments.md)|Creates an enumerator for the type of each argument required to call the method.|  
  
## Remarks  
 A method can contain parameters as well as local variables.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../extensibility/symbol-provider-interfaces.md)   
 [IDebugContainerField](../extensibility/idebugcontainerfield.md)   
 [IDebugField](../extensibility/idebugfield.md)