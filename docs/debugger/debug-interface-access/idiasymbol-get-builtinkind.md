---
description: Retrieves a built-in kind of the HLSL type.
title: "IDiaSymbol::get_builtInKind"
ms.date: "07/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# `IDiaSymbol::get_builtInKind`

Retrieves a built-in kind of the HLSL type.

## Syntax

```C++
HRESULT get_buildInKind(
   DWORD* pRetVal);
```

#### Parameters

 `pRetVal`

[out] A pointer to a `DWORD` that holds a built-in kind of the HLSL type.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## Remarks

> [!NOTE]
> The newer DXC compiler no longer produces PDBs. This API only has valid values on PDBs produced by the older *fxc.exe* compiler.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [`CV_builtin_e`](../../debugger/debug-interface-access/cv-builtin-e.md)
