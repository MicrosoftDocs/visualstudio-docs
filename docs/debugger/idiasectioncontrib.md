---
title: "IDiaSectionContrib"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSectionContrib interface"
ms.assetid: 371d40f6-ca0e-4d7e-9210-64d3768996c6
caps.latest.revision: 14
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# IDiaSectionContrib
Retrieves data describing a section contribution, that is, a contiguous block of memory contributed to the image by a compiland.  
  
## Syntax  
  
```  
IDiaSectionContrib : IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaSectionContrib`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaSectionContrib::get_compiland](../debugger/idiasectioncontrib--get_compiland.md)|Retrieves a reference to the compiland symbol that contributed this section.|  
|[IDiaSectionContrib::get_addressSection](../debugger/idiasectioncontrib--get_addresssection.md)|Retrieves the section part of the contribution's address.|  
|[IDiaSectionContrib::get_addressOffset](../debugger/idiasectioncontrib--get_addressoffset.md)|Retrieves the offset part of the contribution's address.|  
|[IDiaSectionContrib::get_relativeVirtualAddress](../debugger/idiasectioncontrib--get_relativevirtualaddress.md)|Retrieves the image relative virtual address (RVA) of the contribution.|  
|[IDiaSectionContrib::get_virtualAddress](../debugger/idiasectioncontrib--get_virtualaddress.md)|Retrieves the virtual address (VA) of the contribution.|  
|[IDiaSectionContrib::get_length](../debugger/idiasectioncontrib--get_length.md)|Retrieves the number of bytes in a section.|  
|[IDiaSectionContrib::get_notPaged](../debugger/idiasectioncontrib--get_notpaged.md)|Retrieves a flag that indicates whether the section cannot be paged out of memory.|  
|[IDiaSectionContrib::get_nopad](../debugger/idiasectioncontrib--get_nopad.md)|Retrieves a flag indicating whether the section should not be padded to the next memory boundary.|  
|[IDiaSectionContrib::get_code](../debugger/idiasectioncontrib--get_code.md)|Retrieves a flag that indicates whether the section contains executable code.|  
|[IDiaSectionContrib::get_code16bit](../debugger/idiasectioncontrib--get_code16bit.md)|Retrieves a flag that indicates whether the section contains 16-bit code.|  
|[IDiaSectionContrib::get_initializedData](../debugger/idiasectioncontrib--get_initializeddata.md)|Retrieves a flag that indicates whether the section contains initialized data.|  
|[IDiaSectionContrib::get_uninitializedData](../debugger/idiasectioncontrib--get_uninitializeddata.md)|Retrieves a flag that indicates whether the section contains uninitialized data.|  
|[IDiaSectionContrib::get_informational](../debugger/idiasectioncontrib--get_informational.md)|Retrieves a flag indicating whether a section contains comments or similar information.|  
|[IDiaSectionContrib::get_remove](../debugger/idiasectioncontrib--get_remove.md)|Retrieves a flag that indicates whether the section is removed before it is made part of the in-memory image.|  
|[IDiaSectionContrib::get_comdat](../debugger/idiasectioncontrib--get_comdat.md)|Retrieves a flag that indicates whether the section is a COMDAT record.|  
|[IDiaSectionContrib::get_discardable](../debugger/idiasectioncontrib--get_discardable.md)|Retrieves a flag that indicates whether the section can be discarded.|  
|[IDiaSectionContrib::get_notCached](../debugger/idiasectioncontrib--get_notcached.md)|Retrieves a flag that indicates whether the section cannot be cached.|  
|[IDiaSectionContrib::get_share](../debugger/idiasectioncontrib--get_share.md)|Retrieves a flag that indicates whether the section can be shared in memory.|  
|[IDiaSectionContrib::get_execute](../debugger/idiasectioncontrib--get_execute.md)|Retrieves a flag that indicates whether the section is executable as code.|  
|[IDiaSectionContrib::get_read](../debugger/idiasectioncontrib--get_read.md)|Retrieves a flag that indicates whether the section can be read.|  
|[IDiaSectionContrib::get_write](../debugger/idiasectioncontrib--get_write.md)|Retrieves a flag that indicates whether the section can be written.|  
|[IDiaSectionContrib::get_dataCrc](../debugger/idiasectioncontrib--get_datacrc.md)|Retrieves the cyclic redundancy check (CRC) of the data in the section.|  
|[IDiaSectionContrib::get_relocationsCrc](../debugger/idiasectioncontrib--get_relocationscrc.md)|Retrieves the CRC of the relocation information for the section.|  
|[IDiaLineNumber::get_compilandId](../debugger/idialinenumber--get_compilandid.md)|Retrieves the compiland identifier for the section.|  
  
## Remarks  
  
## Notes for Callers  
 This interface is obtained by calling the [IDiaEnumSectionContribs::Item](../debugger/idiaenumsectioncontribs--item.md) and [IDiaEnumSectionContribs::Next](../debugger/idiaenumsectioncontribs--next.md) methods. See the [IDiaEnumSectionContribs](../debugger/idiaenumsectioncontribs.md) interface for an example of obtaining the `IDiaSectionContrib` interface.  
  
## Example  
 This function shows the address of each section along with any associated symbols. See the [IDiaEnumSectionContribs](../debugger/idiaenumsectioncontribs.md) interface to see how the `IDiaSectionContrib` interface is obtained.  
  
```cpp#  
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
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../debugger/interfaces--debug-interface-access-sdk-.md)   
 [IDiaEnumSectionContribs](../debugger/idiaenumsectioncontribs.md)   
 [IDiaEnumSectionContribs::Item](../debugger/idiaenumsectioncontribs--item.md)   
 [IDiaEnumSectionContribs::Next](../debugger/idiaenumsectioncontribs--next.md)