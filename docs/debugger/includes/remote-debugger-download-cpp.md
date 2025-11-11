---
 title: Remote debugger download (C++)
 description: Download links for the remote debugger for C++
 services: ""
 author: mikejo5000
 ms.service: ""
 ms.topic: include
 ms.date: 11/11/2021
 ms.author: mikejo
 ms.custom: include file
---

On the remote device or server that you want to debug on, rather than the Visual Studio machine, download and install the correct version of the remote tools from the links in the following table.

::: moniker range=">=visualstudio"
- Download the most recent update of the remote tools for your version of Visual Studio. Remote tools for Visual Studio 2022 and 2026 can be used with either version of Visual Studio. However, remote tools versions that are earlier than Visual Studio 2022 aren't compatible with later Visual Studio versions. (For example, if you're using Visual Studio 2019, download the latest update of the remote tools for Visual Studio 2019. In this scenario, don't download the remote tools for Visual Studio 2022.)
::: moniker-end
::: moniker range="vs-2022"
- Download the most recent update of the remote tools for your version of Visual Studio. Earlier remote tools versions aren't compatible with later Visual Studio versions. (For example, if you're using Visual Studio 2019, download the latest update of the remote tools for Visual Studio 2019. In this scenario, don't download the remote tools for Visual Studio 2022.)
::: moniker-end
- Download the remote tools with the same architecture as the machine you're installing them on. For example, if you want to debug a 32-bit app on a remote computer running a 64-bit operating system, install the 64-bit remote tools.
- If you're remote debugging an ARM64EC application on an ARM64 device, install the ARM64 remote tools, and then launch the x64 remote debugger that gets installed with those tools. This can be found under: *Program Files (x86)\Microsoft Visual Studio\<version>\Common7\IDE\Remote Debugger\x64*.

::: moniker range=">=vs-2022"

|Version|Link|Notes|
|-|-|-|
|Visual Studio 2022|[Remote tools](https://aka.ms/vs/download/?cid=learn-onpage-download-cta#remote-tools-for-visual-studio-2022)|Compatible with all Visual Studio 2022 versions. Download the version matching your device operating system (x86, x64 (AMD64), or ARM64). On older versions of Windows Server, see [Unblock the file download](/previous-versions/visualstudio/visual-studio-2017/debugger/remote-debugging-unblock-file-download) for help with downloading the remote tools.|
|Visual Studio 2019|[Remote tools](https://my.visualstudio.com/Downloads?q=remote%20tools%20visual%20studio%202019)|Remote tools for Visual Studio 2019 are available from My.VisualStudio.com. If prompted, join the free [Visual Studio Dev Essentials](https://visualstudio.microsoft.com/dev-essentials/) program, or sign in with your Visual Studio subscription ID. Download the version matching your device operating system (x86, x64 (AMD64), or ARM64). On older versions of Windows Server, see [Unblock the file download](/previous-versions/visualstudio/visual-studio-2017/debugger/remote-debugging-unblock-file-download) for help with downloading the remote tools.|
|Visual Studio 2017|[Remote tools](https://my.visualstudio.com/Downloads?q=remote%20tools%20visual%20studio%202017)|Remote tools for Visual Studio 2017 are available from My.VisualStudio.com. If prompted, join the free [Visual Studio Dev Essentials](https://visualstudio.microsoft.com/dev-essentials/) program, or sign in with your Visual Studio subscription ID. Download the version matching your device operating system (x86, x64 (AMD64), or ARM64). On Windows Server, see [Unblock the file download](/previous-versions/visualstudio/visual-studio-2017/debugger/remote-debugging-unblock-file-download) for help with downloading the remote tools.|
|Visual Studio 2015|[Remote tools](https://my.visualstudio.com/Downloads?q=remote%20tools%20visual%20studio%202015)|Remote tools for Visual Studio 2015 are available from My.VisualStudio.com. If prompted, join the free [Visual Studio Dev Essentials](https://visualstudio.microsoft.com/dev-essentials/) program, or sign in with your Visual Studio subscription ID. On Windows Server, see [Unblock the file download](/previous-versions/visualstudio/visual-studio-2017/debugger/remote-debugging-unblock-file-download) for help with downloading the remote tools.|
|Visual Studio 2013|[Remote tools](/previous-versions/visualstudio/visual-studio-2013/bt727f1t(v=vs.120)#installing-the-remote-tools)|Download page in Visual Studio 2013 documentation|
|Visual Studio 2012|[Remote tools](/previous-versions/visualstudio/visual-studio-2012/bt727f1t(v=vs.110)#installing-the-remote-tools)|Download page in Visual Studio 2012 documentation|

::: moniker-end
::: moniker range="vs-2019"

|Version|Link|Notes|
|-|-|-|
|Visual Studio 2019|[Remote tools](https://aka.ms/vs/download/?cid=learn-onpage-download-cta#remote-tools-for-visual-studio-2019)|Compatible with all Visual Studio 2019 versions. Download the version matching your device operating system (x86, x64 (AMD64), or ARM64). On Windows Server, see [Unblock the file download](/previous-versions/visualstudio/visual-studio-2017/debugger/remote-debugging-unblock-file-download) for help with downloading the remote tools. For the most recent version of the remote tools, open the [Visual Studio 2022 doc](../../debugger/remote-debugging.md?view=vs-2022&preserve-view=true).|
|Visual Studio 2017|[Remote tools](https://my.visualstudio.com/Downloads?q=remote%20tools%20visual%20studio%202017)|Compatible with all Visual Studio 2017 versions. Download the version matching your device operating system (x86, x64 (AMD64), or ARM64). On Windows Server, see [Unblock the file download](/previous-versions/visualstudio/visual-studio-2017/debugger/remote-debugging-unblock-file-download) for help with downloading the remote tools.|
|Visual Studio 2015|[Remote tools](https://my.visualstudio.com/Downloads?q=remote%20tools%20visual%20studio%202015)|Remote tools for Visual Studio 2015 are available from My.VisualStudio.com. If prompted, join the free [Visual Studio Dev Essentials](https://visualstudio.microsoft.com/dev-essentials/) program, or sign in with your Visual Studio subscription ID. On Windows Server, see [Unblock the file download](/previous-versions/visualstudio/visual-studio-2017/debugger/remote-debugging-unblock-file-download) for help with downloading the remote tools.|
|Visual Studio 2013|[Remote tools](/previous-versions/visualstudio/visual-studio-2013/bt727f1t(v=vs.120)#installing-the-remote-tools)|Download page in Visual Studio 2013 documentation|
|Visual Studio 2012|[Remote tools](/previous-versions/visualstudio/visual-studio-2012/bt727f1t(v=vs.110)#installing-the-remote-tools)|Download page in Visual Studio 2012 documentation|

::: moniker-end

You can run the remote debugger by copying *msvsmon.exe* to the remote computer, rather than installing the remote tools. However, the Remote Debugger Configuration Wizard (*rdbgwiz.exe*) is available only when you install the remote tools. You may need to use the wizard for configuration if you want to run the remote debugger as a service. For more information, see [(Optional) Configure the remote debugger as a service](../../debugger/remote-debugging.md#bkmk_configureService).

>[!NOTE]
>- To debug Windows 10 or later apps on ARM devices, use ARM64, which is available with the latest version of the remote tools.
>- To debug Windows 10 apps on Windows RT devices, use ARM, which is available only in the Visual Studio 2015 remote tools download.
