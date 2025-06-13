---
title: FIELD_KIND
description: "Specifies the kind of field contained in an IDebugField object."
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- FIELD_KIND
helpviewer_keywords:
- FIELD_KIND enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# FIELD_KIND

Specifies the kind of field contained in an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_FIELD_KIND {
    FIELD_KIND_NONE       = 0x00000000,

    // Type of field
    FIELD_KIND_TYPE       = 0x00000001,
    FIELD_KIND_SYMBOL     = 0x00000002,

    // Storage type of the field
    FIELD_TYPE_PRIMITIVE  = 0x00000010,
    FIELD_TYPE_STRUCT     = 0x00000020,
    FIELD_TYPE_CLASS      = 0x00000040,
    FIELD_TYPE_INTERFACE  = 0x00000080,
    FIELD_TYPE_UNION      = 0x00000100,
    FIELD_TYPE_ARRAY      = 0x00000200,
    FIELD_TYPE_METHOD     = 0x00000400,
    FIELD_TYPE_BLOCK      = 0x00000800,
    FIELD_TYPE_POINTER    = 0x00001000,
    FIELD_TYPE_ENUM       = 0x00002000,
    FIELD_TYPE_LABEL      = 0x00004000,
    FIELD_TYPE_TYPEDEF    = 0x00008000,
    FIELD_TYPE_BITFIELD   = 0x00010000,
    FIELD_TYPE_NAMESPACE  = 0x00020000,
    FIELD_TYPE_MODULE     = 0x00040000,
    FIELD_TYPE_DYNAMIC    = 0x00080000,
    FIELD_TYPE_PROP       = 0x00100000,
    FIELD_TYPE_INNERCLASS = 0x00200000,
    FIELD_TYPE_REFERENCE  = 0x00400000,
    FIELD_TYPE_EXTENDED   = 0x00800000,

    // Specific information about symbols
    FIELD_SYM_MEMBER      = 0x01000000,
    FIELD_SYM_LOCAL       = 0x02000000,
    FIELD_SYM_PARAM       = 0x04000000,
    FIELD_SYM_THIS        = 0x08000000,
    FIELD_SYM_GLOBAL      = 0x10000000,
    FIELD_SYM_PROP_GETTER = 0x20000000,
    FIELD_SYM_PROP_SETTER = 0x40000000,
    FIELD_SYM_EXTENDED    = 0x80000000,

    FIELD_KIND_MASK       = 0x0000000f,
    FIELD_TYPE_MASK       = 0x00fffff0,
    FIELD_SYM_MASK        = 0xff000000,

    FIELD_KIND_ALL        = 0xffffffff
};
```
### [C++](#tab/cpp)
```cpp
enum enum_FIELD_KIND {
    FIELD_KIND_NONE       = 0x00000000,

    // Type of field
    FIELD_KIND_TYPE       = 0x00000001,
    FIELD_KIND_SYMBOL     = 0x00000002,

    // Storage type of the field
    FIELD_TYPE_PRIMITIVE  = 0x00000010,
    FIELD_TYPE_STRUCT     = 0x00000020,
    FIELD_TYPE_CLASS      = 0x00000040,
    FIELD_TYPE_INTERFACE  = 0x00000080,
    FIELD_TYPE_UNION      = 0x00000100,
    FIELD_TYPE_ARRAY      = 0x00000200,
    FIELD_TYPE_METHOD     = 0x00000400,
    FIELD_TYPE_BLOCK      = 0x00000800,
    FIELD_TYPE_POINTER    = 0x00001000,
    FIELD_TYPE_ENUM       = 0x00002000,
    FIELD_TYPE_LABEL      = 0x00004000,
    FIELD_TYPE_TYPEDEF    = 0x00008000,
    FIELD_TYPE_BITFIELD   = 0x00010000,
    FIELD_TYPE_NAMESPACE  = 0x00020000,
    FIELD_TYPE_MODULE     = 0x00040000,
    FIELD_TYPE_DYNAMIC    = 0x00080000,
    FIELD_TYPE_PROP       = 0x00100000,
    FIELD_TYPE_INNERCLASS = 0x00200000,
    FIELD_TYPE_REFERENCE  = 0x00400000,
    FIELD_TYPE_EXTENDED   = 0x00800000,

    // Specific information about symbols
    FIELD_SYM_MEMBER      = 0x01000000,
    FIELD_SYM_LOCAL       = 0x02000000,
    FIELD_SYM_PARAM       = 0x04000000,
    FIELD_SYM_THIS        = 0x08000000,
    FIELD_SYM_GLOBAL      = 0x10000000,
    FIELD_SYM_PROP_GETTER = 0x20000000,
    FIELD_SYM_PROP_SETTER = 0x40000000,
    FIELD_SYM_EXTENDED    = 0x80000000,

    FIELD_KIND_MASK       = 0x0000000f,
    FIELD_TYPE_MASK       = 0x00fffff0,
    FIELD_SYM_MASK        = 0xff000000,

    FIELD_KIND_ALL        = 0xffffffff
};
typedef DWORD FIELD_KIND;
```
---

## Fields
`FIELD_KIND_TYPE`\
Indicates that the field is a type only.

`FIELD_KIND_SYMBOL`\
Indicates that the field is a symbol, with type, name, and other information.

`FIELD_TYPE_PRIMITIVE`\
Indicates that the field is a primitive data type.

`FIELD_TYPE_STRUCT`\
Indicates that the field is a structure.

`FIELD_TYPE_CLASS`\
Indicates that the field is a class.

`FIELD_TYPE_INTERFACE`\
Indicates that the field is an interface.

`FIELD_TYPE_UNION`\
Indicates that the field is a union.

`FIELD_TYPE_ARRAY`\
Indicates that the field is an array.

`FIELD_TYPE_METHOD`\
Indicates that the field is a method.

`FIELD_TYPE_BLOCK`\
Indicates that the field is a block.

`FIELD_TYPE_POINTER`\
Indicates that the field is a pointer.

`FIELD_TYPE_ENUM`\
Indicates that the field is an enumerated data type.

`FIELD_TYPE_LABEL`\
Indicates that the field is a label.

`FIELD_TYPE_TYPEDEF`\
Indicates that the field is a typedef.

`FIELD_TYPE_BITFIELD`\
Indicates that the field is a bitfield.

`FIELD_TYPE_NAMESPACE`\
Indicates that the field is a namespace.

`FIELD_TYPE_MODULE`\
Indicates that the field is a module.

`FIELD_TYPE_DYNAMIC`\
Indicates that the field is dynamic.

`FIELD_TYPE_PROP`\
Indicates that the field is a property.

`FIELD_TYPE_INNERCLASS`\
Indicates that the field is an inner class.

`FIELD_TYPE_REFERENCE`\
Indicates that the field is a reference.

`FIELD_TYPE_EXTENDED`\
Reserved for future use.

`FIELD_SYM_MEMBER`\
Indicates that the field is a member.

`FIELD_SYM_LOCAL`\
Indicates that the field is local.

`FIELD_SYM_PARAMETER`\
Indicates that the field is a parameter.

`FIELD_SYM_THIS`\
Indicates that the field is the "this" pointer.

`FIELD_SYM_GLOBAL`\
Indicates that the field is global.

`FIELD_SYM_PROP_GETTER`\
Indicates that the field retrieves properties.

`FIELD_SYM_PROP_SETTER`\
Indicates that the field sets properties.

`FIELD_SYM_EXTENDED`\
Reserved for future use.

`FIELD_KIND_MASK`\
Indicates a mask for field kinds.

`FIELD_TYPE_MASK`\
Indicates a mask for field types.

`FIELD_SYM_MASK`\
Indicates a mask for symbol information.

## Remarks
Returned from a call to the [GetKind](../../../extensibility/debugger/reference/idebugfield-getkind.md) method.

Depending on the kind of field, [QueryInterface](/cpp/atl/queryinterface) can be called on the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) interface for a more specific form of interface. For example, if [GetKind](../../../extensibility/debugger/reference/idebugfield-getkind.md) returns `FIELD_TYPE_METHOD`, you can then call `QueryInterface` on `IDebugField` to obtain the [IDebugMethodField](../../../extensibility/debugger/reference/idebugmethodfield.md) interface.

## Requirements
Header: sh.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [FIELD_MODIFIERS](../../../extensibility/debugger/reference/field-modifiers.md)
- [GetKind](../../../extensibility/debugger/reference/idebugfield-getkind.md)
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
