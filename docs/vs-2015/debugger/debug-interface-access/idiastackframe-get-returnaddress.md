---
title: "IDiaStackFrame::get_returnAddress | Microsoft Docs"
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
  - "IDiaStackFrame::get_returnAddress method"
ms.assetid: 0df91981-919f-48ed-9c70-4121567d645b
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaStackFrame::get_returnAddress
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the return address of the frame.  
  
## Syntax  
  
```cpp#  
HRESULT get_returnAddress (   
   ULONGLONG* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the return address of the frame.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if the property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md)



