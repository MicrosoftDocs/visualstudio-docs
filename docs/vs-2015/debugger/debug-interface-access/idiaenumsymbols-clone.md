---
title: "IDiaEnumSymbols::Clone | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumSymbols::Clone method"
ms.assetid: 5c542025-98cf-4307-901f-b9430f780cf0
caps.latest.revision: 10
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaEnumSymbols::Clone
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Creates an enumerator that contains the same enumeration state as the current enumerator.  
  
## Syntax  
  
```cpp#  
HRESULT Clone (   
   IDiaEnumSymbols** ppenum  
);  
```  
  
#### Parameters  
 ppenum  
 [out] Returns an [IDiaEnumSymbols](../../debugger/debug-interface-access/idiaenumsymbols.md) object that contains a duplicate of the enumerator. The symbols are not duplicated, only the enumerator.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumSymbols](../../debugger/debug-interface-access/idiaenumsymbols.md)
