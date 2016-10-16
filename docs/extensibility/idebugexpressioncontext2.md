---
title: "IDebugExpressionContext2"
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
  - "IDebugExpressionContext2"
helpviewer_keywords: 
  - "IDebugExpressionContext2 interface"
ms.assetid: 577fdaae-4b2d-4112-9839-ab899535fa6f
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
# IDebugExpressionContext2
This interface represents a context for expression evaluation  
  
## Syntax  
  
```  
IDebugExpressionContext2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface to represent a context in which an expression can be evaluated.  
  
## Notes for Callers  
 A call to [GetExpressionContext](../extensibility/idebugstackframe2--getexpressioncontext.md) returns the this interface. This interface is accessible only when the program being debugged has been paused and a stack frame is available.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugExpressionContext2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetName](../extensibility/idebugexpressioncontext2--getname.md)|Retrieves the name of the evaluation context.|  
|[ParseText](../extensibility/idebugexpressioncontext2--parsetext.md)|Parses a text-based expression for evaluation.|  
  
## Remarks  
 An evaluation context can be thought of as a scope for performing expression evaluation.  
  
 When a program has halted, the session debug manager (SDM) obtains a stack frame from the DE with a call to [EnumFrameInfo](../extensibility/idebugthread2--enumframeinfo.md). The SDM then calls [GetExpressionContext](../extensibility/idebugstackframe2--getexpressioncontext.md) to get the `IDebugExpressionContext2` interface. This is followed by a call to [ParseText](../extensibility/idebugexpressioncontext2--parsetext.md) to create an [IDebugExpression2](../extensibility/idebugexpression2.md) interface, which represents the parsed expression ready to be evaluated.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../extensibility/core-interfaces.md)   
 [GetExpressionContext](../extensibility/idebugstackframe2--getexpressioncontext.md)   
 [IDebugExpression2](../extensibility/idebugexpression2.md)