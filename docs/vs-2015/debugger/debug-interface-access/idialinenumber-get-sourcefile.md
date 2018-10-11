---
title: "IDiaLineNumber::get_sourceFile | Microsoft Docs"
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
  - "IDiaLineNumber::get_sourceFile method"
ms.assetid: 86fc4411-375e-4b99-8f96-4da2c3f68190
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaLineNumber::get_sourceFile
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDiaLineNumber::get_sourceFile](https://docs.microsoft.com/visualstudio/debugger/debug-interface-access/idialinenumber-get-sourcefile).  
  
Retrieves a reference to the source file.  
  
## Syntax  
  
```cpp#  
HRESULT get_sourceFile (   
   IDiaSourceFile** pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns an [IDiaSourceFile](../../debugger/debug-interface-access/idiasourcefile.md) object that represents the source file.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)   
 [IDiaSourceFile](../../debugger/debug-interface-access/idiasourcefile.md)



