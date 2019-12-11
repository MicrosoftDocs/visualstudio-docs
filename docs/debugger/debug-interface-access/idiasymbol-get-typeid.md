---
title: "IDiaSymbol::get_typeId | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_typeId method"
ms.assetid: b40be36e-10e1-463c-9c6d-21862679d29f
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_typeId
Retrieves the type identifier of the symbol.

## Syntax

```C++
HRESULT get_typeId ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the type ID of the symbol.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks
 The identifier is a unique value created by the DIA SDK to mark all symbols as unique.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)