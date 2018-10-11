---
title: "IDiaFrameData::get_lengthProlog | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
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
  - "IDiaFrameData::get_lengthProlog method"
ms.assetid: 5f042ff1-e74e-430a-be34-d2cf1b18eff2
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaFrameData::get_lengthProlog
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDiaFrameData::get_lengthProlog](https://docs.microsoft.com/visualstudio/debugger/debug-interface-access/idiaframedata-get-lengthprolog).  
  
Retrieves the number of bytes of prologue code in the block.  
  
## Syntax  
  
```cpp#  
HRESULT get_lengthProlog (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the number of bytes of prologue code.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## Remarks  
 The prologue code is a sequence of instructions that preserves registers, sets the CPU state, and establishes the stack for the function.  
  
## See Also  
 [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)



