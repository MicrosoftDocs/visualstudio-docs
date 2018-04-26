---
title: "IDiaSymbol::get_symbolsFileName | Microsoft Docs"
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
helpviewer_keywords: 
  - "IDiaSymbol::get_symbolsFileName method"
ms.assetid: c1aa39ee-d645-431e-bf5f-0640c0998934
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaSymbol::get_symbolsFileName
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDiaSymbol::get_symbolsFileName](https://docs.microsoft.com/visualstudio/debugger/debug-interface-access/idiasymbol-get-symbolsfilename).  
  
Retrieves the name of the file from which the symbols were loaded.  
  
## Syntax  
  
```cpp#  
HRESULT get_symbolsFileName (   
   BSTR* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the name of the file from which the symbols were loaded.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
>  A return value of `S_FALSE` means the property is not available for the symbol.  
  
## Remarks  
 This property is valid only for symbols with a [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) value of `SymTagExe` that also have global scope.  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)   
 [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md)



