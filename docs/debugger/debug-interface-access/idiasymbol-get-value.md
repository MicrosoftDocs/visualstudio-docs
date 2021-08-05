---
description: "Retrieves the value of a constant."
title: "IDiaSymbol::get_value | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_value method"
ms.assetid: 2e40174a-2a61-4e5f-bb32-9e0ceec2178a
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
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
    value.vt = VT_EMPTY;    // Initialize variant for use.
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
