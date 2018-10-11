---
title: "IDiaEnumInjectedSources::Clone | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
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
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaEnumInjectedSources::Clone
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

  
Creates an enumerator that contains the same enumeration state as the current enumerator.  
  
## Syntax  
  
```cpp#  
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



