---
title: "IDiaSymbol::get_undecoratedName | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSymbol::get_undecoratedName method"
ms.assetid: e49edf25-a51d-4787-bd5b-2bf5af827c8c
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# IDiaSymbol::get_undecoratedName
Retrieves the undecorated name for a C++ decorated, or linkage, name.  
  
## Syntax  
  
```C++  
HRESULT get_undecoratedName (   
   BSTR* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the undecorated name for a C++ decorated name.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
>  A return value of `S_FALSE` means the property is not available for the symbol.  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)