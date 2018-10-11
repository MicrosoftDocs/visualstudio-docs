---
title: "IDiaSectionContrib::get_compiland | Microsoft Docs"
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
helpviewer_keywords: 
  - "IDiaSectionContrib::get_compiland method"
ms.assetid: c0496f6f-f8f2-435f-8674-6c32db6c5934
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaSectionContrib::get_compiland
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDiaSectionContrib::get_compiland](https://docs.microsoft.com/visualstudio/debugger/debug-interface-access/idiasectioncontrib-get-compiland).  
  
Retrieves a reference to the compiland symbol that contributed this section.  
  
## Syntax  
  
```cpp#  
HRESULT get_compiland (   
   IDiaSymbol** pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns an [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object representing the compiland that contributed this section.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaSectionContrib](../../debugger/debug-interface-access/idiasectioncontrib.md)   
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)



