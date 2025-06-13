---
description: "Enumerates additional kinds of fields that an IDebugField object can contain."
title: FIELD_KIND_EX
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- FIELD_KIND_EX enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# FIELD_KIND_EX

Enumerates additional kinds of fields that an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object can contain. This enumeration extends the [FIELD_KIND](../../../extensibility/debugger/reference/field-kind.md) enumeration.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_FIELD_KIND_EX
{
    FIELD_KIND_EX_NONE = 0,
    FIELD_TYPE_EX_METHODVAR = 0x1,
    FIELD_TYPE_EX_CLASSVAR = 0x2
};
```
### [C++](#tab/cpp)
```cpp
enum enum_FIELD_KIND_EX
{
    FIELD_KIND_EX_NONE = 0,
    FIELD_TYPE_EX_METHODVAR = 0x1,
    FIELD_TYPE_EX_CLASSVAR = 0x2
};
typedef DWORD FIELD_KIND_EX;
```
---

## Fields
`FIELD_KIND_EX_NONE`\
Field does not contain an extended type.

`FIELD_TYPE_EX_METHODVAR`\
Field contains a method variable.

`FIELD_TYPE_EX_CLASSVAR`\
Field contains a class variable.

## Requirements
Header: Sh.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [GetExtendedKind](../../../extensibility/debugger/reference/idebugextendedfield-getextendedkind.md)
