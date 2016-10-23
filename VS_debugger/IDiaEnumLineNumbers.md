---
title: "IDiaEnumLineNumbers"
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
ms.assetid: cdf07b4f-19e4-4dcd-8af8-c2dbca586a7c
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
# IDiaEnumLineNumbers
Enumerates the various line numbers contained in the data source.  
  
## Syntax  
  
```  
IDiaEnumLineNumbers : IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaEnumLineNumbers`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaEnumLineNumbers::get__NewEnum](../VS_debugger/IDiaEnumLineNumbers--get__NewEnum.md)|Retrieves the [IEnumVARIANT Interface](assetId:///139e3c93-faef-4003-9079-e0e94494db3e) version of this enumerator.|  
|[IDiaEnumLineNumbers::get_Count](../VS_debugger/IDiaEnumLineNumbers--get_Count.md)|Retrieves the number of line numbers.|  
|[IDiaEnumLineNumbers::Item](../VS_debugger/IDiaEnumLineNumbers--Item.md)|Retrieves a line number by means of an index.|  
|[IDiaEnumLineNumbers::Next](../VS_debugger/IDiaEnumLineNumbers--Next.md)|Retrieves a specified number of line numbers in the enumeration sequence.|  
|[IDiaEnumLineNumbers::Skip](../VS_debugger/IDiaEnumLineNumbers--Skip.md)|Skips a specified number of line numbers in an enumeration sequence.|  
|[IDiaEnumLineNumbers::Reset](../VS_debugger/IDiaEnumLineNumbers--Reset.md)|Resets an enumeration sequence to the beginning.|  
|[IDiaEnumLineNumbers::Clone](../VS_debugger/IDiaEnumLineNumbers--Clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
  
## Remarks  
  
## Notes for Callers  
 This interface is obtained by calling one of the following methods in the [IDiaSession](../VS_debugger/IDiaSession.md) interface:  
  
-   [IDiaSession::findLines](../VS_debugger/IDiaSession--findLines.md)  
  
-   [IDiaSession::findLinesByAddr](../VS_debugger/IDiaSession--findLinesByAddr.md)  
  
-   [IDiaSession::findLinesByRVA](../VS_debugger/IDiaSession--findLinesByRVA.md)  
  
-   [IDiaSession::findLinesByVA](../VS_debugger/IDiaSession--findLinesByVA.md)  
  
-   [IDiaSession::findLinesByLinenum](../VS_debugger/IDiaSession--findLinesByLinenum.md)  
  
## Example  
 This example shows how to obtain the `IDiaEnumLineNumbers` interface from a session. In this case, the example shows how to get the line number enumeration for a function (represented by `pSymbol`). For a more complete example of using line numbers, see the [IDiaLineNumber](../VS_debugger/IDiaLineNumber.md) interface.  
  
```cpp#  
void dumpFunctionLines( IDiaSymbol* pSymbol, IDiaSession* pSession )  
{  
    ULONGLONG length = 0;  
    DWORD isect = 0;  
    DWORD offset = 0;  
    pSymbol->get_addressSection( &isect );  
    pSymbol->get_addressOffset( &offset );  
    pSymbol->get_length( &length );  
    if ( isect != 0 && length > 0 )  
    {  
        CComPtr< IDiaEnumLineNumbers > pLines;  
        if ( SUCCEEDED( pSession->findLinesByAddr(  
                                      isect,  
                                      offset,  
                                      static_cast<DWORD>( length ),  
                                      &pLines )  
                      )  
           )  
        {  
            // Do something with the enumeration  
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
 [IDiaSession](../VS_debugger/IDiaSession.md)   
 [IDiaSession::findLinesByLinenum](../VS_debugger/IDiaSession--findLinesByLinenum.md)   
 [IDiaSession::findLinesByRVA](../VS_debugger/IDiaSession--findLinesByRVA.md)   
 [IDiaSession::findLinesByVA](../VS_debugger/IDiaSession--findLinesByVA.md)   
 [IDiaSession::findLines](../VS_debugger/IDiaSession--findLines.md)   
 [IDiaSession::findLinesByAddr](../VS_debugger/IDiaSession--findLinesByAddr.md)