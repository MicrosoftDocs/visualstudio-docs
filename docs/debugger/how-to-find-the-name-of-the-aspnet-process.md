---
title: Find the running ASP.NET process
description: Debug a running ASP.NET application in Visual Studio, and attach the Visual Studio debugger to the ASP.NET process by name.   
ms.date: 11/04/2018
ms.topic: how-to
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords: 
  - ASP.NET debugging, ASP.NET process
  - ASP.NET process
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
---
# Find the name of the ASP.NET process

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

To debug a running ASP.NET app, the Visual Studio debugger must attach to the ASP.NET process by name.

**To find out which process is running an ASP.NET app:**

1. With the app running, in Visual Studio, select **Debug** > **Attach to Process**.

1. In the **Attach to Process** dialog, type the first letters of process names from the following list, or enter them into the search box. The one that is running is the one running the ASP.NET app. Attach to that process to debug the app.

    - *w3wp.exe* is IIS 6.0 and later.
    - *aspnet_wp.exe* is earlier versions of IIS.
    - *iisexpress.exe* is IISExpress.
    - *dotnet.exe* is ASP.NET Core.
    - *inetinfo.exe* is older ASP applications running in-process.

>[!NOTE]
>Visual Studio 2012 and earlier ASP.NET code can be on the file system and run on the test server *WebDev.WebServer.exe* or *WebDev.WebServer40.exe*. In this case, for local debugging, attach to *WebDev.WebServer.exe* or *WebDev.WebServer40.exe* instead of the ASP.NET process.

## Related content

- [Attach to a running process](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md)
- [Prerequisites for remote debugging web applications](remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md)
- [System requirements](../debugger/aspnet-debugging-system-requirements.md)
- [Debug ASP.NET applications](../debugger/how-to-enable-debugging-for-aspnet-applications.md)