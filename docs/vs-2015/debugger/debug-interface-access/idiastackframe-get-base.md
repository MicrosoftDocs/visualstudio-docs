---
title: "IDiaStackFrame::get_base | Microsoft Docs"
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
  - "IDiaStackFrame::get_base method"
ms.assetid: f27477d7-26fe-4c1c-a08a-c52cb20c8293
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaStackFrame::get_base
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the base address of the frame.  
  
## Syntax  
  
```cpp#  
HRESULT get_base (   
   ULONGLONG* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the base address.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if the property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md)



