---
title: "IDiaSymbol::get_isAcceleratorPointerTagLiveRange | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
ms.assetid: d195aec4-6d3c-42e0-88a5-3d463539f0b8
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_isAcceleratorPointerTagLiveRange
Retrieves a flag that indicates whether the symbol corresponds to the *definition range symbol* for the tag component of a pointer variable in code compiled for a C++ AMP Accelerator. The definition range symbol is the location of a variable for a span of addresses.

## Syntax

```C++
HRESULT get_isAcceleratorPointerTagLiveRange(
   BOOL* pFlag);
```

#### Parameters
 `pFlag`

[out] A pointer to a `BOOL` that indicates whether the symbol corresponds to the definition range symbol.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)