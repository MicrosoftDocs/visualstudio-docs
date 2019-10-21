---
title: "BasicType | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "BasicType enumeration"
ms.assetid: 19ae53ba-cd6e-47b6-9f94-27ae663ce955
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# BasicType
Specifies the symbol's basic type.

## Syntax

```C++
enum BasicType {
    btNoType   = 0,
    btVoid     = 1,
    btChar     = 2,
    btWChar    = 3,
    btInt      = 6,
    btUInt     = 7,
    btFloat    = 8,
    btBCD      = 9,
    btBool     = 10,
    btLong     = 13,
    btULong    = 14,
    btCurrency = 25,
    btDate     = 26,
    btVariant  = 27,
    btComplex  = 28,
    btBit      = 29,
    btBSTR     = 30,
    btHresult  = 31,
    btChar16   = 32,  // char16_t
    btChar32   = 33,  // char32_t
};
```

## Elements
btNoType
No basic type is specified.

btVoid
Basic type is a `void`.

btChar
Basic type is a `char` (C/C++ type).

btWChar
Basic type is a wide (Unicode) character (`WCHAR`).

btInt
Basic type is `signed int` (C/C++ type).

btUInt
Basic type is `unsigned int` (C/C++ type).

btFloat
Basic type is a floating-point number (`FLOAT`).

btBCD
Basic type is a binary-coded decimal (`BCD`).

btBool
Basic type is a Boolean (`BOOL`).

btLong
Basic type is a `long int` (C/C++ type).

btULong
Basic type is an `unsigned long int` (C/C++ type).

btCurrency
Basic type is currency.

btDate
Basic type is date/time (`DATE`).

btVariant
Basic type is a variable type structure (`VARIANT`).

btComplex
Basic type is a complex number.

btBit
Basic type is a bit.

btBSTR
Basic type is a basic or binary string (`BSTR`).

btHresult
Basic type is an `HRESULT`.

## Remarks
The values in this enumeration are returned by the [IDiaSymbol::get_baseType](../../debugger/debug-interface-access/idiasymbol-get-basetype.md) method.

## Requirements
Header: cvconst.h

## See also
- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
- [IDiaSymbol::get_baseType](../../debugger/debug-interface-access/idiasymbol-get-basetype.md)
- [IDiaSymbol::get_length](../../debugger/debug-interface-access/idiasymbol-get-length.md)
