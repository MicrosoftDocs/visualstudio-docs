---
description: Retrieves an enumeration that allows a client to iterate through the MSIL offsets within a specified relative virtual address (RVA) range.
title: "IDiaSession::findILOffsetsByRVA"
ms.date: "07/22/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::findILOffsetsByRVA method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSession::findILOffsetsByRVA

Retrieves an enumeration that allows a client to iterate through the MSIL offsets within a specified address range.

## Syntax

```C++
HRESULT findILOffsetsByRVA (
    DWORD rva,
    DWORD length,
    IDiaEnumLineNumbers** ppResult
);
```

#### Parameters

`rva`

[in] Specifies the address as an RVA.

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
    DWORD                rva = 0;
    ULONGLONG            length;

    if (pFunc->get_relativeVirtualAddress ( &rva ) == S_OK)
    {
        pFunc->get_length ( &length );
        pSession->findILOffsetsByRVA( rva, static_cast<DWORD>( length ), &pEnum );
    }
    return(pEnum);
}
```

## See also

- [`IDiaEnumLineNumbers`](../../debugger/debug-interface-access/idiaenumlinenumbers.md)
- [`IDiaSession`](../../debugger/debug-interface-access/idiasession.md)
- [`IDiaSession::findILOffsetsByRVA`](../../debugger/debug-interface-access/idiasession-findlinesbyrva.md)
