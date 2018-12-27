---
title: "IDiaSegment::get_execute | Microsoft Docs"
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
  - "IDiaSegment::get_execute method"
ms.assetid: 746cdf8e-9097-415d-ba10-069854153185
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: "ghogen"
---
# IDiaSegment::get_execute
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves a flag that indicates whether the segment is executable.  
  
## Syntax  
  
```cpp#  
HRESULT get_execute (   
   BOOL* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns `TRUE` if the segment is marked as executable; otherwise, returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaSegment](../../debugger/debug-interface-access/idiasegment.md)



