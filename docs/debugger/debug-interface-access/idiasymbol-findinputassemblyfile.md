---
description: Retrieves the .NET Native input assembly file that is the parent of the symbol.
title: "IDiaSymbol::findInputAssemblyFile"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::findInputAssemblyFile method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSymbol::findInputAssemblyFile

Retrieves the .NET Native input assembly file that is the parent of the symbol.

## Syntax

```C++
HRESULT findInputAssemblyFile(
        [out] IDiaInputAssemblyFile** ppResult);
```

#### Parameters

 `ppResult`

[out] Returns the [IDiaInputAssemblyFile`](../../debugger/debug-interface-access/idiainputassemblyfile.md).

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the symbol did not come from a .NET native input assembly.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [IDiaInputAssemblyFile`](../../debugger/debug-interface-access/idiainputassemblyfile.md)
