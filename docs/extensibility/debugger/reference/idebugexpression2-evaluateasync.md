---
description: "This method evaluates the expression asynchronously."
title: IDebugExpression2::EvaluateAsync
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugExpression2::EvaluateAsync
helpviewer_keywords:
- IDebugExpression2::EvaluateAsync
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugExpression2::EvaluateAsync

This method evaluates the expression asynchronously.

## Syntax

### [C#](#tab/csharp)
```csharp
int EvaluateAsync(
    enum_EVALFLAGS       dwFlags,
    IDebugEventCallback2 pExprCallback
);
```
### [C++](#tab/cpp)
```cpp
HRESULT EvaluateAsync (
    EVALFLAGS             dwFlags,
    IDebugEventCallback2* pExprCallback
);
```
---

## Parameters
`dwFlags`\
[in] A combination of flags from the [EVALFLAGS](../../../extensibility/debugger/reference/evalflags.md) enumeration that control expression evaluation.

`pExprCallback`\
[in] This parameter is always a null value.

## Return Value
If successful, returns `S_OK`; otherwise returns an error code. A typical error code is:

|Error|Description|
|-----------|-----------------|
|E_EVALUATE_BUSY_WITH_EVALUATION|Another expression is currently being evaluated, and simultaneous expression evaluation is not supported.|

## Remarks
This method should return immediately after it has started the expression evaluation. When the expression is successfully evaluated, an [IDebugExpressionEvaluationCompleteEvent2](../../../extensibility/debugger/reference/idebugexpressionevaluationcompleteevent2.md) must be sent to the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) event callback as supplied through [Attach](../../../extensibility/debugger/reference/idebugprogram2-attach.md) or [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md).

## Example
The following example shows how to implement this method for a simple `CExpression` object that implements the [IDebugExpression2](../../../extensibility/debugger/reference/idebugexpression2.md) interface.

```cpp
HRESULT CExpression::EvaluateAsync(EVALFLAGS dwFlags,
                                   IDebugEventCallback2* pExprCallback)
{
    // Set the aborted state to FALSE
    // in case the user tries to redo the evaluation after aborting.
    m_bAborted = FALSE;
    // Post the WM_EVAL_EXPR message in the message queue of the current thread.
    // This starts the expression evaluation on a background thread.
    PostThreadMessage(GetCurrentThreadId(), WM_EVAL_EXPR, 0, (LPARAM) this);
    return S_OK;
}
```

## See also
- [IDebugExpression2](../../../extensibility/debugger/reference/idebugexpression2.md)
- [IDebugExpressionEvaluationCompleteEvent2](../../../extensibility/debugger/reference/idebugexpressionevaluationcompleteevent2.md)
- [EVALFLAGS](../../../extensibility/debugger/reference/evalflags.md)
- [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
