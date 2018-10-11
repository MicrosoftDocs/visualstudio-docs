---
title: "IDiaEnumSegments::Skip | Microsoft Docs"
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
  - "IDiaEnumSegments::Skip method"
ms.assetid: ec67039f-da8c-4e70-8db7-957d7d5281e8
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaEnumSegments::Skip
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Skips a specified number of segments in an enumeration sequence.  
  
## Syntax  
  
```cpp#  
HRESULT Skip (   
   ULONG celt  
);  
```  
  
#### Parameters  
 celt  
 [in] The number of segments in the enumeration sequence to skip.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` if there are no more segments to skip.  
  
## See Also  
 [IDiaEnumSegments](../../debugger/debug-interface-access/idiaenumsegments.md)



