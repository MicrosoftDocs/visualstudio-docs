---
title: "Allocation Hook Functions | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug.hooks"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "C++"
helpviewer_keywords: 
  - "memory allocation, logging allocation information"
  - "insufficient memory"
  - "debugging [C++], hook functions"
  - "_CrtSetAllocHook function"
  - "allocation hooks"
  - "hooks, allocation"
ms.assetid: 6bfbdb65-8cb1-4c21-8c45-7194a2b77c1e
caps.latest.revision: 17
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Allocation Hook Functions
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

An allocation hook function, installed using [_CrtSetAllocHook](https://msdn.microsoft.com/library/405df37b-2fd1-42c8-83bc-90887f17f29d), is called every time memory is allocated, re-allocated, or freed. This type of hook can be used for many different purposes. Use it to test how an application handles insufficient memory situations, for example, or to examine allocation patterns, or to log allocation information for later analysis.  
  
> [!NOTE]
> Be aware of the restriction about using C run-time library functions in an allocation hook function, described in [Allocation Hooks and C Run-Time Memory Allocations](../debugger/allocation-hooks-and-c-run-time-memory-allocations.md).  
  
 An allocation hook function should have a prototype like the following:  
  
```  
int YourAllocHook(int nAllocType, void *pvData,  
        size_t nSize, int nBlockUse, long lRequest,  
        const unsigned char * szFileName, int nLine )  
```  
  
 The pointer that you pass to [_CrtSetAllocHook](https://msdn.microsoft.com/library/405df37b-2fd1-42c8-83bc-90887f17f29d) is of type **_CRT_ALLOC_HOOK**, as defined in CRTDBG.H:  
  
```  
typedef int (__cdecl * _CRT_ALLOC_HOOK)  
    (int, void *, size_t, int, long, const unsigned char *, int);  
```  
  
 When the run-time library calls your hook, the *nAllocType* argument indicates what allocation operation is about to be performed (**_HOOK_ALLOC**, **_HOOK_REALLOC**, or **_HOOK_FREE**). In the case of a free or a reallocation, `pvData` contains a pointer to the user topic of the block about to be freed. However, in the case of an allocation, this pointer is null, because the allocation has not yet occurred. The remaining arguments contain the size of the allocation in question, its block type, the sequential request number associated with it, and a pointer to the file name and line number in which the allocation was made, if available. After the hook function performs whatever analysis and other tasks its author wants, it must return either **TRUE**, indicating that the allocation operation can continue, or **FALSE**, indicating that the operation should fail. A simple hook of this type might check the amount of memory allocated so far, and return **FALSE** if that amount exceeded a small limit. The application would then experience the kind of allocation errors that would normally occur only when available memory was very low. More complex hooks might keep track of allocation patterns, analyze memory use, or report when specific situations occur.  
  
## See Also  
 [Allocation Hooks and C Run-Time Memory Allocations](../debugger/allocation-hooks-and-c-run-time-memory-allocations.md)   
 [Debug Hook Function Writing](../debugger/debug-hook-function-writing.md)   
 [crt_dbg2 Sample](https://msdn.microsoft.com/21e1346a-6a17-4f57-b275-c76813089167)
