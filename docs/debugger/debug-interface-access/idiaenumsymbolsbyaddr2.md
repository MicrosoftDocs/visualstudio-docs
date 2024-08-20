---
description: Enumerates by address the various symbols contained in the data source. Extends IDiaEnumSymbolsByAddr.
title: IDiaEnumSymbolsByAddr2
ms.date: "7/2/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSymbolsbyAddr2 interface"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumSymbolsByAddr2

Enumerates by address the various symbols contained in the data source.

## Syntax

`IDiaEnumSymbolsByAddr2 : IDiaEnumSymbolsByAdd`

## Methods in Vtable Order

The following table shows the methods of `IDiaEnumSymbolsByAddr2`.

|Method|Description|
|------------|-----------------|
|[`IDiaEnumSymbolsByAddr2::symbolByAddrEx`](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr2-symbolbyaddrex.md)|Positions the enumerator by performing a lookup by section and offset.|
|[`IDiaEnumSymbolsByAddr2::symbolByRVAEx`](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr2-symbolbyrvaex.md)|Positions the enumerator by performing a lookup by relative virtual address (RVA).|
|[`IDiaEnumSymbolsByAddr2::symbolByVAEx`](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr2-symbolbyvaex.md)|Positions the enumerator by performing a lookup by virtual address (VA).|
|[`IDiaEnumSymbolsByAddr2::NextEx`](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr2-nextex.md)|Retrieves the next symbols in order by address. Updates the enumerator position by number of elements fetched.|
|[`IDiaEnumSymbolsByAddr2::PrevEx`](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr2-prevex.md)|Retrieves the previous symbols in order by address. Updates the enumerator position by number of elements fetched.|

## Remarks

This interface provides symbols grouped by address. To work with symbols grouped by type, for example `SymTagUDT` (user-defined type) or `SymTagBaseClass`, use the [`IDiaEnumSymbols`](../../debugger/debug-interface-access/idiaenumsymbols.md) interface.

## Notes for callers

Obtain this interface by calling the [`IDiaSession::getSymbolsByAddr`](../../debugger/debug-interface-access/idiasession-getsymbolsbyaddr.md) method and then calling [`IUnknown::QueryInterface`](/windows/win32/api/unknwn/nf-unknwn-iunknown-queryinterface(refiid_void)) with the `riid` parameter set to `IID_IDiaEnumSymbolsByAddr2`.

## Example

This function displays the name and address of all symbols ordered by relative virtual address.

```C++
void ShowSymbolsByAddress(IDiaSession *pSession)
{
    CComPtr<IDiaEnumSymbolsByAddr> pEnumByAddr;
    if ( FAILED( psession->getSymbolsByAddr( &pEnumByAddr ) ) )
    {
        Fatal( "getSymbolsByAddr" );
    }
    CComPtr<IDiaEnumSymbolsByAddr2> pEnumByAddr2;
    if ( FAILED( pEnumByAddr->QueryInterface( IID_IDiaEnumSymbolsByAddr2, &pEnumByAddr2 ) ) )
    {
        Fatal( "getSymbolsByAddr" );
    }
    CComPtr<IDiaSymbol> pSym;
    if ( FAILED( pEnumByAddr2->symbolByAddrEx( FALSE, 1, 0, &pSym ) ) )
    {
        Fatal( "symbolByAddr" );
    }
    DWORD rvaLast = 0;
    if ( pSym->get_relativeVirtualAddress( &rvaLast ) == S_OK )
    {
        pSym = 0;
        if ( FAILED( pEnumByAddr2->symbolByRVAEx( FALSE, rvaLast, &pSym ) ) )
        {
            Fatal( "symbolByAddr" );
        }
        printf( "Symbols in order\n" );
        do
        {
            CDiaBSTR name;
            if ( pSym->get_name( &name ) != S_OK )
            {
                printf( "\t0x%08X (%ws) <no name>\n", rvaLast );
            }
            else
            {
                printf( "\t0x%08X %ws\n", rvaLast, name );
            }
            pSym = 0;
            celt = 0;
            if ( FAILED( hr = pEnumByAddr2->NextEx( FALSE, 1, &pSym, &celt ) ) )
            {
                break;
            }
        } while ( celt == 1 );
    }
}
```

## Requirements

Header: Dia2.h

Library: diaguids.lib

DLL: msdia140.dll

## See also

- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [`IDiaSession::getSymbolsByAddr`](../../debugger/debug-interface-access/idiasession-getsymbolsbyaddr.md)
- [`IDiaEnumSymbols`](../../debugger/debug-interface-access/idiaenumsymbols.md)
