---
title: "Debugging Native Code | Microsoft Docs"
description: Learn about common debugging problems and high-level techniques for native applications in Visual Studio.
ms.custom: SEO-VS-2020
ms.date: "02/07/2023"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "debugging native code"
  - "debugging [C++], native code"
  - "debugging [Visual Studio], native code"
  - "native code, debugging"
ms.assetid: d94eee90-7e0d-4cac-88c1-9831030daa5e
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "cplusplus"
---
# Debugging Native Code

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
The section covers some common debugging problems and techniques for native applications. The techniques covered in this section are high-level techniques. For the mechanics of using the Visual Studio debugger, see [First look at the debugger](../debugger/debugger-feature-tour.md).

## In This Section
 [How to: Debug Optimized Code](../debugger/how-to-debug-optimized-code.md)
 Gives tips for debugging optimized code, specifically, why you should debug an unoptimized version of your program, default optimization settings for Debug and Release configurations, and tips for finding bugs that only appear in optimized code (turning on optimization in a Debug build configuration).

 [DebugBreak and __debugbreak](../debugger/debugbreak-and-debugbreak.md)
 Describes the Win32 `DebugBreak` function and provides a link to its reference topic in the Platform SDK. Also describes the `__debugbreak` intrinsic.

 [C/C++ Assertions](../debugger/c-cpp-assertions.md)
 Discusses assertion statements, how they work, the benefits of using them (catching logic errors, checking results of an operation, and testing error conditions), their interaction with `_DEBUG`, and the types of assertions supported in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].

 [How to: Debug Inline Assembly Code](../debugger/how-to-debug-inline-assembly-code.md)
 Provides short instructions on using the Disassembly window to view the assembly instructions and the Registers window to view register contents and provides links to topics regarding those windows.

 [MFC Debugging Techniques](../debugger/mfc-debugging-techniques.md)
 Links you to debugging techniques for MFC programs, including: afxDebugBreak, the TRACE macro, detecting memory leaks in MFC, MFC assertions, and reducing the size of MFC Debug builds.

 [CRT Debugging Techniques](/cpp/c-runtime-library/crt-debugging-techniques.md)
 Links you to debugging techniques for the C Run-Time Library, including using the CRT Debug Library, macros for reporting, differences between malloc and _malloc_dbg, writing debug hook functions, and the CRT debug heap.

 [Debugging Native Code FAQs](../debugger/debugging-native-code-faqs.md)
 Provides answers to frequently asked questions about debugging C++ programs

 [COM and ActiveX Debugging](../debugger/com-and-activex-debugging.md)
 Provides information on debugging COM and ActiveX applications, including tools you can use for COM and ActiveX debugging.

 [How to: Debug Injected Code](/cpp/windows/attributes/cpp-attributes-com-net#debug-injected-code.md)
 Provides guidance on debugging code that uses attributes. Instructions include how to turn on Source Annotation, how to view injected code, and how to view the disassembly code at the current execution point.

 [Walkthrough: Debugging a Parallel Application](../debugger/walkthrough-debugging-a-parallel-application.md)
 Describes how to use the **Parallel Tasks** and **Parallel Stacks** tool windows to debug a parallel application.

## Related Sections
 [Prepare to debug C++ projects](../debugger/debugging-preparation-visual-cpp-project-types.md)
 Provides links to topics that describe how to debug the native project types created by the C++ project templates.

 [Debugging DLL Projects](../debugger/debugging-dll-projects.md)
 Provides information on how to debug native and managed DLLs.

 [First look at the debugger](../debugger/debugger-feature-tour.md)
 Provides links to the larger sections of the debugging documentation. Information includes what's new in the debugger, settings and preparation, breakpoints, handling exceptions, edit and continue, debugging managed code, debugging native code, debugging SQL, and the user interface references.

## See also

- [Debugger Security](../debugger/debugger-security.md)
- [Debugging in Visual Studio](../debugger/index.yml)