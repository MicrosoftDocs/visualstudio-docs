---
title: "IDiaSegment::get_length | Microsoft Docs"
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
  - "IDiaSegment::get_length method"
ms.assetid: 5d92e394-649b-49f2-bce7-12dd9d666d85
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: "ghogen"
---
# IDiaSegment::get_length
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the number of bytes in the segment.  
  
## Syntax  
  
```cpp#  
HRESULT get_ length (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the number of bytes in the segment.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaSegment](../../debugger/debug-interface-access/idiasegment.md)



