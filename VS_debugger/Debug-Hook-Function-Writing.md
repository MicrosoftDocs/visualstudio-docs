---
title: "Debug Hook Function Writing"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 5510635f-cf69-4907-b72d-ae27af1f19af
caps.latest.revision: 14
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Debug Hook Function Writing
This section describes a number of custom debug hook functions you can write that allow you to insert your code into some predefined points inside the debugger's normal processing.  
  
## In This Section  
 [Client Block Hook Functions](../VS_debugger/Client-Block-Hook-Functions.md)  
 Provides guidance and a prototype for writing functions that validate or report the contents of the data stored in _CLIENT_BLOCK blocks.  
  
 [Allocation Hook Functions](../VS_debugger/Allocation-Hook-Functions.md)  
 Defines an allocation hook function, explores its different uses, points out restrictions, and provides a prototype.  
  
 [Allocation Hooks and CRT Memory Allocations](../VS_debugger/Allocation-Hooks-and-C-Run-Time-Memory-Allocations.md)  
 Describes the restriction on allocation hook functions of explicitly ignoring `_CRT_BLOCK` blocks if they make any calls to C run-time library functions that allocate internal memory. This topic also lists the consequences if your allocation hook does not ignore `_CRT_BLOCK` blocks (with examples) and how to change the default allocation hook function, **CrtDefaultAllocHook**.  
  
 [Report Hook Functions](../VS_debugger/Report-Hook-Functions.md)  
 Discusses `_CrtSetReportHook`, which you can use to filter reports to focus on specific types of allocations. This topic also provides a prototype.  
  
## Related Sections  
 [CRT Debugging Techniques](../VS_debugger/CRT-Debugging-Techniques.md)  
 Links to debugging techniques for the C Run-Time Library, including using the CRT Debug Library, macros for reporting, differences between `malloc` and `_malloc_dbg`, writing debug hook functions, and the CRT debug heap.