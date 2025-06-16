---
description: "Determines whether or not the debug engine (DE) supports the option of passing this exception to the program being debugged when execution resumes."
title: IDebugExceptionEvent2::CanPassToDebuggee
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugExceptionEvent2::CanPassToDebuggee
helpviewer_keywords:
- IDebugExceptionEvent2::CanPassToDebuggee
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugExceptionEvent2::CanPassToDebuggee

Determines whether or not the debug engine (DE) supports the option of passing this exception to the program being debugged when execution resumes.

## Syntax

### [C#](#tab/csharp)
```csharp
int CanPassToDebuggee();
```
### [C++](#tab/cpp)
```cpp
HRESULT CanPassToDebuggee(
   void
);
```
---

## Return Value
 Returns either `S_OK` (the exception can be passed to the program) or `S_FALSE` (the exception cannot be passed on).

## Remarks
 The DE must have a default action for passing to the debuggee. The IDE may receive the [IDebugExceptionEvent2](../../../extensibility/debugger/reference/idebugexceptionevent2.md) event and call the [Continue](../../../extensibility/debugger/reference/idebugprocess3-continue.md) method without calling the `CanPassToDebuggee` method. Therefore, the DE should have a default case for passing the exception on or not.

## See also
- [IDebugExceptionEvent2](../../../extensibility/debugger/reference/idebugexceptionevent2.md)
- [Continue](../../../extensibility/debugger/reference/idebugprocess3-continue.md)
