---
title: "Output Window, Debugging, Options Dialog Box"
description: You can specify which types of debugging information appear in the Output window. Learn where to do this, and the types of information that you can control.
ms.date: "11/04/2025"
ms.topic: "ui-reference"
f1_keywords:
  - "vs.debug.options.OutputWindow"
  - "VS.ToolsOptionsPages.Debugger.OutputWindow"
  - "vs.debug.options.Output"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Output Window, Debugging, Options Dialog Box

:::moniker range="visualstudio"

You can specify which types of debugging information appear in the **Output** window. These options are available in the **Tools** (or **Debug**) > **Options** pane under the **All Settings** > **Debugging** > **Output Window** section. 

:::moniker-end
:::moniker range="<=vs-2022"
      
You can specify which types of debugging information appear in the **Output** window. These options are available in the **Tools** (or **Debug**) > **Options** dialog under the **Debugging** > **Output Window** section. 

:::moniker-end

**General Output Settings**

This category contains controls that determine whether general debug messages appear in the **Output** window. You can specify whether each type of message appears.

**WPF Trace Settings**

This category contains controls that determine the level of WPF trace messages that appear in the **Output** window. You can specify whether each type of message appears and specify a level ranging from **Critical** to **All**.

For more information, see [How to: Display WPF Trace Information](../debugger/how-to-display-wpf-trace-information.md).

If you need to restore default settings, you can do that using **Tools** > **Import and Export Settings** > **Reset all settings**. If you only want to reset a subset of settings, save your settings in the **Import and Export Settings Wizard** before making the changes that you want to test, then import your saved settings later.

## See also
- [Debugging, Options Dialog Box](../debugger/debugging-options-dialog-box.md)
- [Output Window](../ide/reference/output-window.md)