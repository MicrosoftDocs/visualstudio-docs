---
title: "Debug Versions of Heap Allocation Functions"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.debug.crt"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "C++"
helpviewer_keywords: 
  - "_CRTDBG_MAP_ALLOC macro"
  - "debugging [CRT], heap allocation functions"
  - "debugging memory leaks, CRT debug library functions"
  - "malloc function"
  - "memory leaks, CRT debug library functions"
  - "heap allocation, debug"
  - "_malloc_dbg function"
ms.assetid: 91748bdc-f4cd-4d8b-ab98-0493dab7ed0d
caps.latest.revision: 17
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Debug Versions of Heap Allocation Functions
The C run-time library contains special Debug versions of the heap allocation functions. These functions have the same names as the Release versions with _dbg appended to them. This topic describes the differences between the Release version of a CRT function and the _dbg version, using `malloc` and `_malloc_dbg` as examples.  
  
 When [_DEBUG](../Topic/_DEBUG.md) is defined, the CRT maps all [malloc](../Topic/malloc.md) calls to [_malloc_dbg](../Topic/_malloc_dbg.md). Therefore, you do not need to rewrite your code using `_malloc_dbg` instead of `malloc` to receive the benefits while debugging.  
  
 You might want to call `_malloc_dbg` explicitly, however. Calling `_malloc_dbg` explicitly has some added benefits:  
  
-   Tracking `_CLIENT_BLOCK` type allocations.  
  
-   Storing the source file and line number where the allocation request occurred.  
  
 If you do not want to convert your `malloc` calls to `_malloc_dbg`, you can obtain the source file information by defining [_CRTDBG_MAP_ALLOC](../Topic/_CRTDBG_MAP_ALLOC.md), which causes the preprocessor to directly map all calls to `malloc` to `_malloc_dbg` instead of relying on a wrapper around `malloc`.  
  
 To track the separate types of allocations in client blocks, you must call `_malloc_dbg` directly and set the `blockType` parameter to `_CLIENT_BLOCK`.  
  
 When _DEBUG is not defined, calls to `malloc` are not disturbed, calls to `_malloc_dbg` are resolved to `malloc`, the definition of [_CRTDBG_MAP_ALLOC](../Topic/_CRTDBG_MAP_ALLOC.md) is ignored, and source file information pertaining to the allocation request is not provided. Because `malloc` does not have a block type parameter, requests for `_CLIENT_BLOCK` types are treated as standard allocations.  
  
## See Also  
 [CRT Debugging Techniques](../debugger/crt-debugging-techniques.md)