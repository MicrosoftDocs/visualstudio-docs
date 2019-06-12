---
title: "IDiaSession::getSymbolsByAddr | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSession::getSymbolsByAddr method"
ms.assetid: eafcc757-b488-487d-a063-ad3703ff42e8
caps.latest.revision: 12
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSession::getSymbolsByAddr
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves an enumerator that finds symbols in the order of their addresses.  
  
## Syntax  
  
```cpp#  
HRESULT getSymbolsByAddr(   
   IDiaEnumSymbolsByAddr** ppEnumbyAddr  
);  
```  
  
#### Parameters  
 `ppEnumbyAddr`  
 [out] Returns an [IDiaEnumSymbolsByAddr](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr.md) object. Use this interface to search for symbols in the symbol store by memory location.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaSession](../../debugger/debug-interface-access/idiasession.md)   
 [IDiaEnumSymbolsByAddr](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr.md)
