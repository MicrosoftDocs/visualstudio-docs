---
description: "Called by the debugger on the current stack frame when it wants to intercept the current exception."
title: IDebugStackFrame3::InterceptCurrentException
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugStackFrame3::InterceptCurrentException
helpviewer_keywords:
- IDebugStackFrame3::InterceptCurrentException
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugStackFrame3::InterceptCurrentException

Called by the debugger on the current stack frame when it wants to intercept the current exception.

## Syntax

### [C#](#tab/csharp)
```csharp
int InterceptCurrentException(
   uint dwFlags,
   out  ulong pqwCookie
);
```
### [C++](#tab/cpp)
```cpp
HRESULT InterceptCurrentException(
   INTERCEPT_EXCEPTION_ACTION dwFlags,
   UINT64*                    pqwCookie
);
```
---

## Parameters
`dwFlags`\
[in] Specifies different actions. Currently, only the [INTERCEPT_EXCEPTION_ACTION](../../../extensibility/debugger/reference/intercept-exception-action.md) value `IEA_INTERCEPT` is supported and must be specified.

`pqwCookie`\
[out] Unique value identifying a particular exception.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

 The following are the most common error returns.

|Error|Description|
|-----------|-----------------|
|`E_EXCEPTION_CANNOT_BE_INTERCEPTED`|The current exception cannot be intercepted.|
|`E_EXCEPTION_CANNOT_UNWIND_ABOVE_CALLBACK`|The current execution frame hasn't been searched for a handler yet.|
|`E_INTERCEPT_CURRENT_EXCEPTION_NOT_SUPPORTED`|This method is not supported for this frame.|

## Remarks
 When an exception is thrown, the debugger gains control from the run time at key points during the exception handling process. During these key moments, the debugger can ask the current stack frame if the frame wants to intercept the exception. In this way, an intercepted exception is essentially an on-the-fly exception handler for a stack frame, even if that stack frame doesn't have an exception handler (for example, a try/catch block in the program code).

 When the debugger wants to know if the exception should be intercepted, it calls this method on the current stack frame object. This method is responsible for handling all details of the exception. If the [IDebugStackFrame3](../../../extensibility/debugger/reference/idebugstackframe3.md) interface is not implemented or the `InterceptStackException` method returns any error, then the debugger continues processing the exception normally.

> [!NOTE]
> Exceptions can be intercepted only in managed code, that is, when the program being debugged is running under the .NET run time. Of course, third-party language implementers can implement `InterceptStackException` in their own debug engines if they so choose.

 After the interception is complete, an [IDebugInterceptExceptionCompleteEvent2](../../../extensibility/debugger/reference/idebuginterceptexceptioncompleteevent2.md) is signaled.

## See also
- [IDebugStackFrame3](../../../extensibility/debugger/reference/idebugstackframe3.md)
- [INTERCEPT_EXCEPTION_ACTION](../../../extensibility/debugger/reference/intercept-exception-action.md)
- [IDebugInterceptExceptionCompleteEvent2](../../../extensibility/debugger/reference/idebuginterceptexceptioncompleteevent2.md)
