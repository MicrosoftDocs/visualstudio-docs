---
title: "IDiaStackWalkFrame::put_registerValue | Microsoft Docs"
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
  - "IDiaStackWalkFrame::put_registerValue method"
ms.assetid: 2d8b79b6-7240-43fe-b24e-e4ff3e2c15b0
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaStackWalkFrame::put_registerValue
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Sets the value of a register.  
  
## Syntax  
  
```cpp#  
HRESULT put_registerValue (   
   DWORD     index,  
   ULONGLONG NewVal  
);  
```  
  
#### Parameters  
 `index`  
 [in] A value from the [CV_HREG_e Enumeration](../../debugger/debug-interface-access/cv-hreg-e.md) enumeration specifying the register to write to.  
  
 `NewVal`  
 [in] The new register value.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaStackWalkFrame](../../debugger/debug-interface-access/idiastackwalkframe.md)   
 [CV_HREG_e Enumeration](../../debugger/debug-interface-access/cv-hreg-e.md)



