---
title: "IDiaEnumSourceFiles::Skip | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumSourceFiles::Skip method"
ms.assetid: 4821e6dd-d33f-403d-857d-e3ae81e4a9e3
caps.latest.revision: 10
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaEnumSourceFiles::Skip
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Skips a specified number of source files in an enumeration sequence.  
  
## Syntax  
  
```cpp#  
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
