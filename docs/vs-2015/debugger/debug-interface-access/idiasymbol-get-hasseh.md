---
title: "IDiaSymbol::get_hasSEH | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSymbol::get_hasSEH method"
ms.assetid: 1a709ded-22c8-464c-97be-eba5e464210c
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSymbol::get_hasSEH
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves a flag that specifies whether the function contains any [Structured Exception Handling (C/C++)](https://msdn.microsoft.com/library/dd3b647d-c269-43a8-aab9-ad1458712976) (for example, __try/\__except blocks).  
  
## Syntax  
  
```cpp#  
HRESULT get_hasSEH(  
   BOOL *pFlag  
);  
```  
  
#### Parameters  
 `pFlag`  
 [out] Returns `TRUE` if the function has any structured exception handling blocks; otherwise, returns `FALSE`.  
  
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
 [Structured Exception Handling (C/C++)](https://msdn.microsoft.com/library/dd3b647d-c269-43a8-aab9-ad1458712976)
