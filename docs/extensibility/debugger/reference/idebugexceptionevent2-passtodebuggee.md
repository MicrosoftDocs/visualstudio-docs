---
description: "Specifies whether the exception should be passed on to the program being debugged when execution resumes, or if the exception should be discarded."
title: IDebugExceptionEvent2::PassToDebuggee
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugExceptionEvent2::PassToDebuggee
helpviewer_keywords:
- IDebugExceptionEvent2::PassToDebuggee
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugExceptionEvent2::PassToDebuggee

Specifies whether the exception should be passed on to the program being debugged when execution resumes, or if the exception should be discarded.

## Syntax

### [C#](#tab/csharp)
```csharp
int PassToDebuggee(
   int fPass
);
```
### [C++](#tab/cpp)
```cpp
HRESULT PassToDebuggee(
   BOOL fPass
);
```
---

## Parameters
`fPass`\
[in] Nonzero (`TRUE`) if the exception should be passed on to the program being debugged when execution resumes, or zero (`FALSE`) if the exception should be discarded.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Calling this method does not actually cause any code to be executed in the program being debugged. The call is merely to set the state for the next code execution. For example, calls to the [CanPassToDebuggee](../../../extensibility/debugger/reference/idebugexceptionevent2-canpasstodebuggee.md) method may return `S_OK` with the [EXCEPTION_INFO](../../../extensibility/debugger/reference/exception-info.md).`dwState` field set to `EXCEPTION_STOP_SECOND_CHANCE`.

 The IDE may receive the [IDebugExceptionEvent2](../../../extensibility/debugger/reference/idebugexceptionevent2.md) event and call the [Continue](../../../extensibility/debugger/reference/idebugprogram2-continue.md) method. The debug engine (DE) should have a default behavior to handle the case if the `PassToDebuggee` method is not called.

## See also
- [IDebugExceptionEvent2](../../../extensibility/debugger/reference/idebugexceptionevent2.md)
- [CanPassToDebuggee](../../../extensibility/debugger/reference/idebugexceptionevent2-canpasstodebuggee.md)
- [Continue](../../../extensibility/debugger/reference/idebugprogram2-continue.md)
