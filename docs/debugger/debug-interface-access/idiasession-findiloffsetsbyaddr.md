---
description: Retrieves an enumeration that allows a client to iterate through the MSIL offsets within a specified address range.
title: "IDiaSession::findILOffsetsByAddr"
ms.date: "07/22/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::findILOffsetsByAddr method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSession::findILOffsetsByAddr

Retrieves an enumeration that allows a client to iterate through the MSIL offsets within a specified address range.

## Syntax

```C++
HRESULT findILOffsetsByAddr (
    DWORD isect,
    DWORD offset,
    DWORD length,
    IDiaEnumLineNumbers** ppResult
);
```

#### Parameters
`isect`

[in] Specifies the section component of the specific address.

`offset`

[in] Specifies the offset component of the specific address.

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
    DWORD                seg;
    DWORD                offset;
    ULONGLONG            length;

    if (pFunc->get_addressSection ( &seg ) == S_OK &&
        pFunc->get_addressOffset ( &offset ) == S_OK)
    {
        pFunc->get_length ( &length );
        pSession->findILOffsetsByAddr( seg, offset, static_cast<DWORD>( length ), &pEnum );
    }
    return(pEnum);
}
```

## See also

- [`IDiaEnumLineNumbers`](../../debugger/debug-interface-access/idiaenumlinenumbers.md)
- [`IDiaSession`](../../debugger/debug-interface-access/idiasession.md)
- [`IDiaSession::findILOffsetsByVA`](../../debugger/debug-interface-access/idiasession-findlinesbyva.md)
