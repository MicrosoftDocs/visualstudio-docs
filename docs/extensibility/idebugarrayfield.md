---
title: "IDebugArrayField"
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
  - "IDebugArrayField"
helpviewer_keywords: 
  - "IDebugArrayField interface"
ms.assetid: 9667b0a5-4295-46cc-9388-b75c1350be15
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
# IDebugArrayField
This interface describes an array symbol or type.  
  
## Syntax  
  
```  
IDebugArrayField : IDebugContainerField  
```  
  
## Notes for Implementers  
 The symbol provider implements this interface on the same object that implements the [IDebugContainerField](../extensibility/idebugcontainerfield.md) interface. This interface is a specialization that represents array objects.  
  
## Notes for Callers  
 Use [QueryInterface](../Topic/QueryInterface.md) to obtain this interface from the [IDebugContainerField](../extensibility/idebugcontainerfield.md) interface if [GetKind](../extensibility/idebugfield--getkind.md) returns the flag `FIELD_TYPE_ARRAY`.  
  
## Methods in Vtable Order  
 In addition to the methods on the [IDebugField](../extensibility/idebugfield.md) and [IDebugContainerField](../extensibility/idebugcontainerfield.md) interfaces, this interface implements the following:  
  
|Method|Description|  
|------------|-----------------|  
|[GetNumberOfElements](../extensibility/idebugarrayfield--getnumberofelements.md)|Gets the number of elements in the array.|  
|[GetElementType](../extensibility/idebugarrayfield--getelementtype.md)|Gets the type of element in the array.|  
|[GetRank](../extensibility/idebugarrayfield--getrank.md)|Gets the rank of the array.|  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../extensibility/symbol-provider-interfaces.md)   
 [IDebugContainerField](../extensibility/idebugcontainerfield.md)   
 [IDebugField](../extensibility/idebugfield.md)