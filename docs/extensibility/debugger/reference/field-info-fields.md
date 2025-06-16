---
description: "Specifies what information to retrieve about an IDebugField object."
title: FIELD_INFO_FIELDS
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- FIELD_INFO_FIELDS
helpviewer_keywords:
- FIELD_INFO_FIELDS enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# FIELD_INFO_FIELDS

Specifies what information to retrieve about an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_FIELD_INFO_FIELDS {
    FIF_FULLNAME  = 0x0001,
    FIF_NAME      = 0x0002,
    FIF_TYPE      = 0x0004,
    FIF_MODIFIERS = 0x0008,
    FIF_ALL       = 0xffffffff,
    FIF_NONE      = 0x0000
};
```
### [C++](#tab/cpp)
```cpp
enum enum_FIELD_INFO_FIELDS { 
    FIF_FULLNAME  = 0x0001,
    FIF_NAME      = 0x0002,
    FIF_TYPE      = 0x0004,
    FIF_MODIFIERS = 0x0008,
    FIF_ALL       = 0xffffffff,
    FIF_NONE      = 0x0000
};
typedef DWORD FIELD_INFO_FIELDS;
```
---

## Fields
`FIF_FULLNAME`\
Initialize/use the `bstrFullName` field in the [FIELD_INFO](../../../extensibility/debugger/reference/field-info.md) structure.

`FIF_NAME`\
Initialize/use the `bstrName` field in the `FIELD_INFO` structure.

`FIF_TYPE`\
Initialize/use the `bstrType` field in the `FIELD_INFO` structure.

`FIF_MODIFIERS`\
Initialize/use the `bstrModifiers` field in the `FIELD_INFO` structure.

## Remarks
These values are also passed as an argument to the [GetInfo](../../../extensibility/debugger/reference/idebugfield-getinfo.md) method to specify which fields of the [FIELD_INFO](../../../extensibility/debugger/reference/field-info.md) structure are to be initialized.

These values are also used in the `dwFields` member of the `FIELD_INFO` structure to indicate which fields are used and valid.

These flags may be combined with a bitwise `OR`.

## Requirements
Header: sh.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [FIELD_INFO](../../../extensibility/debugger/reference/field-info.md)
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
- [GetInfo](../../../extensibility/debugger/reference/idebugfield-getinfo.md)
