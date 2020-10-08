---
title: "IDiaSession::findSymbolByToken | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSession::findSymbolByToken method"
ms.assetid: 3c92149c-6eef-454f-86be-66e89557b9e6
caps.latest.revision: 12
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSession::findSymbolByToken
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the symbol that contains a specified metadata token.  
  
## Syntax  
  
```cpp#  
HRESULT findSymbolByToken (   
   ULONG        token,  
   SymTagEnum   symtag,  
   IDiaSymbol** ppSymbol  
);  
```  
  
#### Parameters  
 `token`  
 [in] Specifies the token.  
  
 `symtag`  
 [in] Symbol type to be found. Values are taken from the [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) enumeration.  
  
 `ppSymbol`  
 [out] Returns an [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object that represents the symbol retrieved.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Example  
  
```cpp#  
IDiaSymbol* pFunc;  
pSession->findSymbolByToken( token, SymTagFunction, &pFunc );  
```  
  
## See Also  
 [IDiaSession](../../debugger/debug-interface-access/idiasession.md)   
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)   
 [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md)
