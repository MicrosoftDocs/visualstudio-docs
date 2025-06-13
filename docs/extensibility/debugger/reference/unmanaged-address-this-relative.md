---
description: "This structure represents an address that is relative to a this pointer (Me in Visual Basic)."
title: UNMANAGED_ADDRESS_THIS_RELATIVE
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- UNMANAGED_ADDRESS_THIS_RELATIVE
helpviewer_keywords:
- UNMANAGED_ADDRESS_THIS_RELATIVE structure
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# UNMANAGED_ADDRESS_THIS_RELATIVE

This structure represents an address that is relative to a `this` pointer (`Me` in Visual Basic).

## Syntax

### [C#](#tab/csharp)
```csharp
public struct UNMANAGED_THIS_RELATIVE {
   public uint dwOffset;
   public uint dwBitOffset;
   public uint dwBitLength;
}
```
### [C++](#tab/cpp)
```cpp
typedef struct _tagUNMANAGED_THIS_RELATIVE {
   DWORD dwOffset;
   DWORD dwBitOffset;
   DWORD dwBitLength;
} UNMANAGED_ADDRESS_THIS_RELATIVE;
```
---

## Members
 `dwOffset`\
 Byte offset from a base position (for example, start of a class vtable).

 `dwBitOffset`\
 Offset in bits from a base position (always 0 unless referring to a bit field).

 `dwBitLength`\
 Number of bits representing the address (always 0 unless referring to a bit field).

## Remarks
 This structure is part of the union in the [DEBUG_ADDRESS_UNION](../../../extensibility/debugger/reference/debug-address-union.md) structure when the `dwKind` field of the `DEBUG_ADDRESS_UNION` structure is set to `ADDRESS_KIND_UNMANAGED_THIS_RELATIVE` (a value from the [ADDRESS_KIND](../../../extensibility/debugger/reference/address-kind.md) enumeration).

## Requirements
 Header: sh.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [DEBUG_ADDRESS_UNION](../../../extensibility/debugger/reference/debug-address-union.md)
