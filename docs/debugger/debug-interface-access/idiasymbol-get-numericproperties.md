---
description: "Retrieves the set of numeric properties for this symbol."
title: "IDiaSymbol::get_numericProperties"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_numericProperties method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_numericProperties

Retrieves the set of numeric properties for this symbol.

## Syntax

```C++
HRESULT get_numericProperties(
    DWORD cnt,
    DWORD *pcnt,
    DWORD *pProperties
);
```

#### Parameters

 `cnt`

[in] The number of DWORDs pointed to by the buffer `pProperties`.

 `pcnt`

[out] Returns the number of valid properties set in `pProperties`.

 `pProperties`

[out] Returns the set of properties for this symbol.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Example

```C++
CComPtr<pSymbol> pSymbol;
BOOL f = FALSE;
HRESULT hr = E_FAIL;
...

hr = pSymbol->get_isHLSLData(&f);
if (FAILED(hr)) {
    return hr;
}
if (f) {
    DWORD value = 0;
    hr = pSymbol->get_numberOfRegisterIndices(&value);
    if (hr == S_OK && value > 0) {
        DWORD *pOff = new (std::nothrow) DWORD[value];
        if (pOff == NULL) {
            return E_OUTOFMEMORY;
        }
        DWORD propertiesRead;
        if (IfOkOrReportAuto(pSymbol->get_numericProperties(value, &propertiesRead, pOff))) {
            value = __min(value, propertiesRead);
            for (DWORD i = 0; i < value; i++) {
                printf("%u\n", pOff[i]);
            }
        }
        delete[] pOff;
    }
}
```

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [`IDiaSymbol::get_numberOfRegisterIndices`](../../debugger/debug-interface-access/idiasymbol-get-numberofregisterindices.md)
