---
description: "Retrieves a flag indicating whether this is an Objective-C category."
title: "IDiaSymbol2::get_isObjCCategory"
ms.date: "07/12/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol2::get_isObjCCategory method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol2::get_isObjCCategory

Retrieves a flag indicating whether this is an Objective-C category.

## Syntax

```C++
HRESULT get_isObjCCategory ( 
   BOOL* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns `TRUE` is this symbol is an Objective-C category; otherwise, returns `FALSE`.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol2`](../../debugger/debug-interface-access/idiasymbol2.md)
- [`IDiaSymbol2::get_isObjCClass`](../../debugger/debug-interface-access/idiasymbol2-get-isobjcclass.md)
- [`IDiaSymbol2::get_isObjCProtocol`](../../debugger/debug-interface-access/idiasymbol2-get-isobjcprotocol.md)
