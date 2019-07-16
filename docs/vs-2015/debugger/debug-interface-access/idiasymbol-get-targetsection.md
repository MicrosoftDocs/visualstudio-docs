---
title: "IDiaSymbol::get_targetSection | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSymbol::get_targetSection method"
ms.assetid: 95382395-da41-4aa8-87f1-5b03da128565
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSymbol::get_targetSection
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the address section of a thunk target.  
  
## Syntax  
  
```cpp#  
HRESULT get_targetSection (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Section part of a thunk target address.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
