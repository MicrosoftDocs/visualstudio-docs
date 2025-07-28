---
title: Visual Studio on ARM Processor-Powered Devices
description: Review recommendations for using Visual Studio on devices with ARM-based processors, including supported workloads and remote targeting.
ms.date: 08/01/2025
ms.topic: concept-article
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: installation

#customer intent: As a developer, I want to learn about Visual Basic support for ARM so that I can determine 
---
# Visual Studio on Arm-powered devices

::: moniker range="vs-2019"

Visual Studio is built to target processors based on the x86 architecture, and there are no versions of Visual Studio for ARM-based processors.

Visual Studio can run on ARM-powered devices via x86 emulation, though some features aren't currently supported on Azure Resource Manager. As such, we don't recommend running Visual Studio on devices that use ARM-based processors, and instead recommend remotely targeted ARM devices.

See [Visual Studio 2019 System Requirements](/visualstudio/releases/2019/system-requirements) for supported operating systems, hardware, supported languages, and other requirements and guidance.

::: moniker-end

::: moniker range=">=vs-2022"

[Visual Studio 2022 version 17.4 is now available as a native Arm64 application](https://aka.ms/vs/arm64) on Windows 11 Arm64. It's the first version of Visual Studio that natively supports building and debugging Arm64 apps on Arm-based processors. With Visual Studio 2022 version 17.4 and later, Visual Studio eliminates the dependence on x64 emulation [for most developer workloads](#supported-workloads). 

## Get started with Arm64 Visual Studio

To get started with the native Arm64 Visual Studio experience:

- Ensure you have an Arm64 device with Windows 11.
- Uninstall any prior versions of Visual Studio from your Arm64 device.
- Download and install the latest version [Visual Studio 2022](https://visualstudio.microsoft.com/vs/).

## Installing Arm64 Visual Studio

There's a single installer for both Visual Studio x64 and Arm64 architectures. The Visual Studio Installer detects if the system architecture is Arm64. The installer then downloads and installs the Arm64 version of Visual Studio on your Arm64 device (support is for Windows 11). If you're installing the product via a layout, you need to [explicitly configure the layout to include ARM binaries](./use-command-line-parameters-to-install-visual-studio.md#layout-command-and-command-line-parameters).

> [!NOTE]
> For Windows 11 Arm64, you must uninstall all previous versions of Visual Studio (x64, x86) before installing Visual Studio 2022 version 17.4 or later.

## Supported workloads

The Arm64 GA supports the following workloads:

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

### Managed developers

With this release, you can now build desktop applications (Windows Forms and WPF) using both .NET 6+ and .NET Framework 4.8.1. 
.NET Framework 4.8.1 is included in the next major update for Windows 11 and will be available for previous operating systems in the future. 

### Native developers

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
