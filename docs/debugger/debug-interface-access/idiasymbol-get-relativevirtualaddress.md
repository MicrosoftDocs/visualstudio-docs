---
title: "IDiaSymbol::get_relativeVirtualAddress | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_relativeVirtualAddress method"
ms.assetid: e37219e3-c021-4057-9ec8-4f7cf3c13a15
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_relativeVirtualAddress
Retrieves the relative virtual address (RVA) of the location. Use when the [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md) is set to `LocIsStatic`.

## Syntax

```C++
HRESULT get_relativeVirtualAddress ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the relative virtual address of the location.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Example

```C++
IDiaSymbol* pSymbol;
DWORD       rva;
pSymbol->get_relativeVirtualAddress( &rva );
```

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md)