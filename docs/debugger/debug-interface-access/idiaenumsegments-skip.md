---
title: "IDiaEnumSegments::Skip | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.technology: "vs-ide-debug"
ms.topic: "conceptual"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumSegments::Skip method"
ms.assetid: ec67039f-da8c-4e70-8db7-957d7d5281e8
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload: 
  - "multiple"
---
# IDiaEnumSegments::Skip
Skips a specified number of segments in an enumeration sequence.  
  
## Syntax  
  
```C++  
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