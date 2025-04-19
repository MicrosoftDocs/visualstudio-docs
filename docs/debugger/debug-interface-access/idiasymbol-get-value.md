---
description: "Retrieves the value of a constant."
title: "IDiaSymbol::get_value"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_value method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_value

Retrieves the value of a constant.

## Syntax

```C++
HRESULT get_value (
    VARIANT* pRetVal
);
```

#### Parameters
`pRetVal`

[in, out] A `VARIANT` object that is filled in with the value of a constant.

## Return Value
If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks
The supplied VARIANT must be initialized before it is passed to this method. For more information, see the example.

## Example

```C++
void ProcessValue(IDiaSymbol *pSymbol)
{
    VARIANT value;
    VariantInit(&value);    // Initialize variant for use.
    if (pSymbol->get_value(&value) == S_OK)
    {
        // Do something with value.
    }
}

//----------------------------------------------------
// Alternate approach
void ProcessValue2(IDiaSymbol *pSymbol)
{
    CComVariant value;
    if (pSymbol->get_value(&value) == S_OK)
    {
        // Do something with value
    }
}
```

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [Variant Manipulation Functions](/previous-versions/windows/desktop/automat/variant-manipulation-functions)
