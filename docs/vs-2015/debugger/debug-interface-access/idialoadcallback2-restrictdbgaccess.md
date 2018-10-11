---
title: "IDiaLoadCallback2::RestrictDBGAccess | Microsoft Docs"
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
  - "IDiaLoadCallback2::RestrictDBGAccess method"
ms.assetid: 63b67a93-2910-4fff-aa70-6b2eaa08e5c8
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaLoadCallback2::RestrictDBGAccess
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Determines if looking for debug information is allowed from .dbg files.  
  
## Syntax  
  
```cpp#  
HRESULT RestrictDBGAccess();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Any return value other than `S_OK` to prevent looking for debug information from .dbg files.  
  
## See Also  
 [IDiaLoadCallback2](../../debugger/debug-interface-access/idialoadcallback2.md)



