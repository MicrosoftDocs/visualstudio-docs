---
title: "IDiaSymbol::get_pure | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSymbol::get_pure method"
ms.assetid: b61107e9-9144-4981-b7ef-58a339b80c58
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSymbol::get_pure
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves a flag that specifies whether the function is pure virtual.  
  
## Syntax  
  
```cpp#  
HRESULT get_pure (   
   BOOL* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns `TRUE` if the function is pure virtual; otherwise, returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
