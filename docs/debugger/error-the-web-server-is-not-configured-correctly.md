---
description: "After taking steps detailed here to resolve the issue, and before trying again to debug, you may also need to reset IIS."
title: "The web server is not configured correctly | Microsoft Docs"
ms.date: "09/20/2017"
ms.topic: "error-reference"
f1_keywords:
  - "vs.debug.remote.projnotconfigured"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "debugger, Web application errors"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Error: The web server is not configured correctly

After taking steps detailed here to resolve the issue, and before trying again to debug, you may also need to reset IIS. You can do that by opening an Administrator command prompt and typing `iisreset`.

Take these steps to resolve this issue:

1. If the web app hosted on the server is configured as a Release build, republish as a Debug build, and verify that the web.config file contains `debug=true` in the compilation element. Reset IIS and retry.

    For example, if you are using a Publish Profile for a Release build, change it to Debug and republish. Otherwise, the debug attribute will be set to `false` when you publish.

2. (IIS) Verify that the physical path is correct. In IIS, you find this setting in **Basic Settings > Physical Path** (or **Advanced Settings** in older versions of IIS).

    The physical path may be incorrect if the web application was copied to a different machine, manually renamed, or moved. Reset IIS and retry.

3. If you are debugging locally in Visual Studio, verify that the correct server is selected in the properties. (Open **Properties > Web > Servers** or **Properties > Debug** depending on your project type. For a Web Forms project, open **Property Pages > Start Options > Server**).

    If you are using an external (custom) server such as IIS, the URL must be correct. Otherwise, select IIS Express and retry.

4. (IIS) Make sure that the correct version of ASP.NET is installed on the server.

    Mismatched versions of ASP.NET on IIS and in your Visual Studio project may cause this issue. You may need to set the framework version in web.config. To install ASP.NET on IIS, use the [Web Platform Installer (WebPI)](https://www.microsoft.com/web/downloads/platform.aspx). Also, see [IIS 8.0 Using ASP.NET 3.5 and ASP.NET 4.5](/iis/get-started/whats-new-in-iis-8/iis-80-using-aspnet-35-and-aspnet-45) or, for ASP.NET Core, [Host on Windows with IIS](https://docs.asp.net/en/latest/publishing/iis.html).

4. If the `maxConnection` limit in IIS is too low, and you have too many connections, you may need to [increase the connection limit](/iis/configuration/system.applicationhost/sites/sitedefaults/limits).

## See also
- [Remote Debugging ASP.NET on a Remote IIS Computer](../debugger/remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md)
- [Debugging Web Applications: Errors and Troubleshooting](../debugger/debugging-web-applications-errors-and-troubleshooting.md)
