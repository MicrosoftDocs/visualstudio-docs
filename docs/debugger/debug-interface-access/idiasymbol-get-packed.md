---
title: "IDiaSymbol::get_packed | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_packed method"
ms.assetid: e42ff368-56c4-49a2-8676-f80e349efa21
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_packed
Retrieves a flag that specifies whether the user-defined data type (UDT) is packed.

## Syntax

```C++
HRESULT get_packed ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the UDT is packed; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Remarks
 Packed means all the members of the UDT are positioned as close together as possible, with no intervening padding to align to memory boundaries.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)