---
title: "IDiaSymbol::get_locationType | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_locationType method"
ms.assetid: fbb09c43-ebb7-4b4f-be53-ccff86eb183a
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_locationType
Retrieves the location type of a data symbol.

## Syntax

```C++
HRESULT get_locationType ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns a value from the [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md) enumeration that specifies the location type of a data symbol, such as `static` or `local`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md)