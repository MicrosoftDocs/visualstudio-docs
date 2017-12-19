---
title: "How to: Find the Name of the ASP.NET Process | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords: 
  - "ASP.NET debugging, ASP.NET process"
  - "ASP.NET process"
ms.assetid: 931a7597-b0f0-4a28-931d-46e63344435f
caps.latest.revision: 29
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "aspnet"
---
# How to: Find the Name of the ASP.NET Process
To attach to a running [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] application, you have to know the name of the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] process:  

-   If you are running ASP.NET Core on IIS or IISExpress, the process name is dotnet.exe.

-   If you are running ASP.NET on IIS 6.0 later, the name is w3wp.exe.  
  
-   If you are running ASP.NET on an earlier version of IIS, the name is aspnet_wp.exe.

-   If you are running ASP.NET on IISExpress, the name is iisexpress.exe.
  
For applications built by using versions of Visual Studio prior to Visual Studio 2012, the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] code can reside on the file system and run under the test server WebDev.WebServer.exe or WebDev.WebServer40.exe. In that case, you must attach to WebDev.WebServer.exe or WebDev.WebServer40.exe instead of the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] process. This scenario applies only to local debugging.
  
Older ASP applications run inside the IIS process inetinfo.exe when they are running in-process.  

### To determine the IIS version under which the application is running  

1.  Make sure the application is running and then, from Visual Studio, use the [Attach to Process](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md) command.

2.  Type the first letter of a process name like w3wp.exe to quickly find processes in the **Available Processes** list.

    The available processes from the list in this topic will indicate which versions of IIS are available, and which process is running your application.

    > [!NOTE]
    > Starting in Visual Studio 2017, you can use the search box to search for the process name.
  
## See Also  
 [Attach to a running process](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md)  
 [Prerequistes for Remote Debugging Web Applications](../debugger/prerequistes-for-remote-debugging-web-applications.md)   
 [System Requirements](../debugger/aspnet-debugging-system-requirements.md)   
 [Debug ASP.NET Applications](../debugger/how-to-enable-debugging-for-aspnet-applications.md)