---
title: "IDiaLoadCallback2::RestrictOriginalPathAccess | Microsoft Docs"
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
  - "IDiaLoadCallback2::RestrictOriginalPathAccess method"
ms.assetid: 31fde3af-2824-4b0f-8d0d-cee6046596f6
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# IDiaLoadCallback2::RestrictOriginalPathAccess
Determines if it is okay to look for a .pdb file in the original debug directory.  
  
## Syntax  
  
```C++  
HRESULT RestrictOriginalPathAccess ();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Any return code other than `S_OK` prevents looking for a .pdb file in the original debug directory. The original debug directory is the path to the symbol file compiled into the executable when debugging is turned on. This path is not necessarily the same as the path where the executable exists.  
  
## See Also  
 [IDiaLoadCallback2](../../debugger/debug-interface-access/idialoadcallback2.md)