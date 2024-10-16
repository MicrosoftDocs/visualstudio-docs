---
title: "Property settings for Web projects"
description: Know how to change the property settings for a web site debug configuration in the Property Pages dialog box of Visual Studio.
ms.date: "01/14/2022"
ms.topic: "ui-reference"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "debugging [Visual Studio], Web applications"
  - "project settings [Visual Studio], debug configurations"
  - "debug builds, project settings"
  - "projects [Visual Studio], debug configurations"
  - "debugging Web applications, project settings"
  - "debug configurations, Web projects"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Property Pages Settings for Web Projects

You can change the property settings for a web site debug configuration in the **Property Pages** dialog box, as discussed in [Debug and Release Configurations](../debugger/how-to-set-debug-and-release-configurations.md). The following tables show where to find debugger-related settings in the **Property Pages** dialog box.

::: moniker range=">=vs-2022"
>[!IMPORTANT]
>Some of these settings don't apply to ASP.NET Core. To configure debug settings for ASP.NET Core, see [Project settings for C# debug configurations (.NET 5+, .NET Core)](../debugger/project-settings-for-csharp-debug-configurations-dotnetcore.md).
::: moniker-end

### Start Options category

| **Setting** | **Description** |
| - | - |
| **Start Action** | Heading that groups options related to application startup. |
| **Current Page** | Specifies the current page as the starting point for debugging. |
| **Specific page:** | Specifies the Web page where you want to begin debugging. |
| **Start external program:** | Specifies the command for launching the program you want to debug. |
| **Command line arguments:** | Specifies arguments for the command specified above. |
| **Working directory:** | Specifies the working directory of the program being debugged. In Visual C#, the working directory is the directory the application is launched from, \bin\debug by default. |
| **Start URL** | Specifies the location of the Web application you want to debug. |
| **Don't open a page. Wait for a request from an external application** | Says to wait for a request from an external application. This option does not launch a browser or another application. It just prepares for debugging when called by an application. |
| **Server** | Heading that groups options related to the server to be used. |
| **Server type** | Says to use IIS Express or an External Host. |
| **Project URL** | Allows you to enter the Base URL to use as the server. |
| **Override application root URL** | Allows you to change the default application root URL. |
| **Debuggers** | Heading that groups options related to type of debugging to be done. |
| **ASP.NET** | Enables debugging of server pages written for the ASP.NET development platform. You must specify a URL in **Start URL**. |
| **Native code** | Enables you to debug calls to native (unmanaged) Win32 code from your managed application. |
| **SQL Server** | Allows debugging of SQL Server database objects. |
| **Silverlight** | Allows debugging of Silverlight components. |

## See also
- [Debugger Settings and Preparation](../debugger/debugger-settings-and-preparation.md)