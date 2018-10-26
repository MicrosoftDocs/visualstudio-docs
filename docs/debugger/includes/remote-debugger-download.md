---
 title: Remote debugger download
 description: Download links for the remote debugger
 services: ""
 author: mikejo5000
 ms.service: ""
 ms.topic: include
 ms.date: 05/23/2018
 ms.author: mikejo
 ms.custom: include file
---

On the device or server that you want to debug, rather than the Visual Studio machine, download and install the correct version of the remote tools:

|Version|Link|Notes|
|-|-|-|
|Visual Studio 2017 (latest version)|[Remote tools](https://visualstudio.microsoft.com/downloads/?q=remote+tools#remote-tools-for-visual-studio-2017)|The latest version of the remote tools is compatible with all Visual Studio 2017 releases. Always download the version matching your device operating system (x86, x64, or ARM64). On Windows Server, see [Unblock the file download](../../debugger/remote-debugging-unblock-file-download.md) for help to download the remote tools.|
|Visual Studio 2015|[Remote tools](https://my.visualstudio.com/Downloads?q=remote%20tools%20visual%20studio%202015)|Remote tools for Visual Studio 2015 are available from My.VisualStudio.com. If prompted, join the free [Visual Studio Dev Essentials](https://visualstudio.microsoft.com/dev-essentials/) program, or sign in with your Visual Studio subscription ID. On Windows Server, see [Unblock the file download](../../debugger/remote-debugging-unblock-file-download.md) for help to download the remote tools.|
|Visual Studio 2013|[Remote tools](/previous-versions/visualstudio/visual-studio-2013/bt727f1t(v=vs.120)#Installing_the_Remote_Tools)|Download page in Visual Studio 2013 documentation|
|Visual Studio 2012|[Remote tools](/previous-versions/visualstudio/visual-studio-2012/bt727f1t(v=vs.110)#BKMK_Installing_the_Remote_Tools)|Download page in Visual Studio 2012 documentation|

>[!IMPORTANT]
>- Use the most recent version of the remote tools for your release of Visual Studio. The latest version is compatible with earlier releases, but earlier versions are not compatible with later releases. 
>- Use the remote tools with the same architecture as the machine you're installing them on. For example, if you want to debug a 32-bit app on a remote computer running a 64-bit operating system, install the 64-bit remote tools. 
>[!NOTE]
>-To debug Windows 10 apps on ARM devices, use ARM64, which is available with the latest version of the remote tools.  
>-To debug Windows 10 apps on Windows RT devices, use ARM, which is only available in the Visual Studio 2015 RTW download.

>[!NOTE]
>If you copy the remote debugger (*msvsmon.exe*) to the remote computer, rather than installing it, be aware that the **Remote Debugger Configuration Wizard** (**rdbgwiz.exe**) is installed only when you download and install the tools. You may need to use the wizard for configuration if you want the remote debugger to run as a service. For more information, see [(Optional) Configure the remote debugger as a service](../../debugger/remote-debugging.md#bkmk_configureService).

