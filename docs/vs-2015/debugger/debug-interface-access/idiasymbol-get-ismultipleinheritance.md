---
title: "IDiaSymbol::get_isMultipleInheritance | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 0aa356a1-5c5c-4ee4-8b48-bae0a2610013
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaSymbol::get_isMultipleInheritance
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Specifies whether the `this` pointer points to a data member with multiple inheritance.  
  
## Syntax  
  
```cpp  
HRESULT get_isMultipleInheritance(   
   BOOL* pRetVal);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] A pointer to a `BOOL` that specifies whether the `this` pointer points to a data member with multiple inheritance.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)



