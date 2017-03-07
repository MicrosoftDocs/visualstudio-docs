---
title: "Remote Debugging in Visual Studio | Microsoft Docs"
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
You can debug a Visual Studio application that has been deployed on a different computer. To do so, you use the Visual Studio remote debugger.

For in-depth instructions on remote debugging, see these topics.

|Scenario|Link|
|-|-|-|
|ASP.NET|[Remote Debugging ASP.NET on a Remote IIS Computer](../debugger/remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md)|
|C# or Visual Basic|[Remote Debugging a C# or Visual Basic Project](remote-debugging-csharp.md)|
|C++|[Remote Debugging a C++ Project](remote-debugging-cpp.md)|
|Universal Windows Apps (UWP)|[Debug an Installed App Package](debug-installed-app-package.md)|
|Azure|[Debugging an Azure cloud service or virtual machine in Visual Studio](https://docs.microsoft.com/en-us/azure/vs-azure-tools-debug-cloud-services-virtual-machines)|

If you just want to download and install the remote debugger and don't need any additional instructions for your scenario, follow the steps in this article.
  
## Download and Install the Remote Tools  

[!INCLUDE [remote-debugger-download](../debugger/includes/remote-debugger-download.md)]
  
## Requirements

[!INCLUDE [remote-debugger-requirements](../debugger/includes/remote-debugger-requirements.md)]
  
## Set up the remote debugger  

[!INCLUDE [remote-debugger-configuration](../debugger/includes/remote-debugger-configuration.md)]

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

## Set Up Debugging with Remote Symbols 

[!INCLUDE [remote-debugger-symbols](../debugger/includes/remote-debugger-symbols.md)]
  
## See Also  
 [Debugging in Visual Studio](../debugger/debugging-in-visual-studio.md)   
 [Configure the Windows Firewall for Remote Debugging](../debugger/configure-the-windows-firewall-for-remote-debugging.md)   
 [Remote Debugger Port Assignments](../debugger/remote-debugger-port-assignments.md)   
 [Remote Debugging ASP.NET on a Remote IIS Computer](../debugger/remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md)  
 [Remote Debugging Errors and Troubleshooting](../debugger/remote-debugging-errors-and-troubleshooting.md)