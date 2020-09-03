---
title: Visual Studio on ARM Powered Devices 
description: Recommendations for using Visual Studio on devices with ARM based processors.
ms.date: 08/24/2020
ms.topic: troubleshooting
manager: jillfra
author: andster
ms.author: andster
---

# Visual Studio on ARM powered devices

> [!IMPORTANT]
> Visual Studio is only supported on devices using a x86 or AMD64/x64 based processor.

Visual Studio is built to target processors based on the x86 architecture and there are no versions of Visual Studio for ARM based processors. However, Windows provides [x86 emulation on ARM](https://docs.microsoft.com/windows/uwp/porting/apps-on-arm-x86-emulation) on which Visual Studio can run. Running Visual Studio on an ARM processor via x86 emulation severely impairs the performance of Visual Studio and several features in Visual Studio are not designed to work with it. As such we don't recommend running Visual Studio on devices that use ARM based processors and instead recommend remotely targeted ARM devices.

## Remote targeting ARM devices
For the best experience, we recommend you use Visual Studio on a separate, x86 powered, computer, and use the remote deployment and debugging features in Visual Studio to target the ARM based device. To debug Windows Universal Applications already installed on the device see the [debug installed app package](https://docs.microsoft.com/visualstudio/debugger/debug-installed-app-package?view=vs-2019) documentation. To deploy a new app, see the documentation on [running a Windows Store app remotley](https://docs.microsoft.com/visualstudio/debugger/run-windows-store-apps-on-a-remote-machine?view=vs-2019). For all other application types see the [remote debugging](https://docs.microsoft.com/visualstudio/debugger/remote-debugging?view=vs-2019) documentation.

## Tips for running Visual Studio on ARM devices

### Use only when needed
Optimize your time by using Visual Studio only for ARM specific work. The performance on any ARM powered device is going to be poor, and you will likely find it unacceptable for regular use.

### Install time
Plan for Visual Studio to take longer to install and expect it to pause for period of times or require restarting.
 
### Remote tools
To debug an app running on a remote device, you'll need install the remote tools for ARM ([how to](https://docs.microsoft.com/visualstudio/debugger/remote-debugging?view=vs-2019#download-and-install-the-remote-tools)).

### Start debugging (F5)
Not all Visual Studio projects are configured to launch projects locally when start debugging (F5) from an ARM device. You may need to configure Visual Studio for remote debugging, even though your app is running local. See the [remote debugging](https://docs.microsoft.com/visualstudio/debugger/remote-debugging?view=vs-2019) documentation.

## We need you! 
If you'd like Visual Studio to run natively on ARM devices, we'd love to hear about the scenarios and support you would need. You can reach us by posting on [developer community](https://developercommunity.visualstudio.com/idea/1161018/native-arm-support-for-visual-studio.html). 