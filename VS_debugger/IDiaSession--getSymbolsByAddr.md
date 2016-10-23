---
title: "IDiaSession::getSymbolsByAddr"
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
ms.assetid: eafcc757-b488-487d-a063-ad3703ff42e8
caps.latest.revision: 9
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
# IDiaSession::getSymbolsByAddr
Retrieves an enumerator that finds symbols in the order of their addresses.  
  
## Syntax  
  
```cpp#  
HRESULT getSymbolsByAddr(   
   IDiaEnumSymbolsByAddr** ppEnumbyAddr  
);  
```  
  
#### Parameters  
 `ppEnumbyAddr`  
 [out] Returns an [IDiaEnumSymbolsByAddr](../VS_debugger/IDiaEnumSymbolsByAddr.md) object. Use this interface to search for symbols in the symbol store by memory location.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaSession](../VS_debugger/IDiaSession.md)   
 [IDiaEnumSymbolsByAddr](../VS_debugger/IDiaEnumSymbolsByAddr.md)