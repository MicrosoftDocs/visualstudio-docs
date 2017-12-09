---
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
1.  On the device or server machine that you want to debug (rather than the machine running Visual Studio), get the correct version of the remote tools.

    |Version|Link|Notes|
    |-|-|-|
    |Visual Studio 2017 version 15.5|[Remote tools](https://www.visualstudio.com/downloads/#remote-tools-for-visual-studio-2017)|Always download the version matching your device operating system (x86 or x64). If enhanced security mode is enabled (Windows Server), you must add new trusted sites if prompted.|
    |Visual Studio 2017 (older)|[Remote tools](https://my.visualstudio.com/Downloads?q=remote%20tools%20visual%20studio%202017)|Remote tools for earlier releases of Visual Studio 2017 are available from My.VisualStudio.com. If prompted, join the free Visual Studio Dev Essentials group, or sign in with your Visual Studio subscription ID. If enhanced security mode is enabled (Windows Server), you must add new trusted sites if prompted.|
    |Visual Studio 2015 Update 3|[Remote tools](https://my.visualstudio.com/Downloads?q=remote%20tools%20visual%20studio%202015)|If prompted, join the free Visual Studio Dev Essentials group, or sign in with your Visual Studio subscription ID. If enhanced security mode is enabled (Windows Server), you must add new trusted sites if prompted.|
    |Visual Studio 2015 (older)|[Remote tools](https://my.visualstudio.com/Downloads?q=remote%20tools%20visual%20studio%202015)|If prompted, join the free Visual Studio Dev Essentials group, or sign in with your Visual Studio subscription ID. If enhanced security mode is enabled (Windows Server), you must add new trusted sites if prompted.|
    |Visual Studio 2013|[Remote tools](https://msdn.microsoft.com/library/bt727f1t(v=vs.120).aspx#BKMK_Installing_the_Remote_Tools)|Download page in Visual Studio 2013 documentation|
    |Visual Studio 2012|[Remote tools](https://msdn.microsoft.com/library/bt727f1t(v=vs.110).aspx#BKMK_Installing_the_Remote_Tools)|Download page in Visual Studio 2012 documentation|
  
2.  On the download page, choose the version of the tools that matches your operating system (x86, x64, or ARM) and download the remote tools.
  
    > [!IMPORTANT]
    >  We recommend you install the most recent version of the remote tools that matches your version of Visual Studio. Mismatched versions are not recommended. In addition, you must install the remote tools that have the same architecture as the operating system on which you want to install it. In other words, if you want to debug a 32-bit application on a remote computer running a 64-bit operating system, you must install the 64-bit version of the remote tools on the remote computer. 
    >   
    >  Surface 3 switched from ARM to x64 architecture. An ARM version of the remote tools is not available for Visual Studio 2017. For Visual Studio 2015, find the ARM version in the Visual Studio 2015 RTW download.
  
3.  When you have finished downloading the executable, go to the next section and follow setup instructions.

If you try to copy the remote debugger (msvsmon.exe) to the remote computer and run it, be aware that the **Remote Debugger Configuration Wizard** (**rdbgwiz.exe**) is installed only when you download the tools. You may need to use the wizard for configuration later, especially if you want the remote debugger to run as a service. For more information, see [(Optional) Configure the remote debugger as a service](../../debugger/remote-debugging.md#bkmk_configureService).