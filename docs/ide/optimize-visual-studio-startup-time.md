---
title: "Optimize Visual Studio Startup Time | Microsoft Docs"
ms.custom: ""
ms.date: 8/31/2017
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "startup time [Visual Studio]"
  - "optimizing startup time [Visual Studio]"
  - "speed up start time [Visual Studio]"
ms.assetid: d1508121-8499-4084-8eb5-fa89fa7b17d3
caps.latest.revision: 4
author: "gewarren"
ms.author: "gewarren"
manager: "ghogen"
f1_keywords: 
  - "vs.performancecenter"
ms.technology: 
  - "vs-ide-general"
---

# Optimize Visual Studio Startup Time
Ideally, Visual Studio should always start up as quickly as possible. However, Visual Studio extensions and open tool windows can adversely affect startup time because they load automatically at startup. The **Manage Visual Studio Performance** window enables you see which extensions and features affect Visual Studio startup time and to control loading behavior of those extensions and features.

For more general tips on improving performance, see [Visual Studio Performance Tips and Tricks](../ide/visual-studio-performance-tips-and-tricks.md).

## Control startup behavior

To avoid extending startup time, Visual Studio 2017 avoids loading extensions during startup, using an on-demand-load approach. This behavior means that extensions don't open immediately after Visual Studio starts, but on an as-needed basis after startup. Also, because tool windows left open in a prior Visual Studio session can slow startup time, Visual Studio opens tool windows in a more intelligent way to avoid impacting startup time.

If Visual Studio detects slow startup, a pop-up message appears, alerting you to the extension or tool window that's causing the slowdown. The message also provides a link to the **Manage Visual Studio Performance** dialog box. You can also open this window using the **Help > Manage Visual Studio Performance** menu command.

![Manage Visual Studio Performance - popup reading 'We've noticed that extension ... is slowing Visual Studio'](../ide/media/vside_perfdialog_popup.png)

The dialog box lists the extensions and tools windows that are affecting startup performance. This dialog box enables you to change extension and tool window settings to improve startup performance.

### Change extension settings

If an extension is slowing down Visual Studio startup, the extension appears in the **Manage Visual Studio Performance** dialog box when you choose one of the extension types. The dialog box shows which extensions affect performance at startup, when loading a solution, and when typing in the editor.

![Manage Visual Studio Performance - extensions view](../ide/media/vside_perfdialog_extensions.png)

If the impact on startup, solution load, or typing time is unacceptably high, disable the extension for that scenario by selecting the **Disable** button. You can always re-enable the extension for future sessions by using the Extension Manager or the Manage Visual Studio Performance dialog box.

### Change tool window settings

If a tool window is slowing down Visual Studio startup and you wish to change the impact, you can override its behavior by choosing one of two options instead of **Use default behavior**:

- **Do not show window at startup:** the specified tool window is always closed when you next open Visual Studio, even if left open in a previous session. You can open the tool window from the appropriate menu.
- **Auto hide window at startup:** If a tool window was left open in a previous session, this option collapses the tool window's group at startup to avoid initializing the tool window. This option is a good choice if you use a tool window often, because the tool window is still available, but no longer negatively affects Visual Studio startup time.

![Manage Visual Studio Performance - tool windows view](../ide/media/vside_perfdialog_toolwindows.png)

You can always return to this dialog box at any time to change the setting for any given tool window.

## <a name="speed_up_solution_load"></a>Load large solutions faster in Visual Studio 2017

Visual Studio 2017 introduces a new feature called lightweight solution load that reduces the amount of time and memory required to load large solutions in the IDE. If you have a large solution containing many C#, VB, or C++ projects, you are likely to see a substantial performance benefit if you enable lightweight solution load. For detailed information on how you might benefit by using this feature, see [Optimize solution loading](../ide/optimize-solution-loading-in-visual-studio.md).

> [!NOTE]
> This content applies to Visual Studio 2017 Update 3.

### Enable or disable lightweight solution load

You can right-click the solution name in Solution Explorer, and select **Enable Lightweight Solution Load**. After selecting the option, you need to close and reopen the solution to activate lightweight solution load.

![Solution Explorer](../ide/media/VSIDE_LSL_Solution_Setting.png)

To configure global settings for lightweight solution load, see [Optimize solution loading](../ide/optimize-solution-loading-in-visual-studio.md#global_solution_load_settings).

## See Also
[Visual Studio Performance Tips and Tricks](../ide/visual-studio-performance-tips-and-tricks.md)
