---
title: "IDiaSymbol::get_signature | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_signature method"
ms.assetid: 0efefa39-49a5-4282-9d41-e50832d927e0
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_signature
Retrieves the symbol's signature value.

## Syntax

```C++
HRESULT get_signature ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the symbol's signature value.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)