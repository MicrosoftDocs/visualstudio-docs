---
title: "IDiaSymbol::get_interruptReturn | Microsoft Docs"
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
  - "IDiaSymbol::get_interruptReturn method"
ms.assetid: 9665da6c-4cc0-41d7-b2e2-0d9e50174cf8
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaSymbol::get_interruptReturn
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDiaSymbol::get_interruptReturn](https://docs.microsoft.com/visualstudio/debugger/debug-interface-access/idiasymbol-get-interruptreturn).  
  
Retrieves a flag that specifies whether the function contains a return from interrupt instruction (for example, the X86 assembly code `iret`).  
  
## Syntax  
  
```cpp  
HRESULT get_interruptReturn(  
   BOOL *pFlag  
);  
```  
  
#### Parameters  
 `pFlag`  
 [out] Returns `TRUE` if the function has a return from interrupt instruction; otherwise, returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
>  A return value of `S_FALSE` means that the property is not available for the symbol.  
  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v8.0|  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)



