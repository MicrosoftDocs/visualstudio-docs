---
description: "This error occurs when ASP.NET is not installed correctly on the computer that you are trying to debug."
title: "ASP.NET not installed"
ms.date: "09/19/2024"
ms.topic: "error-reference"
f1_keywords:
  - "vs.debug.error.http_not_supported"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "Web applications, errors"
  - "debugger, Web application errors"
  - "error messages, ASP.NET"
  - "ASP.NET, installation error messages"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Error: ASP.NET Not Installed

This error occurs when ASP.NET is not installed correctly on the computer that you are trying to debug. This might mean that ASP.NET was never installed or that ASP.NET was installed first and IIS was installed later.

The following procedure describes how to install ASP.NET using `aspnet_regiis.exe` for ASP.NET 4.0 and earlier versions. 

You can't install or uninstall ASP.NET 4.5 or later versions on Microsoft Windows 8 or Windows Server 2012 by using `aspnet_regiis.exe`. For more information, see [Install ASP.NET 4.5 in Windows 8 and Windows Server 2012](/troubleshoot/developer/webapps/aspnet/www-administration-management/install-aspnet-45-windows-8-server-2012)

> [!NOTE]
> For ASP.NET Core, see [Install the ASP.NET Core Module/Hosting Bundle](/aspnet/core/host-and-deploy/iis/#install-the-aspnet-core-modulehosting-bundle).

### To reinstall ASP.NET

1. From a command prompt window, run the following command:

   ```cmd
   \WINDOWS\Microsoft.NET\Framework\version\aspnet_regiis -i
   ```

    where *version* represents the version number of the .NET Framework installed on your computer, such as v1.0.370. You can determine the framework version by looking in the `\WINDOWS\Microsoft.NET\Framework` directory.

## See also
- [Debugging Web Applications: Errors and Troubleshooting](../debugger/debugging-web-applications-errors-and-troubleshooting.md)
