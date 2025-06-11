---
description: "Continues running this process from a stopped state. Any previous execution state (such as a step) is preserved, and the process starts executing again."
title: IDebugProcess3::Continue
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProcess3::Continue
helpviewer_keywords:
- IDebugProcess3::Continue
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProcess3::Continue

Continues running this process from a stopped state. Any previous execution state (such as a step) is preserved, and the process starts executing again.

> [!NOTE]
> This method should be used instead of [Continue](../../../extensibility/debugger/reference/idebugprogram2-continue.md).

## Syntax

### [C#](#tab/csharp)
```csharp
int Continue(
   IDebugThread2 pThread
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Continue(
   IDebugThread2* pThread
);
```
---

## Parameters
`pThread`\
[in] An [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md) object representing the thread to be continued.

## Return Value
 If successful, returns `S_OK`; otherwise, returns error code.

## Remarks
 This method is called on this process regardless of how many processes are being debugged, or which process generated the stopping event. The implementation must retain the previous execution state (such as a step) and continue execution as though it had never stopped before completing its prior execution. That is, if a thread in this process was doing a step-over operation and was stopped because some other process stopped, and then `Continue` was called, the specified thread must complete the original step-over operation.

 **Warning** Do not send a stopping event or an immediate (synchronous) event to [Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md) while handling this call; otherwise the debugger may stop responding.

## See also
- [IDebugProcess3](../../../extensibility/debugger/reference/idebugprocess3.md)
- [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)
- [Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md)
