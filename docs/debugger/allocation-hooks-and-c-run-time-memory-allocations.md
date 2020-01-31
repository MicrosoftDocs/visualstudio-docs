---
title: "Allocation Hooks and C Run-Time Memory Allocations | Microsoft Docs"
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
  - "debugging [C++], hook functions"
  - "memory allocation, troubleshooting allocation hooks"
  - "allocation hooks"
  - "hooks, allocation"
ms.assetid: cc34ee96-3d91-41bd-a019-aa3759139e7e
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Allocation Hooks and C Run-Time Memory Allocations
A very important restriction on allocation hook functions is that they must explicitly ignore `_CRT_BLOCK` blocks. These blocks are the memory allocations made internally by C run-time library functions if they make any calls to C run-time library functions that allocate internal memory. You can ignore `_CRT_BLOCK` blocks by including the following code at the beginning of your allocation hook function:

```cpp
if ( nBlockUse == _CRT_BLOCK )
    return( TRUE );
```

If your allocation hook doesn't ignore `_CRT_BLOCK` blocks, then any C run-time library function called in your hook can trap the program in an endless loop. For example, `printf` makes an internal allocation. If your hook code calls `printf`, then the resulting allocation will cause your hook to be called again, which will call **printf** again, and so on, until the stack overflows. If you need to report `_CRT_BLOCK` allocation operations, one way to circumvent this restriction is to use Windows API functions, rather than C run-time functions, for formatting and output. Because the Windows APIs don't use the C run-time library heap, they won't trap your allocation hook in an endless loop.

If you examine the run-time library source files, you will see that the default allocation hook function, **CrtDefaultAllocHook** (which simply returns **TRUE**), is located in a separate file of its own, DBGHOOK.C. If you want your allocation hook to be called even for the allocations made by the run-time startup code that is executed before your application's **main** function, you can replace this default function with one of your own, instead of using [_CrtSetAllocHook](/cpp/c-runtime-library/reference/crtsetallochook).

## See also
- [Debug Hook Function Writing](../debugger/debug-hook-function-writing.md)
