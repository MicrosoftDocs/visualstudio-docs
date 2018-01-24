---
title: "Remote Debug ASP.NET Core on a Remote IIS Computer | Microsoft Docs"
ms.custom: "remotedebugging"
ms.date: "08/14/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 573a3fc5-6901-41f1-bc87-557aa45d8858
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "aspnet"
  - "dotnetcore"
---
# Remote Debug ASP.NET Core on a Remote IIS Computer in Visual Studio 2017
To debug an ASP.NET application that has been deployed to IIS, install and run the remote tools on the computer where you deployed your app, and then attach to your running app from Visual Studio.

![Remote debugger components](../debugger/media/remote-debugger-aspnet.png "Remote_debugger_components")

This guide explains how to set up and configure a Visual Studio 2017 ASP.NET Core, deploy it to IIS, and attach the remote debugger from Visual Studio. To remote debug ASP.NET 4.5.2, see [Remote Debug ASP.NET on an IIS Computer](../debugger/remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md). You can also deploy and debug on IIS using Azure. For Azure App Service, you can easily deploy and debug on a preconfigured instance of IIS using either the [Snapshot Debugger](../debugger/debug-live-azure-applications.md) or by [attaching the debugger from Server Explorer](../debugger/remote-debugging-azure.md).

These procedures have been tested on these server configurations:
* Windows Server 2012 R2 and IIS 8
* Windows Server 2016 and IIS 10

## Requirements

Debugging between two computers connected through a proxy is not supported. Debugging over a high latency or low-bandwidth connection, such as dialup Internet, or over the Internet across countries is not recommended and may fail or be unacceptably slow. For a complete list of requirements, see [Requirements](../debugger/remote-debugging.md#requirements_msvsmon).

## Create the ASP.NET Core application on the Visual Studio 2017 computer 

1. Create a new ASP.NET Core application. (**File > New > Project**, then select **Visual C# > Web > ASP.NET Core Web Application**).

    In the **ASP.NET Core** templates section, select **Web Application**.

2. Make sure that **ASP.NET Core 2.0** is selected, that **Enable Docker Support** is **not** selected and that **Authentication** is set to **No Authentication**.

3. Name the project **MyASPApp** and click **OK** to create the new solution.

4. Open the About.cshtml.cs file and set a breakpoint in the `OnGet` method (in older templates, open HomeController.cs instead and set the breakpoint in the `About()` method).

## <a name="bkmk_configureIIS"></a> Install and Configure IIS on Windows Server

[!INCLUDE [remote-debugger-install-iis-role](../debugger/includes/remote-debugger-install-iis-role.md)]

## Update browser security settings on Windows Server

Depending on your security settings, it may save you time to add the following trusted sites to your browser so you can easily download the software described in this tutorial. Access to these sites may be needed:

- microsoft.com
- go.microsoft.com
- download.microsoft.com
- visualstudio.com

If you are using Internet Explorer, you can add the trusted sites by going to **Internet Options > Security > Trusted Sites > Sites**. These steps are different for other browsers. (If you need to download an older version of the remote debugger from my.visualstudio.com, some additional trusted sites are required to sign in.)

When you download the software, you may get requests to grant permission to load various web site scripts and resources. In most cases, these additional resources are not required to install the software.

## Install ASP.NET Core on Windows Server

1. Install the [.NET Core Windows Server Hosting](https://aka.ms/dotnetcore-2-windowshosting) bundle on the hosting system. The bundle installs the .NET Core Runtime, .NET Core Library, and the ASP.NET Core Module. For more in-depth instructions, see [Publishing to IIS](/aspnet/core/publishing/iis?tabs=aspnetcore2x#iis-configuration).

    > [!NOTE]
    > If the system doesn't have an Internet connection, obtain and install the *[Microsoft Visual C++ 2015 Redistributable](https://www.microsoft.com/download/details.aspx?id=53840)* before installing the .NET Core Windows Server Hosting bundle.

3. Restart the system (or execute **net stop was /y** followed by **net start w3svc** from a command prompt to pick up a change to the system PATH).

## <a name="BKMK_install_webdeploy"></a> (Optional) Install Web Deploy 3.6 on Windows Server

[!INCLUDE [remote-debugger-install-web-deploy](../debugger/includes/remote-debugger-install-web-deploy.md)]

## <a name="BKMK_deploy_asp_net"></a> Configure ASP.NET Web site on the Windows Server computer

1. Open Windows Explorer and create a new folder, **C:\Publish**, where you will later deploy the ASP.NET project.

2. Open the **Internet Information Services (IIS) Manager**. (In the left pane of Server Manager, select **IIS**. Right-click the server and select **Internet Information Services (IIS) Manager**.)

3. Under **Connections** in the left pane, go to **Sites**.

4. Select the **Default Web Site**, choose **Basic Settings**, and set the **Physical path** to **C:\Publish**.

4. Right-click the **Default Web Site** node and select **Add Application**.

5. Set the **Alias** field to **MyASPApp**, accept the default Application Pool (**DefaultAppPool**), and set the **Physical path** to **C:\Publish**.

6. Under **Connections**, select **Application Pools**. Open **DefaultAppPool** and set the Application pool field to **No Managed Code**.

7. Right-click the new site in the IIS Manager, choose **Edit Permissions**, and make sure that IUSR, IIS_IUSRS, or the user configured for access to the web app is an authorized user with Read & Execute rights.

    If you don't see one of these users with access, go through steps to add IUSR as a user with Read & Execute rights.

## <a name="bkmk_webdeploy"></a> (Optional) Publish and deploy the app using Web Deploy from Visual Studio

[!INCLUDE [remote-debugger-deploy-app-web-deploy](../debugger/includes/remote-debugger-deploy-app-web-deploy.md)]

## (Optional) Publish and Deploy the app by publishing to a local folder from Visual Studio

You can also publish and deploy the app using the file system or other tools.

[!INCLUDE [remote-debugger-deploy-app-local](../debugger/includes/remote-debugger-deploy-app-local.md)]

## <a name="BKMK_msvsmon"></a> Download and Install the remote tools on Windows Server

[!INCLUDE [remote-debugger-download](../debugger/includes/remote-debugger-download.md)]

> [!TIP]
> In some scenarios, it can be most efficient to run the remote debugger from a file share. For more information, see [Run the remote debugger from a file share](../debugger/remote-debugging.md#fileshare_msvsmon).
  
## <a name="BKMK_setup"></a> Set up the remote debugger on Windows Server

[!INCLUDE [remote-debugger-configuration](../debugger/includes/remote-debugger-configuration.md)]

> [!NOTE]
> If you need to add permissions for additional users, change the authentication mode, or port number for the remote debugger, see [Configure the remote debugger](../debugger/remote-debugging.md#configure_msvsmon).

For information on running the remote debugger as a service, see [Run the remote debugger as a service](../debugger/remote-debugging.md#bkmk_configureService).

## <a name="BKMK_attach"></a> Attach to the ASP.NET application from the Visual Studio computer

1. On the Visual Studio computer, open the **MyASPApp** solution.
2. In Visual Studio, click **Debug > Attach to Process** (Ctrl + Alt + P).

    > [!TIP]
    > In Visual Studio 2017, you can reattach to the same process you previously attached to by using **Debug > Reattach to Process...** (Shift + Alt + P). 

3. Set the Qualifier field to **\<remote computer name>:4022**.
4. Click **Refresh**.
    You should see some processes appear in the **Available Processes** window.

    If you don't see any processes, try using the IP address instead of the remote computer name (the port is required). You can use `ipconfig` in a command line to get the IPv4 address.

    If you want to use the **Find** button, you may need to [open UDP port 3702](#bkmk_openports) on the server.

5. Check  **Show processes from all users**.
6. Type the first letter of a process name to quickly find **dotnet.exe** (for ASP.NET Core).

    ![RemoteDBG_AttachToProcess](../debugger/media/remotedbg_attachtoprocess_aspnetcore.png "RemoteDBG_AttachToProcess")

7. Click **Attach**.

8. Open the remote computer's website. In a browser, go to **http://\<remote computer name>**.
    
    You should see the ASP.NET web page.

9. In the running ASP.NET application, click the link to the **About** page.

    The breakpoint should be hit in Visual Studio.

## <a name="bkmk_openports"></a> Troubleshooting: Open required ports on Windows Server

In most setups, required ports are opened by the installation of ASP.NET and the remote debugger. However, you may need to verify that ports are open.

> [!NOTE]
> On an Azure VM, you must open ports through the [Network security group](/azure/virtual-machines/virtual-machines-windows-hero-role#open-port-80). 

Required ports:

- 80 - Required for IIS
- 4022 - Required for remote debugging from Visual Studio 2017 (see [Remote Debugger Port Assignments](../debugger/remote-debugger-port-assignments.md) for detailed information.
- 8172 - (Optional) Required for Web Deploy to deploy the app from Visual Studio.
- UDP 3702 - (Optional) Discovery port enables you to the **Find** button when attaching to the remote debugger in Visual Studio.

1. To open a port on Windows Server, open the **Start** menu, search for **Windows Firewall with Advanced Security**.

2. Then choose **Inbound Rules > New Rule > Port**, and then click **Next**. (For UDP 3702, choose **Outbound Rules** instead.)

3. Under **Specific local ports**, enter the port number, click **Next**.

4. Click **Allow the Connection**, click **Next**.

5. Select one or more network types to enable for the port and click **Next**.

    The type you select must include the network to which the remote computer is connected.
6. Add the name (for example, **IIS**, **Web Deploy**, or **msvsmon**) for the Inbound Rule and click **Finish**.

    You should see your new rule in the Inbound Rules or Outbound Rules list.

    If you want more details on configuring Windows Firewall, see [Configure the Windows Firewall for Remote Debugging](../debugger/configure-the-windows-firewall-for-remote-debugging.md).

3. Create additional rules for the other required ports.
