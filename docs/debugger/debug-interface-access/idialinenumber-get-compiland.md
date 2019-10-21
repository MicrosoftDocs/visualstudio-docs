---
title: "IDiaLineNumber::get_compiland | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLineNumber::get_compiland method"
ms.assetid: c476d0b8-c473-47eb-96f5-c4e8f577b1c9
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaLineNumber::get_compiland
Retrieves a reference to the symbol for the compiland that contributed the bytes of image text.

## Syntax

```C++
HRESULT get_compiland ( 
   IDiaSymbol** pRetVal
);
```

#### Parameters
 pRetVal

[out] Returns an [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object for the compiland that contributed the bytes of image text.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)