---
title: "IDiaSectionContrib::get_nopad | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSectionContrib::get_nopad method"
ms.assetid: f5c08603-0b3e-4e81-acf1-1b95a6a83bed
caps.latest.revision: 9
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSectionContrib::get_nopad
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves a flag indicating whether the section should not be padded to the next memory boundary.  
  
## Syntax  
  
```cpp#  
HRESULT get_nopad(  
   BOOL* pRetVal  
};  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns `TRUE` if the section should not be padded to the next memory boundary; otherwise returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## Remarks  
 This is a property typically seen only on older files.  
  
## See Also  
 [IDiaSectionContrib](../../debugger/debug-interface-access/idiasectioncontrib.md)
