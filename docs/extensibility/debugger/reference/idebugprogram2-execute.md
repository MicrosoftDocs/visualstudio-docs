---
description: "IDebugProgram2::Execute continues running this program from a stopped state. Any previous execution state (such as a step) is cleared, and the program starts executing again."
title: IDebugProgram2::Execute
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgram2::Execute
helpviewer_keywords:
- IDebugProgram2::Execute
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgram2::Execute

Continues running this program from a stopped state. Any previous execution state (such as a step) is cleared, and the program starts executing again.

> [!NOTE]
> This method is deprecated. Use the [Execute](../../../extensibility/debugger/reference/idebugprocess3-execute.md) method instead.

## Syntax

### [C#](#tab/csharp)
```csharp
int Execute();
```
### [C++](#tab/cpp)
```cpp
HRESULT Execute(
   void
);
```
---

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 When the user starts execution from a stopped state in some other program's thread, this method is called on this program. This method is also called when the user selects the **Start** command from the **Debug** menu in the IDE. The implementation of this method may be as simple as calling the [Resume](../../../extensibility/debugger/reference/idebugthread2-resume.md) method on the current thread in the program.

> [!WARNING]
> Do not send a stopping event or an immediate (synchronous) event to [Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md) while handling this call; otherwise the debugger may stop responding.

## See also
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
- [Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md)
- [Resume](../../../extensibility/debugger/reference/idebugthread2-resume.md)
