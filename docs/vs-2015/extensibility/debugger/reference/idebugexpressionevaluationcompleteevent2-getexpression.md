---
title: "IDebugExpressionEvaluationCompleteEvent2::GetExpression | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugExpressionEvaluationCompleteEvent2::GetExpression"
helpviewer_keywords: 
  - "IDebugExpressionEvaluationCompleteEvent2::GetExpression"
ms.assetid: faf6b2dd-2afd-4852-b21c-7e8d3130e141
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugExpressionEvaluationCompleteEvent2::GetExpression
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the original expression.  
  
## Syntax  
  
```cpp#  
HRESULT GetExpression(   
   IDebugExpression2** ppExpr  
);  
```  
  
```csharp  
int GetExpression(   
   out IDebugExpression2 ppExpr  
);  
```  
  
#### Parameters  
 `ppExpr`  
 [out] Returns an [IDebugExpression2](../../../extensibility/debugger/reference/idebugexpression2.md) object that represents the expression that was parsed.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method returns the object that was created in a call to the [ParseText](../../../extensibility/debugger/reference/idebugexpressioncontext2-parsetext.md) method.  
  
## See Also  
 [IDebugExpressionEvaluationCompleteEvent2](../../../extensibility/debugger/reference/idebugexpressionevaluationcompleteevent2.md)   
 [IDebugExpression2](../../../extensibility/debugger/reference/idebugexpression2.md)   
 [ParseText](../../../extensibility/debugger/reference/idebugexpressioncontext2-parsetext.md)
