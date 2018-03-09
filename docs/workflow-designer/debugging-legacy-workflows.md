---
title: "Debugging Legacy Workflows | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
helpviewer_keywords: 
  - "workflows, debugging"
  - "debugging, workflows"
  - "debugging workflows"
ms.assetid: e6097b47-760a-4b30-a92c-ae70cdbda49f
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: 
  - "multiple"
---
# Debugging Legacy Workflows

If you are using the legacy Windows Workflow Designer in [!INCLUDE[vs_current_long](../misc/includes/vs_current_long_md.md)] to build [!INCLUDE[wf](../workflow-designer/includes/wf_md.md)] applications that target.NET Framework 3.0 or 3.5, you can debug your workflows like any other program by setting breakpoints, attaching to processes, and examining threads and the call stack. You also have the option of debugging remotely.

> [!NOTE]
> If multiple versions of Visual Studio have been installed and uninstalled on your machine, WF3 debugging can fail with one of the two following possibilities:
>
> -   Your breakpoints are not hit.
> -   The following message is displayed:
>
> **Unable to start debugging on the web server. The debugger is not properly installed.  Cannot debug the requested type of code.  Run setup to install or repair the debugger.**
>
> If either of these scenarios occurs when debugging .NET Framework 3.0 or 3.5 workflows, perform a repair of the Visual Studio installation.

 [!INCLUDE[wf2](../workflow-designer/includes/wf2_md.md)] integrates with the following standard [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] debug windows:

-   **Breakpoint**: Works as expected, but you specify an activity for the function name.

-   **Call Stack**: Modified to provide an outline of the activities that have executed in a workflow instance. The entries in the **Call Stack** window are a depth-first search of executing activities. You can double-click an entry to put focus on the selected activity.

-   **Threads**: Provides the instance ID of the workflow instance that is being debugged.

 Visual Studio for Windows Workflow Foundation does not support the following debugging features:

-   Conditional breakpoints on the designer surface.

-   QuickWatch.

-   Set next statement.

-   Run to cursor.

-   Edit and continue.

-   Just-in-time debugging.

-   Mixed-mode debugging.