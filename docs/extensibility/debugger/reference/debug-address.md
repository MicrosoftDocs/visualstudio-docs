---
description: "This structure represents an address."
title: DEBUG_ADDRESS
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- DEBUG_ADDRESS
helpviewer_keywords:
- DEBUG_ADDRESS structure
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# DEBUG_ADDRESS

This structure represents an address.

## Syntax

### [C#](#tab/csharp)
```csharp
public struct DEBUG_ADDRESS {
    public uint                ulAppDomainID;
    public Guid                guidModule;
    public int                 tokClass;
    public DEBUG_ADDRESS_UNION addr;
}
```
### [C++](#tab/cpp)
```cpp
typedef struct _tagDEBUG_ADDRESS {
    ULONG32             ulAppDomainID;
    GUID                guidModule;
    _mdToken            tokClass;
    DEBUG_ADDRESS_UNION addr;
} DEBUG_ADDRESS;
```
---

## Members
`ulAppDomainID`\
The process ID.

`guidModule`\
The GUID of the module that contains this address.

`tokClass`\
The token identifying the class or type of this address.

> [!NOTE]
> This value is specific to a symbol provider and therefore has no general meaning other than as an identifier for a class type.

`addr`\
A [DEBUG_ADDRESS_UNION](../../../extensibility/debugger/reference/debug-address-union.md) structure, which contains a union of structures that describe the individual address types. The value `addr`.`dwKind` comes from the [ADDRESS_KIND](../../../extensibility/debugger/reference/address-kind.md) enumeration, which explains how to interpret the union.

## Remarks
This structure is passed to the [GetAddress](../../../extensibility/debugger/reference/idebugaddress-getaddress.md) method to be filled in.

**Warning [C++ only]**

If `addr.dwKind` is `ADDRESS_KIND_METADATA_LOCAL` and if `addr.addr.addrLocal.pLocal` is not a null value, then you must call `Release` on the token pointer:

```
if (addr.dwKind == ADDRESS_KIND_METADATA_LOCAL && addr.addr.addrLocal.pLocal != NULL)
{
    addr.addr.addrLocal.pLocal->Release();
}
```

## Requirements
Header: sh.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [GetAddress](../../../extensibility/debugger/reference/idebugaddress-getaddress.md)
- [DEBUG_ADDRESS_UNION](../../../extensibility/debugger/reference/debug-address-union.md)
- [ADDRESS_KIND](../../../extensibility/debugger/reference/address-kind.md)
