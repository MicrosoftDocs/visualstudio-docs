---
title: "IDiaEnumSegments::Item | Microsoft Docs"
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
  - "IDiaEnumSegments::Item method"
ms.assetid: ee44dd55-39a0-4b7b-97ff-2e1226eeb2bd
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaEnumSegments::Item
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDiaEnumSegments::Item](https://docs.microsoft.com/visualstudio/debugger/debug-interface-access/idiaenumsegments-item).  
  
Retrieves a segment by means of an index.  
  
## Syntax  
  
```cpp#  
HRESULT Item (   
   DWORD         index,  
   IDiaSegment** segment  
);  
```  
  
#### Parameters  
 index  
 [in] Index of the [IDiaSegment](../../debugger/debug-interface-access/idiasegment.md) object to be retrieved. The index is in the range 0 to `count`-1, where `count` is returned by the [IDiaEnumSegments::get_Count](../../debugger/debug-interface-access/idiaenumsegments-get-count.md) method.  
  
 segment  
 [out] Returns an [IDiaSegment](../../debugger/debug-interface-access/idiasegment.md) object representing the desired segment.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumSegments](../../debugger/debug-interface-access/idiaenumsegments.md)   
 [IDiaSegment](../../debugger/debug-interface-access/idiasegment.md)



