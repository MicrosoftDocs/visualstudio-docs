---
title: "Debugging Native Code | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "C++"
helpviewer_keywords: 
  - "debugging native code"
  - "debugging [C++], native code"
  - "debugging [Visual Studio], native code"
  - "native code, debugging"
ms.assetid: d94eee90-7e0d-4cac-88c1-9831030daa5e
caps.latest.revision: 24
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Debugging Native Code
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The section covers some common debugging problems and techniques for native applications. The techniques covered in this section are high-level techniques. For the mechanics of using the Visual Studio debugger, see [Debugger Roadmap](../debugger/debugger-basics.md).  
  
## In This Section  
 [How to: Debug Optimized Code](../debugger/how-to-debug-optimized-code.md)  
 Gives tips for debugging optimized code, specifically, why you should debug an unoptimized version of your program, default optimization settings for Debug and Release configurations, and tips for finding bugs that only appear in optimized code (turning on optimization in a Debug build configuration).  
  
 [DebugBreak and __debugbreak](../debugger/debugbreak-and-debugbreak.md)  
 Describes the Win32 `DebugBreak` function and provides a link to its reference topic in the Platform SDK. Also describes the `__debugbreak` intrinsic.  
  
 [C/C++ Assertions](../debugger/c-cpp-assertions.md)  
 Discusses assertion statements, how they work, the benefits of using them (catching logic errors, checking results of an operation, and testing error conditions), their interaction with `_DEBUG`, and the types of assertions supported in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].  
  
 [How to: Debug Inline Assembly Code](../debugger/how-to-debug-inline-assembly-code.md)  
 Provides short instructions on using the Disassembly window to view the assembly instructions and the Registers window to view register contents and provides links to topics regarding those windows.  
  
 [MFC Debugging Techniques](../debugger/mfc-debugging-techniques.md)  
 Links you to debugging techniques for MFC programs, including: afxDebugBreak, the TRACE macro, detecting memory leaks in MFC, MFC assertions, and reducing the size of MFC Debug builds.  
  
 [CRT Debugging Techniques](../debugger/crt-debugging-techniques.md)  
 Links you to debugging techniques for the C Run-Time Library, including using the CRT Debug Library, macros for reporting, differences between malloc and _malloc_dbg, writing debug hook functions, and the CRT debug heap.  
  
 [Debugging Native Code FAQs](../debugger/debugging-native-code-faqs.md)  
 Provides answers to frequently asked questions about debugging Visual C++ programs  
  
 [COM and ActiveX Debugging](../debugger/com-and-activex-debugging.md)  
 Provides information on debugging COM and ActiveX applications, including tools you can use for COM and ActiveX debugging.  
  
 [How to: Debug Native DLLs](../debugger/how-to-debug-native-dlls.md)  
 Explains how to set up debugging for DLLs from native code.  
  
 [How to: Debug Injected Code](../debugger/how-to-debug-injected-code.md)  
 Provides guidance on debugging code that uses attributes. Instructions include how to turn on Source Annotation, how to view injected code, and how to view the disassembly code at the current execution point.  
  
 [Walkthrough: Debugging a Parallel Application](../debugger/walkthrough-debugging-a-parallel-application.md)  
 Describes how to use the **Parallel Tasks** and **Parallel Stacks** tool windows to debug a parallel application.  
  
## Related Sections  
 [Visual C++ Project Types](../debugger/debugging-preparation-visual-cpp-project-types.md)  
 Provides links to topics that describe how to debug the native project types created by the Visual C++ project templates.  
  
 [Debugging in Visual Studio](../debugger/debugging-in-visual-studio.md)  
 Provides links to the larger sections of the debugging documentation. Information includes what's new in the debugger, settings and preparation, breakpoints, handling exceptions, edit and continue, debugging managed code, debugging native code, debugging SQL, and the user interface references.  
  
## See Also  
 [Debugger Security](../debugger/debugger-security.md)   
 [Debugging in Visual Studio](../debugger/debugging-in-visual-studio.md)
