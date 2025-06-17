---
description: Retrieves a unique identifier for the file.
title: "IDiaInputAssemblyFile::get_uniqueId"
ms.date: "07/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaInputAssemblyFile::get_uniqueId method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaInputAssemblyFile::get_uniqueId

Retrieves a unique identifier for the file.

## Syntax

```C++
HRESULT get_uniqueId(
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the unique identifier for this file.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Remarks

The identifiers are only unique within this data store. They are not guaranteed to be unique across different PDBs.

## See also

- [`IDiaInputAssemblyFile`](../../debugger/debug-interface-access/idiainputassemblyfile.md)
- [Compile apps with .NET Native](/windows/uwp/dotnet-native/)
