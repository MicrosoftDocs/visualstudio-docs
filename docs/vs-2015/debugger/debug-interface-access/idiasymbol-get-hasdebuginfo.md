---
title: "IDiaSymbol::get_hasDebugInfo | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSymbol::get_hasDebugInfo method"
ms.assetid: 84cd2b67-0d83-4589-9ecb-a4bcbeed55f5
caps.latest.revision: 10
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSymbol::get_hasDebugInfo
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves a flag that specifies if the [Compiland](../../debugger/debug-interface-access/compiland.md) contains debugging information.  
  
## Syntax  
  
```cpp  
HRESULT get_hasDebugInfo(  
   BOOL *pFlag  
);  
```  
  
#### Parameters  
 `pFlag`  
 [out] Returns `TRUE` if the compiland contains debugging information; otherwise, returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.  
  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v8.0|  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
