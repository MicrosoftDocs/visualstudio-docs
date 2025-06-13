---
description: "Gets the original expression."
title: IDebugExpressionEvaluationCompleteEvent2::GetExpression
titleSuffix: ""
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugExpressionEvaluationCompleteEvent2::GetExpression
helpviewer_keywords:
- IDebugExpressionEvaluationCompleteEvent2::GetExpression
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugExpressionEvaluationCompleteEvent2::GetExpression

Gets the original expression.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetExpression( 
   out IDebugExpression2 ppExpr
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetExpression( 
   IDebugExpression2** ppExpr
);
```
---

## Parameters
`ppExpr`\
[out] Returns an [IDebugExpression2](../../../extensibility/debugger/reference/idebugexpression2.md) object that represents the expression that was parsed.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method returns the object that was created in a call to the [ParseText](../../../extensibility/debugger/reference/idebugexpressioncontext2-parsetext.md) method.

## See also
- [IDebugExpressionEvaluationCompleteEvent2](../../../extensibility/debugger/reference/idebugexpressionevaluationcompleteevent2.md)
- [IDebugExpression2](../../../extensibility/debugger/reference/idebugexpression2.md)
- [ParseText](../../../extensibility/debugger/reference/idebugexpressioncontext2-parsetext.md)
