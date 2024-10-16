---
title: "IDiaSymbol::get_baseType"
description: Retrieves the base type for this symbol
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_baseType method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_baseType

Retrieves the base type for this symbol.

## Syntax

```C++
HRESULT get_baseType (
    DWORD* pRetVal
);
```

#### Parameters
`pRetVal`

[out] Returns a value from the [BasicType Enumeration](../../debugger/debug-interface-access/basictype.md) enumeration specifying the base type of the symbol.

## Return Value
If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Remarks
The basic type for a symbol can be determined by first getting the type of the symbol and then interrogating that returned type for the base type. Note that some symbols may not have a base type—for example, a structure name.

## Example

```C++
IDiaSymbol* pType;
CComPtr<IDiaSymbol> pBaseType;
if (pType->get_type( &pBaseType ) == S_OK)
{
    BasicType btBaseType;
    if (pBaseType->get_baseType((DWORD *)&btBaseType) == S_OK)
    {
        // Do something with basic type.
    }
}
```

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v7.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [BasicType Enumeration](../../debugger/debug-interface-access/basictype.md)
- [IDiaSymbol::get_type](../../debugger/debug-interface-access/idiasymbol-get-type.md)
