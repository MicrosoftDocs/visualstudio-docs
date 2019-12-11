---
title: "IDiaSymbol::get_isHLSLData | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
ms.assetid: 4662058b-c505-4ccf-ae03-739a62c814ca
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
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

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)