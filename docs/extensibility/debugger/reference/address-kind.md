---
description: "Specifies the kinds of addresses."
title: ADDRESS_KIND
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- ADDRESS_KIND
helpviewer_keywords:
- ADDRESS_KIND enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# ADDRESS_KIND

Specifies the kinds of addresses.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_ADDRESS_KIND {
    ADDRESS_KIND_NATIVE                  = 0x0001,
    ADDRESS_KIND_UNMANAGED_THIS_RELATIVE = 0x0002,
    ADDRESS_KIND_UNMANAGED_PHYSICAL      = 0x0005,
    ADDRESS_KIND_METADATA_METHOD         = 0x0010,
    ADDRESS_KIND_METADATA_FIELD          = 0x0011,
    ADDRESS_KIND_METADATA_LOCAL          = 0x0012,
    ADDRESS_KIND_METADATA_PARAM          = 0x0013,
    ADDRESS_KIND_METADATA_ARRAYELEM      = 0x0014,
    ADDRESS_KIND_METADATA_RETVAL         = 0x0015,
};
```
### [C++](#tab/cpp)
```cpp
enum enum_ADDRESS_KIND {
    ADDRESS_KIND_NATIVE                  = 0x0001,
    ADDRESS_KIND_UNMANAGED_THIS_RELATIVE = 0x0002,
    ADDRESS_KIND_UNMANAGED_PHYSICAL      = 0x0005,
    ADDRESS_KIND_METADATA_METHOD         = 0x0010,
    ADDRESS_KIND_METADATA_FIELD          = 0x0011,
    ADDRESS_KIND_METADATA_LOCAL          = 0x0012,
    ADDRESS_KIND_METADATA_PARAM          = 0x0013,
    ADDRESS_KIND_METADATA_ARRAYELEM      = 0x0014,
    ADDRESS_KIND_METADATA_RETVAL         = 0x0015,
};
typedef DWORD ADDRESS_KIND;
```
---

## Fields
`ADDRESS_KIND_NATIVE`\
A native address, represented by the [NATIVE_ADDRESS](../../../extensibility/debugger/reference/native-address.md) structure.

`ADDRESS_KIND_UNMANAGED_THIS_RELATIVE`\
An unmanaged address relative to a `this` (`Me` in Visual Basic) pointer and represented by the [UNMANAGED_ADDRESS_THIS_RELATIVE](../../../extensibility/debugger/reference/unmanaged-address-this-relative.md) structure.

`ADDRESS_KIND_UNMANAGED_PHYSICAL`\
An unmanaged physical address, represented by the [UNMANAGED_ADDRESS_PHYSICAL](../../../extensibility/debugger/reference/unmanaged-address-physical.md) structure.

`ADDRESS_KIND_METHOD`\
A method of a class, represented by the [METADATA_ADDRESS_METHOD](../../../extensibility/debugger/reference/metadata-address-method.md) structure.

`ADDRESS_KIND_FIELD`\
A field of a class, represented by the [METADATA_ADDRESS_FIELD](../../../extensibility/debugger/reference/metadata-address-field.md) structure.

`ADDRESS_KIND_LOCAL`\
The address is for a local variable and is represented by the [METADATA_ADDRESS_LOCAL](../../../extensibility/debugger/reference/metadata-address-local.md) structure.

`ADDRESS_KIND_PARAM`\
A method or function parameter, represented by the [METADATA_ADDRESS_PARAM](../../../extensibility/debugger/reference/metadata-address-param.md) structure.

`ADDRESS_KIND_ARRAYELEM`\
An array element, represented by the [METADATA_ADDRESS_ARRAYELEM](../../../extensibility/debugger/reference/metadata-address-arrayelem.md) structure.

`ADDRESS_KIND_RETVAL`\
A return value, represented by the [METADATA_ADDRESS_RETVAL](../../../extensibility/debugger/reference/metadata-address-retval.md) structure.

## Remarks
The [GetAddress](../../../extensibility/debugger/reference/idebugaddress-getaddress.md) method returns the [DEBUG_ADDRESS](../../../extensibility/debugger/reference/debug-address.md) structure which contains a union of possible structures, the [DEBUG_ADDRESS_UNION](../../../extensibility/debugger/reference/debug-address-union.md) structure. The `dwKind` field of the `DEBUG_ADDRESS_UNION` structure holds the `ADDRESS_KIND` value and describes how to interpret the union field.

## Requirements
Header: sh.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [GetAddress](../../../extensibility/debugger/reference/idebugaddress-getaddress.md)
- [DEBUG_ADDRESS](../../../extensibility/debugger/reference/debug-address.md)
- [DEBUG_ADDRESS_UNION](../../../extensibility/debugger/reference/debug-address-union.md)
