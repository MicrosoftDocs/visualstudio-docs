---
title: "Locating Visual Studio"
description: You can install multiple instances of the same version of Visual Studio. Learn how to use a COM query API to find the instance that you want.
ms.date: "08/21/2017"
ms.topic: "conceptual"
helpviewer_keywords:
  - "deployment, VSIX"
author: tinaschrepfer
ms.author: tinali
---
# Locate Visual Studio

Starting with Visual Studio 2017, you can install multiple instances of the same version or even edition. This is helpful when you want to preview new functionality on your primary development machine while keeping your previous installation. Because of these changes, there is no single environment variable or registry value you can use to locate an instance. Instead, you can use a [COM query API](/dotnet/api/microsoft.visualstudio.setup.configuration) to find instances based on criteria relevant to your extension.

This is a fast, read-only API with NuGet packages available for native and managed code.

| Code | Package |
| ---- | --- |
| Native | `https://nuget.org/packages/Microsoft.VisualStudio.Setup.Configuration.Native` |
| Managed | `https://nuget.org/packages/Microsoft.VisualStudio.Setup.Configuration.Interop` |

You can locate a single instance given a path or the current process, or enumerate all instances. See [our samples](https://github.com/Microsoft/vs-setup-samples) for complete examples of how to locate Visual Studio.

## Tools

To find Visual Studio and other tools in build environments, PowerShell scripts, installers, and more scenarios, there are a number of open-source tools you can use directly or redistribute along with your own scripts.

| Project | Description |
| ------- | ----------- |
| [vswhere](https://github.com/Microsoft/vswhere) | Single-file native executable to locate instances meeting criteria such as release or pre-release, what product is installed, and which workloads are installed. Also supports finding Visual Studio 2010 and newer, though less information is returned that for Visual Studio 2017 and newer. See the [wiki](https://github.com/Microsoft/vswhere/wiki) for examples. |
| [VSSetup cmdlets](https://github.com/Microsoft/vssetup.powershell) | PowerShell cmdlets supported 2.0 and newer that return rich information as objects you can use to find instances based on the same criteria as *vswhere* and to discover even more properties about instances. See the [wiki](https://github.com/Microsoft/vssetup.powershell/wiki) for examples. |
| [VSIXBootstrapper](https://github.com/Microsoft/vsixbootstrapper) | Automatically locates *VSIXInstaller* and passes the command line through to install a `*.vsix` file. This feature can be useful in installers that do not have direct support for the query APIs. See the [wiki](https://github.com/Microsoft/vsixbootstrapper/wiki) for examples. |

## Related content

* [Changes to Visual Studio 2017 setup](https://devblogs.microsoft.com/setup/changes-to-visual-studio-15-setup/)
* [Launch Visual Studio using DTE](launch-visual-studio-dte.md)
