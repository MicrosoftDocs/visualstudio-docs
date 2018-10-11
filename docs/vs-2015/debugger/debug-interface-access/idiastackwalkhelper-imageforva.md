---
title: "IDiaStackWalkHelper::imageForVA | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
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
  - "IDiaStackWalkHelper::imageForVA method"
ms.assetid: 8d4edabf-3c01-4fef-8b61-4779f3371067
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaStackWalkHelper::imageForVA
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDiaStackWalkHelper::imageForVA](https://docs.microsoft.com/visualstudio/debugger/debug-interface-access/idiastackwalkhelper-imageforva).  
  
Returns the start of an executable's image in memory given a virtual address somewhere in the executable's memory space.  
  
## Syntax  
  
```cpp#  
HRESULT imageForVA(  
   ULONGLONG  vaContext,  
   ULONGLONG *pvaImageStart  
);  
```  
  
#### Parameters  
 `vaContext`  
 [in] The virtual address that lies somewhere in the executable's space.  
  
 `pvaImageStart`  
 [out] Returns the starting virtual address of the executable's image.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaStackWalkHelper](../../debugger/debug-interface-access/idiastackwalkhelper.md)



