---
title: "Allocation Hooks and C Run-Time Memory Allocations | Microsoft Docs"
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
  - "debugging [C++], hook functions"
  - "memory allocation, troubleshooting allocation hooks"
  - "allocation hooks"
  - "hooks, allocation"
ms.assetid: cc34ee96-3d91-41bd-a019-aa3759139e7e
caps.latest.revision: 17
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Allocation Hooks and C Run-Time Memory Allocations
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

A very important restriction on allocation hook functions is that they must explicitly ignore `_CRT_BLOCK` blocks (the memory allocations made internally by C run-time library functions) if they make any calls to C run-time library functions that allocate internal memory. The `_CRT_BLOCK` blocks can be ignored by including code such as the following at the beginning of your allocation hook function:  
  
```  
if ( nBlockUse == _CRT_BLOCK )  
    return( TRUE );  
```  
  
 If your allocation hook does not ignore `_CRT_BLOCK` blocks, then any C run-time library function called in your hook can trap the program in an endless loop. For example, `printf` makes an internal allocation. If your hook code calls `printf`, then the resulting allocation will cause your hook to be called again, which will call **printf** again, and so on until the stack overflows. If you need to report `_CRT_BLOCK` allocation operations, one way to circumvent this restriction is to use Windows API functions, rather than C run-time functions, for formatting and output. Because the Windows APIs do not use the C run-time library heap, they will not trap your allocation hook in an endless loop.  
  
 If you examine the run-time library source files, you will see that the default allocation hook function, **CrtDefaultAllocHook** (which simply returns **TRUE**), is located in a separate file of its own, DBGHOOK.C. If you want your allocation hook to be called even for the allocations made by the run-time startup code that is executed before your application's **main** function, you can replace this default function with one of your own, instead of using [_CrtSetAllocHook](https://msdn.microsoft.com/library/405df37b-2fd1-42c8-83bc-90887f17f29d).  
  
## See Also  
 [Debug Hook Function Writing](../debugger/debug-hook-function-writing.md)   
 [crt_dbg2 Sample](https://msdn.microsoft.com/21e1346a-6a17-4f57-b275-c76813089167)
