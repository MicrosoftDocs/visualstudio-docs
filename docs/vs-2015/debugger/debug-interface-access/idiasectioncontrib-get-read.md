---
title: "IDiaSectionContrib::get_read | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSectionContrib::get_read method"
ms.assetid: 68bfb35c-eabd-412a-bc8f-3094703b98c4
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSectionContrib::get_read
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves a flag that indicates whether the section can be read.  
  
## Syntax  
  
```cpp#  
HRESULT get_read (   
   BOOL* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns `TRUE` if the section can be read; otherwise, returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaSectionContrib](../../debugger/debug-interface-access/idiasectioncontrib.md)
