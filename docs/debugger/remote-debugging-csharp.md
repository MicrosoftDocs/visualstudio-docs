---
title: "Remote Debug a C# or VB project"
description: Learn how to debug a Visual Studio C# or Visual Basic application from a remote computer by following these step-by-step instructions.
ms.date: "12/18/2024"
ms.topic: "conceptual"
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
# Remote Debugging a C# or Visual Basic project in Visual Studio

To debug a Visual Studio application that has been deployed on a different computer, install and run the remote tools on the computer where you deployed your app, configure your project to connect to the remote computer from Visual Studio, and then run your app.

![Screenshot of remote debugger components.](../debugger/media/remote-debugger-client-apps.png "Remote_debugger_components")

For information about remote debugging Universal Windows Apps (UWP), see [Debug an Installed App Package](debug-installed-app-package.md).

## Requirements

The remote debugger is supported on Windows 7 and newer and on versions of Windows Server starting with Windows Server 2008 Service Pack 2. For a complete list of requirements, see [Requirements](../debugger/remote-debugging.md#requirements_msvsmon).

> [!NOTE]
> Debugging between two computers connected through a proxy isn't supported. Debugging over a high latency or low bandwidth connection, such as dialup Internet, or over the Internet across countries/regions isn't recommended and may fail or be unacceptably slow.

## Download and Install the remote tools

[!INCLUDE [remote-debugger-download](../debugger/includes/remote-debugger-download.md)]

> [!TIP]
> In some scenarios, it can be most efficient to run the remote debugger from a file share. For more information, see [Run the remote debugger from a file share](../debugger/remote-debugging.md#fileshare_msvsmon).

## <a name="BKMK_setup"></a> Set up the remote debugger

After you install the remote debugger, follow these steps.

[!INCLUDE [remote-debugger-configuration](../debugger/includes/remote-debugger-configuration.md)]

> [!NOTE]
> If you need to add permissions for additional users, change the authentication mode, or port number for the remote debugger, see [Configure the remote debugger](../debugger/remote-debugging.md#configure_msvsmon).

## <a name="remote_csharp"></a> Remote debug the project

The debugger can't deploy Visual C# or Visual Basic desktop applications to a remote machine, but you can still debug them remotely as follows. The following procedure assumes that you want to debug it on a computer named **MJO-DL**, as shown in the illustration below.

1. Create a WPF project named **MyWpf**.

   If you're trying to remote debug a MAUI app instead of WPF, see [Remote debug a .NET MAUI app on Windows](#remote-debug-a-net-maui-app-on-windows).

2. Set a breakpoint somewhere in the code that is easily reached.

    For example, you might set a breakpoint in a button handler. To do this, open MainWindow.xaml, and add a Button control from the Toolbox, then double-click the button to open its handler.

3. In Solution Explorer, right-click the project and choose **Properties**.

4. On the **Properties** page, choose the **Debug** tab.

    ::: moniker range="vs-2022"
    For C# projects targeting .NET Core or .NET 5+, starting in Visual Studio 2022, choose the **Debug launch profiles UI** from the **Debug** tab to configure settings for remote debugging.

    ![Screenshot of the Debug launch profile UI in the Visual Studio Project Properties for C# and .NET.](../debugger/media/vs-2022/remote-debugger-csharp-launch-profile.png)

    Otherwise, for .NET Framework, you change remote debug settings directly in the **Debug** tab.

    ![Screenshot of the Debug tab in the Visual Studio Project Properties. The Use remote machine property is set to 'MJO-DL:4026'.](../debugger/media/vs-2022/remote-debugger-csharp.png)
    ::: moniker-end
    ::: moniker range="vs-2019"
    ![Screenshot of the Debug tab in the Visual Studio Project Properties. The Use remote machine property is set to 'MJO-DL:4022'.](../debugger/media/remotedebuggercsharp.png)
    ::: moniker-end

5. Make sure the **Working directory** text box is empty.

6. Choose **Use remote machine**, and type **yourmachinename:port** in the text box. (The port number is shown in the remote debugger window. The port number increments 2 in each version of Visual Studio).

    In this example, use:
    ::: moniker range="vs-2022"
    **MJO-DL:4026** on Visual Studio 2022
    ::: moniker-end
    ::: moniker range="vs-2019"
    **MJO-DL:4024** on Visual Studio 2019
    ::: moniker-end

7. Make sure that **Enable native code debugging** isn't selected.

8. Build the project.

9. Create a folder on the remote computer that is the same path as the **Debug** folder on your Visual Studio computer: **\<source path>\MyWPF\MyWPF\bin\Debug**.

10. Copy the executable that you just built from your Visual Studio computer to the newly created folder on the remote computer.

    > [!CAUTION]
    > Don't make changes to the code or rebuild (or you must repeat this step). The executable you copied to the remote machine must exactly match your local source and symbols.

    You can copy the project manually, use XCopy, Robocopy, PowerShell, or other options.

11. Make sure the remote debugger is running on the target machine (If it's not, search for **Remote Debugger** in the **Start** menu). The remote debugger window looks like this.

    ::: moniker range=">= vs-2022"
    ![Screenshot of remote debugger window for VS 2022.](../debugger/media/vs-2022/remote-debugger-window.png "Remote Debugger window")
    ::: moniker-end
    ::: moniker range="<= vs-2019"
    ![Screenshot of remote debugger window for VS 2019.](../debugger/media/remotedebuggerwindow.png "Remote Debugger window")
    ::: moniker-end

12. In Visual Studio, start debugging (**Debug > Start Debugging**, or **F5**).

13. If prompted, enter network credentials to connect to the remote machine.

     The required credentials vary depending on your network's security configuration. For example, on a domain computer, you can  enter your domain name and password. On a non-domain machine, you might enter the machine name and a valid user account name, like <strong>MJO-DL\name@something.com</strong>, along with the correct password.

     You should see that the WPF application's main window is open on the remote computer.

14. If necessary, take action to hit the breakpoint. You should see that the breakpoint is active. If it isn't, the symbols for the application haven't loaded. Retry, and if that doesn't work, get information about loading symbols and how to troubleshoot them at [Understanding symbol files and Visual Studio's symbol settings](https://devblogs.microsoft.com/devops/understanding-symbol-files-and-visual-studios-symbol-settings/).

15. On the Visual Studio machine, you should see that execution has stopped at the breakpoint.

    If you have any non-code files that need to be used by the application, you need to include them in the Visual Studio project. Create a project folder for the additional files (in the **Solution Explorer**, click **Add > New Folder**). Then add the files to the folder (in the **Solution Explorer**, click **Add > Existing Item**, then select the files). On the **Properties** page for each file, set **Copy to Output Directory** to **Copy always**.

## Remote debug a .NET MAUI app on Windows

.NET MAUI apps are packaged apps that need to be registered when deployed, not just copied to a remote machine. To remote debug, you can deploy an unpackaged version of the app.

Use one of the following methods to remote debug:

- Publish the app to the remote device as an unpackaged app using the steps described in [Use the CLI to publish unpackaged .NET MAUI apps for Windows](/dotnet/maui/windows/deployment/publish-unpackaged-cli), and then follow the steps in this article to remote debug. (Skip the steps to copy the app.)

- Follow the steps in this article, including steps to create a Debug Launch profile for the project. Before you start debugging, manually edit the *launchSettings.json* file, replacing the **commandName** `Project` value with `MsixPackage`, as shown here.

  ```json
  "Remote Profile": {
    "commandName": "MsixPackage",
    "remoteDebugEnabled": true,
    "remoteDebugMachine": "170.200.20.22",
    "authenticationMode": "None"
  }
  ```

  When you start debugging, this method first deploys an unpackaged version of the app and starts it.

  > [!NOTE]
  > You can't edit *launchSettings.json* in the Debug Launch profile dialog box once you change the value to `MsixPackage`.

## Set Up Debugging with Remote Symbols

[!INCLUDE [remote-debugger-symbols](../debugger/includes/remote-debugger-symbols.md)]

## Related content

- [Debugging in Visual Studio](../debugger/index.yml)
- [First look at the debugger](../debugger/debugger-feature-tour.md)
- [Configure the Windows Firewall for Remote Debugging](../debugger/configure-the-windows-firewall-for-remote-debugging.md)
- [Remote Debugger Port Assignments](../debugger/remote-debugger-port-assignments.md)
- [Remote Debugging ASP.NET on a Remote IIS Computer](../debugger/remote-debugging-aspnet-on-a-remote-iis-computer.md)
- [Remote Debugging Errors and Troubleshooting](../debugger/remote-debugging-errors-and-troubleshooting.md)
