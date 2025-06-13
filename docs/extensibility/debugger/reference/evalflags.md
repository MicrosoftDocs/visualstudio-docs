---
description: "Specifies flags that control expression evaluation."
title: EVALFLAGS
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- EVALFLAGS
helpviewer_keywords:
- EVALFLAGS enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# EVALFLAGS

Specifies flags that control expression evaluation.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_EVALFLAGS {
    EVAL_RETURNVALUE = 0x0002,
    EVAL_NOSIDEEFFECTS = 0x0004,
    EVAL_ALLOWBPS = 0x0008,
    EVAL_ALLOWERRORREPORT = 0x0010,
    EVAL_FUNCTION_AS_ADDRESS = 0x0040,
    EVAL_NOFUNCEVAL = 0x0080,
    EVAL_NOEVENTS = 0x1000
}
```
### [C++](#tab/cpp)
```cpp
enum enum_EVALFLAGS {
    EVAL_RETURNVALUE = 0x0002,
    EVAL_NOSIDEEFFECTS = 0x0004,
    EVAL_ALLOWBPS = 0x0008,
    EVAL_ALLOWERRORREPORT = 0x0010,
    EVAL_FUNCTION_AS_ADDRESS = 0x0040,
    EVAL_NOFUNCEVAL = 0x0080,
    EVAL_NOEVENTS = 0x1000
};
typedef DWORD EVALFLAGS;
```
---

## Fields
`EVAL_RETURNVALUE`\
Specifies that the return value, if any, be evaluated.

`EVAL_NOSIDEEFFECTS`\
Specifies that side effects not be allowed.

`EVAL_ALLOWBPS`\
Specifies stopping on breakpoints.

`EVAL_ALLOWERRORREPORT`\
Specifies error reporting to the host to be allowed. Primarily used for expression evaluation in script in Internet Explorer.

`EVAL_FUNCTION_AS_ADDRESS`\
Forces functions to be evaluated as addresses, instead of invoking the function.

`EVAL_NOFUNCEVAL`\
Prevents function from being evaluated. For example, consider the `int` token in the expression `myExpression(int) + 10`. This function can be correctly evaluated as an address, but not as a value.

`EVAL_NOEVENTS`\
Flag to indicate that events that occur during the expression evaluation should not be sent to the session debug manager (SDM) or to the IDE.

## Remarks
These flags are passed as an argument to the [EvaluateAsync](../../../extensibility/debugger/reference/idebugexpression2-evaluateasync.md) and [EvaluateSync](../../../extensibility/debugger/reference/idebugexpression2-evaluatesync.md) methods.

These flags may be combined with a bitwise OR.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [EvaluateAsync](../../../extensibility/debugger/reference/idebugexpression2-evaluateasync.md)
- [EvaluateSync](../../../extensibility/debugger/reference/idebugexpression2-evaluatesync.md)
