---
title: "Debugging Legacy Workflows | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
helpviewer_keywords:
  - "workflows, debugging"
  - "debugging, workflows"
  - "debugging workflows"
ms.assetid: e6097b47-760a-4b30-a92c-ae70cdbda49f
caps.latest.revision: 8
author: jillre
ms.author: jillfra
manager: jillfra
---
# Debugging Legacy Workflows
If you are using the legacy [!INCLUDE[wfd1](../includes/wfd1-md.md)] in [!INCLUDE[vs_current_long](../includes/vs-current-long-md.md)] to build [!INCLUDE[wf](../includes/wf-md.md)] applications that target.NET Framework 3.0 or 3.5, you can debug your workflows like any other program by setting breakpoints, attaching to processes, and examining threads and the call stack. You also have the option of debugging remotely.

> [!NOTE]
> If multiple versions of Visual Studio have been installed and uninstalled on your machine, WF3 debugging can fail with one of the two following possibilities:
>
> - Your breakpoints are not hit.
>   - The following message is displayed:
>
>   **Unable to start debugging on the web server. The debugger is not properly installed.  Cannot debug the requested type of code.  Run setup to install or repair the debugger.**
>
>   If either of these scenarios occurs when debugging .NET Framework 3.0 or 3.5 workflows, perform a repair of the Visual Studio installation.

 [!INCLUDE[wf2](../includes/wf2-md.md)] integrates with the following standard [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] debug windows:

- **Breakpoint**: Works as expected, but you specify an activity for the function name.

- **Call Stack**: Modified to provide an outline of the activities that have executed in a workflow instance. The entries in the **Call Stack** window are a depth-first search of executing activities. You can double-click an entry to put focus on the selected activity.

- **Threads**: Provides the instance ID of the workflow instance that is being debugged.

  Visual Studio for Windows Workflow Foundation does not support the following debugging features:

- Conditional breakpoints on the designer surface.

- QuickWatch.

- Set next statement.

- Run to cursor.

- Edit and continue.

- Just-in-time debugging.

- Mixed-mode debugging.

## In This Section
 [Invoking the Visual Studio Debugger for Windows Workflow Foundation (Legacy)](../workflow-designer/invoking-the-visual-studio-debugger-for-windows-workflow-foundation-legacy.md)

 [Disabling the Visual Studio Debugger for Windows Workflow Foundation (Legacy)](../workflow-designer/disabling-the-visual-studio-debugger-for-windows-workflow-foundation-legacy.md)

 [How to: Debug ASP.NET-Based Workflows (Legacy)](../workflow-designer/how-to-debug-aspnet-based-workflows-legacy.md)

 [How to: Set Breakpoints in Workflows (Legacy)](../workflow-designer/how-to-set-breakpoints-in-workflows-legacy.md)

 [Debugging Workflows from a Remote Computer (Legacy)](../workflow-designer/debugging-workflows-from-a-remote-computer-legacy.md)

 [Debug Stepping Options (Legacy)](../workflow-designer/debug-stepping-options-legacy.md)

 [How to: Change the Debug Stepping Option (Legacy)](../workflow-designer/how-to-change-the-debug-stepping-option-legacy.md)