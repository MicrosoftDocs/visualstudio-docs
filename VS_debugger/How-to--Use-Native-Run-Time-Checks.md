---
title: "How to: Use Native Run-Time Checks"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
  - JScript
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: dc7b2f1e-5ff6-42e0-89b3-dc9dead83ee1
caps.latest.revision: 19
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# How to: Use Native Run-Time Checks
In Visual C++, you can use native [runtime_checks](../Topic/runtime_checks.md) to catch common run-time errors such as:  
  
-   Stack pointer corruption.  
  
-   Overruns of local arrays.  
  
-   Stack corruption.  
  
-   Dependencies on uninitialized local variables.  
  
-   Loss of data on an assignment to a shorter variable.  
  
 If you use **/RTC** with an optimized (**/O**) build, a compiler error results. If you use a `runtime_checks` pragma in an optimized build, the pragma has no effect.  
  
 When you debug a program that has run-time checks enabled, the default action is for the program to stop and break to the debugger when a run-time error occurs. You can change this default behavior for any run-time check. For more information, see [Managing Exceptions with the Debugger](../VS_debugger/Managing-Exceptions-with-the-Debugger.md).  
  
 The following procedures describe how to enable native run-time checks in a debug build, and how to modify native run-time check behavior.  
  
 Other topics in this section provide information about:  
  
-   [Customizing Run-Time Checks with the C Run-Time Library](../VS_debugger/Native-Run-Time-Checks-Customization.md)  
  
-   [Using Run-Time Checks without the C Run-Time Library](../VS_debugger/Using-Run-Time-Checks-Without-the-C-Run-Time-Library.md)  
  
### To enable native run-time checks in a debug build  
  
-   Use the **/RTC** option and link with the debug version of a C run-time library (/MDd, for example).  
  
### To modify native run-time check behavior  
  
-   Use the `runtime_checks` pragma.  
  
## See Also  
 [Debugging in Visual Studio](../VS_debugger/Debugging-in-Visual-Studio.md)   
 [runtime_checks](../Topic/runtime_checks.md)   
 [Run-Time Error Checking](../Topic/Run-Time%20Error%20Checking.md)