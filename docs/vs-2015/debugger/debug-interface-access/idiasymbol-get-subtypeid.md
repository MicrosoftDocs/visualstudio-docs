---
title: "IDiaSymbol::get_subTypeId | Microsoft Docs"
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
ms.assetid: 0f899920-4fc5-4de8-84a3-cd98c57bf124
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaSymbol::get_subTypeId
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the sub type ID.  
  
## Syntax  
  
```cpp  
HRESULT get_subTypeId(   
   DWORD* pRetVal);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] A pointer to a `DWORD` that holds the sub type ID.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)



