---
title: "IDiaSectionContrib::get_initializedData | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSectionContrib::get_initializedData method"
ms.assetid: f5c108be-a0cc-408b-9590-b8d44361810c
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSectionContrib::get_initializedData
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves a flag that indicates whether the section contains initialized data.  
  
## Syntax  
  
```cpp#  
HRESULT get_initializedData (   
   BOOL* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns `TRUE` if the section contains initialized data; otherwise, returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaSectionContrib](../../debugger/debug-interface-access/idiasectioncontrib.md)
