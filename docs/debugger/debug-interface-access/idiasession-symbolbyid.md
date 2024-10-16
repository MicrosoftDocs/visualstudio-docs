---
description: Retrieves a symbol by its unique identifier.
title: "IDiaSession::symbolById"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::symbolById method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSession::symbolById

Retrieves a symbol by its unique identifier.

## Syntax

```C++
HRESULT symbolById (
    DWORD        id,
    IDiaSymbol** ppSymbol
);
```

#### Parameters
`id`

[in] Unique identifier.

`ppSymbol`

[out] Returns an [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object that represents the symbol retrieved.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
The specified identifier is a unique value used internally by the DIA SDK to make all symbols unique.

This method can be used, for example, to retrieve the symbol representing the type of another symbol (see the example).

## Example
This example retrieves an [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) representing the type of another symbol. This example shows how to use the `symbolById` method in the session. A simpler approach is to call the [IDiaSymbol::get_type](../../debugger/debug-interface-access/idiasymbol-get-type.md) method to retrieve the type symbol directly.

```C++
IDiaSymbol *GetSymbolType(IDiaSymbol *pSymbol, IDiaSession *pSession)
{
    IDiaSymbol *pTypeSymbol = NULL;
    if (pSymbol != NULL && pSession != NULL)
    {
        DWORD symbolTypeId;
        pSymbol->get_typeId(&symbolTypeId);
        pSession->symbolById(symbolTypeId, &pTypeSymbol);
    }
    return(pTypeSymbol);
}
```

## See also
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [IDiaSymbol::get_type](../../debugger/debug-interface-access/idiasymbol-get-type.md)
