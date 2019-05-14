---
title: "How to: Use Native Run-Time Checks | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "c.runtime.errorchecks"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "/RTC compiler option [C++], /O compiler option"
  - "run-time checks, native"
  - "stack, pointer corruption"
  - "stack pointers, corruption"
  - "/O compiler option, /RTC option"
  - "run-time errors, error checks"
  - "O compiler option, /RTC option"
  - "debugger, runtime errors"
  - "variables [debugger], loss of data"
  - "runtime_checks pragma"
  - "variables [debugger], catching dependencies on uninitialized local variables"
  - "run-time errors, debugging"
  - "debugger, native run-time checks"
  - "optimized build option"
  - "RTC compiler option, /O compiler option"
  - "native run-time checks"
  - "run-time checks"
  - "debugging arrays"
  - "stack pointers"
  - "arrays [Visual Studio], debugging"
ms.assetid: dc7b2f1e-5ff6-42e0-89b3-dc9dead83ee1
caps.latest.revision: 24
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Use Native Run-Time Checks
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In Visual C++, you can use native [runtime_checks](https://msdn.microsoft.com/library/ae50b43f-f88d-47ad-a2db-3389e9e7df5b) to catch common run-time errors such as:  
  
- Stack pointer corruption.  
  
- Overruns of local arrays.  
  
- Stack corruption.  
  
- Dependencies on uninitialized local variables.  
  
- Loss of data on an assignment to a shorter variable.  
  
  If you use **/RTC** with an optimized (**/O**) build, a compiler error results. If you use a `runtime_checks` pragma in an optimized build, the pragma has no effect.  
  
  When you debug a program that has run-time checks enabled, the default action is for the program to stop and break to the debugger when a run-time error occurs. You can change this default behavior for any run-time check. For more information, see [Managing Exceptions with the Debugger](../debugger/managing-exceptions-with-the-debugger.md).  
  
  The following procedures describe how to enable native run-time checks in a debug build, and how to modify native run-time check behavior.  
  
  Other topics in this section provide information about:  
  
- [Customizing Run-Time Checks with the C Run-Time Library](../debugger/native-run-time-checks-customization.md)  
  
- [Using Run-Time Checks without the C Run-Time Library](../debugger/using-run-time-checks-without-the-c-run-time-library.md)  
  
### To enable native run-time checks in a debug build  
  
- Use the **/RTC** option and link with the debug version of a C run-time library (/MDd, for example).  
  
### To modify native run-time check behavior  
  
- Use the `runtime_checks` pragma.  
  
## See Also  
 [Debugging in Visual Studio](../debugger/debugging-in-visual-studio.md)   
 [runtime_checks](https://msdn.microsoft.com/library/ae50b43f-f88d-47ad-a2db-3389e9e7df5b)   
 [Run-Time Error Checking](https://msdn.microsoft.com/library/c965dd01-57ad-4a3c-b1d6-5aa04f920501)
