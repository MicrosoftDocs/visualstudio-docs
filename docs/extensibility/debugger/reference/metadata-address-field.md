---
title: METADATA_ADDRESS_FIELD
description: "This structure represents the address of a field of a class or structure."
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- METADATA_ADDRESS_FIELD
helpviewer_keywords:
- METADATA_ADDRESS_FIELD structure
author: maiak
ms.author: maiak
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# METADATA_ADDRESS_FIELD

This structure represents the address of a field of a class or structure.

## Syntax

### [C#](#tab/csharp)
```csharp
public struct METADATA_ADDRESS_FIELD {
    public int tokField;
}
```
### [C++](#tab/cpp)
```cpp
typedef struct _tagMETADATA_ADDRESS_FIELD {
    _mdToken tokField;
} METADATA_ADDRESS_FIELD;
```
---

## Members

`tokField`\
The ID of the field token.

[C++] `_mdToken` is a `typedef` for a 32-bit `int`.

## Remarks

This structure is part of the union in the [DEBUG_ADDRESS_UNION](debug-address-union.md) structure when the `dwKind` field of the `DEBUG_ADDRESS_UNION` structure is set to `ADDRESS_KIND_FIELD` (a value from the [ADDRESS_KIND](address-kind.md) enumeration).

## Requirements

Header: sh.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also

- [Structures and Unions](structures-and-unions.md)
- [DEBUG_ADDRESS_UNION](debug-address-union.md)
- [ADDRESS_KIND](address-kind.md)
