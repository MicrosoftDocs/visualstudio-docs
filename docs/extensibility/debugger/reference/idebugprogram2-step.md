---
description: "Performs a step."
title: IDebugProgram2::Step
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgram2::Step
helpviewer_keywords:
- IDebugProgram2::Step
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgram2::Step

Performs a step.

> [!NOTE]
> This method is deprecated. Use the [Step](../../../extensibility/debugger/reference/idebugprocess3-step.md) method instead.

## Syntax

### [C#](#tab/csharp)
```csharp
int Step( 
   IDebugThread2  pThread,
   enum_STEPKIND  sk,
   enum_STEPUNIT  step
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Step( 
   IDebugThread2*  pThread,
   STEPKIND        sk,
   STEPUNIT        step
);
```
---

## Parameters
`pThread`\
[in] An [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md) object that represents the thread being stepped.

`sk`\
[in] A value from the [STEPKIND](../../../extensibility/debugger/reference/stepkind.md) enumeration that specifies the kind of step.

`step`\
[in] A value from the [STEPUNIT](../../../extensibility/debugger/reference/stepunit.md) enumeration that specifies the unit of step (for example, by statement or instruction).

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 In case there is any thread synchronization or communication between threads, other threads in the program should run when a particular thread is stepping.

> [!WARNING]
> Do not send a stopping event or an immediate (synchronous) event to [Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md) while handling this call; otherwise the debugger may stop responding.

## See also
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
- [IDebugEngineProgram2](../../../extensibility/debugger/reference/idebugengineprogram2.md)
- [Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md)
