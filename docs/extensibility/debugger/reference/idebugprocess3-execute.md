---
description: "Continues running this process from a stopped state. Any previous execution state (such as a step) is cleared and the process starts executing again."
title: IDebugProcess3::Execute
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProcess3::Execute
helpviewer_keywords:
- IDebugProcess3::Execute
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProcess3::Execute

Continues running this process from a stopped state. Any previous execution state (such as a step) is cleared and the process starts executing again.

> [!NOTE]
> This method should be used instead of [Execute](../../../extensibility/debugger/reference/idebugprogram2-execute.md).

## Syntax

### [C#](#tab/csharp)
```csharp
int Execute(
   IDebugThread2 pThread
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Execute(
   IDebugThread2* pThread
);
```
---

## Parameters
`pThread`\
[in] An [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md) object representing the thread to execute.

## Return Value
 If successful, returns `S_OK`; otherwise, returns error code.

## Remarks
 When the user starts execution from a stopped state in some other process's thread, this method is called on this process. This method is also called when the user selects the **Start** command from the **Debug** menu in the IDE. The implementation of this method may be as simple as calling the [Resume](../../../extensibility/debugger/reference/idebugthread2-resume.md) method on the current thread in the process.

> [!WARNING]
> Do not send a stopping event or an immediate (synchronous) event to [Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md) while handling this call; otherwise the debugger may stop responding.

## See also
- [IDebugProcess3](../../../extensibility/debugger/reference/idebugprocess3.md)
- [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)
- [Resume](../../../extensibility/debugger/reference/idebugthread2-resume.md)
- [Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md)
