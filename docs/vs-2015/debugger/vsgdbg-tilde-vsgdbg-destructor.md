---
title: "VsgDbg::~VsgDbg (Destructor) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: 7a3b97fb-d344-4df7-b195-9347d1edfcf7
caps.latest.revision: 7
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# VsgDbg::~VsgDbg (Destructor)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Destroys an instance of the `VsgDbg` class. If graphics information is actively being recorded, the graphics log file is finalized and closed, and the resources that were used while actively capturing graphics information are released.  
  
## Syntax  
  
```cpp  
~VsgDbg();  
```  
  
## See Also  
 [VsgDbg::VsgDbg (Constructor)](../debugger/vsgdbg-vsgdbg-constructor.md)
