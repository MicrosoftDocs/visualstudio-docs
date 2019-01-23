---
title: "UnInit | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: 4cd4fc0b-974a-4e61-9ea8-0aaa1a0c52ea
caps.latest.revision: 7
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# UnInit
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Finalizes the graphics log file, closes it, and frees resources that were used while the app was actively recording graphics information.  
  
## Syntax  
  
```cpp  
void UnInit();  
```  
  
## Remarks  
 `UnInit` is called automatically when an instance of the `VsgDbg` class is destroyed. If the `VsgDbg` instance was not actively recording graphics information, this has no effect.  
  
 After `UnInit` has been called on an instance of the `VsgDbg` class, a new graphics log file can be created by calling `Init` and finalized by calling `UnInit`. You can repeat this as many times as you want to use the same `VsgDbg` instance to create several independent graphics log files.  
  
## See Also  
 [Init](../debugger/init.md)
