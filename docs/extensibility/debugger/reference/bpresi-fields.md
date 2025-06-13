---
description: "Specifies the information to be retrieved about the successful resolution of a breakpoint."
title: BPRESI_FIELDS
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- BPRESI_FIELDS
helpviewer_keywords:
- BPRESI_FIELDS enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# BPRESI_FIELDS

Specifies the information to be retrieved about the successful resolution of a breakpoint.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_BPRESI_FIELDS {
    BPRESI_BPRESLOCATION = 0x0001,
    BPRESI_PROGRAM       = 0x0002,
    BPRESI_THREAD        = 0x0004,
    BPRESI_ALLFIELDS     = 0xffffffff
};
```
### [C++](#tab/cpp)
```cpp
enum enum_BPRESI_FIELDS {
    BPRESI_BPRESLOCATION = 0x0001,
    BPRESI_PROGRAM       = 0x0002,
    BPRESI_THREAD        = 0x0004,
    BPRESI_ALLFIELDS     = 0xffffffff
};
typedef DWORD BPRESI_FIELDS;
```
---

## Fields
`BPRESI_BPRESLOCATION`\
Initialize/use the `bpResLocation` (breakpoint resolution location) field of the [BP_RESOLUTION_INFO](../../../extensibility/debugger/reference/bp-resolution-info.md) structure.

`BPRESI_PROGRAM`\
Initialize/use the `pProgram` field of the `BP_RESOLUTION_INFO` structure.

`BPRESI_THREAD`\
Initialize/use the `pThread` field of the `BP_RESOLUTION_INFO` structure.

`BPRESI_ALLFIELDS`\
Specifies all fields.

## Remarks
Passed to the [GetResolutionInfo](../../../extensibility/debugger/reference/idebugbreakpointresolution2-getresolutioninfo.md) method to indicate which fields of the [BP_RESOLUTION_INFO](../../../extensibility/debugger/reference/bp-resolution-info.md) structure are to be initialized.

These flags are also used to indicate which fields of the `BP_RESOLUTION_INFO` structure are used and valid when that structure is returned.

These values may be combined with a bitwise `OR`.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [BP_RESOLUTION_INFO](../../../extensibility/debugger/reference/bp-resolution-info.md)
- [GetResolutionInfo](../../../extensibility/debugger/reference/idebugbreakpointresolution2-getresolutioninfo.md)
