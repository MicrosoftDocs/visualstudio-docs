---
description: "Retrieves a flag that indicates whether another symbol references this symbol's address."
title: "IDiaSymbol::get_addressTaken | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_addressTaken method"
ms.assetid: 0d366188-f5e1-4226-b392-58c09539d097
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_addressTaken
Retrieves a flag that indicates whether another symbol references this symbol's address.

## Syntax

```C++
HRESULT get_addressTaken ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if another symbol references this address; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Example
 In the following example, `B` references `A`. Therefore, symbol `A`'s `get_addressTaken` method returns `TRUE`.

```C++
int A  = 0;
int* B = &A;
```

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v7.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
