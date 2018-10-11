---
title: "IDiaSymbol::get_language | Microsoft Docs"
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
  - "IDiaSymbol::get_language method"
ms.assetid: c759ad3c-1c21-4234-869b-86aa3a608a38
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaSymbol::get_language
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDiaSymbol::get_language](https://docs.microsoft.com/visualstudio/debugger/debug-interface-access/idiasymbol-get-language).  
  
Retrieves the language of the source.  
  
## Syntax  
  
```cpp#  
HRESULT get_language (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns a value from the [CV_CFL_LANG Enumeration](../../debugger/debug-interface-access/cv-cfl-lang.md) enumeration that specifies the language of the source.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or error code.  
  
> [!NOTE]
>  A return value of `S_FALSE` means the property is not available for the symbol.  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)   
 [CV_CFL_LANG Enumeration](../../debugger/debug-interface-access/cv-cfl-lang.md)



