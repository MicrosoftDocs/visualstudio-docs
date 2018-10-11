---
title: "IDiaStackWalkHelper::put_registerValue | Microsoft Docs"
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
  - "IDiaStackWalkHelper2::put_registerValue method"
ms.assetid: 8f02ce54-ef59-455f-8aa6-dc26761c7aff
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaStackWalkHelper::put_registerValue
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
  
## Remarks  
 Despite the size of the value, an implementation should store only what the register normally holds. For example, an 8-bit register would hold only the lowest 8-bits of the given value.  
  
## See Also  
 [IDiaStackWalkHelper](../../debugger/debug-interface-access/idiastackwalkhelper.md)   
 [CV_HREG_e Enumeration](../../debugger/debug-interface-access/cv-hreg-e.md)



