---
description: "Retrieves the Source Link blob associated with this SymTagCompiland symbol."
title: "IDiaSymbol10::get_sourceLink"
ms.date: "07/15/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol10::get_sourceLink method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol10::get_sourceLink

Retrieves the [Source Link](https://github.com/dotnet/designs/blob/main/accepted/2020/diagnostics/source-link.md) blob associated with this `SymTagCompiland` symbol.

## Syntax

```C++
HRESULT get_sourceLink(
    DWORD cb,
    DWORD *pcb,
    BYTE *pb
);
```

#### Parameters

 `cb`

[in] The size in bytes of the optional buffer pointed to by `pb` parameter.

 `pcb`

[out, optional] If `pb` is `nullptr` and `cb` is 0, this parameter is required, and returns the size in bytes needed to contain the entire source link blob. Otherwise it returns the number of bytes written to the `pb` buffer upon success.

 `pb`

[out, optional] Returns the source link information blob.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol10`](../../debugger/debug-interface-access/idiasymbol10.md)
- [Using Source Link](https://github.com/dotnet/sourcelink#using-source-link-in-c-projects)
