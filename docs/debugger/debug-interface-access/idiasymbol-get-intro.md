---
description: Retrieves a flag that specifies whether the function is an introducing virtual function.
title: "IDiaSymbol::get_intro"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_intro method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_intro

Retrieves a flag that specifies whether the function is an introducing virtual function.

## Syntax

```C++
HRESULT get_intro ( 
    BOOL* pRetVal
);
```

#### Parameters
`pRetVal`

[out] Returns `TRUE` if the function is intro virtual; otherwise, returns `FALSE`.

## Return Value
If successful, returns `S_OK`; otherwise, returns `S_FALSE` or error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Example

```C++
class A {
    virtual int f1();
}
class B : public A {
    int f1();
}
```

Both `A::f1` and `B::f1` are virtual functions, but `A::f1` is intro virtual.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v7.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
