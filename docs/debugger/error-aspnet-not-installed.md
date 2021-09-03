---
description: "This error occurs when ASP.NET is not installed correctly on the computer that you are trying to debug."
title: "ASP.NET not installed"
ms.date: "11/04/2016"
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
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "aspnet"
---
# Error: ASP.NET Not Installed
This error occurs when [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] is not installed correctly on the computer that you are trying to debug. This might mean that [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] was never installed or that [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] was installed first and IIS was installed later.

### To reinstall ASP.NET

1. From a command prompt window, run the following command:

   ```cmd
   \WINDOWS\Microsoft.NET\Framework\version\aspnet_regiis -i
   ```

    where *version* represents the version number of the .NET Framework installed on your computer, such as v1.0.370. You can determine the framework version by looking in the `\WINDOWS\Microsoft.NET\Framework` directory.

   > [!NOTE]
   > With Windows Server 2003, you can install [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] by using **Add or Remove Programs** in Control Panel.

## See also
- [Debugging Web Applications: Errors and Troubleshooting](../debugger/debugging-web-applications-errors-and-troubleshooting.md)
