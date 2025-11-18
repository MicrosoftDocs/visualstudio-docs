---
title: Edit and Continue in your C++ projects
description: Edit and Continue is available for C++ projects. Learn what edits are supported, and how to can control whether, and when, your edits are applied.
ms.date: "05/31/2018"
ms.topic: how-to
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "Edit and Continue [C++]"
  - "debugging [C++], Edit and Continue"
  - "C/C++, Edit and Continue"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Edit and Continue (C++)

::: moniker range=">=vs-2022"

You can use Hot Reload, previously called Edit and Continue, in C++ projects. For information about the limitations of the feature, see [Supported Code Changes (C++)](../debugger/supported-code-changes-cpp.md).

::: moniker-end
::: moniker range="vs-2019"

You can use Edit and Continue in C++ projects. For more information about the limitations of Edit and Continue, see [Supported Code Changes (C++)](../debugger/supported-code-changes-cpp.md).


::: moniker-end

The [/Zo (Enhance Optimized Debugging)](/cpp/build/reference/zo-enhance-optimized-debugging) compiler option adds additional information to .pdb (symbol) files for binaries compiled without the [/Od (Disable (Debug))](/cpp/build/reference/od-disable-debug) option.

The `/Zo` option disables Edit and Continue, as described in [How to: Debug Optimized Code](../debugger/how-to-debug-optimized-code.md).

::: moniker range=">=vs-2022"

## <a name="BKMK_Enable_or_disable_automatic_invocation_of_Hot_Reload"></a> Enable or disable Hot Reload

You might want to disable the automatic invocation of Hot Reload if you're making edits to the code that you don't want applied during the current debugging session. You can re-enable automatic Hot Reload as needed.

> [!IMPORTANT]
> For required build settings and other information about feature compatibility, see [C++ Edit and Continue in Visual Studio 2015 Update 3](https://devblogs.microsoft.com/cppblog/c-edit-and-continue-in-visual-studio-2015-update-3/).

1. If you're currently in a debugging session, stop debugging (**Shift** + **F5**).

::: moniker-end
:::moniker range="visualstudio"

2. Open the **Tools** > **Options** pane, and expand the **All Settings** > **Debugging** > **.NET/C++ Hot Reload** section.

3. To enable Hot Reload when starting with the debugger attached (**F5**), select the **Enable Hot Reload** checkbox in the right pane.

   After you select the checkbox, you can configure the following options:

   | Hot Reload option | Description | Default |
   | --- | --- | --- |
   | **Automatically apply changes on continue (Native only)** | Applies changes when you continue with debugger attached (**F5**). | Enabled |
   | **Warn about stale code**  | Enables a warning when the debugger encounters code that has been modified but can't be immediately applied. | Enabled |
   | **Enable when not debugging**  | Enables Hot Reload when starting _without_ the debugger attached (**Ctrl** + **F5**). | Enabled |
   | **Apply on file save**  | Applies changes when the file is saved. | Disabled |
   | **Logging verbosity** | Set the level of logging when Hot Reload is enabled. Choose from **Minimal**, **Detailed**, or **Diagnostic**. | **Minimal** |

::: moniker-end
:::moniker range="vs-2022"

2. Open the **Tools** > **Options** dialog, and expand the **Debugging** > **.NET/C++ Hot Reload** section.

3. Select one or all of the following options to enable the feature:

   - **Enable Hot Reload**: Enables Hot Reload when starting with the debugger attached (**F5**).

   - **Enable Hot Reload when starting without debugging**: Enables Hot Reload when starting _without_ the debugger attached (**Ctrl** + **F5**).

   - **Enable Hot Reload on File Save**: Enables Hot Reload when the file is saved.

   - **Logging verbosity**: Set the level of logging when Hot Reload is enabled. Choose from **Minimal** (default), **Detailed**, or **Diagnostic**.

   Altering these settings affects all projects you work on. You don't need to rebuild your application after changing a setting. If you build your application from the command line or from a makefile, but you debug in the Visual Studio environment, you can still use Edit and Continue if you set the `/ZI` option.

4. Select **OK**.

::: moniker-end
::: moniker range="<=vs-2019"

## <a name="BKMK_Enable_or_disable_automatic_invocation_of_Edit_and_Continue"></a> Enable or disable Edit and Continue

You might want to disable the automatic invocation of Edit and Continue if you're making edits to the code that you don't want applied during the current debugging session. You can re-enable automatic Edit and Continue as needed.

> [!IMPORTANT]
> For required build settings and other information about feature compatibility, see [C++ Edit and Continue in Visual Studio 2015 Update 3](https://devblogs.microsoft.com/cppblog/c-edit-and-continue-in-visual-studio-2015-update-3/).

1. If you're currently in a debugging session, stop debugging (**Shift** + **F5**).

1. Open the **Tools** > **Options** dialog, and expand the **Debugging** > **General** section.

1. To enable Edit and Continue, select the **Enable Edit and Continue** checkbox. To disable the option, clear the checkbox.

1. In the **Edit and Continue** group, select or clear the **Enable Native Edit and Continue** checkbox.

   Altering this setting affects all projects you work on. You don't need to rebuild your application after changing this setting. If you build your application from the command line or from a makefile, but you debug in the Visual Studio environment, you can still use Edit and Continue if you set the `/ZI` option.

::: moniker-end

## <a name="BKMK_How_to_apply_code_changes_explicitly"></a> Apply code changes explicitly

In C++, Edit and Continue can apply code changes in two ways. Code changes can be applied implicitly, when you choose an execution command, or explicitly, using the **Apply Code Changes** command.

When you apply code changes explicitly, your program remains in break mode - no execution occurs.

- To apply code changes explicitly, on the **Debug** menu, choose **Apply Code Changes**.

## <a name="BKMK_How_to_stop_code_changes"></a> How to stop code changes

While Edit and Continue is in the process of applying code changes, you can stop the operation.

To stop applying code changes:

- On the **Debug** menu, choose **Stop Applying Code Changes**.

  This menu item is visible only when code changes are being applied.

  If you choose this option, none of the code changes are committed.

## <a name="BKMK_How_to_reset_the_point_of_execution"></a> Reset the point of execution

Some code changes can cause the point of execution to move to a new location when Edit and Continue applies the changes. The feature places the point of execution as accurately as possible, but the results might not be correct in all cases.

In C++, a dialog box informs you when the point of execution changes. You should verify that the location is correct before you continue debugging. If it isn't correct, use the **Set Next Statement** command. For more information, see [Set the next statement to execute](./navigating-through-code-with-the-debugger.md#BKMK_Set_the_next_statement_to_execute).

## <a name="BKMK_How_to_work_with_stale_code"></a> Work with stale code

In some cases, Edit and Continue can't apply code changes to the executable immediately, but might be able to apply the code changes later if you continue debugging. This scenario happens if you edit a function that calls the current function or if you add more than 64 bytes of new variables to a function on the call stack.

In such cases, the debugger continues executing the original code until the changes can be applied. The stale code appears as a temporary source file window in a separate source window, with a title such as `enc25.tmp`. The edited source continues to appear in the original source window. If you try to edit the stale code, a warning message appears.

## Related content

- [Supported Code Changes (C++)](../debugger/supported-code-changes-cpp.md)
- [Configure Edit and Continue](../debugger/how-to-enable-and-disable-edit-and-continue.md)
