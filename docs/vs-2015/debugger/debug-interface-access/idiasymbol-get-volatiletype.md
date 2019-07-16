---
title: "IDiaSymbol::get_volatileType | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSymbol::get_volatileType method"
ms.assetid: 19782a4d-40a8-467b-ab7d-58bc4d812309
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSymbol::get_volatileType
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves a flag that specifies whether the user-defined data type (UDT) is volatile.  
  
## Syntax  
  
```cpp#  
HRESULT get_volatileType (   
   BOOL* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns `TRUE` if the UDT is volatile; otherwise, returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.  
  
## Remarks  
 In C++, a UDT can be marked with the `volatile` keyword, indicating that its contents cannot be assumed to exist from one access to the next.  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
