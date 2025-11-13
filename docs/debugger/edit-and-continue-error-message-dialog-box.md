---
title: "Edit and Continue error message dialog box| Microsoft Docs"
description: Edit and Continue may report that it isn't available for your code changes. This article provides possible reasons.
ms.date: "10/15/2018"
ms.topic: "ui-reference"
f1_keywords:
  - "vs.debug.ENC.SupportedButNotAvailable"
  - "vs.debug.ENC.CannotEditWhileException"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "Edit and Continue Error Message dialog box"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Edit and Continue error message

The **Edit and Continue** error message box appears when you're debugging in a code language that supports Edit and Continue, but Edit and Continue isn't available for the code changes you've made. The error message provides a more detailed explanation. To respond to the dialog, select **OK** to close the dialog box and cancel the edit attempt.

Possible reasons for this error message include:

- Trying to edit SQL Server code.
- Trying to edit optimized code. You may need to switch from a release build to a debug build.
- Trying to edit code while it's running, instead of while paused in the debugger. Try [setting a breakpoint](../debugger/using-breakpoints.md), and editing the code while paused.
- Trying to edit managed code when only unmanaged debugging is enabled. Edit and Continue doesn't work with [mixed-mode debugging](../debugger/how-to-debug-in-mixed-mode.md).
- Making a code change that isn't supported by Edit and Continue in your programming language. For more information, see articles about [supported code changes in C#](supported-code-changes-csharp.md), [unsupported edits in Visual Basic Edit and Continue](supported-code-changes-csharp.md), and [supported C++ code changes](supported-code-changes-cpp.md).
- Trying to edit code in an app you're attached to, instead of starting debugging from the **Debug** menu.
- Trying to edit code while debugging a Dr. Watson dump.
- Trying to edit code after an unhandled exception occurs, and the option **Unwind the call stack on unhandled exceptions** is not selected.
- Trying to edit code while debugging an embedded runtime application.
- Trying to edit managed code using a .NET Framework version earlier than 4.5.1 with a 64-bit app target. To use Edit and Continue for .NET Framework earlier than 4.5.1, set the target to **x86** in the **\<ProjectName>** > **Properties** > **Compile** tab, **Advanced Compiler** setting.
- Trying to edit code in an assembly that was modified during debugging and has been reloaded.
- Trying to edit code in an assembly that hasn't been loaded.
- Starting to debug an old version of an app, because the latest version has build errors.

For more information, see:
- [C++ Edit and Continue blog post](https://devblogs.microsoft.com/cppblog/c-edit-and-continue-in-visual-studio-2015-update-3/)
- [Supported code changes (C++)](../debugger/supported-code-changes-cpp.md)
- [Edit and Continue](/visualstudio/debugger/how-to-enable-and-disable-edit-and-continue)