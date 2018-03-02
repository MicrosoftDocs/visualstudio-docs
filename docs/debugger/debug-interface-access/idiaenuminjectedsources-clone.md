---
title: "IDiaEnumInjectedSources::Clone | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumInjectedSources::Clone method"
ms.assetid: 18038691-c140-426a-8617-27f0360650f3
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# IDiaEnumInjectedSources::Clone
Creates an enumerator that contains the same enumeration state as the current enumerator.  
  
## Syntax  
  
```C++  
HRESULT Clone (   
   IDiaEnumInjectedSources** ppenum  
);  
```  
  
#### Parameters  
 `ppenum`  
 [out] Returns an [IDiaEnumInjectedSources](../../debugger/debug-interface-access/idiaenuminjectedsources.md) object that contains a duplicate of the enumerator. The injected sources are not duplicated, only the enumerator.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumInjectedSources](../../debugger/debug-interface-access/idiaenuminjectedsources.md)