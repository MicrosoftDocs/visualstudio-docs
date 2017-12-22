---
title: "UnInit | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 4cd4fc0b-974a-4e61-9ea8-0aaa1a0c52ea
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# UnInit
Finalizes the graphics log file, closes it, and frees resources that were used while the app was actively recording graphics information.  
  
## Syntax  
  
```C++  
void UnInit();  
```  
  
## Remarks  
 `UnInit` is called automatically when an instance of the `VsgDbg` class is destroyed. If the `VsgDbg` instance was not actively recording graphics information, this has no effect.  
  
 After `UnInit` has been called on an instance of the `VsgDbg` class, a new graphics log file can be created by calling `Init` and finalized by calling `UnInit`. You can repeat this as many times as you want to use the same `VsgDbg` instance to create several independent graphics log files.  
  
## See Also  
 [Init](init.md)