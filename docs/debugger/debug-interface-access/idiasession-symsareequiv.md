---
title: "IDiaSession::symsAreEquiv | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSession::symsAreEquiv method"
ms.assetid: 9941d520-e203-46c0-83c3-b3a967f4fc59
caps.latest.revision: 9
author: "mikejo5000"
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
# IDiaSession::symsAreEquiv
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