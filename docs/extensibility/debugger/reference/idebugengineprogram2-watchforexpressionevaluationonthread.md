---
title: "IDebugEngineProgram2::WatchForExpressionEvaluationOnThread | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugEngineProgram2::WatchForExpressionEvaluationOnThread"
helpviewer_keywords:
  - "IDebugEngineProgram2::WatchForExpressionEvaluationOnThread"
ms.assetid: 01d05e77-8cac-4d1b-b19f-25756767ed27
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugEngineProgram2::WatchForExpressionEvaluationOnThread
Allows (or disallows) expression evaluation to occur on the given thread, even if the program has stopped.

## Syntax

```cpp
HRESULT WatchForExpressionEvaluationOnThread( 
   IDebugProgram2*       pOriginatingProgram,
   DWORD                 dwTid,
   DWORD                 dwEvalFlags,
   IDebugEventCallback2* pExprCallback,
   BOOL                  fWatch
);
```

```csharp
int WatchForExpressionEvaluationOnThread( 
   IDebugProgram2       pOriginatingProgram,
   uint                  dwTid,
   uint                  dwEvalFlags,
   IDebugEventCallback2 pExprCallback,
   int                   fWatch
);
```

## Parameters
`pOriginatingProgram`\
[in] An [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md) object representing the program that is evaluating an expression.

`dwTid`\
[in] Specifies the identifier of the thread.

`dwEvalFlags`\
[in] A combination of flags from the [EVALFLAGS](../../../extensibility/debugger/reference/evalflags.md) enumeration that specify how the evaluation is to be performed.

`pExprCallback`\
[in] An [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) object to be used to send debug events that occur during expression evaluation.

`fWatch`\
[in] If non-zero (`TRUE`), allows expression evaluation on the thread identified by `dwTid`; otherwise, zero (`FALSE`) disallows expression evaluation on that thread.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 When the session debug manager (SDM) asks a program, identified by the `pOriginatingProgram` parameter, to evaluate an expression, it notifies all other attached programs by calling this method.

 Expression evaluation in one program may cause code to run in another, due to function evaluation or evaluation of any `IDispatch` properties. Because of this, this method allows expression evaluation to run and complete even though the thread may be stopped in this program.

## See also
- [IDebugEngineProgram2](../../../extensibility/debugger/reference/idebugengineprogram2.md)
- [EVALFLAGS](../../../extensibility/debugger/reference/evalflags.md)
- [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)