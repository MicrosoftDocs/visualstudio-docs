---
title: "Just-In-Time, Debugging, Options Dialog Box"
description: Just-In-Time debugging lets you debug programs that start outside Visual Studio. Learn how to enable Just-In-Time debugging for various program types.
ms.date: "11/04/2025"
ms.topic: "ui-reference"
f1_keywords:
  - "VS.ToolsOptionsPages.Debugger.JIT"
  - "vs.debug.options.JIT"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "JScript"
helpviewer_keywords:
  - "Just-In-Time debugging, setting options"
  - "Options dialog box, debugging"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Just-In-Time, Debugging, Options Dialog Box

When you work with the Just-In-Time debugger in Visual Studio, configuration options for the debugger are accessible from the **Tools** > **Options** or **Debug** > **Options** menu. 

:::moniker range="visualstudio"

Open the **Tools** (or **Debug**) > **Options** pane, expand the **All Settings** > **Debugging** > **General** section, and select the **Configure Just-In-Time debugging** link. Configure the options in the **Visual Studio Debugger Options** dialog. You can enable Just-In-Time debugging for managed code and native code.

:::moniker-end
:::moniker range="<=vs-2022"

Open the **Tools** (or **Debug**) > **Options** dialog, expand the **Debugging** > **Just-In-Time** section, and configure the options. You can enable Just-In-Time debugging for managed code, native code, and script. 

:::moniker-end

Just-In-Time debugging is a technique for debugging a program started outside Visual Studio. You can run a program created in Visual Studio outside of the Visual Studio environment. If you enable Just-in-time debugging, you see a crash dialog that asks if you want to debug the program. For more information, see [Just-In-Time Debugging](../debugger/just-in-time-debugging-in-visual-studio.md).

## Associated warnings

When you work with the Just-In-Time debugger, you might see a warning message like this:

**Another debugger has registered itself as the Just-In-Time debugger. To repair, enable Just-In-Time debugging or run Visual Studio repair.**

This message occurs if you have another debugger, possibly an older version of Visual Studio debugger, set as the Just-In-Time debugger.

Another message that you might see is as follows:

**Just-In-Time debugging registration errors detected. To repair, enable Just-In-Time debugging or run Visual Studio repair.**

If you see either of these warnings, Just-In-Time debugging with Visual Studio requires Administrator privileges until you resolve the problem. If you try to enable the feature as a nonadministrator under these conditions, you see the following error message:

**Access is denied. Have an administrator enable Just-In-Time debugging, or repair your installation of Visual Studio.**

## See also
- [Debugging, Options Dialog Box](../debugger/debugging-options-dialog-box.md)
- [How to: Specify Debugger Settings](../debugger/how-to-specify-debugger-settings.md)