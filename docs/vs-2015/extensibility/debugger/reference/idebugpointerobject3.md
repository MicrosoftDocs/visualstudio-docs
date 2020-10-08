---
title: "IDebugPointerObject3 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "IDebugPointerObject3 interface"
ms.assetid: 11d26af4-1079-435e-96fa-d5269cbea8eb
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugPointerObject3
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 Represents a pointer in a parse tree, and extends the **IDebugPointerObject** interface.  
  
## Syntax  
  
```  
IDebugPointerObject3 : IDebugPointerObject  
```  
  
## Notes for Implementers  
 An expression evaluator (EE) implements this interface.  
  
## Methods  
 In addition to the methods on the [IDebugPointerObject](../../../extensibility/debugger/reference/idebugpointerobject.md) interface, this interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[GetPointerAddress](../../../extensibility/debugger/reference/idebugpointerobject3-getpointeraddress.md)|Retrieves the address of pointer.|  
  
## Requirements  
 Header: Ee.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
