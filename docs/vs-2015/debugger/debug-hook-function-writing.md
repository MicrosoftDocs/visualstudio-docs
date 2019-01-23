---
title: "Debug Hook Function Writing | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vc.hooks"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "C++"
helpviewer_keywords: 
  - "debugging [C++], CRT debug support"
  - "debug hook functions"
  - "hooks, debug"
  - "hooks"
  - "debugging [CRT], debug hook functions"
ms.assetid: 5510635f-cf69-4907-b72d-ae27af1f19af
caps.latest.revision: 17
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Debug Hook Function Writing
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This section describes a number of custom debug hook functions you can write that allow you to insert your code into some predefined points inside the debugger's normal processing.  
  
## In This Section  
 [Client Block Hook Functions](../debugger/client-block-hook-functions.md)  
 Provides guidance and a prototype for writing functions that validate or report the contents of the data stored in _CLIENT_BLOCK blocks.  
  
 [Allocation Hook Functions](../debugger/allocation-hook-functions.md)  
 Defines an allocation hook function, explores its different uses, points out restrictions, and provides a prototype.  
  
 [Allocation Hooks and CRT Memory Allocations](../debugger/allocation-hooks-and-c-run-time-memory-allocations.md)  
 Describes the restriction on allocation hook functions of explicitly ignoring `_CRT_BLOCK` blocks if they make any calls to C run-time library functions that allocate internal memory. This topic also lists the consequences if your allocation hook does not ignore `_CRT_BLOCK` blocks (with examples) and how to change the default allocation hook function, **CrtDefaultAllocHook**.  
  
 [Report Hook Functions](../debugger/report-hook-functions.md)  
 Discusses `_CrtSetReportHook`, which you can use to filter reports to focus on specific types of allocations. This topic also provides a prototype.  
  
## Related Sections  
 [CRT Debugging Techniques](../debugger/crt-debugging-techniques.md)  
 Links to debugging techniques for the C Run-Time Library, including using the CRT Debug Library, macros for reporting, differences between `malloc` and `_malloc_dbg`, writing debug hook functions, and the CRT debug heap.
