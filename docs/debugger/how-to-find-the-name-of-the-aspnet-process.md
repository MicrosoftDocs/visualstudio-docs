---
title: Find the running ASP.NET process
description: Debug a running ASP.NET application in Visual Studio, and attach the Visual Studio debugger to the ASP.NET process by name.   
ms.date: 04/24/2024
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
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Find the name of the ASP.NET process

To debug a running ASP.NET app, the Visual Studio debugger must attach to the ASP.NET process by name.

**To find out which process is running an ASP.NET app:**

1. With the app running, in Visual Studio, select **Debug** > **Attach to Process**.

1. In the **Attach to Process** dialog, type the first letters of process names from the following list, or enter them into the search box. The one that is running is the one running the ASP.NET app. Attach to that process to debug the app.

    - *w3wp.exe* is for ASP.NET and also for ASP.NET Core when using the [in-process hosting model](/aspnet/core/host-and-deploy/aspnet-core-module?view=aspnetcore-3.1&preserve-view=true#hosting-models) (IIS 6.0 and later).
    - *appname.exe* is for ASP.NET Core running on the kestrel server (local default).
    - *iisexpress.exe* is for IISExpress.
    - *dotnet.exe* is for ASP.NET Core for the out-of-process hosting model.
    - aspnet_wp.exe* is for ASP.NET running on IIS before IIS 6.0.
    - *inetinfo.exe* is for older ASP applications running in-process.

## Related content

- [Attach to a running process](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md)
- [Prerequisites for remote debugging web applications](remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md)
- [System requirements](../debugger/aspnet-debugging-system-requirements.md)
- [Debug ASP.NET applications](../debugger/how-to-enable-debugging-for-aspnet-applications.md)