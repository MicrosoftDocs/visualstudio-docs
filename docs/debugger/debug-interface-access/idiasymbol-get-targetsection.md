---
title: "IDiaSymbol::get_targetSection | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_targetSection method"
ms.assetid: 95382395-da41-4aa8-87f1-5b03da128565
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_targetSection
Retrieves the address section of a thunk target.

## Syntax

```C++
HRESULT get_targetSection ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Section part of a thunk target address.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)