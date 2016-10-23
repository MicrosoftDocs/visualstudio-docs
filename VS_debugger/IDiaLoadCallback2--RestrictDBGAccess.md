---
title: "IDiaLoadCallback2::RestrictDBGAccess"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 63b67a93-2910-4fff-aa70-6b2eaa08e5c8
caps.latest.revision: 7
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# IDiaLoadCallback2::RestrictDBGAccess
Determines if looking for debug information is allowed from .dbg files.  
  
## Syntax  
  
```cpp#  
HRESULT RestrictDBGAccess();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Any return value other than `S_OK` to prevent looking for debug information from .dbg files.  
  
## See Also  
 [IDiaLoadCallback2](../VS_debugger/IDiaLoadCallback2.md)