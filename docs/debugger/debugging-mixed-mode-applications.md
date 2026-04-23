---
title: "Debugging Mixed-Mode Applications"
description: Debug a mixed-mode application, which is an app that combines native code with managed code that runs on the common language runtime, in Visual Studio.
ms.date: "04/15/2022"
ms.topic: how-to
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "debugging [Visual Studio], mixed-mode"
  - "mixed-mode debugging, property evaluation"
  - "Call Stack window"
  - "mixed-mode debugging"
  - "Call Stack window, mixed-mode debugging"
  - "debugging managed code, mixed code"
  - "mixed-mode debugging, call stack"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Debugging Mixed-Mode Applications

A mixed-mode application is any application that combines native code (C++) with managed code (such as Visual Basic, Visual C#, or C++ that runs on the common language runtime). Debugging mixed-mode applications is largely transparent in Visual Studio. It's not too different from debugging a single-mode application. There are a few special considerations, however.

## Enable C++ Edit and Continue in Mixed Mode Debugging

To enable Edit and Continue for C++, see [How to enable and disable Edit and Continue](../debugger/how-to-enable-and-disable-edit-and-continue.md).

## Property Evaluation in Mixed-Mode Applications

In a mixed-mode application, the evaluation of properties by the debugger is an expensive operation. As a result, debugging operations such as stepping might appear slow. For more information, see [Navigating code in the debugger](../debugger/navigating-through-code-with-the-debugger.md). If you experience poor performance in mixed-mode debugging, you might want to turn off property evaluation in the debugger windows.

> [!NOTE]
> The dialogs and menu commands you see might differ from the UI described in Help depending on your active settings or edition. To change your settings, select the **Import and Export Settings** option on the **Tools** menu. For more information, see [Reset all settings](../ide/personalizing-the-visual-studio-ide.md#reset-all-settings).

### To turn off property evaluation

:::moniker range="visualstudio"

1. In the **Tools** > **Options** pane, expand the **All Settings** > **Debugging** > **General** section.

:::moniker-end
:::moniker range="<=vs-2022"

1. In the **Tools** > **Options** dialog, expand the **Debugging** > **General** section.

:::moniker-end

2. Clear the **Enable property evaluation and other implicit function calls** option checkbox.

   When you disable this option, the **Call string-conversion function on objects in variables windows** option is automatically disabled.

Because native call stacks and managed call stacks differ, the debugger can't always provide the complete call stack for mixed code. When native code calls managed code, you might notice some discrepancies. For more information, see [Mixed Code and Missing Information in the Call Stack Window](../debugger/mixed-code-and-missing-information-in-the-call-stack-window.md).

## Related content

- [Debugging Managed Code](/visualstudio/debugger/)
