---
title: "IDiaSymbol::get_signature | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSymbol::get_signature method"
ms.assetid: 0efefa39-49a5-4282-9d41-e50832d927e0
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSymbol::get_signature
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the symbol's signature value.  
  
## Syntax  
  
```cpp#  
HRESULT get_signature (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the symbol's signature value.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
