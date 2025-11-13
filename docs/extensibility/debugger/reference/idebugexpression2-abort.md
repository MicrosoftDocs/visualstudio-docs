---
description: "This method cancels asynchronous expression evaluation as started by a call to the EvaluateAsync) method."
title: IDebugExpression2::Abort
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugExpression2::Abort
helpviewer_keywords:
- IDebugExpression2::Abort
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugExpression2::Abort

This method cancels asynchronous expression evaluation as started by a call to the [EvaluateAsync](../../../extensibility/debugger/reference/idebugexpression2-evaluateasync.md) method.

## Syntax

### [C#](#tab/csharp)
```csharp
int Abort();
```
### [C++](#tab/cpp)
```cpp
HRESULT Abort(
   void
);
```
---

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 When asynchronous expression evaluation is cancelled, do not sent an [IDebugExpressionEvaluationCompleteEvent2](../../../extensibility/debugger/reference/idebugexpressionevaluationcompleteevent2.md) event to the event callback passed to the [Attach](../../../extensibility/debugger/reference/idebugprogram2-attach.md) or [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md) methods.

## See also
- [IDebugExpression2](../../../extensibility/debugger/reference/idebugexpression2.md)
- [IDebugExpressionEvaluationCompleteEvent2](../../../extensibility/debugger/reference/idebugexpressionevaluationcompleteevent2.md)
- [EvaluateAsync](../../../extensibility/debugger/reference/idebugexpression2-evaluateasync.md)
