---
title: "IDiaSymbol::get_noStackOrdering | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_noStackOrdering method"
ms.assetid: a1753917-705b-4165-9880-d05e91e6dcb4
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_noStackOrdering
This function retrieves a flag that indicates whether no stack ordering could be done as part of stack buffer checking ([/GS (Buffer Security Check)](/cpp/build/reference/gs-buffer-security-check) compiler option).

## Syntax

```C++
HRESULT get_noStackOrdering(
   BOOL *pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if no stack ordering could be done as part of stack buffer checking; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v8.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [/GS (Buffer Security Check)](/cpp/build/reference/gs-buffer-security-check)