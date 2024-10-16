---
description: Retrieves the time stamp.
title: "IDiaInputAssemblyFile::get_timestamp"
ms.date: "07/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaInputAssemblyFile::get_timestamp method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaInputAssemblyFile::get_timestamp

Retrieves the time stamp.

## Syntax

```C++
HRESULT get_timestamp(
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the `TimeDateStamp` field from the COFF File Header of this input assembly file when the .NET Native binary was built.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaInputAssemblyFile`](../../debugger/debug-interface-access/idiainputassemblyfile.md)
- [COFF File Header (Object and Image)](/windows/win32/debug/pe-format#coff-file-header-object-and-image)
- [Compile apps with .NET Native](/windows/uwp/dotnet-native/)
