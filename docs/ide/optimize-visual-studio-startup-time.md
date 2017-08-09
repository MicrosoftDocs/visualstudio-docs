---
title: "Optimize Visual Studio Startup Time | Microsoft Docs"
ms.custom: ""
ms.date: 7/20/2017
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
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
f1_keywords:
    - "vs.performancecenter"
---

# Optimize Visual Studio Startup Time
Ideally, Visual Studio should always start up as quickly as possible. However, Visual Studio extensions and open tool windows can adversely affect startup time because they load automatically at startup. The **Manage Visual Studio Performance** window enables you see which extensions and features affect Visual Studio startup time and to control loading behavior of those extensions and features.

## Control startup behavior

To avoid extending startup time, Visual Studio 2017 avoids loading extensions during startup, using an on-demand-load approach. This behavior means that extensions don't open immediately after Visual Studio starts, but on an as-needed basis after startup. Also, because tool windows left open in a prior Visual Studio session can slow startup time, Visual Studio opens tool windows in a more intelligent way to avoid impacting startup time.

If Visual Studio detects slow startup, a pop-up message appears, alerting you to the extension or tool window that's causing the slowdown. The message also provides a link to the **Manage Visual Studio Performance** dialog box, which can also be opened using the **Help > Manage Visual Studio Performance** menu command.

![Manage Visual Studio Performance - popup reading 'We've noticed that extension ... is slowing Visual Studio'](../ide/media/vside_perfdialog_popup.png)

The dialog box lists the extensions and tools windows that are affecting startup performance. This dialog box enables you to change extension and tool window settings to improve startup performance.

### Change extension settings

If an extension is slowing down Visual Studio startup, the extension appears in the **Manage Visual Studio Performance** dialog box when you choose one of the extension types. The dialog shows which extensions affect performance at startup, when loading a solution, and when typing in the editor.

![Manage Visual Studio Performance - extensions view](../ide/media/vside_perfdialog_extensions.png)

If the impact on startup, solution load, or typing time is unacceptably high, disable the extension for that scenario by selecting the **Disable** button. You can always re-enable the extension for future sessions by using the Extension Manager or the Manage Visual Studio Performance dialog box.

### Change tool window settings

If a tool window is slowing down Visual Studio startup and you wish to change the impact, you can override its behavior by choosing one of two options instead of **Use default behavior**:

- **Do not show window at startup:** the specified tool window is always closed when you next open Visual Studio, even if left open in a previous session. You can open the tool window from the appropriate menu.
- **Auto hide window at startup:** If a tool window was left open in a previous session, this option collapses the tool window's group at startup to avoid initializing the tool window. This option is a good choice if you use a tool window often, because the tool window is still available, but no longer negatively affects Visual Studio startup time.

![Manage Visual Studio Performance - tool windows view](../ide/media/vside_perfdialog_toolwindows.png)

You can always return to this dialog box at any time to change the setting for any given tool window.

## Speed up solution load

Visual Studio 2017 supports **lightweight solution load** that reduces the amount of time and memory required to load large solutions in the IDE. If you have a large solution containing many C#, VB, and/or C++ projects, you are likely to see a substantial performance benefit if you enable lightweight solution load.

Because some IDE features are not fully available when lightweight solution load is enabled, the feature is turned off by default. The following sections help you decide whether or not to enable this feature.

### Enable lightweight solution load

You can enable lightweight solution load for the IDE as a whole or for individual solutions.

To change lightweight solution load for settings for all projects and solution, go to **Tools > Options > Projects and Solutions > General** and select one of the three load options:

![Tools Options dialog box](../ide/media/VSIDE_LightweightSolutionLoad.png)

- **Let Visual Studio choose what's best for my solution:** Visual Studio determines whether to apply lightweight solution load by analyzing each solution when you open it. 
- **Enable:** Enable lightweight solution load is enabled for this solution regardless of the IDE-wide setting.
- **Disable:** Lightweight solution load is disabled for this solution regardless of the IDE-wide setting.

To enable lightweight solution load for an individual solution, select the top-level solution node in Solution Explorer. In the **Properties** window, choose **Default**, **Enabled**, or **Disabled** for the **Lightweight load** property.

![Solution Explorer](../ide/media/VSIDE_LSL Solution Setting.png)

You can also right-click the top-level solution node in Solution Explorer and select either **Enable Lightweight Solution Load** (if the feature is presently disabled) or **Disable Lightweight Solution Load** (if the feature is presently enabled):

When you change the lightweight solution load setting, the change takes effect the next time the solution is loaded. You don't need to restart the IDE.

### Automatically enable lightweight solution load

When you open a large solution in Visual Studio 2017, you may see a pop-up message offering to enable lightweight solution load. The message appears only for solutions that contain many C#, VB, or C++ projects. Choosing **enable** activated lightweight solution load for that solution only. The IDE-wide setting is not changed.

![Popup window](../ide/media/VSIDE_LSL Popup.png)

You can disable lightweight solution load later in the solution's **Properties** window.

### Limitations

Most features of the IDE are fully available when lightweight solution load is enabled. However, some IDE features and third-party extensions may not be fully compatible.  The following features are known to not work when lightweight solution load is enabled:

- Some third-party extensions may not behave as expected when lightweight solution load is enabled.
- Edit and Continue doesn't work in projects that are not loaded when you start debugging. The files contained in such a project is read-only and an error is reported that the project has not been loaded if an edit is attempted.
- When lightweight solution load is enabled, F# projects may not properly build and symbols may not be fully available in GoTo.
