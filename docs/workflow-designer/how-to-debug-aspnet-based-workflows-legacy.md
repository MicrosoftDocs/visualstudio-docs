---
title: "Workflow Designer - How to: Debug ASP.NET-Based Workflows (Legacy)"
ms.date: 11/04/2016
ms.topic: conceptual
ms.prod: visual-studio-dev15
ms.technology: vs-workflow-designer
helpviewer_keywords:
  - "ASP.NET, debugging workflows"
  - "debugging workflows, ASP.NET workflows"
  - "ASP.NET workflows, debugging"
  - "debugging, ASP.NET workflows"
ms.assetid: 79b21edc-9e7d-410d-af68-09c1598b9c30
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "aspnet"
---
# How to: Debug ASP.NET-Based Workflows (Legacy)

This topic describes how to debug ASP.NET-based Windows Workflow Foundation (WF) applications that target either the .NET Framework version 3.5 or the WinFX in the legacy Windows Workflow Designer.

You can debug legacy workflows that are started in ASP.NET or legacy workflows that are published as a Web service by attaching to the process in which the workflow is hosted.

## To debug an ASP.NET-based workflow

1.  Enable debugging for the ASP.NET application by setting **debug = true** in the web.config file.

2.  Set the workflow library as the startup project, and set breakpoints on the workflow.

3.  Enter the URL of the default Web page in the workflow project properties **Debug** option **Start browser with external URL** text box.

4.  Select **Attach to process** on the **Debug** menu.

5.  Select the process to attach to from the **Available Processes** list.

     Attach to the w3wp.exe, webdev.webserver, or aspnet_wp process in which the workflow is hosted.

6.  Click **Select** next to the **Attach To** text box.

     The **Select Code Type** dialog box appears.

7.  Select **Debug these code types** and select **Workflow**.

8.  Click **OK**.

9. Click **Attach**.

10. Open the default Web page in a browser and start the workflow.

## See also

- [Invoking the Visual Studio Debugger for Windows Workflow Foundation (Legacy)](../workflow-designer/invoking-the-visual-studio-debugger-for-windows-workflow-foundation-legacy.md)
- [How to: Set Breakpoints in Workflows (Legacy)](../workflow-designer/how-to-set-breakpoints-in-workflows-legacy.md)
- [Debugging Legacy Workflows](../workflow-designer/debugging-legacy-workflows.md)