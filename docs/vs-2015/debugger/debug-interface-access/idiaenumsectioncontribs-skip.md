---
title: "IDiaEnumSectionContribs::Skip | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumSectionContribs::Skip method"
ms.assetid: 7471a178-5134-41b2-80a6-51ff96abe916
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaEnumSectionContribs::Skip
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Skips a specified number of section contributions in an enumeration sequence.  
  
## Syntax  
  
```cpp#  
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
