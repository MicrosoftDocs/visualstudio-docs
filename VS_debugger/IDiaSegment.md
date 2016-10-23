---
title: "IDiaSegment"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 384ae0e1-077e-4d4f-98de-ac43c32c882f
caps.latest.revision: 13
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# IDiaSegment
Maps data from the section number to segments of address space.  
  
## Syntax  
  
```  
IDiaSegment : IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaSegment`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaSegment::get_frame](../VS_debugger/IDiaSegment--get_frame.md)|Retrieves the segment number.|  
|[IDiaSegment::get_offset](../VS_debugger/IDiaSegment--get_offset.md)|Retrieves the offset in segments where the section begins.|  
|[IDiaSegment::get_length](../VS_debugger/IDiaSegment--get_length.md)|Retrieves the number of bytes in the segment.|  
|[IDiaSegment::get_read](../VS_debugger/IDiaSegment--get_read.md)|Retrieves a flag that indicates whether the segment can be read.|  
|[IDiaSegment::get_write](../VS_debugger/IDiaSegment--get_write.md)|Retrieves a flag that indicates whether the segment can be modified.|  
|[IDiaSegment::get_execute](../VS_debugger/IDiaSegment--get_execute.md)|Retrieves a flag that indicates whether the segment is executable.|  
|[IDiaSegment::get_addressSection](../VS_debugger/IDiaSegment--get_addressSection.md)|Retrieves the section number that maps to this segment.|  
|[IDiaSegment::get_relativeVirtualAddress](../VS_debugger/IDiaSegment--get_relativeVirtualAddress.md)|Retrieves the relative virtual address (RVA) of the beginning of the section.|  
|[IDiaSegment::get_virtualAddress](../VS_debugger/IDiaSegment--get_virtualAddress.md)|Retrieves the virtual address (VA) of the beginning of the section.|  
  
## Remarks  
 Because the DIA SDK already performs translations from the section offset to relative virtual addresses, most applications will not make use of the information in the segment map.  
  
## Notes for Callers  
 Obtain this interface by calling the [IDiaEnumSegments::Item](../VS_debugger/IDiaEnumSegments--Item.md) or [IDiaEnumSegments::Next](../VS_debugger/IDiaEnumSegments--Next.md) methods. See the example for details.  
  
## Example  
 This function displays the address of all segments in a table and the nearest symbol.  
  
```cpp#  
void ShowSegments(IDiaTable *pTable, IDiaSession *pSession)  
{  
    CComPtr<IDiaEnumSegments> pSegments;  
    if ( SUCCEEDED( pTable->QueryInterface(  
                                _uuidof( IDiaEnumSegments ),  
                               (void**)&pSegments )  
                  )  
       )  
    {  
        CComPtr<IDiaSegment> pSegment;  
        while ( SUCCEEDED( hr = pSegments->Next( 1, &pSegment, &celt ) ) &&  
                celt == 1 )  
        {  
            DWORD rva;  
            DWORD seg;  
  
            pSegment->get_addressSection( &seg );  
            if ( pSegment->get_relativeVirtualAddress( &rva ) == S_OK )  
            {  
                printf( "Segment %i addr: 0x%.8X\n", seg, rva );  
                pSegment = NULL;  
  
                CComPtr<IDiaSymbol> pSym;  
                if ( psession->findSymbolByRVA( rva, SymTagNull, &pSym ) == S_OK )  
                {  
                    CDiaBSTR name;  
                    DWORD    tag;  
  
                    pSym->get_symTag( &tag );  
                    pSym->get_name( &name );  
                    printf( "\tClosest symbol: %ws (%ws)\n",  
                            name != NULL ? name : L"",  
                            szTags[ tag ] );  
                }  
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
 [Interfaces (Debug Interface Access SDK)](../VS_debugger/Interfaces--Debug-Interface-Access-SDK-.md)   
 [IDiaEnumSegments::Item](../VS_debugger/IDiaEnumSegments--Item.md)   
 [IDiaEnumSegments::Next](../VS_debugger/IDiaEnumSegments--Next.md)