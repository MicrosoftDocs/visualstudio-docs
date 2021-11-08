---
title: Apply Edits in break mode with Edit and Continue | Microsoft Docs
description: See how to use Edit and Continue to edit your Visual Basic code when in break mode. There are various ways to enter break mode.

ms.date: 11/04/2016
ms.topic: how-to
f1_keywords: 
  - vs.debug.variables.failededit
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords: 
  - Edit and Continue [Visual Basic], applying edits in break mode
  - break mode, applying code changes
  - Edit and Continue, applying edits in break mode
  - editing, break mode
  - coding, editing in break mode
  - code, editing in break mode
ms.assetid: 1eef7498-6a1f-4fba-8146-510adc6375c9
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---
# How to: Apply Edits in Break Mode with Edit and Continue (Visual Basic)
You can use Edit and Continue to edit your code in Break mode, and then continue without stopping and restarting execution.

For limitations on using Edit and Continue while debugging, see [Supported Code Changes (C# and Visual Basic)](../debugger/supported-code-changes-csharp.md).

### To edit code in Break mode

1. Enter Break mode by doing one of the following:

    - Set a breakpoint in your code, then choose **Start Debugging** from the **Debug** menu and wait for the application to hit the breakpoint.

         -or-

    - Start debugging, and then select **Break All** from the **Debug** menu.

         -or-

    - When an exception occurs, choose **Enable Editing** on the **Exception Assistant**.

2. Make any desired and supported code changes.

     For more information, see [Supported Code Changes (C# and Visual Basic)](../debugger/supported-code-changes-csharp.md).

    > [!NOTE]
    > If you attempt to make a code change that is not allowed by Edit and Continue, your edit will be underlined by a purple wavy line and a task will appear in the Task List. You will not be able to continue code execution unless you undo the illegal code change.

3. On the **Debug** menu, click **Continue** to resume execution.

     Your code now executes with your applied edits incorporated into the project.

## See also
- [Supported Code Changes (C# and Visual Basic)](../debugger/supported-code-changes-csharp.md)
- [Edit and Continue (Visual Basic)](../debugger/edit-and-continue-visual-basic.md)
