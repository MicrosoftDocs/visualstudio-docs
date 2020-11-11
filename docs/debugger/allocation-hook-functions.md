---
title: "Allocation Hook Functions | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.debug.hooks"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "memory allocation, logging allocation information"
  - "insufficient memory"
  - "debugging [C++], hook functions"
  - "_CrtSetAllocHook function"
  - "allocation hooks"
  - "hooks, allocation"
ms.assetid: 6bfbdb65-8cb1-4c21-8c45-7194a2b77c1e
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Allocation Hook Functions
An allocation hook function, installed using [_CrtSetAllocHook](/cpp/c-runtime-library/reference/crtsetallochook), is called every time memory is allocated, reallocated, or freed. You can use this type of hook for many different purposes. Use it to test how an application handles insufficient memory situations, such as to examine allocation patterns, or log allocation information for later analysis.

> [!NOTE]
> Be aware of the restriction about using C run-time library functions in an allocation hook function, described in [Allocation Hooks and C Run-Time Memory Allocations](../debugger/allocation-hooks-and-c-run-time-memory-allocations.md).

 An allocation hook function should have a prototype like the following example:

```cpp
int YourAllocHook(int nAllocType, void *pvData,
        size_t nSize, int nBlockUse, long lRequest,
        const unsigned char * szFileName, int nLine )
```

 The pointer that you pass to [_CrtSetAllocHook](/cpp/c-runtime-library/reference/crtsetallochook) is of type **_CRT_ALLOC_HOOK**, as defined in CRTDBG.H:

```cpp
typedef int (__cdecl * _CRT_ALLOC_HOOK)
    (int, void *, size_t, int, long, const unsigned char *, int);
```

 When the run-time library calls your hook, the *nAllocType* argument indicates what allocation operation is about to be made (**_HOOK_ALLOC**, **_HOOK_REALLOC**, or **_HOOK_FREE**). In a free or in a reallocation, `pvData` has a pointer to the user article of the block about to be freed. However for an allocation, this pointer is null, because the allocation hasn't occurred. The remaining arguments contain the size of the allocation in question, its block type, the sequential request number associated with it, and a pointer to the file name. If available, the arguments also include the line number in which the allocation was made. After the hook function performs whatever analysis and other tasks its author wants, it must return either **TRUE**, indicating that the allocation operation can continue, or **FALSE**, indicating that the operation should fail. A simple hook of this type might check the amount of memory allocated so far, and return **FALSE** if that amount exceeded a small limit. The application would then experience the kind of allocation errors that would normally occur only when available memory was very low. More complex hooks might keep track of allocation patterns, analyze memory use, or report when specific situations occur.

## See also

- [Allocation Hooks and C Run-Time Memory Allocations](../debugger/allocation-hooks-and-c-run-time-memory-allocations.md)
- [Debug Hook Function Writing](../debugger/debug-hook-function-writing.md)