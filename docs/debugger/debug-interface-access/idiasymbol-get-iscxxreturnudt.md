---
description: "Retrieves a flag indicating whether return C++ style UDT."
title: "IDiaSymbol::get_isCxxReturnUdt"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_isCxxReturnUdt method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_isCxxReturnUdt

Retrieves a flag indicating whether return C++ style UDT.

## Syntax

```C++
HRESULT get_isCxxReturnUdt ( 
   BOOL* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns `TRUE` if the function's return parameter is using C++ semmantics where the caller must pass a buffer for the UDT to be constructed in-place; otherwise returns `FALSE` when the function return is using C-semmantics (return-by-value).

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
