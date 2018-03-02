---
title: "IDiaEnumSectionContribs::Skip | Microsoft Docs"
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
  - "IDiaEnumSectionContribs::Skip method"
ms.assetid: 7471a178-5134-41b2-80a6-51ff96abe916
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# IDiaEnumSectionContribs::Skip
Skips a specified number of section contributions in an enumeration sequence.  
  
## Syntax  
  
```C++  
HRESULT Skip(   
   ULONG celt  
);  
```  
  
#### Parameters  
 `celt`  
 [in] The number of section contributions in the enumeration sequence to skip.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` if there are no more section contributions to skip.  
  
## See Also  
 [IDiaEnumSectionContribs](../../debugger/debug-interface-access/idiaenumsectioncontribs.md)