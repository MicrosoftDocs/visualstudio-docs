---
description: "Specifies what information to retrieve about a memory context."
title: CONTEXT_INFO_FIELDS
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- CONTEXT_INFO_FIELDS
helpviewer_keywords:
- CONTEXT_INFO_FIELDS enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# CONTEXT_INFO_FIELDS

Specifies what information to retrieve about a memory context.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_CONTEXT_INFO_FIELDS {
    CIF_MODULEURL =       0x00000001,
    CIF_FUNCTION =        0x00000002,
    CIF_FUNCTIONOFFSET =  0x00000004,
    CIF_ADDRESS =         0x00000008,
    CIF_ADDRESSOFFSET =   0x00000010,
    CIF_ADDRESSABSOLUTE = 0x00000020,
    CIF_ALLFIELDS =       0x0000003f
};
```
### [C++](#tab/cpp)
```cpp
enum enum_CONTEXT_INFO_FIELDS {
    CIF_MODULEURL =       0x00000001,
    CIF_FUNCTION =        0x00000002,
    CIF_FUNCTIONOFFSET =  0x00000004,
    CIF_ADDRESS =         0x00000008,
    CIF_ADDRESSOFFSET =   0x00000010,
    CIF_ADDRESSABSOLUTE = 0x00000020,
    CIF_ALLFIELDS =       0x0000003f
};
typedef DWORD CONTEXT_INFO_FIELDS;
```
---

## Fields
`CIF_MODULEURL`\
Initialize/use the `bstrModuleUrl` field of the [CONTEXT_INFO](../../../extensibility/debugger/reference/context-info.md) structure.

`CIF_FUNCTION`\
Initialize/use the `bstrFunction` field of the `CONTEXT_INFO` structure.

`CIF_FUNCTIONOFFSET`\
Initialize/use the `posFunctionOffset` field of the `CONTEXT_INFO` structure.

`CIF_ADDRESS`\
Initialize/use the `bstrAddress` field of the `CONTEXT_INFO` structure.

`CIF_ADDRESSOFFSET`\
Initialize/use the `bstrAddressOffset` field of the `CONTEXT_INFO` structure.

`CIF_ALLFIELDS`\
Initialize/use all fields of the `CONTEXT_INFO` structure.

## Remarks
These values are passed a parameter to the [GetInfo](../../../extensibility/debugger/reference/idebugmemorycontext2-getinfo.md) method to indicate which fields of the [CONTEXT_INFO](../../../extensibility/debugger/reference/context-info.md) structure are to be initialized.

These flags are also used to indicate which fields of the `CONTEXT_INFO` structure are used and valid when the structure is returned.

These values may be combined with a bitwise OR.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [CONTEXT_INFO](../../../extensibility/debugger/reference/context-info.md)
- [GetInfo](../../../extensibility/debugger/reference/idebugmemorycontext2-getinfo.md)
