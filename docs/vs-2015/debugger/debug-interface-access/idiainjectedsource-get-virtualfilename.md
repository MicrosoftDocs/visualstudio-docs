---
title: "IDiaInjectedSource::get_virtualFilename | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
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
  - "IDiaInjectedSource::get_virtualFilename method"
ms.assetid: b9977075-8fd1-4b11-bfff-d87e9f2586dc
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaInjectedSource::get_virtualFilename
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the name given to non-file source code; that is, code that was injected.  
  
## Syntax  
  
```cpp#  
HRESULT get_virtualFilename (   
   BSTR* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the name given to injected non-file source code.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaInjectedSource](../../debugger/debug-interface-access/idiainjectedsource.md)



