---
title: "IDebugStackFrame2::GetExpressionContext"
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
  - "IDebugStackFrame2::GetExpressionContext"
helpviewer_keywords: 
  - "IDebugStackFrame2::GetExpressionContext"
ms.assetid: a2604e6a-502d-473b-868f-b11ac64c7a35
caps.latest.revision: 10
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
# IDebugStackFrame2::GetExpressionContext
Gets an evaluation context for expression evaluation within the current context of a stack frame and thread.  
  
## Syntax  
  
```cpp#  
HRESULT GetExpressionContext (   
   IDebugExpressionContext2** ppExprCxt  
);  
```  
  
```c#  
int GetExpressionContext (   
   out IDebugExpressionContext2 ppExprCxt  
);  
```  
  
#### Parameters  
 `ppExprCxt`  
 [out] Returns an [IDebugExpressionContext2](../extensibility/idebugexpressioncontext2.md) object that represents a context for expression evaluation.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Generally, an expression evaluation context can be thought of as a scope for performing expression evaluation. Call the [ParseText](../extensibility/idebugexpressioncontext2--parsetext.md) method to parse an expression and then call the resulting [EvaluateSync](../extensibility/idebugexpression2--evaluatesync.md) or [EvaluateAsync](../extensibility/idebugexpression2--evaluateasync.md) methods to evaluate the parsed expression.  
  
## See Also  
 [IDebugStackFrame2](../extensibility/idebugstackframe2.md)   
 [IDebugExpressionContext2](../extensibility/idebugexpressioncontext2.md)   
 [ParseText](../extensibility/idebugexpressioncontext2--parsetext.md)   
 [EvaluateSync](../extensibility/idebugexpression2--evaluatesync.md)   
 [EvaluateAsync](../extensibility/idebugexpression2--evaluateasync.md)