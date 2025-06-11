---
description: "IDebugProgram2::Continue continues running this program from a stopped state. Any previous execution state (such as a step) is preserved, and the program starts executing again."
title: IDebugProgram2::Continue
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgram2::Continue
helpviewer_keywords:
- IDebugProgram2::Continue
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgram2::Continue

Continues running this program from a stopped state. Any previous execution state (such as a step) is preserved, and the program starts executing again.

> [!NOTE]
> This method is deprecated. Use the [Continue](../../../extensibility/debugger/reference/idebugprocess3-continue.md) method instead.

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
`pThread`
[in] An [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md) object that represents the thread.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method is called on this program regardless of how many programs are being debugged, or which program generated the stopping event. The implementation must retain the previous execution state (such as a step) and continue execution as though it had never stopped before completing its prior execution. That is, if a thread in this program was doing a step-over operation and was stopped because some other program stopped, and then this method was called, the program must complete the original step-over operation.

> [!WARNING]
> Do not send a stopping event or an immediate (synchronous) event to [Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md) while handling this call; otherwise the debugger may stop responding.

## See also
- [IDebugEngineProgram2](../../../extensibility/debugger/reference/idebugengineprogram2.md)
- [Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md)
