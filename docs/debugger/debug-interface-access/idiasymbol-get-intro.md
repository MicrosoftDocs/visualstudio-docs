---
title: "IDiaSymbol::get_intro | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_intro method"
ms.assetid: 101afe4a-4c57-45de-87b4-330394c6de10
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
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
