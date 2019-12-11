---
title: "Find the running ASP.NET process | Microsoft Docs"
ms.date: "11/04/2018"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "ASP.NET debugging, ASP.NET process"
  - "ASP.NET process"
ms.assetid: 931a7597-b0f0-4a28-931d-46e63344435f
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "aspnet"
---
# Find the name of the ASP.NET process

To debug a running [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] app, the Visual Studio debugger must attach to the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] process by name.

**To find out which process is running an ASP.NET app:**

1. With the app running, in Visual Studio, select **Debug** > **Attach to Process**.

1. In the **Attach to Process** dialog, type the first letters of process names from the following list, or enter them into the search box. The one that is running is the one running the ASP.NET app. Attach to that process to debug the app.

    - *w3wp.exe* is IIS 6.0 and later.
    - *aspnet_wp.exe* is earlier versions of IIS.
    - *iisexpress.exe* is IISExpress.
    - *dotnet.exe* is ASP.NET Core.
    - *inetinfo.exe* is older ASP applications running in-process.

>[!NOTE]
>Visual Studio 2012 and earlier [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] code can be on the file system and run on the test server *WebDev.WebServer.exe* or *WebDev.WebServer40.exe*. In this case, for local debugging, attach to *WebDev.WebServer.exe* or *WebDev.WebServer40.exe* instead of the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] process.

**See also:**

- [Attach to a running process](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md)
- [Prerequisites for remote debugging web applications](remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md)
- [System requirements](../debugger/aspnet-debugging-system-requirements.md)
- [Debug ASP.NET applications](../debugger/how-to-enable-debugging-for-aspnet-applications.md)