---
title: "IDiaEnumLineNumbers::Clone | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumLineNumbers::Clone method"
ms.assetid: fcd2479a-8ff7-4aba-a737-06123c280d54
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaEnumLineNumbers::Clone
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDiaEnumLineNumbers::Clone](https://docs.microsoft.com/visualstudio/debugger/debug-interface-access/idiaenumlinenumbers-clone).  
  
Creates an enumerator that contains the same enumeration state as the current enumerator.  
  
## Syntax  
  
```cpp#  
HRESULT Clone (   
   IDiaEnumLineNumbers** ppenum  
);  
```  
  
#### Parameters  
 `ppenum`  
 [out] Returns an [IDiaEnumLineNumbers](../../debugger/debug-interface-access/idiaenumlinenumbers.md) object that contains a duplicate of the enumerator. The line numbers are not duplicated, only the enumerator..  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumLineNumbers](../../debugger/debug-interface-access/idiaenumlinenumbers.md)



