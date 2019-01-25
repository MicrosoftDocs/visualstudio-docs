---
title: "IDiaStackFrame::get_maxStack | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaStackFrame::get_maxStack method"
ms.assetid: 6352e972-7105-4d0e-aeba-b8fc16d62dec
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaStackFrame::get_maxStack
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the maximum number of bytes pushed on the stack in the frame.  
  
## Syntax  
  
```cpp#  
HRESULT get_maxStack (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the maximum number of bytes pushed on the stack.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if the property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md)
