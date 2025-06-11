---
description: "Enumerates the valid values that specify the information to be retrieved about a breakpoint request."
title: BPREQI_FIELDS90
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- BPREQI_FIELDS90 enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# BPREQI_FIELDS90

Enumerates the valid values that specify the information to be retrieved about a breakpoint request. This enumeration extends the [BPREQI_FIELDS](../../../extensibility/debugger/reference/bpreqi-fields.md) enumeration.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_BPREQI_FIELDS90
{
    // VS 8.0 values
    BPREQI90_BPLOCATION                = 0x0001,
    BPREQI90_LANGUAGE                  = 0x0002,
    BPREQI90_PROGRAM                   = 0x0004,
    BPREQI90_PROGRAMNAME               = 0x0008,
    BPREQI90_THREAD                    = 0x0010,
    BPREQI90_THREADNAME                = 0x0020,
    BPREQI90_PASSCOUNT                 = 0x0040,
    BPREQI90_CONDITION                 = 0x0080,
    BPREQI90_FLAGS                     = 0x0100,
    BPREQI90_ALLOLDFIELDS              = 0x01ff,
    BPREQI90_VENDOR                    = 0x0200,
    BPREQI90_CONSTRAINT                = 0x0400,
    BPREQI90_TRACEPOINT                = 0x0800,

    // Values added in VS 9.0
    BPREQI90_MACROTRACEPOINT           = 0x1000,

    BPREQI90_ALLFIELDS                 = 0xffff
};
```
### [C++](#tab/cpp)
```cpp
enum enum_BPREQI_FIELDS90
{
    // VS 8.0 values
    BPREQI90_BPLOCATION                = 0x0001,
    BPREQI90_LANGUAGE                  = 0x0002,
    BPREQI90_PROGRAM                   = 0x0004,
    BPREQI90_PROGRAMNAME               = 0x0008,
    BPREQI90_THREAD                    = 0x0010,
    BPREQI90_THREADNAME                = 0x0020,
    BPREQI90_PASSCOUNT                 = 0x0040,
    BPREQI90_CONDITION                 = 0x0080,
    BPREQI90_FLAGS                     = 0x0100,
    BPREQI90_ALLOLDFIELDS              = 0x01ff,
    BPREQI90_VENDOR                    = 0x0200,
    BPREQI90_CONSTRAINT                = 0x0400,
    BPREQI90_TRACEPOINT                = 0x0800,

    // Values added in VS 9.0
    BPREQI90_MACROTRACEPOINT           = 0x1000,

    BPREQI90_ALLFIELDS                 = 0xffff
};
typedef DWORD BPREQI_FIELDS90;
```
---

## Fields
`BPREQI90_BPLOCATION`\
Initialize or use the `bpLocation` (breakpoint location) field of the [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md) or [BP_REQUEST_INFO2](../../../extensibility/debugger/reference/bp-request-info2.md) structure.

`BPREQI90_LANGUAGE`\
Initialize or use the `guidLanguage` field of the `BP_REQUEST_INFO` or `BP_REQUEST_INFO2` structure.

`BPREQI90_PROGRAM`\
Initialize or use the `pProgram` field of the `BP_REQUEST_INFO` or `BP_REQUEST_INFO2` structure.

`BPREQI90_PROGRAMNAME`\
Initialize or use the `bstrProgramName` field of the `BP_REQUEST_INFO` or `BP_REQUEST_INFO2` structure.

`BPREQI90_THREAD`\
Initialize or use the `pThread` field of the `BP_REQUEST_INFO` or `BP_REQUEST_INFO2` structure.

`BPREQI90_THREADNAME`\
Initialize or use the `bstrThreadName` field of the `BP_REQUEST_INFO` or `BP_REQUEST_INFO2` structure.

`BPREQI90_PASSCOUNT`\
Initialize or use the `bpPassCount` field of the `BP_REQUEST_INFO` or `BP_REQUEST_INFO2` structure.

`BPREQI90_CONDITION`\
Initialize or use the `bpCondition` (breakpoint condition) field of the `BP_REQUEST_INFO` or `BP_REQUEST_INFO2` structure.

`BPREQI90_FLAGS`\
Initialize or use the `dwFlags` field of the `BP_REQUEST_INFO` or `BP_REQUEST_INFO2` structure.

`BPREQI90_ALLOLDFIELDS`\
Initialize or use all fields for the of the `BP_REQUEST_INFO` structure.

`BPREQI90_VENDOR`\
Initialize or use the `guidVendor` field of `BP_REQUEST_INFO2` structure.

`BPREQI90_CONSTRAINT`\
Initialize or use the `bstrConstraint` field of `BP_REQUEST_INFO2` structure.

`BPREQI90_TRACEPOINT`\
Initialize or use the `bstrTracepoint` field of `BP_REQUEST_INFO2` structure.

`BPREQI90_MACROTRACEPOINT`\
Initialize or use the `bstrMacroTracepoint` field of `BP_REQUEST_INFO2` structure. BPREQI_ALLFIELDS does not include this field.

`BPREQI90_ALLFIELDS`\
Specifies all fields for the `BP_REQUEST_INFO2` structure.

## Requirements
Header: Msdbg90.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
