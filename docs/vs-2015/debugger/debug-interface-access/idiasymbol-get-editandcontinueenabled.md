---
title: "IDiaSymbol::get_editAndContinueEnabled | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSymbol::get_editAndContinueEnabled method"
ms.assetid: cd703c64-9ff8-4654-8493-8cde9309cb22
caps.latest.revision: 12
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSymbol::get_editAndContinueEnabled
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves a flag indicating whether the module was compiled with the [/Z7, /Zi, /ZI (Debug Information Format)](https://msdn.microsoft.com/library/ce9fa7e1-0c9b-47e3-98ea-26d1a16257c8) compiler switch.  
  
## Syntax  
  
```cpp#  
HRESULT get_editAndContinueEnabled (   
   BOOL* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns `TRUE` if edit-and-continue was enabled at compilation; otherwise, returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.  
  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v7.0|  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)   
 [/Z7, /Zi, /ZI (Debug Information Format)](https://msdn.microsoft.com/library/ce9fa7e1-0c9b-47e3-98ea-26d1a16257c8)
