---
title: "IDiaSymbol::get_isPointerBasedOnSymbolValue | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 577c8011-9269-4373-8577-b4822a983724
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaSymbol::get_isPointerBasedOnSymbolValue
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDiaSymbol::get_isPointerBasedOnSymbolValue](https://docs.microsoft.com/visualstudio/debugger/debug-interface-access/idiasymbol-get-ispointerbasedonsymbolvalue).  
  
Specifies whether the `this` pointer is based on a symbol value.  
  
## Syntax  
  
```cpp  
HRESULT get_isPointerBasedOnSymbolValue(   
   BOOL* pRetVal);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] A pointer to a `BOOL` that specifies whether the `this` pointer is based on a symbol value.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)



