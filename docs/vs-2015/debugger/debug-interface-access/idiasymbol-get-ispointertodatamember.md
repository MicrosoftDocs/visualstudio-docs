---
title: "IDiaSymbol::get_isPointerToDataMember | Microsoft Docs"
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
ms.assetid: ef17c737-242e-43e8-b7e1-2c3bc58cfcef
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaSymbol::get_isPointerToDataMember
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Specifies whether this symbol is a pointer to a data member.  
  
## Syntax  
  
```cpp  
HRESULT get_isPointerToDataMember(   
   BOOL* pRetVal);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] A pointer to a `BOOL` that specifies whether this symbol is a pointer to a data member.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)



