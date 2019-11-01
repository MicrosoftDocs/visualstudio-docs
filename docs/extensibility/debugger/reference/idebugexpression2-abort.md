---
title: "IDebugExpression2::Abort | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugExpression2::Abort"
helpviewer_keywords:
  - "IDebugExpression2::Abort"
ms.assetid: 4fcb712e-1bdb-4b75-a440-35cc79ee147e
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugExpression2::Abort
This method cancels asynchronous expression evaluation as started by a call to the [EvaluateAsync](../../../extensibility/debugger/reference/idebugexpression2-evaluateasync.md) method.

## Syntax

```cpp
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

## See also
- [IDebugExpression2](../../../extensibility/debugger/reference/idebugexpression2.md)
- [IDebugExpressionEvaluationCompleteEvent2](../../../extensibility/debugger/reference/idebugexpressionevaluationcompleteevent2.md)
- [EvaluateAsync](../../../extensibility/debugger/reference/idebugexpression2-evaluateasync.md)