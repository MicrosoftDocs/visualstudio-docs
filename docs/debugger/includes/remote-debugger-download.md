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

1.  On the device or server machine that you want to debug (rather than the machine running Visual Studio), get the correct version of the remote tools.

    |Version|Link|Notes|
    |-|-|-|
    |Visual Studio 2017 (latest version)|[Remote tools](https://visualstudio.microsoft.com/downloads/?q=remote+tools#remote-tools-for-visual-studio-2017)|The latest version of the remote tools is compatible with all Visual Studio 2017 releases. Always download the version matching your device operating system (x86, x64, or ARM64). On Windows Server, see [Unblock the file download](../../debugger/remote-debugging-unblock-file-download.md) for help to download the remote tools.|
    |Visual Studio 2015|[Remote tools](https://my.visualstudio.com/Downloads?q=remote%20tools%20visual%20studio%202015)|Remote tools for Visual Studio 2015 are available from My.VisualStudio.com. If prompted, join the free [Visual Studio Dev Essentials](https://visualstudio.microsoft.com/dev-essentials/) program, or sign in with your Visual Studio subscription ID. On Windows Server, see [Unblock the file download](../../debugger/remote-debugging-unblock-file-download.md) for help to download the remote tools.|
    |Visual Studio 2013|[Remote tools](/previous-versions/visualstudio/visual-studio-2013/bt727f1t(v=vs.120)#Installing_the_Remote_Tools)|Download page in Visual Studio 2013 documentation|
    |Visual Studio 2012|[Remote tools](/previous-versions/visualstudio/visual-studio-2012/bt727f1t(v=vs.110)#BKMK_Installing_the_Remote_Tools)|Download page in Visual Studio 2012 documentation|

2.  On the download page, choose the version of the tools that matches your operating system (x86, x64, ARM, or ARM64) and download the remote tools.

    > [!IMPORTANT]
    >  We recommend that you install the most recent version of the remote tools for your release of Visual Studio. The latest version (for example, 15.8) is compatible with earlier releases (for example, 15.0); however, earlier versions are not compatible with later releases. In addition, you must install the remote tools that have the same architecture as the operating system on which you want to install it. In other words, if you want to debug a 32-bit application on a remote computer running a 64-bit operating system, you must install the 64-bit version of the remote tools on the remote computer.
    >
    >  For debugging on Windows 10 on ARM devices, choose the ARM64 download available with the latest version of the remote tools.  For Windows RT devices, choose the ARM version, which is only available in the Visual Studio 2015 RTW download.

3.  When you have finished downloading the executable, go to the next section and follow setup instructions.

If you try to copy the remote debugger (msvsmon.exe) to the remote computer and run it, be aware that the **Remote Debugger Configuration Wizard** (**rdbgwiz.exe**) is installed only when you download the tools. You may need to use the wizard for configuration later, especially if you want the remote debugger to run as a service. For more information, see [(Optional) Configure the remote debugger as a service](../../debugger/remote-debugging.md#bkmk_configureService).
