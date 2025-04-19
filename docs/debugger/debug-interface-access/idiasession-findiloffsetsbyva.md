---
description: Retrieves an enumeration that allows a client to iterate through the MSIL offsets within a specified virtual address (VA) range.
title: "IDiaSession::findILOffsetsByVA"
ms.date: "07/22/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::findILOffsetsByVA method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSession::findILOffsetsByVA

Retrieves an enumeration that allows a client to iterate through the MSIL offsets within a specified address range.

## Syntax

```C++
HRESULT findILOffsetsByVA (
    ULONGLONG va,
    DWORD length,
    IDiaEnumLineNumbers** ppResult
);
```

#### Parameters

`va`

[in] Specifies the address as a VA.

`length`

[in] Specifies the number of bytes of address range to cover with this query.

`ppResult`

[out] Returns an [`IDiaEnumLineNumbers`](../../debugger/debug-interface-access/idiaenumlinenumbers.md) object that contains a list of all the MSIL offsets that cover the specified address range.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## Example

This example shows a function that obtains all MSIL offset contained in a function using the function's address and length.

```C++
IDiaEnumLineNumbers* GetLineNumbersByAddr(IDiaSymbol *pFunc,
                                          IDiaSession *pSession)
{
    IDiaEnumLineNumbers* pEnum = NULL;
    ULONGLONG            va = 0;
    ULONGLONG            length = 0;

    if (pFunc->get_virtualAddress ( &rva ) == S_OK)
    {
        pFunc->get_length ( &length );
        pSession->findILOffsetsByVA( va, static_cast<DWORD>( length ), &pEnum );
    }
    return(pEnum);
}
```

## See also

- [`IDiaEnumLineNumbers`](../../debugger/debug-interface-access/idiaenumlinenumbers.md)
- [`IDiaSession`](../../debugger/debug-interface-access/idiasession.md)
- [`IDiaSession::findILOffsetsByRVA`](../../debugger/debug-interface-access/idiasession-findlinesbyrva.md)
