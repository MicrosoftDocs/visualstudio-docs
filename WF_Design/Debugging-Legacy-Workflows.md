---
title: "Debugging Legacy Workflows"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: e6097b47-760a-4b30-a92c-ae70cdbda49f
caps.latest.revision: 8
manager: erikre
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Debugging Legacy Workflows
If you are using the legacy Windows Workflow Designer in Visual Studio 2012 to build Windows Workflow Foundation (WF) applications that target.NET Framework 3.0 or 3.5, you can debug your workflows like any other program by setting breakpoints, attaching to processes, and examining threads and the call stack. You also have the option of debugging remotely.  
  
> [!NOTE]
>  If multiple versions of Visual Studio have been installed and uninstalled on your machine, WF3 debugging can fail with one of the two following possibilities:  
>   
>  -   Your breakpoints are not hit.  
> -   The following message is displayed:  
>   
>  **Unable to start debugging on the web server. The debugger is not properly installed.  Cannot debug the requested type of code.  Run setup to install or repair the debugger.**  
>   
>  If either of these scenarios occurs when debugging .NET Framework 3.0 or 3.5 workflows, perform a repair of the Visual Studio installation.  
  
 Windows Workflow Foundation integrates with the following standard Visual Studio debug windows:  
  
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
  
## In This Section  
 [Invoking the Visual Studio Debugger for Windows Workflow Foundation (Legacy)](../WF_Design/Invoking-the-Visual-Studio-Debugger-for-Windows-Workflow-Foundation--Legacy-.md)  
  
 [Disabling the Visual Studio Debugger for Windows Workflow Foundation (Legacy)](../WF_Design/Disabling-the-Visual-Studio-Debugger-for-Windows-Workflow-Foundation--Legacy-.md)  
  
 [How to: Debug ASP.NET-Based Workflows (Legacy)](../WF_Design/How-to--Debug-ASP.NET-Based-Workflows--Legacy-.md)  
  
 [How to: Set Breakpoints in Workflows (Legacy)](../WF_Design/How-to--Set-Breakpoints-in-Workflows--Legacy-.md)  
  
 [Debugging Workflows from a Remote Computer (Legacy)](../WF_Design/Debugging-Workflows-from-a-Remote-Computer--Legacy-.md)  
  
 [Debug Stepping Options (Legacy)](../WF_Design/Debug-Stepping-Options--Legacy-.md)  
  
 [How to: Change the Debug Stepping Option (Legacy)](../WF_Design/How-to--Change-the-Debug-Stepping-Option--Legacy-.md)