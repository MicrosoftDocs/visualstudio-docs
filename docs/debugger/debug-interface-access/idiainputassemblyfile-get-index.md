---
description: Retrieves the file index.
title: "IDiaInputAssemblyFile::get_index"
ms.date: "07/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaInputAssemblyFile::get_index method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaInputAssemblyFile::get_index

Retrieves the file index.

## Syntax

```C++
HRESULT get_index(
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the index of this input assembly file within the .NET Native binary.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaInputAssemblyFile`](../../debugger/debug-interface-access/idiainputassemblyfile.md)
- [Compile apps with .NET Native](/windows/uwp/dotnet-native/)
