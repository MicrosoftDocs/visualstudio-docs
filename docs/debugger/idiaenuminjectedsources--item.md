---
title: "IDiaEnumInjectedSources::Item"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumInjectedSources::Item method"
ms.assetid: 14846955-7270-451d-91d2-9cb34bb65187
caps.latest.revision: 7
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# IDiaEnumInjectedSources::Item
Retrieves an injected source by means of an index.  
  
## Syntax  
  
```cpp#  
HRESULT Item (   
   DWORD                index,  
   IDiaInjectedSource** injectedSource  
);  
```  
  
#### Parameters  
 index  
 [in] Index of the [IDiaInjectedSource](../debugger/idiainjectedsource.md) object to be retrieved. The index is the range 0 to `count`-1, where `count` is returned by the [IDiaEnumInjectedSources::get_Count](../debugger/idiaenuminjectedsources--get_count.md) method.  
  
 injectedSource  
 [out] Returns an [IDiaInjectedSource](../debugger/idiainjectedsource.md) object representing the injected source.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumInjectedSources](../debugger/idiaenuminjectedsources.md)   
 [IDiaInjectedSource](../debugger/idiainjectedsource.md)