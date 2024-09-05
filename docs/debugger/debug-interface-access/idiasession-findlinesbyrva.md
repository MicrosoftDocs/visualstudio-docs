---
description: Retrieves the lines in a specified compiland that contain a specified relative virtual address (RVA).
title: "IDiaSession::findLinesByRVA"
ms.date: "07/22/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::findLinesByRVA method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# `IDiaSession::findLinesByRVA`

Retrieves the lines in a specified compiland that contain a specified relative virtual address (RVA).

## Syntax

```C++
HRESULT findLinesByRVA ( 
    DWORD                 rva,
    DWORD                 length,
    IDiaEnumLineNumbers** ppResult
);
```

#### Parameters

`rva`

[in] Specifies the address as an RVA.

`length`

[in] Specifies the number of bytes of address range to cover with this query.

`ppResult`

[out] Returns an [`IDiaEnumLineNumbers`](../../debugger/debug-interface-access/idiaenumlinenumbers.md) object that contains a list of all the line numbers that cover the specified address range.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Example
This example shows a function that obtains all line numbers contained in the specified function using the function's relative virtual address and length.

```C++
IDiaEnumLineNumbers* GetLineNumbersByRVA(IDiaSymbol *pFunc, IDiaSession *pSession)
{
    IDiaEnumLineNumbers* pEnum = NULL;
    DWORD                rva;
    ULONGLONG            length;

    if (pFunc->get_relativeVirtualAddress ( &rva ) == S_OK)
    {
        pFunc->get_length ( &length );
        pSession->findLinesByRVA( rva, static_cast<DWORD>( length ), &pEnum );
    }
    return(pEnum);
}
```

## See also
- [`IDiaEnumLineNumbers`](../../debugger/debug-interface-access/idiaenumlinenumbers.md)
- [`IDiaSession`](../../debugger/debug-interface-access/idiasession.md)
