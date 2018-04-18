---
title: "IDiaEnumSymbols::Clone | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.technology: "vs-ide-debug"
ms.topic: "conceptual"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumSymbols::Clone method"
ms.assetid: 5c542025-98cf-4307-901f-b9430f780cf0
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload: 
  - "multiple"
---
# IDiaEnumSymbols::Clone
Creates an enumerator that contains the same enumeration state as the current enumerator.  
  
## Syntax  
  
```C++  
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