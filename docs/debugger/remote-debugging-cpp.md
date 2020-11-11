---
title: "Remote Debug a C++ Project | Microsoft Docs"
ms.custom: "remotedebugging"
ms.date: "08/14/2018"
ms.topic: "conceptual"
dev_langs:
  - "C++"
  - "FSharp"
  - "CSharp"
  - "JScript"
  - "VB"
helpviewer_keywords:
  - "remote debugging, setup"
ms.assetid: 8b8eca0d-122f-4eda-848a-cf0945f207d0
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "cplusplus"
---
# Remote Debugging a C++ Project in Visual Studio
To debug a Visual Studio application on a different computer, install and run the remote tools on the computer where you will deploy your app, configure your project to connect to the remote computer from Visual Studio, and then deploy and run your app.

![Remote debugger components](../debugger/media/remote-debugger-client-apps.png "Remote_debugger_components")

For information about remote debugging Universal Windows Apps (UWP), see [Debug an Installed App Package](debug-installed-app-package.md).

## Requirements

The remote debugger is supported on Windows 7 and newer (not phone) and versions of Windows Server starting with Windows Server 2008 Service Pack 2. For a complete list of requirements, see [Requirements](../debugger/remote-debugging.md#requirements_msvsmon).

> [!NOTE]
> Debugging between two computers connected through a proxy is not supported. Debugging over a high latency or low bandwidth connection, such as dialup Internet, or over the Internet across countries is not recommended and may fail or be unacceptably slow.

## Download and Install the remote tools

[!INCLUDE [remote-debugger-download](../debugger/includes/remote-debugger-download.md)]

> [!TIP]
> In some scenarios, it can be most efficient to run the remote debugger from a file share. For more information, see [Run the remote debugger from a file share](../debugger/remote-debugging.md#fileshare_msvsmon).

## <a name="BKMK_setup"></a> Set up the remote debugger

[!INCLUDE [remote-debugger-configuration](../debugger/includes/remote-debugger-configuration.md)]

> [!NOTE]
> If you need to add permissions for additional users, change the authentication mode, or port number for the remote debugger, see [Configure the remote debugger](../debugger/remote-debugging.md#configure_msvsmon).

## <a name="remote_cplusplus"></a> Remote debug a C++ project
 In the following procedure, the name and path of the project is C:\remotetemp\MyMfc, and the name of the remote computer is **MJO-DL**.

1. Create an MFC application named **mymfc.**

2. Set a breakpoint somewhere in the application that is easily reached, for example in **MainFrm.cpp**, at the start of `CMainFrame::OnCreate`.

3. In Solution Explorer, right-click on the project and select **Properties**. Open the **Debugging** tab.

4. Set the **Debugger to launch** to **Remote Windows Debugger**.

    ![RemoteDebuggingCPlus](../debugger/media/remotedebuggingcplus.png "RemoteDebuggingCPlus")

5. Make the following changes to the properties:

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

6. In Solution Explorer, right-click the solution and choose **Configuration Manager**.

7. For the **Debug** configuration, select the **Deploy** check box.

    ![RemoteDebugCplusDeploy](../debugger/media/remotedebugcplusdeploy.png "RemoteDebugCplusDeploy")

8. Start debugging (**Debug > Start Debugging**, or **F5**).

9. The executable is automatically deployed to the remote computer.

10. If prompted, enter network credentials to connect to the remote machine.

     The required credentials are specific to your network's security configuration. For example, on a domain computer, you might choose a security certificate or enter your domain name and password. On a non-domain machine, you might enter the machine name and a valid user account name, like <strong>MJO-DL\name@something.com</strong>, along with the correct password.

11. On the Visual Studio computer, you should see that execution is stopped at the breakpoint.

    > [!TIP]
    > Alternatively, you can deploy the files as a separate step. In the **Solution Explorer,** right-click the **mymfc** node and then choose **Deploy**.

    If you have non-code files that are required by the application, you can specify them in **Additional Files to Deploy** on the **Remote Windows Debugger** page.

    Alternatively, you can include the files in your project, and set the **Content** property to **Yes** in the **Properties** page for each file. These files are copied to the **Deployment Directory** specified on the **Remote Windows Debugger** page. You can also change the **Item Type** to **Copy File** and specify additional properties there if you need the files to be copied to a subfolder of the **Deployment Directory**.

## Set Up Debugging with Remote Symbols

[!INCLUDE [remote-debugger-symbols](../debugger/includes/remote-debugger-symbols.md)]

## See also
- [Debugging in Visual Studio](../debugger/index.yml)
- [First look at the debugger](../debugger/debugger-feature-tour.md)
- [Configure the Windows Firewall for Remote Debugging](../debugger/configure-the-windows-firewall-for-remote-debugging.md)
- [Remote Debugger Port Assignments](../debugger/remote-debugger-port-assignments.md)
- [Remote Debugging ASP.NET on a Remote IIS Computer](../debugger/remote-debugging-aspnet-on-a-remote-iis-computer.md)
- [Remote Debugging Errors and Troubleshooting](../debugger/remote-debugging-errors-and-troubleshooting.md)