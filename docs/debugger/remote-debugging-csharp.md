---
title: "Remote Debug a C# or VB Project in Visual Studio | Microsoft Docs"
ms.custom: "H1Hack27Feb2017"
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "hero-article"
f1_keywords: 
  - "vs.debug.remote.overview"
dev_langs: 
  - "C++"
  - "FSharp"
  - "CSharp"
  - "JScript"
  - "VB"
helpviewer_keywords: 
  - "remote debugging, setup"
ms.assetid: a9753fbb-e7f4-47f0-9dbe-9de90c6c8457
caps.latest.revision: 65
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Remote Debugging a C# or Visual Basic project in Visual Studio
You can debug a Visual Studio application that has been deployed on a different computer. To do so, you use the Visual Studio remote debugger.  
  
For information about remote debugging apps with Azure backends, see [Debugging an Azure cloud service or virtual machine in Visual Studio](https://docs.microsoft.com/en-us/azure/vs-azure-tools-debug-cloud-services-virtual-machines). For information about remote debugging Windows Universal Apps (UWP), see [Debug an Installed App Package](debug-installed-app-package.md).
  
## Download and Install the Remote Tools

[!INCLUDE [remote-debugger-download](../debugger/includes/remote-debugger-download.md)]
  
## Requirements

[!INCLUDE [remote-debugger-requirements](../debugger/includes/remote-debugger-requirements.md)]
  
## <a name="BKMK_setup"></a> Set up the remote debugger

[!INCLUDE [remote-debugger-configuration](../debugger/includes/remote-debugger-configuration.md)]
  
## Remote debug the project
The debugger cannot deploy Visual C# or Visual Basic desktop applications to a remote machine, but you can still debug them remotely as follows. The following procedure assumes that you want to debug it on a computer named **MJO-DL**, as shown in the earlier illustration.
  
1.  Create a WPF project named **MyWpf**.  
  
2.  Set a breakpoint somewhere in the code that is easily reached.  
  
     For example, you might set a breakpoint in a button handler. To do this, open MainWindow.xaml, and add a Button control from the Toolbox, then double-click the button to open it's handler.
  
3.  In Solution Explorer, right-click the project and choose **Properties**.  
  
4.  On the **Properties** page, choose the **Debug** tab.  
  
     ![RemoteDebuggerCSharp](../debugger/media/remotedebuggercsharp.png "RemoteDebuggerCSharp")  
  
5.  Make sure the **Working directory** text box is empty.  
  
6.  Choose **Use remote machine**, and type **MJO-DL:4020** in the text box. (4020 is the port number shown in the remote debugger window).  
  
7.  Make sure that **Enable native code debugging** is not selected.  
  
8.  Build the project.  
  
9. Create a folder on the remote computer that is the same path as the **Debug** folder on your Visual Studio computer: **\<source path>\MyWPF\MyWPF\bin\Debug**.  
  
10. Copy the executable that you just built from your Visual Studio computer to the newly-created folder on the remote computer.
  
    > [!CAUTION]
    >  Do not make changes to the code or rebuild (or you must repeat this step). The executable you copied to the remote machine must exactly match your local source and symbols.

    You can copy the project manually, use Xcopy, Robocopy, Powershell, or other options.
  
11. Make sure the remote debugger is running on the target machine. (If it's not, search for **Remote Debugger** in the **Start** menu. ) The remote debugger window looks like this.  
  
     ![RemoteDebuggerWindow](../debugger/media/remotedebuggerwindow.png "RemoteDebuggerWindow")  
  
12. In Visual Studio, start debugging (**Debug / Start Debugging**, or **F5**).  
  
13. If prompted, enter network credentials to connect to the remote machine.  
  
     The required credentials vary depending on your network's security configuration. For example, on a domain computer, you can  enter your domain name and password. On a non-domain machine, you might enter the machine name and a valid user account name, like **MJO-DL\name@something.com**, along with the correct password.

     You should see that the WPF application’s main window is open on the remote computer.
  
14. If necessary, take action to hit the breakpoint. You should see that the breakpoint is active. If it isn’t, the symbols for the application haven’t loaded. Retry, and if that doesn't work, get information about loading symbols and how troubleshoot them at [Understanding symbol files and Visual Studio’s symbol settings](http://blogs.msdn.com/b/visualstudioalm/archive/2015/01/05/understanding-symbol-files-and-visual-studio-s-symbol-settings.aspx).
  
15. On the Visual Studio machine, you should see that execution has stopped at the breakpoint.
  
 If you have non-code files that need to be used by the application, you need to include them in the Visual Studio project. Create a project folder for the additional files (in the **Solution Explorer**, click **Add / New Folder**.) Then add the files to the folder (in the **Solution Explorer**, click **Add / Existing Item**, then select the files.). On the **Properties** page for each file, set **Copy to Output Directory** to **Copy always**.

## Set Up Debugging with Remote Symbols 

[!INCLUDE [remote-debugger-symbols](../debugger/includes/remote-debugger-symbols.md)]  
  
## See Also  
 [Debugging in Visual Studio](../debugger/debugging-in-visual-studio.md)   
 [Configure the Windows Firewall for Remote Debugging](../debugger/configure-the-windows-firewall-for-remote-debugging.md)   
 [Remote Debugger Port Assignments](../debugger/remote-debugger-port-assignments.md)   
 [Remote Debugging ASP.NET on a Remote IIS Computer](../debugger/remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md)  
 [Remote Debugging Errors and Troubleshooting](../debugger/remote-debugging-errors-and-troubleshooting.md)