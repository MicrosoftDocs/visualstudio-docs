---
title: "Edit and Continue Error Message Dialog Box | Microsoft Docs"
ms.custom: ""
ms.date: "06/22/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "reference"
f1_keywords: 
  - "vs.debug.ENC.SupportedButNotAvaiable"
  - "vs.debug.ENC.CannotEditWhileException"
dev_langs: 
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords: 
  - "Edit and Continue Error Message dialog box"
ms.assetid: f98c91c0-447a-4533-85b6-87170a0dc4c3
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Edit and Continue Error Message Dialog Box
This dialog box appears when you are debugging in a language that supports Edit and Continue, but **Edit and Continue** is not available for the type of code changes you have made. The error message inside the box provides a more detailed explanation. Possible reasons for seeing this dialog box include:  

-   You tried to edit SQL Server code.

-   You tried to edit optimized code. (You may need to switch from a release build to a debug build.)

-   You tried to edit code while it was running (instead of while paused in the debugger). Try [setting a breakpoint](../debugger/using-breakpoints.md) and editing code while paused.

-   You tried to edit managed code when unmanaged debugging was enabled. Edit and Continue does not work with [mixed-mode debugging](../debugger/how-to-debug-in-mixed-mode.md).

-   You made a code change that is not supported by Edit and Continue in your programming language. For more info, see topics for unsupported code changes in [C#](../debugger/supported-code-changes-csharp.md), [Visual Basic](../debugger/unsupported-edits-in-visual-basic-edit-and-continue.md), and [C++](../debugger/supported-code-changes-cpp.md).
  
-   You tried to edit code in a program that you attached to rather than starting from the **Debug** menu.  
  
-   You tried to edit code while debugging a Dr. Watson dump.  
  
-   You tried to edit code after an unhandled exception occurred and the option "**Unwind the call stack on unhandled exceptions**" was not selected.  
  
-   You tried to edit code while debugging an embedded runtime application.
  
-   You tried to edit managed code using .NET Framework version prior to 4.5.1, and the target is a 64-bit application. If you want to use Edit and Continue, you must set the target to x86. (*projectname* **Properties**, **Compile** tab, **Advanced Compiler** setting.).  
  
-   You tried to edit code in an assembly that was modified during debugging and has been reloaded.  
  
-   You tried to edit code in an assembly that has not been loaded.  
  
-   You started debugging an old version of your application (since the new version has build errors).
  
## UIElement List  
 **OK**  
 Exit the dialog box and cancel the immediately preceding edit attempt.  
  
## See Also  
 [C++ Edit and Continue blog post](https://blogs.msdn.microsoft.com/vcblog/2016/07/01/c-edit-and-continue-in-visual-studio-2015-update-3/)  
 [Supported Code Changes (C++)](../debugger/supported-code-changes-cpp.md)