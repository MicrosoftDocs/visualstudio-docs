---
title: "IDiaSymbol::get_lexicalParentId | Microsoft Docs"
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
  - "IDiaSymbol::get_lexicalParentId method"
ms.assetid: 6c0c2874-cc47-4e4f-ad9c-02a18a108d9d
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# IDiaSymbol::get_lexicalParentId
Retrieves the lexical parent identifier of the symbol.  
  
## Syntax  
  
```C++  
HRESULT get_lexicalParentId (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the lexical parent ID of the symbol.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
>  A return value of `S_FALSE` means the property is not available for the symbol.  
  
## Remarks  
 The identifier is a unique value created by the DIA SDK to mark all symbols as unique.  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)