---
title: "IDiaSymbol::get_numberOfModifiers | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
ms.assetid: 61ff7431-1994-4f7e-a182-1817f16f60a9
caps.latest.revision: 6
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSymbol::get_numberOfModifiers
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the number of modifiers that are applied to the original type.  
  
## Syntax  
  
```cpp  
HRESULT get_numberOfModifiers(   
   DWORD* pRetVal);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] A pointer to a `DWORD` that specifies the number of modifiers that are applied to the original type.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
