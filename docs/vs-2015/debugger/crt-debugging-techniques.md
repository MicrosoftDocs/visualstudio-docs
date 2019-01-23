---
title: "CRT Debugging Techniques | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "c.runtime.debugging"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "C++"
helpviewer_keywords: 
  - "debugging [CRT]"
  - "CRT, debugging"
  - "debugging [C++], CRT debug support"
ms.assetid: 9be561f6-14a8-44ff-925d-d911d5b8e6ff
caps.latest.revision: 23
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# CRT Debugging Techniques
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

If you are debugging a program that uses the C run-time library, these debugging techniques might be useful.  
  
## In This Section  
 [CRT Debug Library Use](../debugger/crt-debug-library-use.md)  
 Describes the debugging support provided by the C Run-Time Library and provides instructions for accessing the tools.  
  
 [Macros for Reporting](../debugger/macros-for-reporting.md)  
 Provides information about the **_RPTn** and **_RPTFn** macros (defined in CRTDBG.H), which replace the use of `printf` statements for debugging.  
  
 [Debug Versions of Heap Allocation Functions](../debugger/debug-versions-of-heap-allocation-functions.md)  
 Discusses the special Debug versions of the heap allocation functions, including: how the CRT maps calls, the benefits of calling them explicitly, how to avoid conversion, tracking the separate types of allocations in client blocks, and the results of not defining _DEBUG.  
  
 [CRT Debug Heap Details](../debugger/crt-debug-heap-details.md)  
 Provides links to memory management and the debug heap, types of blocks on the debug heap, using the debug heap, heap state reporting functions, and tracking heap allocation requests.  
  
 [Debug Hook Function Writing](../debugger/debug-hook-function-writing.md)  
 Lists links to client block hook functions, allocation hook functions, allocation hooks and CRT memory allocations, and report hook functions.  
  
 [Finding Memory Leaks Using the CRT Library](../debugger/finding-memory-leaks-using-the-crt-library.md)  
 Covers techniques for detecting and isolating memory leaks by using the debugger and the C Run-Time Library.  
  
## Related Sections  
 [Debugging Native Code](../debugger/debugging-native-code.md)  
 Discusses some common debugging problems and techniques for C and C++ applications.  
  
 [Debugger Security](../debugger/debugger-security.md)  
 Provides recommendations for more secure debugging.
