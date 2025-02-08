---
title: Configure Edit and Continue
description: Learn how to enable, disable, and configure Edit and Continue, in Visual Studio Options at design time. Edit and Continue works only in debug builds.
ms.date: 01/24/2025
ms.topic: how-to
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
f1_keywords:
  - "vs.debug.enc"
helpviewer_keywords: 
  - /INCREMENTAL linker option
  - Apply Code Changes command
  - Edit and Continue, disabling
  - code changes, applying in break mode
  - INCREMENTAL linker option
  - Edit and Continue, enabling
  - break mode, applying code changes
  - Edit and Continue, applying code changes
  - Step command
  - Go command
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Configure Edit and Continue (C#, VB, C++)

::: moniker range=">=vs-2022"
You can disable or enable Hot Reload, previously called Edit and Continue, in the Visual Studio **Options** dialog box at design time. **Hot Reload** works only in debug builds. For more information, see [Hot Reload](../debugger/hot-reload.md).
::: moniker-end

::: moniker range="vs-2019"
Edit and Continue is a time-saving feature that enables you to make changes to your source code while your program is in break mode. When you resume execution of the program by choosing an execution command like **Continue** or **Step**, Edit and Continue automatically applies the code changes with some limitations. This allows you to make changes to your code during a debugging session, instead of having to stop, recompile your entire program, and restart the debugging session.

You can disable or enable Edit and Continue in the Visual Studio **Options** dialog box at design time. **Edit and Continue** works only in debug builds. For more information, see [Edit and Continue](../debugger/edit-and-continue.md).
::: moniker-end

For native C++, **Edit and Continue** requires using the `/INCREMENTAL` option. For more information about feature requirements in C++, see this [blog post](https://devblogs.microsoft.com/cppblog/c-edit-and-continue-in-visual-studio-2015-update-3/) and [Edit and Continue (C++)](../debugger/edit-and-continue-visual-cpp.md).

::: moniker range=">=vs-2022"

## Enable and configure Hot Reload

You can configure Hot Reload by selecting **Settings** from the **Hot Reload** drop-down button.

![Screenshot of configuring Hot Reload.](../debugger/media/vs-2022/dotnet-hot-reload-configure.png)

Or, open **Tools** > **Options** > **Debugging** > **.NET/C++ Hot Reload**.

> [!NOTE]
> If IntelliTrace is enabled and you collect both IntelliTrace events and call information, Edit and Continue is disabled. For more information, see [IntelliTrace](../debugger/intellitrace.md).

The settings for Hot Reload include:

- **Enable Hot Reload**. Enables Hot Reload when starting with the debugger attached (F5).

- **Enable Hot Reload when starting without debugging**. Enables Hot Reload when starting without the debugger attached (Ctrl+F5).

- **Apply Hot Reload on File Save**. Applies code changes when you save the file.

- **Logging Verbosity**. Filters amount of information displayed in the Hot Reload Output window.

![Screenshot of settings for .NET Hot Reload.](../debugger/media/vs-2022/dotnet-hot-reload-settings.png)

For .NET Hot Reload, you also can control whether Hot Reload is available at the project level by modifying your .NET 6+ project's *launchSetting.json* file and setting `hotReloadEnabled` to `false`.

Example:

```xaml
{
  "profiles": {
    "Console": {
      "commandName": "Project",
      "hotReloadEnabled": false
    }
  }
}
```

For C++, you can set additional options by opening **Tools** > **Options** > **Debugging** > **General**. Make sure **Enable Hot Reload** is selected, and set the other options:

- **Apply changes on continue (Native only)**

  If selected, Visual Studio automatically compiles and applies code changes when you continue debugging from a break state. Otherwise, you can choose to apply changes using **Debug** > **Apply Code Changes**.

- **Warn about stale code (Native only)**

  If selected, gives warnings about stale code.

::: moniker-end

::: moniker range="vs-2019"

## Enable or disable Edit and Continue

1. If you're in a debugging session, stop debugging (**Debug** > **Stop Debugging** or **Shift**+**F5**).

1. In **Tools** > **Options** > (or **Debug** > **Options**) > **Debugging** > **General**, select **Edit and Continue** in the right pane.

    > [!NOTE]
    > If IntelliTrace is enabled and you collect both IntelliTrace events and call information, Edit and Continue is disabled. For more information, see [IntelliTrace](../debugger/intellitrace.md).

1. For C++ code, make sure **Enable Native Edit and Continue** is selected, and set the other options:

   - **Apply changes on continue (Native only)**

     If selected, Visual Studio automatically compiles and applies code changes when you continue debugging from a break state. Otherwise, you can choose to apply changes using **Debug** > **Apply Code Changes**.

   - **Warn about stale code (Native only)**

     If selected, gives warnings about stale code.

1. Select **OK**.
::: moniker-end

## Stop code changes

::: moniker range=">=vs-2022"
While Hot Reload is in the process of applying code changes, you can stop the operation.
::: moniker-end

::: moniker range="vs-2019"
While Edit and Continue is in the process of applying code changes, you can stop the operation.
::: moniker-end

> [!CAUTION]
> Stopping code changes in managed code can produce unexpected results. Applying changes to managed code is normally a quick process, so there is seldom a need to stop code changes in managed code.

To stop applying code changes:

- Choose **Stop Applying Code Changes** from the **Debug** menu.

  This menu item is visible only when code changes are being applied.

  If you choose this option, none of the code changes are committed.
