---
description: Retrieves the line number information for lines contained in a specified virtual address (VA) range.
title: "IDiaSession::findLinesByVA"
ms.date: "07/22/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::findLinesByVA method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# `IDiaSession::findLinesByVA`

Retrieves the line number information for lines contained in a specified virtual address (VA) range.

## Syntax

```C++
HRESULT findLinesByVA (
    ULONGLONG             va,
    DWORD                 length,
    IDiaEnumLineNumbers** ppResult
);
```

#### Parameters

`va`

[in] Specifies the address as a VA.

`length`

[in] Specifies the number of bytes of address range to cover with this query.

`ppResult`

[out] Returns an [`IDiaEnumLineNumbers`](../../debugger/debug-interface-access/idiaenumlinenumbers.md) object that contains a list of all the line numbers that cover the specified address range.

## Example
This example shows a function that obtains all line numbers contained in a function using the function's virtual address and length.

```C++
IDiaEnumLineNumbers *GetLineNumbersByVA(IDiaSymbol *pFunc, IDiaSession *pSession)
{
    IDiaEnumLineNumbers* pEnum = NULL;
    ULONGLONG            va;
    ULONGLONG            length;

    if (pFunc->get_virtualAddress ( &va ) == S_OK)
    {
        pFunc->get_length( &length );
        pSession->findLinesByVA( va, static_cast<DWORD>( length ), &pEnum );
    }
    return(pEnum);
}
```

## See also
- [`IDiaEnumLineNumbers`](../../debugger/debug-interface-access/idiaenumlinenumbers.md)
- [`IDiaSession`](../../debugger/debug-interface-access/idiasession.md)
