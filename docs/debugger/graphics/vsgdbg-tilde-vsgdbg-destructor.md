---
title: "VsgDbg::~VsgDbg (Destructor) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 7a3b97fb-d344-4df7-b195-9347d1edfcf7
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# VsgDbg::~VsgDbg (Destructor)
Destroys an instance of the `VsgDbg` class. If graphics information is actively being recorded, the graphics log file is finalized and closed, and the resources that were used while actively capturing graphics information are released.  
  
## Syntax  
  
```C++  
~VsgDbg();  
```  
  
## See Also  
 [VsgDbg::VsgDbg (Constructor)](vsgdbg-vsgdbg-constructor.md)