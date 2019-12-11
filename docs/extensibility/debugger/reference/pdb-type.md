---
title: "PDB_TYPE | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "PDB_TYPE"
helpviewer_keywords:
  - "PDB_TYPE structure"
ms.assetid: 1c1bb772-77d6-4870-90b2-fd9247d0004e
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# PDB_TYPE

This structure specifies information about a field type taken from a PDB symbol.

## Syntax

```cpp
typedef struct _tagTYPE_PDB {
    ULONG32 ulAppDomainID;
    GUID    guidModule;
    DWORD   symid;
} PDB_TYPE;
```

```csharp
public struct PDB_TYPE {
    public uint ulAppDomainID;
    public Guid guidModule;
    public uint symid;
};
```

## Members

`ulAppDomainID`\
ID of the application from which the symbol came. This is used to uniquely identify an instance of the application.

`guidModule`\
The GUID of the module that contains this field.

`symid`\
The ID of the symbol that corresponds to this field.

## Remarks

This structure appears as part of the union in the [TYPE_INFO](../../../extensibility/debugger/reference/type-info.md) structure when the `dwKind` field of the `TYPE_INFO` structure is set to `TYPE_KIND_PDB` (a value from the [dwTYPE_KIND](../../../extensibility/debugger/reference/dwtype-kind.md) enumeration).

## Requirements

Header: sh.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also

- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [TYPE_INFO](../../../extensibility/debugger/reference/type-info.md)
- [dwTYPE_KIND](../../../extensibility/debugger/reference/dwtype-kind.md)
