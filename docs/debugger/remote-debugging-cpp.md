---
title: "Remote Debug a Visual C++ Project | Microsoft Docs"
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
ms.assetid: 8b8eca0d-122f-4eda-848a-cf0945f207d0
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
# Remote Debugging a Visual C++ Project in Visual Studio
You can debug a Visual Studio application that has been deployed on a different computer. To do so, you use the Visual Studio remote debugger.  
  
For information about remote debugging apps with Azure backends, see [Debugging an Azure cloud service or virtual machine in Visual Studio](https://docs.microsoft.com/en-us/azure/vs-azure-tools-debug-cloud-services-virtual-machines). For information about remote debugging Windows Universal Apps (UWP), see [Debug an Installed App Package](debug-installed-app-package.md).
  
## Download and Install the Remote Tools

[!INCLUDE [remote-debugger-download](../debugger/includes/remote-debugger-download.md)]
  
## Requirements

[!INCLUDE [remote-debugger-requirements](../debugger/includes/remote-debugger-requirements.md)]
  
## <a name="BKMK_setup"></a> Set up the remote debugger

[!INCLUDE [remote-debugger-configuration](../debugger/includes/remote-debugger-configuration.md)]

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
  
## Set Up Debugging with Remote Symbols 

[!INCLUDE [remote-debugger-symbols](../debugger/includes/remote-debugger-symbols.md)] 
  
## See Also  
 [Debugging in Visual Studio](../debugger/debugging-in-visual-studio.md)   
 [Configure the Windows Firewall for Remote Debugging](../debugger/configure-the-windows-firewall-for-remote-debugging.md)   
 [Remote Debugger Port Assignments](../debugger/remote-debugger-port-assignments.md)   
 [Remote Debugging ASP.NET on a Remote IIS Computer](../debugger/remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md)  
 [Remote Debugging Errors and Troubleshooting](../debugger/remote-debugging-errors-and-troubleshooting.md)