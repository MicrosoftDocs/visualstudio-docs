---
description: "Retrieves the metadata token of a managed function or variable."
title: "IDiaSymbol::get_token | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_token method"
ms.assetid: 7ee7a9be-a0d8-48e4-9fef-d37b3d6ae4ef
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_token
Retrieves the metadata token of a managed function or variable.

## Syntax

```C++
HRESULT get_token ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the metadata token of a managed function or variable.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
