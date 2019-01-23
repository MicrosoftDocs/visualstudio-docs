---
title: "IDiaStackFrame::get_allocatesBasePointer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaStackFrame::get_allocatesBasePointer"
ms.assetid: a91e9c8e-c5e3-4887-a60b-f03b5a98f30c
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaStackFrame::get_allocatesBasePointer
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves a flag that indicates whether the base pointer is allocated for code in this address range.  
  
## Syntax  
  
```cpp#  
HRESULT get_allocatesBasePointer (   
   BOOL* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns `TRUE` if a base pointer is allocated for code in this frame; otherwise, returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if the property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md)
