---
title: "IDiaEnumSourceFiles::Skip | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumSourceFiles::Skip method"
ms.assetid: 4821e6dd-d33f-403d-857d-e3ae81e4a9e3
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# IDiaEnumSourceFiles::Skip
Skips a specified number of source files in an enumeration sequence.  
  
## Syntax  
  
```C++  
HRESULT Skip (   
   ULONG celt  
);  
```  
  
#### Parameters  
 celt  
 [in] The number of source files in the enumeration sequence to skip.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` if there are no more source files to skip.  
  
## See Also  
 [IDiaEnumSourceFiles](../../debugger/debug-interface-access/idiaenumsourcefiles.md)