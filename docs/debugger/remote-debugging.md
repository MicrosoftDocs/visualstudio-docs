---
title: Remote debugging
description: Debug a Visual Studio application that has been deployed on a different computer by using the Visual Studio remote debugger.
ms.date: 01/21/2025
ms.topic: conceptual
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
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Remote Debugging

You can debug a Visual Studio application that has been deployed on a different computer. To do so, you use the Visual Studio remote debugger.

For in-depth instructions on remote debugging, see these topics.

|Scenario|Link|
|-|-|
|C# or Visual Basic|[Remote debug a C# or Visual Basic project](../debugger/remote-debugging-csharp.md)|
|C++|[Remote debug a C++ project](../debugger/remote-debugging-cpp.md)|
|Azure App Service|[Remote debug ASP.NET Core on Azure](../debugger/remote-debugging-azure-app-service.md) or, for Visual Studio Enterprise, the [Snapshot Debugger](../debugger/debug-live-azure-applications.md)|
|ASP.NET|[Remote debug ASP.NET Core](../debugger/remote-debugging-aspnet-on-a-remote-iis-computer.md) or [Remote Debug ASP.NET](../debugger/remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md)|
|Azure VM|[Remote debug ASP.NET on an Azure VM](../debugger/remote-debugging-azure.md)|
|Linux|[Debug .NET Core on Linux using SSH by attaching to a process](../debugger/remote-debugging-dotnet-core-linux-with-ssh.md)|
|Docker|[Attach to a process running in a Docker container](../debugger/attach-to-process-running-in-docker-container.md)|
|Universal Windows Apps (UWP)|[Run UWP apps on a remote machine](../debugger/run-windows-store-apps-on-a-remote-machine.md) or [Debug an installed app package](../debugger/debug-installed-app-package.md)|

If you just want to download and install the remote debugger and don't need any additional instructions for your scenario, follow the steps in this article.

## Download and Install the remote tools

[!INCLUDE [remote-debugger-download](../debugger/includes/remote-debugger-download.md)]

## <a name="requirements_msvsmon"></a> Requirements

[!INCLUDE [remote-debugger-requirements](../debugger/includes/remote-debugger-requirements.md)]

## <a name="fileshare_msvsmon"></a> (Optional) To run the remote debugger from a file share

You can find the remote debugger (*msvsmon.exe*) on a computer with Visual Studio Community, Professional, or Enterprise already installed. For some scenarios, the easiest way to set up remote debugging is to run the remote debugger (msvsmon.exe) from a file share. For usage limitations, see the remote debugger's Help page (**Help > Usage** in the remote debugger).

1. Find *msvsmon.exe* in the directory matching your version of Visual Studio:

   ::: moniker range=">=vs-2022"

   *Program Files\Microsoft Visual Studio 17.0\Common7\IDE\Remote Debugger\x64\msvsmon.exe*

   *Program Files\Microsoft Visual Studio 17.0\Common7\IDE\Remote Debugger\x86\msvsmon.exe*

   ::: moniker-end
   ::: moniker range="vs-2019"

   *Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\Common7\IDE\Remote Debugger\x64\msvsmon.exe*

   *Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\Common7\IDE\Remote Debugger\x86\msvsmon.exe*

   ::: moniker-end

2. Share the **Remote Debugger** folder on the Visual Studio computer.

3. On the remote computer, run *msvsmon.exe* from the shared folder. Follow the [setup instructions](#bkmk_setup).

> [!TIP]
> For command line installation and command line reference, see the Help page for *msvsmon.exe* by typing ``msvsmon.exe /?`` in the command line on the computer with Visual Studio installed (or go to **Help > Usage** in the remote debugger).

## <a name="bkmk_setup"></a> Set up the remote debugger

[!INCLUDE [remote-debugger-configuration](../debugger/includes/remote-debugger-configuration.md)]

### <a name="configure_msvsmon"></a> Configure the remote debugger

You can change some aspects of the configuration of the remote debugger after you have started it for the first time.

- If you need to add permissions for other users to connect to the remote debugger, choose **Tools > Permissions**. You must have administrator privileges to grant or deny permissions.

     > [!IMPORTANT]
     > You can run the remote debugger under a user account that differs from the user account you're using on the Visual Studio computer, but you must add the different user account to the remote debugger's permissions.

     Alternatively, you can start the remote debugger from the command line with the **/allow \<username>** parameter: **msvsmon /allow \<username@computer>**.

- If you need to change the Authentication mode or the port number, or specify a timeout value for the remote tools: choose **Tools > Options**.

     For a listing of the port numbers used by default, see [Remote Debugger Port Assignments](../debugger/remote-debugger-port-assignments.md).

     > [!WARNING]
     > You can choose to run the remote tools in No Authentication mode, but this mode is strongly discouraged. There's no network security when you run in this mode. Choose the No Authentication mode only if you're sure that the network isn't at risk from malicious or hostile traffic.

## Connect to the app from Visual Studio

For detailed instructions to connect to the app from Visual Studio, use the links related to your specific scenario at the beginning of this article.

Many scenarios require the use of Attach to Process to connect to a remote app that is already started. However, for .NET Core, .NET 5+, .NET Framework, and C++ apps, you can start the remote app from Visual Studio by configuring project properties and starting the debugger. For more information, see [Remote debug a C# or Visual Basic project](../debugger/remote-debugging-csharp.md) or [Remote debug a C++ project](../debugger/remote-debugging-cpp.md).

You can also remote debug an executable that is not part of a Visual Studio project, although the supported debugging features depend on configuration such as the availability of symbols. For more information, see [Debug an app that isn't part of a Visual Studio solution](../debugger/how-to-debug-an-executable-not-part-of-a-visual-studio-solution.md).

## <a name="bkmk_configureService"></a> (Optional) Configure the remote debugger as a service

For debugging in ASP.NET and other server environments, you must either run the remote debugger as an Administrator or, if you want it always running,  run the remote debugger as a service.

 If you want to configure the remote debugger as a service, follow these steps.

1. Find the **Remote Debugger Configuration Wizard** (rdbgwiz.exe). (This is a separate application from the Remote Debugger.) It is available only when you install the remote tools. It isn't installed with Visual Studio.

2. Start running the configuration wizard. When the first page comes up, click **Next**.

3. Check the **Run the Visual Studio Remote Debugger as a service** checkbox.

4. Add the name of the user account and password.

    You may need to add the **Log on as a service** user right to this account (Find **Local Security Policy** (secpol.msc) in the **Start** page or window (or type **secpol** at a command prompt). When the window appears, double-click **User Rights Assignment**, then find **Log on as a service** in the right pane. Double-click it. Add the user account to the **Properties** window and click **OK**). Click **Next**.

5. Select the type of network that you want the remote tools to communicate with. At least one network type must be selected. If the computers are connected through a domain, you should choose the first item. If the computers are connected through a workgroup or homegroup, you should choose the second or third items. Click **Next**.

6. If the service can be started, you'll see **You have successfully completed the Visual Studio Remote Debugger Configuration Wizard**. If the service can't be started, you'll see **Failed to complete the Visual Studio Remote Debugger Configuration Wizard**. The page also gives some tips to follow to get the service to start.

7. Click **Finish**.

   At this point the remote debugger is running as a service. You can verify this by going to **Control Panel > Services** and looking for **Visual Studio Remote Debugger**.

   You can stop and start the remote debugger service from **Control Panel > Services**.

## Set up debugging with remote symbols

[!INCLUDE [remote-debugger-symbols](../debugger/includes/remote-debugger-symbols.md)]

## Related content

- [First look at the debugger](../debugger/debugger-feature-tour.md)
- [Configure the Windows Firewall for Remote Debugging](../debugger/configure-the-windows-firewall-for-remote-debugging.md)
- [Remote Debugger Port Assignments](../debugger/remote-debugger-port-assignments.md)
- [Remote Debugging ASP.NET Core on a Remote IIS Computer](../debugger/remote-debugging-aspnet-on-a-remote-iis-computer.md)
- [Remote Debugging Errors and Troubleshooting](../debugger/remote-debugging-errors-and-troubleshooting.md)
