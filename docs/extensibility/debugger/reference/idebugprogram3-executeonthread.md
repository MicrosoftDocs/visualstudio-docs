---
description: "Executes the debugger program."
title: IDebugProgram3::ExecuteOnThread
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugProgram3::ExecuteOnThread
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgram3::ExecuteOnThread

Executes the debugger program. The thread is returned to give the debugger information on which thread the user is viewing when executing the program.

## Syntax

### [C#](#tab/csharp)
```csharp
int ExecuteOnThread(
   IDebugThread2 pThread
);
```
### [C++](#tab/cpp)
```cpp
HRESULT ExecuteOnThread(
   [in] IDebugThread2* pThread)
```
---

## Parameters
`pThread`\
[in] An [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md) object.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 There are three different ways that a debugger can resume execution after stopping:

- Execute: Cancel any previous step, and run until the next breakpoint and so on.

- Step: Cancel any old step, and run until the new step completes.

- Continue: Run again, and leave any old step active.

  The thread passed to `ExecuteOnThread` is useful when deciding which step to cancel. If you do not know the thread, running execute cancels all steps. With knowledge of the thread, you only need to cancel the step on the active thread.

## See also
- [Execute](../../../extensibility/debugger/reference/idebugprogram2-execute.md)
- [IDebugProgram3](../../../extensibility/debugger/reference/idebugprogram3.md)
