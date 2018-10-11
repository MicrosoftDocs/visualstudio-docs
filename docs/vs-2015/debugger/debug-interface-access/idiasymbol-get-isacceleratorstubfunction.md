---
title: "IDiaSymbol::get_isAcceleratorStubFunction | Microsoft Docs"
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
ms.assetid: cc4ea375-76f6-4ba8-baed-c5fa82108137
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaSymbol::get_isAcceleratorStubFunction
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

  
Indicates whether the symbol corresponds to a top-level function symbol for a shader compiled for an accelerator that corresponds to a `parallel_for_each` call.  
  
## Syntax  
  
```cpp  
HRESULT get_isAcceleratorStubFunction(   
   BOOL* pFlag);  
```  
  
#### Parameters  
 `pFlag`  
 [out] A pointer to a `BOOL` that indicates whether the symbol corresponds to a top-level function symbol for a shader compiled for an accelerator that corresponds to a `parallel_for_each` call.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)



