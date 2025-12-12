---
title: Visual Studio on Arm Processor-Powered Devices
description: Review recommendations for using Visual Studio on devices with Arm-based processors, including supported workloads and remote targeting.
ms.date: 08/25/2025
ms.topic: concept-article
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: installation

#customer intent: As a developer, I want to learn about Visual Studio support for Arm so that I can determine the best path for getting started with building and debugging Arm64 apps by using Visual Studio.  
---
# Visual Studio on Arm-powered devices


::: moniker range=">=vs-2022"

[Visual Studio 2022 version 17.4 is now available as a native Arm64 application](https://aka.ms/vs/arm64) on Windows 11 for Arm-based PCs. It's the first version of Visual Studio that natively supports building and debugging Arm64 apps on Arm-based processors. Visual Studio 2022 version 17.4 and later eliminate the dependence on x64 emulation [for most developer workloads](#supported-workloads). This article describes how to get started with Visual Studio for Arm64.

## Get started with Visual Studio for Arm64

To get started with the native Arm64 Visual Studio experience:

- Ensure that Windows 11 is installed on your Arm64 device.
- Uninstall any prior versions of Visual Studio from your Arm64 device.
- Download and install the latest version of [Visual Studio 2022](https://visualstudio.microsoft.com/vs/).

## Installing Visual Studio for Arm64

There's a single installer for both Visual Studio x64 and Visual Studio Arm64 architectures. The Visual Studio Installer detects whether the system architecture is Arm64. If it is, the installer downloads and installs the Arm64 version of Visual Studio. (Only Windows 11 is supported.) If you install the product via a layout, you need to [explicitly configure the layout to include Arm binaries](./use-command-line-parameters-to-install-visual-studio.md#layout-command-and-command-line-parameters).

> [!NOTE]
> To use Visual Studio for Arm64, you must uninstall all previous versions of Visual Studio (x64, x86) before you install Visual Studio 2022 17.4 or later.

## Supported workloads

Visual Studio for Arm64 supports the following workloads:

- .NET desktop development
- Desktop development with C++
- ASP.NET and web development
- Node.js development
- Visual Studio extension development
- Game development with C++
- Game development with Unity
- Windows application development
- .NET Multi-platform App UI development (.NET MAUI)
- Linux and embedded development with C++
- Database development with SQL Server Data Tools

### Managed development

With this release, you can build desktop applications (Windows Forms and WPF) targeting both .NET 6 and later and .NET Framework 4.8.1. 
.NET Framework 4.8.1 is included in Windows 11 and is installable on some versions of Windows 10. 

### Native development

With Visual Studio 2022 17.4 and later, you can access the native Arm64 Visual C++ compiler toolset, which includes C++ code analysis, and still target all platforms currently supported by Visual C++.

| **Host architecture (platform the compiler is running on)** | **Target architecture (platform the compiler is generating binaries for)** | **Installation path** |
| ----------- | ------ | --------------- |
| Arm64 | Arm64 | \<Install location\>\VC\Tools\MSVC\\<version\>\bin\HostARM64\ARM64 |
| Arm64 | X64 | \<Install location\>\VC\Tools\MSVC\\<version\>\bin\HostARM64\x64 |
| Arm64 | X86 | \<Install location\>\VC\Tools\MSVC\\<version\>\bin\HostARM64\x86 |

Many C++ libraries are available on Arm64. vcpkg also runs natively on Arm64, and although some dependent non-Microsoft tools might still run emulated, you can successfully build and consume more than 1,700 C++ libraries directly in your native Arm64 build environment.

If you install the **Desktop development with C++** workload, you can load any desktop C++ project and solution using MSBuild, and then use the editing, building, and debugging capabilities that you're already familiar with in Visual Studio.

## Visual Studio versions before 17.4

Visual Studio 2022 versions before 17.4 can run on Arm-powered devices via x64 emulation, but some features aren't supported on Arm. Therefore, we don't recommend running these versions of Visual Studio on devices that use Arm-based processors. Instead, we recommend remotely targeting Arm devices.

See [Visual Studio 2022 System Requirements](/visualstudio/releases/2022/system-requirements) for supported operating systems, hardware, supported languages, and other requirements and guidance.

::: moniker-end


::: moniker range=">=vs-2022"

## We need your help!

Let us know what you like and whether you have suggestions for making Visual Studio better on Arm64. You can share feedback via [Developer Community](https://developercommunity.visualstudio.com/home): report any bugs or issues via [report a problem](../ide/how-to-report-a-problem-with-visual-studio.md) and [share your suggestions](https://developercommunity.visualstudio.com/report?space=8&entry=suggestion) for prioritizing more workloads.

::: moniker-end
