---
title: "IDiaEnumStackFrames::Next"
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
  - "IDiaEnumStackFrames::Next method"
ms.assetid: 09378a21-d5e3-4213-b7e2-10f04d85295f
caps.latest.revision: 8
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
# IDiaEnumStackFrames::Next
Retrieves a specified number of stack frame elements from the enumeration sequence.  
  
## Syntax  
  
```cpp#  
HRESULT Next(   
   ULONG             celt,  
   IDiaStackFrame**  rgelt,  
   ULONG*            pceltFetched  
);  
```  
  
#### Parameters  
 celt  
 [in] The number of stackframe elements in the enumerator to be retrieved.  
  
 rgelt  
 [out] An array that is to be filled in with the requested [IDiaStackFrame](../debugger/idiastackframe.md) objects.  
  
 pceltFetched  
 [out] Returns the number of stack frame elements in the fetched enumerator.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if there are no more stack frames. Otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumStackFrames](../debugger/idiaenumstackframes.md)   
 [IDiaStackFrame](../debugger/idiastackframe.md)