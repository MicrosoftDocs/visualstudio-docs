---
title: "Debug Versions of Heap Allocation Functions | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
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
caps.latest.revision: 20
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Debug Versions of Heap Allocation Functions
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The C run-time library contains special Debug versions of the heap allocation functions. These functions have the same names as the Release versions with _dbg appended to them. This topic describes the differences between the Release version of a CRT function and the _dbg version, using `malloc` and `_malloc_dbg` as examples.  
  
 When [_DEBUG](https://msdn.microsoft.com/library/a9901568-4846-4731-a404-399d947e2e7a) is defined, the CRT maps all [malloc](https://msdn.microsoft.com/library/144fcee2-be34-4a03-bb7e-ed6d4b99eea0) calls to [_malloc_dbg](https://msdn.microsoft.com/library/c97eca51-140b-4461-8bd2-28965b49ecdb). Therefore, you do not need to rewrite your code using `_malloc_dbg` instead of `malloc` to receive the benefits while debugging.  
  
 You might want to call `_malloc_dbg` explicitly, however. Calling `_malloc_dbg` explicitly has some added benefits:  
  
- Tracking `_CLIENT_BLOCK` type allocations.  
  
- Storing the source file and line number where the allocation request occurred.  
  
  If you do not want to convert your `malloc` calls to `_malloc_dbg`, you can obtain the source file information by defining [_CRTDBG_MAP_ALLOC](https://msdn.microsoft.com/library/435242b8-caea-4063-b765-4a608200312b), which causes the preprocessor to directly map all calls to `malloc` to `_malloc_dbg` instead of relying on a wrapper around `malloc`.  
  
  To track the separate types of allocations in client blocks, you must call `_malloc_dbg` directly and set the `blockType` parameter to `_CLIENT_BLOCK`.  
  
  When _DEBUG is not defined, calls to `malloc` are not disturbed, calls to `_malloc_dbg` are resolved to `malloc`, the definition of [_CRTDBG_MAP_ALLOC](https://msdn.microsoft.com/library/435242b8-caea-4063-b765-4a608200312b) is ignored, and source file information pertaining to the allocation request is not provided. Because `malloc` does not have a block type parameter, requests for `_CLIENT_BLOCK` types are treated as standard allocations.  
  
## See Also  
 [CRT Debugging Techniques](../debugger/crt-debugging-techniques.md)
