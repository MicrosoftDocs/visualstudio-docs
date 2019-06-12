---
title: "IDebugExpression2::Abort | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugExpression2::Abort"
helpviewer_keywords: 
  - "IDebugExpression2::Abort"
ms.assetid: 4fcb712e-1bdb-4b75-a440-35cc79ee147e
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IDebugExpression2::Abort
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This method cancels asynchronous expression evaluation as started by a call to the [EvaluateAsync](../../../extensibility/debugger/reference/idebugexpression2-evaluateasync.md) method.  
  
## Syntax  
  
```cpp#  
HRESULT Abort(  
   void  
);  
```  
  
```csharp  
int Abort();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 When asynchronous expression evaluation is cancelled, do not sent an [IDebugExpressionEvaluationCompleteEvent2](../../../extensibility/debugger/reference/idebugexpressionevaluationcompleteevent2.md) event to the event callback passed to the [Attach](../../../extensibility/debugger/reference/idebugprogram2-attach.md) or [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md) methods.  
  
## See Also  
 [IDebugExpression2](../../../extensibility/debugger/reference/idebugexpression2.md)   
 [IDebugExpressionEvaluationCompleteEvent2](../../../extensibility/debugger/reference/idebugexpressionevaluationcompleteevent2.md)   
 [EvaluateAsync](../../../extensibility/debugger/reference/idebugexpression2-evaluateasync.md)
