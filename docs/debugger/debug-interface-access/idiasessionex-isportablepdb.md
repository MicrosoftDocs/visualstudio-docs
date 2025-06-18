---
description: Retrieves a Boolean indicating that the source debug information is using the Portable PDB format.
title: "IDiaSessionEx::isPortablePDB"
ms.date: "07/05/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSessionEx::isPortablePDB method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSessionEx::isPortablePDB

Retrieves a Boolean indicating that the source debug information is using the [Portable PDB](https://github.com/dotnet/runtime/blob/main/docs/design/specs/PortablePdb-Metadata.md) format.

## Syntax

```C++
HRESULT isPortablePDB(
    BOOL* pfPortablePDB
);
```

#### Parameters

 `pfPortablePDB`

[out] Returns a Boolean indicating if the debug information was in the [Portable PDB](https://github.com/dotnet/runtime/blob/main/docs/design/specs/PortablePdb-Metadata.md) format.

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks

The DIA SDK internally converts portable PDBs into classic windows PDBs in memory when opening them. This can incur extra time and memory usage when the PDB is opened. The file on disk is unmodified.

## See also

- [`IDiaSessionEx`](../../debugger/debug-interface-access/idiasessionex.md)
- [Portable PDB v1.0 Format Specification](https://github.com/dotnet/runtime/blob/main/docs/design/specs/PortablePdb-Metadata.md)
