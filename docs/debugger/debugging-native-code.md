---
title: Debug native code and check for optimizations
description: Explore common debugging problems and high-level techniques for native applications in Visual Studio, including optimizations, assertions, and assembly code.
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
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Debugging Native Code

The section covers some common debugging problems and techniques for native applications. The techniques covered in this section are high-level techniques. For the mechanics of using the Visual Studio debugger, see [First look at the debugger](../debugger/debugger-feature-tour.md).

## In this section

[How to: Debug Optimized Code](../debugger/how-to-debug-optimized-code.md) gives tips for debugging optimized code, specifically, why you should debug an unoptimized version of your program, default optimization settings for Debug and Release configurations, and tips for finding bugs that only appear in optimized code (turning on optimization in a Debug build configuration).

[DebugBreak and __debugbreak](../debugger/debugbreak-and-debugbreak.md) describes the Win32 `DebugBreak` function and provides a link to its reference topic in the Platform SDK. Also describes the `__debugbreak` intrinsic.

[C/C++ Assertions](../debugger/c-cpp-assertions.md) discusses assertion statements, how they work, the benefits of using them (catching logic errors, checking results of an operation, and testing error conditions), their interaction with `_DEBUG`, and the types of assertions supported in Visual Studio.

[How to: Debug Inline Assembly Code](../debugger/how-to-debug-inline-assembly-code.md) provides short instructions on using the Disassembly window to view the assembly instructions and the Registers window to view register contents and provides links to topics regarding those windows.

[MFC Debugging Techniques](../debugger/mfc-debugging-techniques.md) links you to debugging techniques for MFC programs, including: afxDebugBreak, the TRACE macro, detecting memory leaks in MFC, MFC assertions, and reducing the size of MFC Debug builds.

[CRT Debugging Techniques](/cpp/c-runtime-library/crt-debugging-techniques) Links you to debugging techniques for the C Run-Time Library, including using the CRT Debug Library, macros for reporting, differences between malloc and _malloc_dbg, writing debug hook functions, and the CRT debug heap.

[Debugging Native Code FAQs](../debugger/debugging-native-code-faqs.md) provides answers to frequently asked questions about debugging C++ programs

[COM and ActiveX Debugging](/previous-versions/visualstudio/visual-studio-2017/debugger/com-and-activex-debugging) provides information on debugging COM and ActiveX applications, including tools you can use for COM and ActiveX debugging.

[How to: Debug Injected Code](/cpp/windows/attributes/cpp-attributes-com-net#debug-injected-code.md) provides guidance on debugging code that uses attributes. Instructions include how to turn on Source Annotation, how to view injected code, and how to view the disassembly code at the current execution point.

## Related sections

[Prepare to debug C++ projects](../debugger/debugging-preparation-visual-cpp-project-types.md) provides links to topics that describe how to debug the native project types created by the C++ project templates.

[Debugging DLL Projects](../debugger/debugging-dll-projects.md) provides information on how to debug native and managed DLLs.

[First look at the debugger](../debugger/debugger-feature-tour.md) provides links to the larger sections of the debugging documentation. Information includes what's new in the debugger, settings and preparation, breakpoints, handling exceptions, edit and continue, debugging managed code, debugging native code, debugging SQL, and the user interface references.

## Related content

- [Debugger Security](../debugger/debugger-security.md)
- [Debugging in Visual Studio](../debugger/index.yml)
