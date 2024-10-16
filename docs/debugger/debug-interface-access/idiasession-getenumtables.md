---
description: Retrieves an enumerator for all tables contained in the symbol store.
title: "IDiaSession::getEnumTables"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::getEnumTables method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSession::getEnumTables

Retrieves an enumerator for all tables contained in the symbol store.

## Syntax

```C++
HRESULT getEnumTables (
    IDiaEnumTables** ppEnumTables
);
```

#### Parameters
`ppEnumTables`

[out] Returns an [IDiaEnumTables](../../debugger/debug-interface-access/idiaenumtables.md) object. Use this interface to enumerate the tables in the symbol store.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Example
This example presents a general function that uses the `getEnumTables` method to obtain a specific enumerator object. If the enumerator is found, the function returns a pointer that can be cast to the desired interface; otherwise, the function returns `NULL`.

```C++
IUnknown *GetTable(IDiaSession *pSession, REFIID iid)
{
    IUnknown *pUnknown = NULL;
    if (pSession != NULL)
    {
        CComPtr<IDiaEnumTables> pEnumTables;
        if (pSession->getEnumTables(&pEnumTables) == S_OK)
        {
            CComPtr<IDiaTable> pTable;
            DWORD celt = 0;
            while(pEnumTables->Next(1,&pTable,&celt) == S_OK &&
                  celt == 1)
            {
                if (pTable->QueryInterface(iid, (void **)pUnknown) == S_OK)
                {
                    break;
                }
                pTable = NULL;
            }
        }
    }
    return(pUnknown);
}
```

## See also
- [IDiaEnumTables](../../debugger/debug-interface-access/idiaenumtables.md)
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
