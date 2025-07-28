---
title: Visual Studio on ARM Processor-Powered Devices
description: Review recommendations for using Visual Studio on devices with ARM-based processors, including supported workloads and remote targeting.
ms.date: 08/01/2025
ms.topic: concept-article
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: installation

#customer intent: As a developer, I want to learn about Visual Studio support for ARM so that I can determine the best path for getting started with building and debugging ARM64 apps by using Visual Studio.  
---
# Visual Studio on ARM-powered devices

::: moniker range="vs-2019"

Visual Studio 2019 is built to target processors based on the x86 architecture, and there are no versions of Visual Studio 2019 for ARM-based processors.

Visual Studio can run on ARM-powered devices via x86 emulation, though some features aren't currently supported on Azure Resource Manager. Therefore, we don't recommend running Visual Studio 2019 on devices that use ARM-based processors. Instead, we recommend remotely targeting ARM devices.

See [Visual Studio 2019 System Requirements](/visualstudio/releases/2019/system-requirements) for supported operating systems, hardware, supported languages, and other requirements and guidance.

::: moniker-end

::: moniker range=">=vs-2022"

[Visual Studio 2022 version 17.4 is now available as a native ARM64 application](https://aka.ms/vs/arm64) on Windows 11 for ARM-based PCs. It's the first version of Visual Studio that natively supports building and debugging ARM64 apps on ARM-based processors. Visual Studio 2022 version 17.4 and later eliminate the dependence on x64 emulation [for most developer workloads](#supported-workloads).

## Get started with Visual Studio for ARM64

To get started with the native ARM64 Visual Studio experience:

- Ensure that Windows 11 is installed on your ARM64 device.
- Uninstall any prior versions of Visual Studio from your ARM64 device.
- Download and install the latest version of [Visual Studio 2022](https://visualstudio.microsoft.com/vs/).

## Installing Visual Studio for ARM64

There's a single installer for both Visual Studio x64 and Visual Studio ARM64 architectures. The Visual Studio Installer detects whether the system architecture is ARM64. If it is, the installer downloads and installs the ARM64 version of Visual Studio. (Only Windows 11 is supported.) If you install the product via a layout, you need to [explicitly configure the layout to include ARM binaries](./use-command-line-parameters-to-install-visual-studio.md#layout-command-and-command-line-parameters).

> [!NOTE]
> To use Visual Studio for ARM64, you must uninstall all previous versions of Visual Studio (x64, x86) before you install Visual Studio 2022 17.4 or later.

## Supported workloads

The Visual Studio for ARM64 supports the following workloads:

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

With this release, you can build desktop applications (Windows Forms and WPF) using both .NET 6+ and .NET Framework 4.8.1. 
.NET Framework 4.8.1 is included in the next major update for Windows 11 and will be available for previous operating systems in the future. 

### Native development

With the Visual Studio 2022 version 17.4 release or later, you can access the new native Arm64 MSVC (Microsoft Visual C++) compiler toolset, including C++ Code Analysis, while still targeting all platforms currently supported by MSVC.

| **Host architecture (platform the compiler is running on)** | **Target architecture (platform the compiler is generating binaries for)** | **Installation path** |
| ----------- | ------ | --------------- |
| Arm64 | Arm64 | \<Install location\>\VC\Tools\MSVC\\<version\>\bin\HostARM64\ARM64 |
| Arm64 | X64 | \<Install location\>\VC\Tools\MSVC\\<version\>\bin\HostARM64\x64 |
| Arm64 | X86 | \<Install location\>\VC\Tools\MSVC\\<version\>\bin\HostARM64\x86 |

Many C++ libraries are already available on Arm64. `Vcpkg` also runs natively on Arm64, and while some dependent third party tools may still run emulated, you can successfully build and consume 1700+ C++ libraries directly in your native Arm64 build environment.

By installing the C++ Desktop workload, you can load any desktop C++ projects and solutions using MSBuild, and then use the editing, building, and debugging capabilities you're already familiar with in Visual Studio.

## Visual Studio versions before 17.4

Visual Studio 2022 versions before 17.4 can run on ARM-powered devices via x64 emulation, though some features aren't supported on ARM. As such, we don't recommend running these versions of Visual Studio on devices that use ARM-based processors, and instead recommend remotely targeted ARM devices.

See [Visual Studio 2022 System Requirements](/visualstudio/releases/2022/system-requirements) for supported operating systems, hardware, supported languages, and other requirements and guidance.

::: moniker-end

::: moniker range="vs-2019"

## Remote targeting ARM devices

For the best experience, we recommend you use Visual Studio on a separate x86 powered computer, and use the remote deployment and debugging features in Visual Studio to target the ARM-based device. To debug Windows Universal Applications already installed on the device, see the [debug installed app package](../debugger/debug-installed-app-package.md) documentation. To deploy a new app, see [running a Windows Store app remotely](../debugger/run-windows-store-apps-on-a-remote-machine.md). For all other application types, see the [remote debugging](../debugger/remote-debugging.md) documentation.

## Tips for running Visual Studio on ARM devices

### Use only when needed

Visual Studio can be run on an ARM processor using x86 emulation. Some features may not be supported in this emulation and performance may be slower when using emulation for ARM-based processors. You might consider remotely targeting ARM devices.

### Install time

Plan for Visual Studio to take longer to install, and expect it to pause for periods of time, or require a restart.
 
### Remote tools

To debug an app running on a remote device, you need to [download and install the remote tools](../debugger/remote-debugging.md#download-and-install-the-remote-tools) for ARM.

### Start debugging (F5)

Not all Visual Studio projects are configured to launch projects locally when you start debugging (**F5**) from an ARM device. You need to configure Visual Studio for remote debugging, even though your app is running locally. For more information, see [remote debugging](../debugger/remote-debugging.md).

::: moniker-end

::: moniker range=">=vs-2022"

## We need your help!

We’d love to hear from you about the experiences we're bringing online. Let us know what you like and whether you have suggestions for making Visual Studio even better on Arm64. You can share feedback with us via [Developer Community](https://developercommunity.visualstudio.com/home): report any bugs or issues via [report a problem](../ide/how-to-report-a-problem-with-visual-studio.md) and [share your suggestions](https://developercommunity.visualstudio.com/report?space=8&entry=suggestion) for prioritizing more workloads.

::: moniker-end
