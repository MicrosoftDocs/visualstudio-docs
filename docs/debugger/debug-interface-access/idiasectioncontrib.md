---
description: Retrieves data describing a section contribution, that is, a contiguous block of memory contributed to the image by a compiland.
title: IDiaSectionContrib
ms.date: "07/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSectionContrib interface"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSectionContrib

Retrieves data describing a section contribution, that is, a contiguous block of memory contributed to the image by a compiland.

## Syntax

`IDiaSectionContrib : IUnknown`

## Methods in Vtable Order

The following table shows the methods of `IDiaSectionContrib`.

|Method|Description|
|------------|-----------------|
|[`IDiaSectionContrib::get_compiland`](../../debugger/debug-interface-access/idiasectioncontrib-get-compiland.md)|Retrieves a reference to the compiland symbol that contributed this section.|
|[`IDiaSectionContrib::get_addressSection`](../../debugger/debug-interface-access/idiasectioncontrib-get-addresssection.md)|Retrieves the section part of the contribution's address.|
|[`IDiaSectionContrib::get_addressOffset`](../../debugger/debug-interface-access/idiasectioncontrib-get-addressoffset.md)|Retrieves the offset part of the contribution's address.|
|[`IDiaSectionContrib::get_relativeVirtualAddress`](../../debugger/debug-interface-access/idiasectioncontrib-get-relativevirtualaddress.md)|Retrieves the image relative virtual address (RVA) of the contribution.|
|[`IDiaSectionContrib::get_virtualAddress`](../../debugger/debug-interface-access/idiasectioncontrib-get-virtualaddress.md)|Retrieves the virtual address (VA) of the contribution.|
|[`IDiaSectionContrib::get_length`](../../debugger/debug-interface-access/idiasectioncontrib-get-length.md)|Retrieves the number of bytes in a section.|
|[`IDiaSectionContrib::get_notPaged`](../../debugger/debug-interface-access/idiasectioncontrib-get-notpaged.md)|Retrieves a flag that indicates whether the section cannot be paged out of memory.|
|[`IDiaSectionContrib::get_nopad`](../../debugger/debug-interface-access/idiasectioncontrib-get-nopad.md)|Retrieves a flag indicating whether the section should not be padded to the next memory boundary.|
|[`IDiaSectionContrib::get_code`](../../debugger/debug-interface-access/idiasectioncontrib-get-code.md)|Retrieves a flag that indicates whether the section contains executable code.|
|[`IDiaSectionContrib::get_initializedData`](../../debugger/debug-interface-access/idiasectioncontrib-get-initializeddata.md)|Retrieves a flag that indicates whether the section contains initialized data.|
|[`IDiaSectionContrib::get_uninitializedData`](../../debugger/debug-interface-access/idiasectioncontrib-get-uninitializeddata.md)|Retrieves a flag that indicates whether the section contains uninitialized data.|
|[`IDiaSectionContrib::get_informational`](../../debugger/debug-interface-access/idiasectioncontrib-get-informational.md)|Retrieves a flag indicating whether a section contains comments or similar information.|
|[`IDiaSectionContrib::get_remove`](../../debugger/debug-interface-access/idiasectioncontrib-get-remove.md)|Retrieves a flag that indicates whether the section is removed before it is made part of the in-memory image.|
|[`IDiaSectionContrib::get_comdat`](../../debugger/debug-interface-access/idiasectioncontrib-get-comdat.md)|Retrieves a flag that indicates whether the section is a COMDAT record.|
|[`IDiaSectionContrib::get_discardable`](../../debugger/debug-interface-access/idiasectioncontrib-get-discardable.md)|Retrieves a flag that indicates whether the section can be discarded.|
|[`IDiaSectionContrib::get_notCached`](../../debugger/debug-interface-access/idiasectioncontrib-get-notcached.md)|Retrieves a flag that indicates whether the section cannot be cached.|
|[`IDiaSectionContrib::get_share`](../../debugger/debug-interface-access/idiasectioncontrib-get-share.md)|Retrieves a flag that indicates whether the section can be shared in memory.|
|[`IDiaSectionContrib::get_execute`](../../debugger/debug-interface-access/idiasectioncontrib-get-execute.md)|Retrieves a flag that indicates whether the section is executable as code.|
|[`IDiaSectionContrib::get_read`](../../debugger/debug-interface-access/idiasectioncontrib-get-read.md)|Retrieves a flag that indicates whether the section can be read.|
|[`IDiaSectionContrib::get_write`](../../debugger/debug-interface-access/idiasectioncontrib-get-write.md)|Retrieves a flag that indicates whether the section can be written.|
|[`IDiaSectionContrib::get_dataCrc`](../../debugger/debug-interface-access/idiasectioncontrib-get-datacrc.md)|Retrieves the cyclic redundancy check (CRC) of the data in the section.|
|[`IDiaSectionContrib::get_relocationsCrc`](../../debugger/debug-interface-access/idiasectioncontrib-get-relocationscrc.md)|Retrieves the CRC of the relocation information for the section.|
|[`IDiaSectionContrib::get_compilandId`](../../debugger/debug-interface-access/idiasectioncontrib-get-compilandid.md)|Retrieves the compiland identifier for the section.|
|[`IDiaSectionContrib::get_code16bit`](../../debugger/debug-interface-access/idiasectioncontrib-get-code16bit.md)|Retrieves a flag that indicates whether the section contains 16-bit code.|

## Remarks

## Notes for Callers

This interface is obtained by calling the [`IDiaEnumSectionContribs::Item`](../../debugger/debug-interface-access/idiaenumsectioncontribs-item.md) and [`IDiaEnumSectionContribs::Next`](../../debugger/debug-interface-access/idiaenumsectioncontribs-next.md) methods. See the [`IDiaEnumSectionContribs`](../../debugger/debug-interface-access/idiaenumsectioncontribs.md) interface for an example of obtaining the `IDiaSectionContrib` interface.

## Example

This function shows the address of each section along with any associated symbols. See the [`IDiaEnumSectionContribs`](../../debugger/debug-interface-access/idiaenumsectioncontribs.md) interface to see how the `IDiaSectionContrib` interface is obtained.

```C++
void PrintSectionContrib(IDiaSectionContrib* pSecContrib, IDiaSession* pSession)
{
    if (pSecContrib != NULL && pSession != NULL)
    {
        DWORD rva;
        if ( pSecContrib->get_relativeVirtualAddress( &rva ) == S_OK )
        {
            printf( "\taddr: 0x%.8X", rva );
            pSecContrib = NULL;
            CComPtr<IDiaSymbol> pSym;
            if ( psession->findSymbolByRVA( rva, SymTagNull, &pSym ) == S_OK )
            {
                CDiaBSTR name;
                DWORD    tag;
                pSym->get_symTag( &tag );
                pSym->get_name( &name );
                printf( "     symbol: %ws (%ws)\n",
                        name != NULL ? name : L"",
                        szTags[ tag ] );
            }
            else
            {
                printf( "<no symbol found?>\n" );
            }
        }
        else
        {
            DWORD isect;
            DWORD offset;
            pSecContrib->get_addressSection( &isect );
            pSecContrib->get_addressOffset( &offset );
            printf( "\taddr: 0x%.4X:0x%.8X", isect, offset );
            pSecContrib = NULL;
            CComPtr<IDiaSymbol> pSym;
            if ( SUCCEEDED( psession->findSymbolByAddr(
                                              isect,
                                              offset,
                                              SymTagNull,
                                              &pSym )
                          )
               )
            {
                CDiaBSTR name;
                DWORD    tag;
                pSym->get_symTag( &tag );
                pSym->get_name( &name );
                printf( "     symbol: %ws (%ws)\n",
                    name != NULL ? name : L"",
                    szTags[ tag ] );
            }
            else
            {
                printf( "<no symbol found?>\n" );
            }
        }
    }
}
```

## Requirements

Header: Dia2.h

Library: diaguids.lib

DLL: msdia140.dll

## See also

- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [`IDiaEnumSectionContribs`](../../debugger/debug-interface-access/idiaenumsectioncontribs.md)
- [`IDiaEnumSectionContribs::Item`](../../debugger/debug-interface-access/idiaenumsectioncontribs-item.md)
- [`IDiaEnumSectionContribs::Next`](../../debugger/debug-interface-access/idiaenumsectioncontribs-next.md)
