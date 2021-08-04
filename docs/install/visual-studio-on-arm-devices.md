---
title: Visual Studio on ARM powered devices
description: Recommendations for using Visual Studio on devices with ARM-based processors.
ms.date: 09/10/2020
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

> [!IMPORTANT]
> Visual Studio is only supported on devices using a x86 or AMD64/x64 based processor.

Visual Studio is built to target processors based on the x86 architecture, and there are no versions of Visual Studio for ARM-based processors. However, Windows provides [x86 emulation on ARM](https://www.docs.microsoft.com/windows/uwp/porting/apps-on-arm-x86-emulation), which Visual Studio can run. Running Visual Studio on an ARM processor via x86 emulation severely impairs the performance of Visual Studio, and several features in Visual Studio are not designed to work in this scenario. As such, we don't recommend running Visual Studio on devices that use ARM-based processors, and instead recommend remotely targeted ARM devices.

## Remote targeting ARM devices
For the best experience, we recommend you use Visual Studio on a separate, x86 powered, computer, and use the remote deployment and debugging features in Visual Studio to target the ARM-based device. To debug Windows Universal Applications already installed on the device, see the [debug installed app package](../debugger/debug-installed-app-package.md) documentation. To deploy a new app, see [running a Windows Store app remotley](../debugger/run-windows-store-apps-on-a-remote-machine.md). For all other application types, see the [remote debugging](../debugger/remote-debugging.md) documentation.

## Tips for running Visual Studio on ARM devices

### Use only when needed
Optimize your time by using Visual Studio only when necessary for ARM-specific work. The performance on any ARM-powered device is going to be poor, and you will likely find it unacceptable for regular use.

### Install time
Plan for Visual Studio to take longer to install, and expect it to pause for periods of time, or require restarting.
 
### Remote tools
To debug an app running on a remote device, you'll need to [download and install the remote tools](../debugger/remote-debugging.md#download-and-install-the-remote-tools) for ARM.

### Start debugging (F5)
Not all Visual Studio projects are configured to launch projects locally when you start debugging (**F5**) from an ARM device. You may need to configure Visual Studio for remote debugging, even though your app is running locally. For more information, see [remote debugging](../debugger/remote-debugging.md).

## We need your help!
If you'd like Visual Studio to run natively on ARM devices, we'd love to hear about the scenarios and support necessary. You can reach us by posting on the [developer community](https://developercommunity.visualstudio.com/idea/1161018/native-arm-support-for-visual-studio.html).
