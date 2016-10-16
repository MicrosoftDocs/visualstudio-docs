---
title: "IDiaEnumLineNumbers::Item"
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
  - "IDiaEnumLineNumbers::Item method"
ms.assetid: 08efbeaf-22f7-49e9-96a8-bb906dfe4fd8
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
# IDiaEnumLineNumbers::Item
Retrieves a line number by means of an index.  
  
## Syntax  
  
```cpp#  
HRESULT Item (   
   DWORD            index,  
   IDiaLineNumber** lineNumber  
);  
```  
  
#### Parameters  
 index  
 [in] Index of the [IDiaLineNumber](../debugger/idialinenumber.md) object to be retrieved. The index is in the range 0 to `count`-1, where `count` is returned by the [IDiaEnumLineNumbers::get_Count](../debugger/idiaenumlinenumbers--get_count.md) method.  
  
 lineNumber  
 [out] Returns an [IDiaLineNumber](../debugger/idialinenumber.md) object representing the desired line number.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumLineNumbers](../debugger/idiaenumlinenumbers.md)   
 [IDiaLineNumber](../debugger/idialinenumber.md)