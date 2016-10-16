---
title: "How to: Debug ASP.NET-Based Workflows (Legacy)"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "reference"
helpviewer_keywords: 
  - "ASP.NET, debugging workflows"
  - "debugging workflows, ASP.NET workflows"
  - "ASP.NET workflows, debugging"
  - "debugging, ASP.NET workflows"
ms.assetid: 79b21edc-9e7d-410d-af68-09c1598b9c30
caps.latest.revision: 5
ms.author: "erikre"
manager: "erikre"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Debug ASP.NET-Based Workflows (Legacy)
This topic describes how to debug [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)]-based [!INCLUDE[wf](../workflowdesigner/includes/wf_md.md)] applications that target either the [!INCLUDE[netfx35_long](../workflowdesigner/includes/netfx35_long_md.md)] or the [!INCLUDE[vstecwinfx](../workflowdesigner/includes/vstecwinfx_md.md)] in the legacy [!INCLUDE[wfd1](../workflowdesigner/includes/wfd1_md.md)].  
  
 You can debug legacy workflows that are started in ASP.NET or legacy workflows that are published as a Web service by attaching to the process in which the workflow is hosted.  
  
### To debug an ASP.NET-based workflow  
  
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
  
## See Also  
 [Invoking the Visual Studio Debugger for Windows Workflow Foundation (Legacy)](../workflowdesigner/invoking-the-visual-studio-debugger-for-windows-workflow-foundation--legacy-.md)   
 [How to: Set Breakpoints in Workflows (Legacy)](../workflowdesigner/how-to--set-breakpoints-in-workflows--legacy-.md)   
 [Debugging Legacy Workflows](../workflowdesigner/debugging-legacy-workflows.md)