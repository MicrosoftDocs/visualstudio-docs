---
title: "Edit and Continue (Visual Basic)"
description: Edit and Continue is available for Visual Basic projects. Learn what edits are supported, and how to can control whether, and when, your edits are applied.
ms.date: "08/15/2023"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "Edit and Continue, 64-bit"
  - "Edit and Continue [Visual Basic]"
  - "debugging [Visual Basic], Edit and Continue"
  - "Visual Basic, Edit and Continue"
  - "64-bit Edit and Continue"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Edit and Continue (Visual Basic)

::: moniker range=">=vs-2022"
Hot Reload, previously called Edit and Continue, is a feature for Visual Basic debugging that enables you to change your code while it's executing in Break mode. After code edits have been applied, you can resume code execution with the new edits in place and see the effect.
::: moniker-end

::: moniker range="vs-2019"
Edit and Continue is a feature for Visual Basic debugging that enables you to change your code while it's executing in Break mode. After code edits have been applied, you can resume code execution with the new edits in place and see the effect.
::: moniker-end

You can use the Edit and Continue feature whenever you enter Break mode. In Break mode, the instruction pointer, a yellow arrowhead in the source window, points to the line containing an executable statement in a method or property body that will be executed next.

When you make an unauthorized edit, the change is marked with a purple wavy underline and a task is displayed in the Task List. You must undo an unauthorized edit if you want to continue to use Edit and Continue. Certain unauthorized edits may be permitted if done outside Edit and Continue. If you want to retain the results of such an unauthorized edit, you must stop debugging and restart your application.

Edit and Continue is supported in UWP apps for Windows 10 or later, and x86 and x64 apps that target the .NET Framework 4.6 desktop or later versions (the .NET Framework is a desktop version only).

Edit and Continue supports most changes you might want to make during a debugging session, but there are some exceptions. Edit and Continue isn't supported when you start debugging using **Attach to Process**. Edit and Continue isn't supported for optimized code or mixed managed and native code. For more information, see [Supported Code Changes (C# and Visual Basic)](../debugger/supported-code-changes-csharp.md).

## Apply edits in Break Mode with Edit and Continue

You can use Edit and Continue to edit your code in Break mode, and then continue without stopping and restarting execution.

To edit code in Break mode:

1. Enter Break mode by doing one of the following:

    - Set a breakpoint in your code, then choose **Start Debugging** from the **Debug** menu and wait for the application to hit the breakpoint.

      -or-

    - Start debugging, and then select **Break All** from the **Debug** menu.

      -or-

    - When an exception occurs, choose **Enable Editing** on the **Exception Assistant**.

2. Make any desired and supported code changes.

     For more information, see [Supported Code Changes (C# and Visual Basic)](../debugger/supported-code-changes-csharp.md).

    > [!NOTE]
    > If you attempt to make a code change that is not allowed by Edit and Continue, your edit will be underlined by a purple wavy line and a task will appear in the Task List. You won't be able to continue code execution unless you undo the illegal code change.

3. On the **Debug** menu, click **Continue** to resume execution.

     Your code now executes with your applied edits incorporated into the project.

## Related content

- [Supported Code Changes (C# and Visual Basic)](../debugger/supported-code-changes-csharp.md)
- [Edit and Continue](/visualstudio/debugger/how-to-enable-and-disable-edit-and-continue)
- [Configure Edit and Continue](../debugger/how-to-enable-and-disable-edit-and-continue.md)
