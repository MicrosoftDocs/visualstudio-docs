---
description: "Specifies modifiers for a field type."
title: FIELD_MODIFIERS
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- FIELD_MODIFIERS
helpviewer_keywords:
- FIELD_MODIFIERS enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# FIELD_MODIFIERS

Specifies modifiers for a field type.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_FIELD_MODIFIERS {
    FIELD_MOD_NONE             = 0x00000000,

    // Modifier of the field
    FIELD_MOD_ACCESS_NONE      = 0x00000001,
    FIELD_MOD_ACCESS_PUBLIC    = 0x00000002,
    FIELD_MOD_ACCESS_PROTECTED = 0x00000004,
    FIELD_MOD_ACCESS_PRIVATE   = 0x00000008,

    // Storage modifier of the field
    FIELD_MOD_NOMODIFIERS      = 0x00000010,
    FIELD_MOD_STATIC           = 0x00000020,
    FIELD_MOD_CONSTANT         = 0x00000040,
    FIELD_MOD_TRANSIENT        = 0x00000080,
    FIELD_MOD_VOLATILE         = 0x00000100,
    FIELD_MOD_ABSTRACT         = 0x00000200,
    FIELD_MOD_NATIVE           = 0x00000400,
    FIELD_MOD_SYNCHRONIZED     = 0x00000800,
    FIELD_MOD_VIRTUAL          = 0x00001000,
    FIELD_MOD_INTERFACE        = 0x00002000,
    FIELD_MOD_FINAL            = 0x00004000,
    FIELD_MOD_SENTINEL         = 0x00008000,
    FIELD_MOD_INNERCLASS       = 0x00010000,
    FIELD_TYPE_OPTIONAL        = 0x00020000,
    FIELD_MOD_BYREF            = 0x00040000,
    FIELD_MOD_HIDDEN           = 0x00080000,
    FIELD_MOD_MARSHALASOBJECT  = 0x00100000,
    FIELD_MOD_SPECIAL_NAME     = 0x00200000,
    FIELD_MOD_HIDEBYSIG        = 0x00400000,

    FIELD_MOD_WRITEONLY        = 0x80000000,
    FIELD_MOD_ACCESS_MASK      = 0x000000ff,
    FIELD_MOD_MASK             = 0xffffff00,
    FIELD_MOD_ALL              = 0x7fffffff
};
```
### [C++](#tab/cpp)
```cpp
enum enum_FIELD_MODIFIERS {
    FIELD_MOD_NONE             = 0x00000000,

    // Modifier of the field
    FIELD_MOD_ACCESS_NONE      = 0x00000001,
    FIELD_MOD_ACCESS_PUBLIC    = 0x00000002,
    FIELD_MOD_ACCESS_PROTECTED = 0x00000004,
    FIELD_MOD_ACCESS_PRIVATE   = 0x00000008,

    // Storage modifier of the field
    FIELD_MOD_NOMODIFIERS      = 0x00000010,
    FIELD_MOD_STATIC           = 0x00000020,
    FIELD_MOD_CONSTANT         = 0x00000040,
    FIELD_MOD_TRANSIENT        = 0x00000080,
    FIELD_MOD_VOLATILE         = 0x00000100,
    FIELD_MOD_ABSTRACT         = 0x00000200,
    FIELD_MOD_NATIVE           = 0x00000400,
    FIELD_MOD_SYNCHRONIZED     = 0x00000800,
    FIELD_MOD_VIRTUAL          = 0x00001000,
    FIELD_MOD_INTERFACE        = 0x00002000,
    FIELD_MOD_FINAL            = 0x00004000,
    FIELD_MOD_SENTINEL         = 0x00008000,
    FIELD_MOD_INNERCLASS       = 0x00010000,
    FIELD_TYPE_OPTIONAL        = 0x00020000,
    FIELD_MOD_BYREF            = 0x00040000,
    FIELD_MOD_HIDDEN           = 0x00080000,
    FIELD_MOD_MARSHALASOBJECT  = 0x00100000,
    FIELD_MOD_SPECIAL_NAME     = 0x00200000,
    FIELD_MOD_HIDEBYSIG        = 0x00400000,

    FIELD_MOD_WRITEONLY        = 0x80000000,
    FIELD_MOD_ACCESS_MASK      = 0x000000ff,
    FIELD_MOD_MASK             = 0xffffff00,
    FIELD_MOD_ALL              = 0x7fffffff
};
typedef DWORD FIELD_MODIFIERS;
```
---

## Fields
`FIELD_MOD_ACCESS_TYPE`\
Indicates that the field cannot be accessed.

`FIELD_MOD_ACCESS_PUBLIC`\
Indicates that the field has public access.

`FIELD_MOD_ACCESS_PROTECTED`\
Indicates that the field has protected access.

`FIELD_MOD_ACCESS_PRIVATE`\
Indicates that the field has private access.

`FIELD_MOD_NOMODIFIERS`\
Indicates that the field has no modifiers.

`FIELD_MOD_STATIC`\
Indicates that the field is static.

`FIELD_MOD_CONSTANT`\
Indicates that the field is a constant.

`FIELD_MOD_TRANSIENT`\
Indicates that the field is transient.

`FIELD_MOD_VOLATILE`\
Indicates that the field is volatile.

`FIELD_MOD_ABSTRACT`\
Indicates that the field is abstract.

`FIELD_MOD_NATIVE`\
Indicates that the field is native.

`FIELD_MOD_SYNCHRONIZED`\
Indicates that the field is synchronized.

`FIELD_MOD_VIRTUAL`\
Indicates that the field is virtual.

`FIELD_MOD_INTERFACE`\
Indicates that the field is an interface.

`FIELD_MOD_FINAL`\
Indicates that the field is final.

`FIELD_MOD_SENTINEL`\
Indicates that the field is a sentinel.

`FIELD_MOD_INNERCLASS`\
Indicates that the field is an inner class.

`FIELD_TYPE_OPTIONAL`\
Indicates that the field is optional.

`FIELD_MOD_BYREF`\
Indicates that the field is a reference argument. This is specifically for method arguments.

`FIELD_MOD_HIDDEN`\
Indicates that the field must be hidden or presented in another context; for example, Visual Basic static locals.

`FIELD_MOD_MARSHALASOBJECT`\
Indicates that the field represents an object with an `IUnknown` interface.

`FIELD_MOD_SPECIAL_NAME`\
Indicates that the field has a special name, for example, `.ctor` for a constructor (Visual Basic only).

`FIELD_MOD_HIDEBYSIG`\
Indicates that the field has the `Overloads` keyword applied to it (Visual Basic only).

`FIELD_MOD_WRITEONLY`\
Indicates that the field is write-only. This value is not included in `FIELD_MOD_ALL`, as the only use of such write-only fields is for function evaluation. A user must explicitly ask for `FIELD_MOD_WRITEONLY` fields.

`FIELD_MOD_ACCESS_MASK`\
Indicates a mask for field access.

`FIELD_MOD_MASK`\
Indicates a mask for field modifiers.

## Remarks
Used for the `dwModifiers` member of the [FIELD_INFO](../../../extensibility/debugger/reference/field-info.md) structure.

These values are also passed to the [EnumFields](../../../extensibility/debugger/reference/idebugcontainerfield-enumfields.md) method to filter for specific fields.

## Requirements
Header: sh.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [FIELD_INFO](../../../extensibility/debugger/reference/field-info.md)
- [EnumFields](../../../extensibility/debugger/reference/idebugcontainerfield-enumfields.md)
