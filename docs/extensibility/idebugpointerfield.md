---
title: "IDebugPointerField"
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
  - "IDebugPointerField"
helpviewer_keywords: 
  - "IDebugPointerField interface"
ms.assetid: d51bd5b2-f18e-4e27-b4fb-e6f652fbf635
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
# IDebugPointerField
This interface represents a pointer type.  
  
## Syntax  
  
```  
IDebugPointerField : IDebugContainerField  
```  
  
## Notes for Implementers  
 The symbol provider implements this interface to represent a pointer.  
  
## Notes for Callers  
 Use [QueryInterface](../Topic/QueryInterface.md) to obtain this interface from the [IDebugField](../extensibility/idebugfield.md) interface if [GetKind](../extensibility/idebugfield--getkind.md) returns `FIELD_TYPE_POINTER`.  
  
## Methods in Vtable order  
 In addition to the methods on the `IDebugField` and `IDebugContainerField` interfaces, this interface implements the following method:  
  
|Method|Description|  
|------------|-----------------|  
|[GetDereferencedField](../extensibility/idebugpointerfield--getdereferencedfield.md)|Returns an [IDebugField](../extensibility/idebugfield.md) describing the target of the pointer.|  
  
## Remarks  
 In C/C++, a pointer can be a container if it is used with array notation. For example, given `char *pString`, `pString` has a type of pointer to `char`. `pString[3]` has the type of a container that is a pointer to `char` that references the fourth element of that container.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../extensibility/symbol-provider-interfaces.md)   
 [IDebugField](../extensibility/idebugfield.md)   
 [IDebugContainerField](../extensibility/idebugcontainerfield.md)