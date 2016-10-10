---
title: "IDiaEnumSymbolsByAddr"
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
ms.assetid: 37d3dcdf-e4fa-4354-b5e1-8843566b52ac
caps.latest.revision: 10
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
# IDiaEnumSymbolsByAddr
Enumerates by address the various symbols contained in the data source.  
  
## Syntax  
  
```  
IDiaEnumSymbolsByAddr : IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaEnumSymbolsByAddr`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaEnumSymbolsByAddr::symbolByAddr](../VS_debugger/IDiaEnumSymbolsByAddr--symbolByAddr.md)|Positions the enumerator by performing a lookup by section and offset.|  
|[IDiaEnumSymbolsByAddr::symbolByRVA](../VS_debugger/IDiaEnumSymbolsByAddr--symbolByRVA.md)|Positions the enumerator by performing a lookup by relative virtual address (RVA).|  
|[IDiaEnumSymbolsByAddr::symbolByVA](../VS_debugger/IDiaEnumSymbolsByAddr--symbolByVA.md)|Positions the enumerator by performing a lookup by virtual address (VA).|  
|[IDiaEnumSymbolsByAddr::Next](../VS_debugger/IDiaEnumSymbolsByAddr--Next.md)|Retrieves the next symbols in order by address. Updates the enumerator position by number of elements fetched.|  
|[IDiaEnumSymbolsByAddr::Prev](../VS_debugger/IDiaEnumSymbolsByAddr--Prev.md)|Retrieves the previous symbols in order by address. Updates the enumerator position by number of elements fetched.|  
|[IDiaEnumSymbolsByAddr::Clone](../VS_debugger/IDiaEnumSymbolsByAddr--Clone.md)|Makes a copy of an object.|  
  
## Remarks  
 This interface provides symbols grouped by address. To work with symbols grouped by type, for example `SymTagUDT` (user-defined type) or `SymTagBaseClass`, use the [IDiaEnumSymbols](../VS_debugger/IDiaEnumSymbols.md) interface.  
  
## Notes for Callers  
 Obtain this interface by calling the [IDiaSession::getSymbolsByAddr](../VS_debugger/IDiaSession--getSymbolsByAddr.md) method.  
  
## Example  
 This function displays the name and address of all symbols ordered by relative virtual address.  
  
```cpp#  
void ShowSymbolsByAddress(IDiaSession *pSession)  
{  
    CComPtr<IDiaEnumSymbolsByAddr> pEnumByAddr;  
    if ( FAILED( psession->getSymbolsByAddr( &pEnumByAddr ) ) )  
    {  
        Fatal( "getSymbolsByAddr" );  
    }  
    CComPtr<IDiaSymbol> pSym;  
    if ( FAILED( pEnumByAddr->symbolByAddr( 1, 0, &pSym ) ) )  
    {  
        Fatal( "symbolByAddr" );  
    }  
    DWORD rvaLast = 0;  
    if ( pSym->get_relativeVirtualAddress( &rvaLast ) == S_OK )  
    {  
        pSym = 0;  
        if ( FAILED( pEnumByAddr->symbolByRVA( rvaLast, &pSym ) ) )  
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
            if ( FAILED( hr = pEnumByAddr->Next( 1, &pSym, &celt ) ) )  
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
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../VS_debugger/Interfaces--Debug-Interface-Access-SDK-.md)   
 [IDiaSession::getSymbolsByAddr](../VS_debugger/IDiaSession--getSymbolsByAddr.md)   
 [IDiaEnumSymbols](../VS_debugger/IDiaEnumSymbols.md)