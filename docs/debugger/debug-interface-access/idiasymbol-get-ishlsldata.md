---
description: "Specifies whether this symbol represents High Level Shader Language (HLSL) data."
title: "IDiaSymbol::get_isHLSLData"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_isHLSLData

Specifies whether this symbol represents High Level Shader Language (HLSL) data.

## Syntax

```C++
HRESULT get_isHLSLData(
   BOOL* pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `BOOL` that specifies whether this symbol represents HLSL data.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## Remarks

> [!NOTE]
> The newer DXC compiler no longer produces PDBs. This API only has valid values on PDBs produced by the older *fxc.exe* compiler.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
