---
title: Visual Studio on ARM powered devices
description: Recommendations for using Visual Studio on devices with ARM-based processors.
ms.date: 05/13/2022
ms.topic: conceptual
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.workload:
- multiple
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Visual Studio on ARM-powered devices

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

::: moniker range="vs-2019"

Visual Studio is built to target processors based on the x86 architecture, and there are no versions of Visual Studio for ARM-based processors.

Visual Studio can run on ARM-powered devices via x86 emulation, though some features are not currently supported on ARM. As such, we don't recommend running Visual Studio on devices that use ARM-based processors, and instead recommend remotely targeted ARM devices.

See [Visual Studio 2019 System Requirements](/visualstudio/releases/2019/system-requirements) for supported operating systems, hardware, supported languages, and additional requirements and guidance.

::: moniker-end

::: moniker range="vs-2022"

Visual Studio is built to target processors based on the x64 architecture, and there are no versions of Visual Studio for ARM-based processors.

Visual Studio can run on ARM-powered devices via x64 emulation, though some features are not currently supported on ARM. As such, we don't recommend running Visual Studio on devices that use ARM-based processors, and instead recommend remotely targeted ARM devices.

See [Visual Studio 2022 System Requirements](/visualstudio/releases/2022/system-requirements) for supported operating systems, hardware, supported languages, and additional requirements and guidance.

> [!NOTE]
> 17.3 Preview 2 release of Visual Studio 2022 will include support for Windows 11 on Arm64! This version of Visual Studio will run natively on Arm64, giving developers the ability to build and debug apps directly on Arm64-based Windows 11 devices. Checkout the [release blog](https://blogs.windows.com/windowsdeveloper/2022/05/24/create-next-generation-experiences-at-scale-with-windows/) to learn more.
::: moniker-end

## Remote targeting ARM devices

::: moniker range="vs-2019"

For the best experience, we recommend you use Visual Studio on a separate, x86 powered, computer, and use the remote deployment and debugging features in Visual Studio to target the ARM-based device. To debug Windows Universal Applications already installed on the device, see the [debug installed app package](../debugger/debug-installed-app-package.md) documentation. To deploy a new app, see [running a Windows Store app remotely](../debugger/run-windows-store-apps-on-a-remote-machine.md). For all other application types, see the [remote debugging](../debugger/remote-debugging.md) documentation.

::: moniker-end

::: moniker range="vs-2022"

For the best experience, we recommend you use Visual Studio on a separate, x64 powered, computer, and use the remote deployment and debugging features in Visual Studio to target the ARM-based device. To debug Windows Universal Applications already installed on the device, see the [debug installed app package](../debugger/debug-installed-app-package.md) documentation. To deploy a new app, see [running a Windows Store app remotely](../debugger/run-windows-store-apps-on-a-remote-machine.md). For all other application types, see the [remote debugging](../debugger/remote-debugging.md) documentation.

::: moniker-end

## Tips for running Visual Studio on ARM devices

### Use only when needed

::: moniker range="vs-2019"

Visual Studio can be run on an ARM processor using x86 emulation. Note that some features may not be supported in this emulation and performance may be slower when using emulation for ARM-based processors. You might consider remotely targeting ARM devices.

::: moniker-end

::: moniker range="vs-2022"

Visual Studio can be run on an ARM processor using x64 emulation. Note that some features may not be supported in this emulation and performance may be slower when using emulation for ARM-based processors. You might consider remotely targeting ARM devices.

::: moniker-end

### Install time
Plan for Visual Studio to take longer to install, and expect it to pause for periods of time, or require restarting.
 
### Remote tools
To debug an app running on a remote device, you'll need to [download and install the remote tools](../debugger/remote-debugging.md#download-and-install-the-remote-tools) for ARM.

### Start debugging (F5)
Not all Visual Studio projects are configured to launch projects locally when you start debugging (**F5**) from an ARM device. You may need to configure Visual Studio for remote debugging, even though your app is running locally. For more information, see [remote debugging](../debugger/remote-debugging.md).

## We need your help!
If you'd like Visual Studio to run natively on ARM devices, we'd love to hear about the scenarios and support necessary. You can reach us by posting on the [developer community](https://developercommunity.visualstudio.com/idea/1161018/native-arm-support-for-visual-studio.html).
