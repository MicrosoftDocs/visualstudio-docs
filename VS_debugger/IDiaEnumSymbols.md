---
title: "IDiaEnumSymbols"
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
ms.assetid: 649f7bfd-86ac-49a5-8533-aff77e1bc62e
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
# IDiaEnumSymbols
Enumerates the various symbols contained in the data source.  
  
## Syntax  
  
```  
IDiaEnumSymbols : IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaEnumSymbols`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaEnumSymbols::get__NewEnum](../VS_debugger/IDiaEnumSymbols--get__NewEnum.md)|Retrieves the `IEnumVARIANT Interface` version of this enumerator.|  
|[IDiaEnumSymbols::get_Count](../VS_debugger/IDiaEnumSymbols--get_Count.md)|Retrieves the number of symbols.|  
|[IDiaEnumSymbols::Item](../VS_debugger/IDiaEnumSymbols--Item.md)|Retrieves a symbol by means of an index.|  
|[IDiaEnumSymbols::Next](../VS_debugger/IDiaEnumSymbols--Next.md)|Retrieves a specified number of symbols in the enumeration sequence.|  
|[IDiaEnumSymbols::Skip](../VS_debugger/IDiaEnumSymbols--Skip.md)|Skips a specified number of symbols in an enumeration sequence.|  
|[IDiaEnumSymbols::Reset](../VS_debugger/IDiaEnumSymbols--Reset.md)|Resets an enumeration sequence to the beginning.|  
|[IDiaEnumSymbols::Clone](../VS_debugger/IDiaEnumSymbols--Clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
  
## Remarks  
 This interface provides symbols grouped by a specific type of symbol, for example, `SymTagUDT` (user-defined types) or `SymTagBaseClass`. To work with symbols grouped by address, use the [IDiaEnumSymbolsByAddr](../VS_debugger/IDiaEnumSymbolsByAddr.md) interface.  
  
## Notes for Callers  
 Obtain this interface by calling the following methods:  
  
-   [IDiaSession::findChildren](../VS_debugger/IDiaSession--findChildren.md)  
  
-   [IDiaSymbol::findChildren](../VS_debugger/IDiaSymbol--findChildren.md)  
  
-   [IDiaSourceFile::get_compilands](../VS_debugger/IDiaSourceFile--get_compilands.md)  
  
## Example  
 This example shows how to obtain the `IDiaEnumSymbols` interface and then use that enumeration to list user-defined types (UDTs).  
  
> [!NOTE]
>  `CDiaBSTR` is a class that wraps a `BSTR` and automatically handles freeing the string when the instantiation goes out of scope.  
  
```cpp#  
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
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../VS_debugger/Interfaces--Debug-Interface-Access-SDK-.md)   
 [IDiaSession::findChildren](../VS_debugger/IDiaSession--findChildren.md)   
 [IDiaSourceFile::get_compilands](../VS_debugger/IDiaSourceFile--get_compilands.md)   
 [IDiaSymbol::findChildren](../VS_debugger/IDiaSymbol--findChildren.md)