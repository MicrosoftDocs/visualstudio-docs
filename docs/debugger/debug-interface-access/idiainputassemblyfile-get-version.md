---
description: Retrieves the version of the orginal assembly.
title: "IDiaInputAssemblyFile::get_version"
ms.date: "07/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaInputAssemblyFile::get_version method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaInputAssemblyFile::get_version

Retrieves the version of the orginal assembly.

## Syntax

```C++
HRESULT get_version(
    DWORD cbData,
    DWORD *pcbData,
    BYTE *pbData
);
```

#### Parameters

 `cbData`

[in] Size of the data buffer, in bytes.

 `pcbData`

[out] Returns the number of bytes of the version data. This parameter cannot be `NULL`.

 `pbData`

[out] A buffer that is filled with the version bytes. If this parameter is `NULL`, then `pcbData` returns the number of bytes required.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaInputAssemblyFile`](../../debugger/debug-interface-access/idiainputassemblyfile.md)
- [Compile apps with .NET Native](/windows/uwp/dotnet-native/)
