---
description: "Specifies the information to be retrieved about a breakpoint request."
title: BPREQI_FIELDS
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- BPREQI_FIELDS
helpviewer_keywords:
- BPREQI_FIELDS enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# BPREQI_FIELDS

Specifies the information to be retrieved about a breakpoint request.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_BPREQI_FIELDS {
    BPREQI_BPLOCATION   = 0x0001,
    BPREQI_LANGUAGE     = 0x0002,
    BPREQI_PROGRAM      = 0x0004,
    BPREQI_PROGRAMNAME  = 0x0008,
    BPREQI_THREAD       = 0x0010,
    BPREQI_THREADNAME   = 0x0020,
    BPREQI_PASSCOUNT    = 0x0040,
    BPREQI_CONDITION    = 0x0080,
    BPREQI_FLAGS        = 0x0100,
    BPREQI_ALLOLDFIELDS = 0x01ff
    BPREQI_VENDOR       = 0x0200,   // BP_REQUEST_INFO2 only
    BPREQI_CONSTRAINT   = 0x0400,   // BP_REQUEST_INFO2 only
    BPREQI_TRACEPOINT   = 0x0800,   // BP_REQUEST_INFO2 only
    BPREQI_ALLFIELDS    = 0x0fff    // BP_REQUEST_INFO2 only
};
```
### [C++](#tab/cpp)
```cpp
enum enum_BPREQI_FIELDS {
    BPREQI_BPLOCATION   = 0x0001,
    BPREQI_LANGUAGE     = 0x0002,
    BPREQI_PROGRAM      = 0x0004,
    BPREQI_PROGRAMNAME  = 0x0008,
    BPREQI_THREAD       = 0x0010,
    BPREQI_THREADNAME   = 0x0020,
    BPREQI_PASSCOUNT    = 0x0040,
    BPREQI_CONDITION    = 0x0080,
    BPREQI_FLAGS        = 0x0100,
    BPREQI_ALLOLDFIELDS = 0x01ff
    BPREQI_VENDOR       = 0x0200,   // BP_REQUEST_INFO2 only
    BPREQI_CONSTRAINT   = 0x0400,   // BP_REQUEST_INFO2 only
    BPREQI_TRACEPOINT   = 0x0800,   // BP_REQUEST_INFO2 only
    BPREQI_ALLFIELDS    = 0x0fff    // BP_REQUEST_INFO2 only
};
typedef DWORD BPREQI_FIELDS;
```
---

## Fields
`BPREQI_BPLOCATION`\
Initialize/use the `bpLocation` (breakpoint location) field of the [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md) or [BP_REQUEST_INFO2](../../../extensibility/debugger/reference/bp-request-info2.md) structure.

`BPREQI_LANGUAGE`\
Initialize/use the `guidLanguage` field of the `BP_REQUEST_INFO` or `BP_REQUEST_INFO2` structure.

`BPREQI_PROGRAM`\
Initialize/use the `pProgram` field of the `BP_REQUEST_INFO` or `BP_REQUEST_INFO2` structure.

`BPREQI_PROGRAMNAME`\
Initialize/use the `bstrProgramName` field of the `BP_REQUEST_INFO` or `BP_REQUEST_INFO2` structure.

`BPREQI_THREAD`\
Initialize/use the `pThread` field of the `BP_REQUEST_INFO` or `BP_REQUEST_INFO2` structure.

`BPREQI_THREADNAME`\
Initialize/use the `bstrThreadName` field of the `BP_REQUEST_INFO` or `BP_REQUEST_INFO2` structure.

`BPREQI_PASSCOUNT`\
Initialize/use the `bpPassCount` field of the `BP_REQUEST_INFO` or `BP_REQUEST_INFO2` structure.

`BPREQI_CONDITION`\
Initialize/use the `bpCondition` (breakpoint condition) field of the `BP_REQUEST_INFO` or `BP_REQUEST_INFO2` structure.

`BPREQI_FLAGS`\
Initialize/use the `dwFlags` field of the `BP_REQUEST_INFO` or `BP_REQUEST_INFO2` structure.

`BPREQI_ALLOLDFIELDS`\
Initialize/use all fields for the of the `BP_REQUEST_INFO` structure.

`BPREQI_VENDOR`\
Initialize/use the `guidVendor` field of `BP_REQUEST_INFO2` structure.

`BPREQI_CONSTRAINT`\
Initialize/use the `bstrConstraint` field of `BP_REQUEST_INFO2` structure.

`BPREQI_TRACEPOINT`\
Initialize/use the `bstrTracepoint` field of `BP_REQUEST_INFO2` structure.

`BPREQI_ALLFIELDS`\
Specifies all fields for the `BP_REQUEST_INFO2` structure.

## Remarks
Passed as an argument to the [GetRequestInfo](../../../extensibility/debugger/reference/idebugbreakpointrequest2-getrequestinfo.md) and [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md) methods to specify which fields of the [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md) and [BP_REQUEST_INFO2](../../../extensibility/debugger/reference/bp-request-info2.md) structures are to be initialized.

These flags are also used to indicate which fields of the `BP_REQUEST_INFO` and `BP_REQUEST_INFO2` structures are used and valid when each structure is returned.

These values may be combined with a bitwise `OR`.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [GetRequestInfo](../../../extensibility/debugger/reference/idebugbreakpointrequest2-getrequestinfo.md)
- [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md)
- [BP_REQUEST_INFO2](../../../extensibility/debugger/reference/bp-request-info2.md)
