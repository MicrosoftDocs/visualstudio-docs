---
title: Improve start up time, control extension settings
description: Learn how to control the settings of extensions and tool windows in the Performance Manager dialog box to improve Visual Studio start-up time.
ms.date: 04/24/2023
ms.topic: how-to
helpviewer_keywords:
- startup time [Visual Studio]
- optimizing performance [Visual Studio]
- speed up start time [Visual Studio]
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# Optimize Visual Studio startup time

Visual Studio is designed to start up as quickly and efficiently as possible. However, certain Visual Studio extensions and tool windows can adversely affect startup time when they're loaded. You can control the behavior of slow extensions and tool windows in the **Performance Manager** dialog box. For more general tips on improving performance, see [Visual Studio performance tips and tricks](../ide/visual-studio-performance-tips-and-tricks.md).

## Startup behavior

To avoid extending startup time, Visual Studio loads extensions using an *on demand* approach. This behavior means that extensions don't open immediately after Visual Studio starts, but on an as-needed basis. Also, because tool windows left open in a prior Visual Studio session can slow startup time, Visual Studio opens tool windows in a more intelligent way to avoid impacting startup time.

If Visual Studio detects slow startup, a pop-up message appears, alerting you to the extension or tool window that's causing the slowdown. The message provides a link to the **Performance Manager** dialog box. You can also access this dialog box by choosing **Help** > **Visual Studio Performance Manager** from the menu bar.

![Screenshot of the Performance Manager popup that says 'We've noticed that extension ... is slowing Visual Studio'](../ide/media/vside_perfdialog_popup.png)

The dialog box lists the extensions and tools windows that are affecting startup performance. You can change extension and tool window settings to improve startup performance.

## <a name="extensions"></a> To change extension settings to improve startup, solution load, and typing performance

1. Open the **Performance Manager** dialog box by choosing **Help** > **Visual Studio Performance Manager** from the menu bar.

    If an extension is slowing down Visual Studio startup, solution loading, or typing, the extension appears in the **Performance Manager** dialog box under **Extensions** > **Startup** (or **Solution Load** or **Typing**).

    ![Screenshot of the extensions view in the Performance Manager dialog box](../ide/media/vside_perfdialog_extensions.png)

2. Choose the extension you want to disable, then choose the **Disable** button.

You can always re-enable the extension for future sessions by using the **Extension Manager** or the **Visual Studio Performance Manager** dialog box.

## <a name="tool-windows"></a> To change tool window settings to improve startup time

1. Open the **Performance Manager** dialog box by choosing **Help** > **Visual Studio Performance Manager** from the menu bar.

    If a tool window is slowing down Visual Studio startup, the tool window appears in the **Performance Manager** dialog box under **Tool Windows** > **Startup**.

2. Choose the tool window you want to change the behavior for.

3. Choose one of the following three options:

   - **Use default behavior:** The default behavior for the tool window. Keeping this option selected won't improve startup performance.

   - **Do not show window at startup:** The specified tool window is always closed when you open Visual Studio, even if you left it open in a previous session. You can open the tool window from the appropriate menu when you need it.

   - **Auto hide window at startup:** If a tool window was left open in a previous session, this option collapses the tool window's group at startup to avoid initializing the tool window. This option is a good choice if you use a tool window often. The tool window is still available, but no longer negatively affects Visual Studio startup time.

     ![Screenshot of the tools windows view in the Performance Manager dialog box](../ide/media/vside_perfdialog_toolwindows.png)

> [!NOTE]
> Some earlier versions of Visual Studio had a feature named **lightweight solution load**. In current versions, large solutions that contain managed code load much faster than previously, even without lightweight solution load.

## Related content

- [Optimize Visual Studio performance](../ide/optimize-visual-studio-performance.md)
- [Visual Studio performance tips and tricks](../ide/visual-studio-performance-tips-and-tricks.md)
