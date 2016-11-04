---
title: "Remote Debugging | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
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
  - "CSharp"
  - "FSharp"
  - "JScript"
  - "VB"
helpviewer_keywords: 
  - "remote debugging, setup"
ms.assetid: 5a94ad64-100d-43ca-9779-16cb5af86f97
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
# Remote Debugging
You can debug a Visual Studio application that has been deployed on a different computer.  To do so, you use the Visual Studio remote debugger.  
  
 The information here applies to Windows desktop applications and ASP.NET applications.  For information about remote debugging Windows Store apps and Azure apps, see [Remote Debugging on Windows Store and Azure apps](#bkmk_winstoreAzure).  
  
## Download and Install the Remote Tools  
 Follow these steps to download the remote tools.
  
1.  On the device or server machine that you want to debug (rather than the machine running Visual Studio), open the correct download page for the remote tools.

     For Update 3 of the remote tools for Visual Studio 2015, open [this download page](https://www.visualstudio.com/downloads/#remote-tools-for-visual-studio-2015).

     If you are not using Update 3 of Visual Studio 2015, open the [download page at My.VisualStudio.com](https://my.visualstudio.com/Downloads?q=remote%20tools%20visual%20studio%202015) instead.
  
     If prompted (My.VisualStudio.com only), join the free Visual Studio Dev Essentials group or you can just sign in with a valid Visual Studio subscription. Then re-open the link if necessary.
  
     ![DBG&#95;remote&#95;dbg&#95;download](../debugger/media/dbg_remote_dbg_download.png "DBG_remote_dbg_download")
  
2.  On the download page, choose the version of the tools that matches your operating system (x86, x64, or  ARM version) and download the remote tools.
  
     If you need remote tools for a different version of Visual Studio, enter a search phrase in the search box such as "remote tools visual studio 2013" or "remote tools Preview 5".
  
     The ARM version of this download actually provides the Visual Studio 2015 Update 1 ARM version of the remote tools. You can use the Update 1 ARM remote tools along with Visual Studio 2015 Update 3. 
  
    > [!IMPORTANT]
    >  We recommend you install the most recent version of the remote tools that matches your version of Visual Studio. Mismatched versions are not recommended.  
    >   
    >  In addition, you must install the remote tools that have the same architecture as the operating system on which you want to install it. In other words, if you want to debug a 32-bit application on a  a remote computer running a 64-bit operating system, you must install the 64-bit version of the remote tools on the remote computer.  
  
3.  When you have finished downloading the executable, follow the directions to install the application on the remote computer.
  
 If the remote computer already has Visual Studio 2015 Community, Professional, or Enterprise already installed, the remote debugger (**msvsmon.exe**) is already installed, and you can start it from its directory:
  
 **\<Visual Studio installation directory>\Common7\IDE\Remote Debugger\\(x64, x86, Appx)\msvsmon.exe**
  
 However, the **Remote Debugger Configuration Wizard** (**rdbgwiz.exe**) is installed only when you download and install the tools, and you may need to use it for configuration later, especially if you want the remote debugger to run as a service. For more information, see [(Optional) Configure the remote debugger as a service](#bkmk_configureService) below.
  
## Supported Operating Systems  
 The remote computer must be running one of the following operating systems:  
  
-   Windows 10  
  
-   Windows 8 or 8.1  
  
-   Windows 7 Service Pack 1  
  
-   Windows Server 2012 or Windows Server 2012 R2  
  
-   Windows Server 2008 Service Pack 2, Windows Server 2008 R2 Service Pack 1  
  
## Supported Hardware Configurations  
  
-   1.6 GHz or faster processor  
  
-   1 GB of RAM (1.5 GB if running on a virtual machine)  
  
-   1 GB of available hard disk space  
  
-   5400 RPM hard drive  
  
-   DirectX 9-capable video card running at 1024 x 768 or higher display resolution  
  
## Network configuration  
 The remote computer and the Visual Studio computer must be connected over a network, workgroup, or homegroup, or else connected directly through an Ethernet cable. Debugging over the Internet is not supported.  
  
## Set up the remote debugger  
 You must have administrative permissions on the remote computer  
  
1.  Locate the Remote Debugger application. (Open the Start menu and search for **Remote Debugger**.)
  
     If you are running the remote debugger on a  remote server, you can right-click the Remote Debugger app and choose **Run as administrator** (Or, you can run the remote debugger as a service).If you are not running it on a remote server, just start it normally.
  
3.  When you start the remote tools for the first time (or before you have configured it), the **Remote Debugging Configuration** dalog box appears.  
  
     ![RemoteDebuggerConfWizardPage](../debugger/media/remotedebuggerconfwizardpage.png "RemoteDebuggerConfWizardPage")  
  
4.  If the Windows Service API is not installed (which happens only on Windows Server 2008 R2), choose the **Install** button.  
  
5.  Select the network types you want use the remote tools on. At least one network type must be selected. If the computers are connected through a domain, you must choose the first item. If the computers are connected through a workgroup or homegroup, you need to choose the second or third item as appropriate.  
  
6.  Choose **Configure remote debugging** to configure the firewall and start the tool.  
  
7.  When configuration is complete, the Remote Debugger window appears.
  
     ![RemoteDebuggerWindow](../debugger/media/remotedebuggerwindow.png "RemoteDebuggerWindow")
  
     The remote debugger is now waiting for a connection. Make a note of the server name and port number that is displayed, because you will need this later for configuration in Visual Studio.  
  
 When you are finished debugging and need to stop the remote debugger, click **File / Exit** on the window. You can restart it from the **Start** menu or from the command line:  
  
 **\<Visual Studio installation directory>\Common7\IDE\Remote Debugger\\<x86, x64, or Appx\msvsmon.exe**.  
  
## Configure the remote debugger  
 You can change some aspects of the configuration of the remote debugger after you have started it for the first time.
  
-   To enable other users to connect to the remote debugger, choose **Tools / Permissions**. You must have administrator privileges to grant or deny permissions.

     > [!IMPORTANT] You can run the remote debugger under a user account that differs from the user account you are using on the Visual Studio computer, but you must add the different user account to the remote debugger's permissions. 

     Alternatively, you can start the remote debugger from the command line with the **/allow \<username>** parameter: **msvsmon /allow \<username@computer>**.
  
-   To change the Authentication mode or the port number, or to specify a timeout value for the remote tools: choose **Tools / Options**.  
  
     For a listing of the port numbers used by default, see [Remote Debugger Port Assignments](../debugger/remote-debugger-port-assignments.md).  
  
     > [!WARNING]
>  You can choose to run the remote tools in No Authentication mode, but this mode is strongly discouraged. There is no network security when you run in this mode. Choose the No Authentication mode only if you are sure that the network is not at risk from malicious or hostile traffic.

##  <a name="bkmk_configureService"></a> (Optional) Configure the remote debugger as a service
 For debugging in ASP.NET and other server environments, you must either run the remote debugger as an Administrator or, if you want it always running,  run the remote debugger as a service.
  
 If you want to configure the remote debugger as a service, follow these steps.  
  
1.  Find the **Remote Debugger Configuration Wizard** (rdbgwiz.exe). (This is a separate application from the Remote Debugger.) It is available only when you install the remote tools. It is not installed with Visual Studio.  
  
2.  Start running the configuration wizard. When the first page comes up, click **Next**.  
  
3.  Check the **Run the Visual Studio 2015 Remote Debugger as a service** checkbox.  
  
4.  Add the name of the user account and password.  
  
     You may need to add the **Log on as a service** user right to this account. (Find **Local Security Policy** (secpol.msc) in the **Start** page or window (or type **secpol** at a command prompt). When the window appears, double-click **User Rights Assignment**, then find **Log on as a service** in the right pane. Double-click it. Add the user account to the **Properties** window and click **OK**.) Click **Next**.  
  
5.  Select the type of network that you want the remote tools to communicate with. At least one network type must be selected. If the computers are connected through a domain, you should choose the first item. If the computers are connected through a workgroup or homegroup, you should choose the second or third items. Click **Next**.  
  
6.  If the service can be started, you will see **You have successfully completed the Visual Studio Remote Debugger Configuration Wizard**. If the service cannot be started, you will see **Failed to complete the Visual Studio Remote Debugger Configuration Wizard**. The page also gives some tips to follow to get the service to start.  
  
7.  Click **Finish**.  
  
 At this point the remote debugger is running as a service. You can verify this by going to **Control Panel / Services** and looking for **Visual Studio 2015 Remote Debugger**.  
  
 You can stop and start the remote debugger service from **Control Panel / Services**.  

## Remote debug an ASP.NET application  
 Deploying an ASP.NET application to a remote computer running IIS has different steps, depending on the operating system and version of IIS. For remote computers running Windows Server 2008 or Windows Server 2012 that have IIS 7.5 or later installed, please see [Remote Debugging ASP.NET on a Remote IIS Computer](../debugger/remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md).
 
 If you are debugging an ASP.NET Core app, please see [Publishing to IIS](https://docs.asp.net/en/latest/publishing/iis.html). Different steps are required to publish an ASP.NET Core on IIS. Once you publish an ASP.NET Core app successfully, you can remote debug it [just like other ASP.NET apps](../debugger/remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md), except that the process you need to attach to is dnx.exe instead of w3wp.exe.

## Remote debug a Visual C++ project  
 In the following procedure, the name and path of the project is C:\remotetemp\MyMfc, and the name of the remote computer is **MJO-DL**.  
  
1.  Create an MFC application named **mymfc.**  
  
2.  Set a breakpoint somewhere in the application that is easily reached, for example in **MainFrm.cpp**, at the start of `CMainFrame::OnCreate`.  
  
3.  In Solution Explorer, right-click on the project and select **Properties**. Open the **Debugging** tab.  
  
4.  Set the **Debugger to launch** to **Remote Windows Debugger**.  
  
     ![RemoteDebuggingCPlus](../debugger/media/remotedebuggingcplus.png "RemoteDebuggingCPlus")  
  
5.  Make the following changes to the properties:  
  
    |Setting|Value|
    |-|-|  
    |Remote Command|C:\remotetemp\mymfc.exe|  
    |Working Directory|C:\remotetemp|  
    |Remote Server Name|MJO-DL:*portnumber*|  
    |Connection|Remote with Windows Authentication|  
    |Debugger Type|Native Only|  
    |Deployment Directory|C:\remotetemp.|  
    |Additional Files to Deploy|C:\data\mymfcdata.txt.|  
  
     If you deploy additional files (optional), the folder must exist on both machines.  
  
6.  In Solution Explorer, right-click the solution and choose **Configuration Manager**.  
  
7.  For the **Debug** configuration, select the **Deploy** check box.  
  
     ![RemoteDebugCplusDeploy](../debugger/media/remotedebugcplusdeploy.png "RemoteDebugCplusDeploy")  
  
8.  Start debugging (**Debug / Start Debugging**, or **F5**).  
  
9. The executable is automatically deployed to the remote computer.  
  
10. If prompted, enter network credentials to connect to the remote machine.  
  
     The required credentials are specific to your network's security configuration. For example, on a domain computer, you might choose a security certificate or enter your domain name and password. On a non-domain machine, you might enter the machine name and a valid user account name, like **MJO-DL\name@something.com**, along with the correct password.  
  
11. On the Visual Studio computer, you should see that execution is stopped at the breakpoint.  
  
    > [!TIP]
    >  Alternatively, you can deploy the files as a separate step. In the **Solution Explorer,** right-click the **mymfc** node and then choose **Deploy**.  
  
 If you have non-code files that need to be used by the application, you need to include them in the Visual Studio project. Create a project folder for the additional files (in the **Solution Explorer**, click **Add / New Folder**.) Then add the files to the folder (in the **Solution Explorer**, click **Add / Existing Item**, then select the files.). On the **Properties** page for each file, set **Copy to Output Directory** to **Copy always**.  
  
## Remote debug a Visual C# or Visual Basic project  
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
 You should be able to debug your code with the symbols you generate on the Visual Studio computer. The performance of the remote debugger is much better when you use local symbols.  If you must   use remote symbols, you need to tell the remote debugging monitor to look for symbols on the remote machine.  
  
 Starting in Visual Studio 2013 Update 2, you can use the following msvsmon command-line switch to use remote symbols for managed code: `Msvsmon / /FallbackLoadRemoteManagedPdbs`  
  
 For more information, please see the remote debugging help (press **F1** in the remote debugger window, or click **Help / Usage**). You can find more information at [.NET Remote Symbol Loading Changes in Visual Studio 2012 and 2013](http://blogs.msdn.com/b/visualstudioalm/archive/2013/10/16/net-remote-symbol-loading-changes-in-visual-studio-2012-and-2013.aspx)  
  
##  <a name="bkmk_winstoreAzure"></a> Remote Debugging on Windows Store and Azure apps  
 For information about remote debugging with Windows Store apps, see [Debug and test Windows Store apps on a remote device from Visual Studio](http://msdn.microsoft.com/library/windows/apps/hh441469.aspx).  
  
 For information about debugging on Azure, see one of these topics:  
  
-   [Debugging a Cloud Service or Virtual Machine in Visual Studio](http://msdn.microsoft.com/library/azure/ff683670.aspx)  
  
-   [Debugging the .NET Backend in Visual Studio](http://blogs.msdn.com/b/azuremobile/archive/2014/03/14/debugging-net-backend-in-visual-studio.aspx)  
  
-   Introduction to Remote Debugging on Azure Web Sites ([Part 1](http://azure.microsoft.com/blog/2014/05/06/introduction-to-remote-debugging-on-azure-web-sites/), [Part 2](http://azure.microsoft.com/blog/2014/05/07/introduction-to-remote-debugging-azure-web-sites-part-2-inside-remote-debugging/), [Part 3](http://azure.microsoft.com/blog/2014/05/08/introduction-to-remote-debugging-on-azure-web-sites-part-3-multi-instance-environment-and-git/)).  
  
## See Also  
 [Debugging in Visual Studio](../debugger/debugging-in-visual-studio.md)   
 [Configure the Windows Firewall for Remote Debugging](../debugger/configure-the-windows-firewall-for-remote-debugging.md)   
 [Remote Debugger Port Assignments](../debugger/remote-debugger-port-assignments.md)   
 [Remote Debugging ASP.NET on a Remote IIS Computer](../debugger/remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md)  
 [Remote Debugging Errors and Troubleshooting](../debugger/remote-debugging-errors-and-troubleshooting.md)