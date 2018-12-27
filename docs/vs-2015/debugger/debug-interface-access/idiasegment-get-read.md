---
title: "IDiaSegment::get_read | Microsoft Docs"
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
  - "IDiaSegment::get_read method"
ms.assetid: aafbc86d-352c-4e1a-911a-1472d2d59212
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: "ghogen"
---
# IDiaSegment::get_read
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves a flag that indicates whether the segment can be read.  
  
## Syntax  
  
```cpp#  
HRESULT get_read (   
   BOOL* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns `TRUE` if the segment can be read; otherwise, returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaSegment](../../debugger/debug-interface-access/idiasegment.md)



