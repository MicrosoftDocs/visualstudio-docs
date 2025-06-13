---
description: "This structure represents the address of a local variable within a scope (usually a function or method)."
title: METADATA_ADDRESS_LOCAL
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- METADATA_ADDRESS_LOCAL
helpviewer_keywords:
- METADATA_ADDRESS_LOCAL structure
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# METADATA_ADDRESS_LOCAL

This structure represents the address of a local variable within a scope (usually a function or method).

## Syntax

### [C#](#tab/csharp)
```csharp
public struct METADATA_ADDRESS_LOCAL {
    public int    tokMethod;
    public object pLocal;
    public uint   dwIndex;
}
```
### [C++](#tab/cpp)
```cpp
typedef struct _tagMETADATA_ADDRESS_LOCAL {
    _mdToken  tokMethod;
    IUnknown* pLocal;
    DWORD     dwIndex;
} METADATA_ADDRESS_LOCAL;
```
---

## Members

`tokMethod`\
The ID of the method or function the local variable is part of.

[C++] `_mdToken` is a `typedef` for a 32-bit `int`.

`pLocal`\
The token whose address this structure represents.

`dwIndex`\
Can be the index of this local variable in the method or function, or some other value (language-specific).

## Remarks

This structure is part of the union in the [DEBUG_ADDRESS_UNION](../../../extensibility/debugger/reference/debug-address-union.md) structure when the `dwKind` field of the `DEBUG_ADDRESS_UNION` structure is set to `ADDRESS_KIND_LOCAL` (a value from the [ADDRESS_KIND](../../../extensibility/debugger/reference/address-kind.md) enumeration).

> [!WARNING]
> [C++ only] If `pLocal` is not null, then you must call `Release` on the token pointer (`addr` is a field in the [DEBUG_ADDRESS](../../../extensibility/debugger/reference/debug-address.md) structure):
>
> ```cpp
> if (addr.dwKind == ADDRESS_KIND_METADATA_LOCAL && addr.addr.addrLocal.pLocal != NULL)
> {
>     addr.addr.addrLocal.pLocal->Release();
> }
> ```

## Requirements

Header: sh.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also

- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [DEBUG_ADDRESS_UNION](../../../extensibility/debugger/reference/debug-address-union.md)
- [DEBUG_ADDRESS](../../../extensibility/debugger/reference/debug-address.md)
- [ADDRESS_KIND](../../../extensibility/debugger/reference/address-kind.md)
