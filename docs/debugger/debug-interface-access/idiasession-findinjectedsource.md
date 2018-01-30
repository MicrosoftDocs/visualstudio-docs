---
title: "IDiaSession::findInjectedSource | Microsoft Docs"
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
  - "IDiaSession::findInjectedSource method"
ms.assetid: 907531b6-1ef8-4153-986d-b72611a1632d
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# IDiaSession::findInjectedSource
Retrieves a list of sources that has been placed into the symbol store by attribute providers or other components of the compilation process.  
  
## Syntax  
  
```C++  
HRESULT findInjectedSource (   
   LPCOLESTR                 srcFile,  
   IDiaEnumInjectedSources** ppResult  
);  
```  
  
#### Parameters  
 srcFile  
 [in] Name of the source file for which to search.  
  
 ppResult  
 [out] Returns an [IDiaEnumInjectedSources](../../debugger/debug-interface-access/idiaenuminjectedsources.md) object that contains a list of all of the injected sources.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumInjectedSources](../../debugger/debug-interface-access/idiaenuminjectedsources.md)   
 [IDiaSession](../../debugger/debug-interface-access/idiasession.md)