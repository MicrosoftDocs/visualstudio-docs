---
description: Retrieves the orginal assembly file name.
title: "IDiaInputAssemblyFile::get_fileName"
ms.date: "07/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaInputAssemblyFile::get_fileName method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaInputAssemblyFile::get_fileName

Retrieves the orginal assembly file name.

## Syntax

```C++
HRESULT get_fileName(
   BSTR* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the original filename of the input assembly.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaInputAssemblyFile`](../../debugger/debug-interface-access/idiainputassemblyfile.md)
- [Compile apps with .NET Native](/windows/uwp/dotnet-native/)
