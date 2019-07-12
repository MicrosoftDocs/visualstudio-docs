---
title: "IDebugProcess3::Step | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugProcess3::Step"
helpviewer_keywords:
  - "IDebugProcess3::Step"
ms.assetid: 6ad9094c-27cc-4927-8a7c-1b4d97b2e436
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugProcess3::Step
Causes the process to step one instruction or statement.

> [!NOTE]
> This method should be used instead of [Step](../../../extensibility/debugger/reference/idebugprogram2-step.md).

## Syntax

```cpp
HRESULT Step(
   IDebugThread2* pThread,
   STEPKIND       sk,
   STEPUNIT       step,
);
```

```csharp
int Step(
   IDebugThread2 pThread,
   enum_STEPKIND sk,
   enum_STEPUNIT step
);
```

## Parameters
`pThread`\
[in] An [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md) object representing the thread being stepped.

`sk`\
[in] One of the [STEPKIND](../../../extensibility/debugger/reference/stepkind.md) values.

`step`\
[in] One of the [STEPUNIT](../../../extensibility/debugger/reference/stepunit.md) values.

## Return Value
 If successful, returns S_OK; otherwise returns error code.

## Remarks
 In case there is any thread synchronization or communication between threads, other threads in the process should run when a particular thread is stepping.

 **Warning** Do not send a stopping event or an immediate (synchronous) event to [Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md) while handling this call; otherwise the debugger may hang.

## See also
- [IDebugProcess3](../../../extensibility/debugger/reference/idebugprocess3.md)
- [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)
- [STEPKIND](../../../extensibility/debugger/reference/stepkind.md)
- [STEPUNIT](../../../extensibility/debugger/reference/stepunit.md)
- [Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md)