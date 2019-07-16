---
title: "IDiaSession::symsAreEquiv | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSession::symsAreEquiv method"
ms.assetid: 9941d520-e203-46c0-83c3-b3a967f4fc59
caps.latest.revision: 12
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSession::symsAreEquiv
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Checks to see if two symbols are equivalent.  
  
## Syntax  
  
```cpp#  
HRESULT symsAreEquiv (   
   IDiaSymbol* symbolA,  
   IDiaSymbol* symbolB  
);  
```  
  
#### Parameters  
 `symbolA`  
 [in] The first [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object used in the comparison.  
  
 `symbolB`  
 [in] The second `IDiaSymbol` object used in the comparison.  
  
## Return Value  
 If the symbols are equivalent, returns `S_OK`; otherwise, returns `S_FALSE`, the symbols are not equivalent. Otherwise, return an error code.  
  
## See Also  
 [IDiaSession](../../debugger/debug-interface-access/idiasession.md)   
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
