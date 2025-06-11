---
description: "Specifies the error type of a breakpoint."
title: BP_ERROR_TYPE
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- BP_ERROR_TYPE
helpviewer_keywords:
- BP_ERROR_TYPE enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# BP_ERROR_TYPE

Specifies the error type of a breakpoint.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_BP_ERROR_TYPE {
    BPET_NONE            = 0x00000000,
    BPET_TYPE_WARNING    = 0x00000001,
    BPET_TYPE_ERROR      = 0x00000002,
    BPET_SEV_HIGH        = 0x0F000000,
    BPET_SEV_GENERAL     = 0x07000000,
    BPET_SEV_LOW         = 0x01000000,
    BPET_TYPE_MASK       = 0x0000ffff,
    BPET_SEV_MASK        = 0xffff0000,
    BPET_GENERAL_WARNING = BPET_SEV_GENERAL | BPET_TYPE_WARNING,
    BPET_GENERAL_ERROR   = BPET_SEV_GENERAL | BPET_TYPE_ERROR,
    BPET_ALL             = 0xffffffff
};
```
### [C++](#tab/cpp)
```cpp
enum enum_BP_ERROR_TYPE {
    BPET_NONE            = 0x00000000,
    BPET_TYPE_WARNING    = 0x00000001,
    BPET_TYPE_ERROR      = 0x00000002,
    BPET_SEV_HIGH        = 0x0F000000,
    BPET_SEV_GENERAL     = 0x07000000,
    BPET_SEV_LOW         = 0x01000000,
    BPET_TYPE_MASK       = 0x0000ffff,
    BPET_SEV_MASK        = 0xffff0000,
    BPET_GENERAL_WARNING = BPET_SEV_GENERAL | BPET_TYPE_WARNING,
    BPET_GENERAL_ERROR   = BPET_SEV_GENERAL | BPET_TYPE_ERROR,
    BPET_ALL             = 0xffffffff
};
typedef DWORD BP_ERROR_TYPE;
```
---

## Fields
`BPET_NONE`\
Specifies no breakpoint error.

`BPET_TYPE_WARNING`\
Specifies a warning-style breakpoint error.

`BPET_TYPE_ERROR`\
Specifies an error-style breakpoint error.

`BPET_SEV_HIGH`\
Specifies a high-severity breakpoint error.

`BPET_SEV_GENERAL`\
Specifies a medium-severity breakpoint error.

`BPET_SEV_LOW`\
Specifies a low-severity breakpoint error.

`BPET_TYPE_MASK`\
Specifies a mask-style breakpoint error.

`BPET_SEV_MASK`\
Specifies a severity-mask-style breakpoint error.

`BPET_GENERAL_WARNING`\
Specifies a general-warning-style breakpoint error.

`BPET_GENERAL_ERROR`\
Specifies a general-error-style breakpoint error.

`BPET_ALL`\
Specifies all breakpoint error types.

## Remarks
These values may be combined with a bitwise `OR` and used for the `dwType` member of the [BP_ERROR_RESOLUTION_INFO](../../../extensibility/debugger/reference/bp-error-resolution-info.md) structure. Passed as a parameter to the [EnumErrorBreakpoints](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-enumerrorbreakpoints.md) method.

A breakpoint error type is composed of a type and a severity. This means that a breakpoint error type is never just a type (for example, `BPET_TYPE_ERROR`,) or a severity (for example, `BPET_SEV_GENERAL`) by itself. `BPET_GENERAL_WARNING` and `BPET_GENERAL_ERROR` provide predefined values for general warning and error breakpoints.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [BP_ERROR_RESOLUTION_INFO](../../../extensibility/debugger/reference/bp-error-resolution-info.md)
- [EnumErrorBreakpoints](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-enumerrorbreakpoints.md)
