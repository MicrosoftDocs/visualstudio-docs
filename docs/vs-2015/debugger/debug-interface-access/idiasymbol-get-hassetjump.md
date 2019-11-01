---
title: "IDiaSymbol::get_hasSetJump | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSymbol::get_hasSetJump method"
ms.assetid: 22656206-dccf-40ed-b179-fc016d1b262a
caps.latest.revision: 10
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSymbol::get_hasSetJump
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves a flag that specifies whether the function contains a use of the [setjmp](https://msdn.microsoft.com/library/684a8b27-e8eb-455b-b4a8-733ca1cbd7d2) command (paired with the [longjmp](https://msdn.microsoft.com/library/0e13670a-5130-45c1-ad69-6862505b7a2f) command, these form the C-style method of exception handling).  
  
## Syntax  
  
```cpp  
HRESULT get_hasSetJump(  
   BOOL *pFlag  
);  
```  
  
#### Parameters  
 `pFlag`  
 [out] Returns `TRUE` if the function contains a `setjmp` command; otherwise, returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or error code.  
  
> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.  
  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v8.0|  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)   
 [IDiaSymbol::get_hasLongJump](../../debugger/debug-interface-access/idiasymbol-get-haslongjump.md)   
 [longjmp](https://msdn.microsoft.com/library/0e13670a-5130-45c1-ad69-6862505b7a2f)   
 [setjmp](https://msdn.microsoft.com/library/684a8b27-e8eb-455b-b4a8-733ca1cbd7d2)
