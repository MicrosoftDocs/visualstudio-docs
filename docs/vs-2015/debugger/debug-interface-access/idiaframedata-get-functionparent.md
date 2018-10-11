---
title: "IDiaFrameData::get_functionParent | Microsoft Docs"
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
  - "IDiaFrameData::get_functionParent method"
ms.assetid: f00b9ab1-d4da-4818-973a-58f8f0e66769
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaFrameData::get_functionParent
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves a frame data interface for the enclosing function.  
  
## Syntax  
  
```cpp#  
HRESULT get_functionParent (   
   IDiaFrameData** pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns an [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md) object for the enclosing function.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)



