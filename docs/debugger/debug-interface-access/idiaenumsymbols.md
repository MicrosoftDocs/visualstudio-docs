---
description: Enumerates the various symbols contained in the data source.
title: IDiaEnumSymbols
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSymbols interface"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumSymbols

Enumerates the various symbols contained in the data source.

## Syntax

`IDiaEnumSymbols : IUnknown`

## Methods in Vtable Order

The following table shows the methods of `IDiaEnumSymbols`.

|Method|Description|
|------------|-----------------|
|[IDiaEnumSymbols::get__NewEnum](../../debugger/debug-interface-access/idiaenumsymbols-get-newenum.md)|Retrieves the `IEnumVARIANT Interface` version of this enumerator.|
|[IDiaEnumSymbols::get_Count](../../debugger/debug-interface-access/idiaenumsymbols-get-count.md)|Retrieves the number of symbols.|
|[IDiaEnumSymbols::Item](../../debugger/debug-interface-access/idiaenumsymbols-item.md)|Retrieves a symbol by means of an index.|
|[IDiaEnumSymbols::Next](../../debugger/debug-interface-access/idiaenumsymbols-next.md)|Retrieves a specified number of symbols in the enumeration sequence.|
|[IDiaEnumSymbols::Skip](../../debugger/debug-interface-access/idiaenumsymbols-skip.md)|Skips a specified number of symbols in an enumeration sequence.|
|[IDiaEnumSymbols::Reset](../../debugger/debug-interface-access/idiaenumsymbols-reset.md)|Resets an enumeration sequence to the beginning.|
|[IDiaEnumSymbols::Clone](../../debugger/debug-interface-access/idiaenumsymbols-clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|

## Remarks

This interface provides symbols grouped by a specific type of symbol, for example, `SymTagUDT` (user-defined types (UDTs)) or `SymTagBaseClass`. To work with symbols grouped by address, use the [IDiaEnumSymbolsByAddr](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr.md) interface.

## Notes for Callers

Obtain this interface by calling the following methods:

- [IDiaSession::findChildren](../../debugger/debug-interface-access/idiasession-findchildren.md)

- [IDiaSymbol::findChildren](../../debugger/debug-interface-access/idiasymbol-findchildren.md)

- [IDiaSourceFile::get_compilands](../../debugger/debug-interface-access/idiasourcefile-get-compilands.md)

## Example

This example shows how to obtain the `IDiaEnumSymbols` interface and then use that enumeration to list user-defined types (UDTs).

> [!NOTE]
> `CDiaBSTR` is a class that wraps a `BSTR` and automatically handles freeing the string when the instantiation goes out of scope.

```c++
void ShowUDTs(IDiaSymbol *pGlobals)
{
    CComPtr<IDiaEnumSymbols> pEnum;
    CComPtr<IDiaSymbol> pSymbol;
    HRESULT hr;

    hr = pGlobals->findChildren(SymTagUDT,
                                NULL,
                                nsfCaseInsensitive | nsfUndecoratedName,
                                &pEnum);
    if (hr == S_OK)
    {
        while ( SUCCEEDED( hr = pEnum->Next( 1, &pSymbol, &celt ) ) &&
                celt == 1 )
        {
            CDiaBSTR name;
            if ( pSymbol->get_name( &name ) != S_OK )
                Fatal( "get_name" );
            printf( "Found UDT: %ws\n", name );
            pSymbol = 0;
        }
    }
}
```

## Requirements

Header: Dia2.h

Library: diaguids.lib

DLL: msdia80.dll

## See also

- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [IDiaSession::findChildren](../../debugger/debug-interface-access/idiasession-findchildren.md)
- [IDiaSourceFile::get_compilands](../../debugger/debug-interface-access/idiasourcefile-get-compilands.md)
- [IDiaSymbol::findChildren](../../debugger/debug-interface-access/idiasymbol-findchildren.md)
