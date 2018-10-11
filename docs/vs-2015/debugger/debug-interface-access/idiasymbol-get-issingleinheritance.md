---
title: "IDiaSymbol::get_isSingleInheritance | Microsoft Docs"
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
ms.assetid: 46cde656-059b-4c20-9476-3ca68ccc9912
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaSymbol::get_isSingleInheritance
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDiaSymbol::get_isSingleInheritance](https://docs.microsoft.com/visualstudio/debugger/debug-interface-access/idiasymbol-get-issingleinheritance).  
  
Specifies whether the `this` pointer points to a data member with single inheritance.  
  
## Syntax  
  
```cpp  
HRESULT get_isSingleInheritance(   
   BOOL* pRetVal);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] A pointer to a `BOOL` that specifies whether the `this` pointer points to a data member with single inheritance.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)



