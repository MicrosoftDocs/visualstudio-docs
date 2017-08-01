---
title: "Remote Debug ASP.NET on a Remote IIS Computer | Microsoft Docs"
ms.custom: "remotedebugging"
ms.date: "07/26/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 9cb339b5-3caf-4755-aad1-4a5da54b2a23
caps.latest.revision: 6
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
# Remote Debug ASP.NET on a Remote IIS Computer
You can deploy an ASP.NET Web application to a Windows Server computer with IIS, and set it up for remote debugging. This guide explains how to set up and configure a Visual Studio 2017 ASP.NET MVC 4.5.2 application, deploy it to IIS, and attach the remote debugger from Visual Studio. To remote debug ASP.NET Core, see [Remote Debug ASP.NET Core on an IIS Computer](../debugger/remote-debugging-aspnet-on-a-remote-iis-computer.md).

These procedures have been tested on these server configurations:
* Windows Server 2012 R2 and IIS 10 (For Windows Server 2008 R2, server steps are different)

There are many ways you can deploy and debug on IIS. Here are a few of the common scenarios.

|Scenario|Notes|
|-|-|-|
|[Azure App Service](https://docs.microsoft.com/en-us/aspnet/core/tutorials/publish-to-azure-webapp-using-vs)|From Visual Studio, you can quickly publish and debug your app to a fully provisioned instance of IIS. However, the configuration of IIS is preset and you cannot customize it. To use this option, choose **Microsoft Azure App Service** from the **Publish** dialog box, follow the prompts to publish, and debug in **Server Explorer** by right-clicking on the App Service instance, and choosing **Attach Debugger**.|
|[Azure VM](../debugger/remote-debugging-azure.md)|If you want more control of the IIS configuration, you can [install the IIS role on an Azure VM](https://docs.microsoft.com/en-us/azure/virtual-machines/virtual-machines-windows-hero-role), download and run the RDP file, and open ports in the Network security group, as described in the [Azure VM tutorial](../debugger/remote-debugging-azure.md).|
|[Windows Server](#bkmk_configureIIS)|Follow the steps in this tutorial to remote debug on Windows Server or a VM running Windows Server.|

## Create the ASP.NET 4.5.2 application on the Visual Studio computer
  
1. Create a new MVC ASP.NET application. (**File / New / Project**, then select **Visual C# / Web / ASP.NET Web Application** . In the **ASP.NET 4.5.2** templates section, select **MVC**. Make sure that **Enable Docker Support** is not selected and that **Authentication** is set to **No Authentication**. Name the project **MyASPApp**.)

2. Open the  HomeController.cs file, and set a breakpoint in the `About()` method.

## <a name="bkmk_configureIIS"></a> Install and Configure IIS on Windows Server

[!INCLUDE [remote-debugger-install-iis-role](../debugger/includes/remote-debugger-install-iis-role.md)]

## Update browser security settings on Windows Server

Depending on your security settings, it may save you time to add the following trusted sites to your browser so you can easily download the software described in this tutorial. Access to these sites may be needed:

- microsoft.com
- go.microsoft.com
- download.microsoft.com
- visualstudio.com

If you are using Internet Explorer, you can add the trusted sites by going to **Internet Options > Security > Trusted Sites > Sites**. These steps are different for other browsers.

When you download the software, you may get requests to grant permission to load various web site scripts and resources. In most cases, these additional resources are not required to install the software.

## <a name="BKMK_deploy_asp_net"></a> Install ASP.NET 4.5 on Windows Server

On Windows Server 2012 R2, see [IIS Configuration](https://docs.asp.net/en/latest/publishing/iis.html#iis-configuration) if you need more detailed information.

1. Use the Web Platform Installer (WebPI) to install ASP.NET 4.5 (from the Server node in Windows Server 2012 R2, choose **Get New Web Platform Components** and then search for ASP.NET)

    ![RemoteDBG_IIS_AspNet_45](../debugger/media/remotedbg_iis_aspnet_45.png "RemoteDBG_IIS_AspNet_45")

    > [!NOTE]
    > If you are using Windows Server 2008 R2, install ASP.NET 4 instead using this command:

     **C:\Windows\Microsoft.NET\Framework64\v4.0.30319\aspnet_regiis.exe -ir**

2. Restart the system (or execute **net stop was /y** followed by **net start w3svc** from a command prompt to pick up a change to the system PATH).

## <a name="BKMK_install_webdeploy"></a> (Optional) Install Web Deploy 3.6 on Windows Server

[!INCLUDE [remote-debugger-install-web-deploy](../debugger/includes/remote-debugger-install-web-deploy.md)]

## <a name="BKMK_deploy_asp_net"></a> Configure ASP.NET Web site on the Windows Server computer

1. Open Windows Explorer and create a new folder, **C:\Publish**, where you will later deploy the ASP.NET project.

2. Open the **Internet Information Services (IIS) Manager**. (In the left pane of Server Manager, select **IIS**. Right-click the server and select **Internet Information Services (IIS) Manager**.)

3. Under **Connections** in the left pane, go to **Sites**.

4. Select the **Default Web Site**, choose **Basic Settings**, and set the **Physical path** to **C:\Publish**.

5. Right-click the **Default Web Site** node and select **Add Application**.

6. Set the **Alias** field to **MyASPApp**, accept the default Application Pool (**DefaultAppPool**), and set the **Physical path** to **C:\Publish**.

7. Under **Connections**, select **Application Pools**. Open **DefaultAppPool** and set the Application pool field to **ASP.NET v4.0** (ASP.NET 4.5 is not an option for the Application pool).

8. With the site selected in the IIS Manager, choose **Edit Permissions**, and make sure that IUSR, IIS_IUSRS, or the user configured for the Application Pool is an authorized user with Read & Execute rights. If none of these are present, add IUSR as a user with Read & Execute rights.

## <a name="bkmk_webdeploy"></a> (Optional) Publish and deploy the app using Web Deploy from Visual Studio

[!INCLUDE [remote-debugger-deploy-app-web-deploy](../debugger/includes/remote-debugger-deploy-app-web-deploy.md)]

Also, you may need to read the section on [Troubleshooting ports](#bkmk_openports).

## (Optional) Publish and Deploy the app by publishing to a local folder from Visual Studio

You can also publish and deploy the app using the file system or other tools.

1. (ASP.NET 4.5.2) Make sure that the web.config file lists the correct version of the .NET Framework.  For example, if you are targeting ASP.NET 4.5.2, make sure this version is listed in web.config.
  
    ```xml
    <system.web>
      <compilation debug="true" targetFramework="4.5.2" />
      <httpRuntime targetFramework="4.5.2" />
      <httpModules>
        <add name="ApplicationInsightsWebTracking" type="Microsoft.ApplicationInsights.Web.ApplicationInsightsHttpModule, Microsoft.AI.Web" />
      </httpModules>
    </system.web>
  
    ```

    For example, the version should be 4.0 if you install ASP.NET 4 instead of 4.5.2.

[!INCLUDE [remote-debugger-deploy-app-local](../debugger/includes/remote-debugger-deploy-app-local.md)]

## <a name="BKMK_msvsmon"></a> Download and Install the Remote Tools on Windows Server

In this tutorial, we are using Visual Studio 2017.

[!INCLUDE [remote-debugger-download](../debugger/includes/remote-debugger-download.md)]

> [!NOTE]
>  The remote computer and the Visual Studio computer must be connected over a network, workgroup, or homegroup, or else connected directly through an Ethernet cable. Debugging over the Internet is not supported in this scenario.
  
## <a name="BKMK_setup"></a> Set up the remote debugger on Windows Server

[!INCLUDE [remote-debugger-configuration](../debugger/includes/remote-debugger-configuration.md)]

## <a name="BKMK_attach"></a> Attach to the ASP.NET application from the Visual Studio computer

1. On the Visual Studio computer, open the **MyASPApp** solution.
2. In Visual Studio, click **Debug / Attach to Process** (Ctrl + Alt + P).

    > [!TIP]
    > In Visual Studio 2017, you can re-attach to the same process you previously attached to by using **Debug / Reattach to Process...** (Shift+Alt+P). 

3. Set the Qualifier field to **\<remote computer name>:4022**.
4. Click **Refresh**.
    You should see some processes appear in the **Available Processes** window.

    If you don't see any processes, try using the IP address instead of the remote computer name (the port is required). You can use `ipconfig` in a command line to get the IPv4 address.

5. Check  **Show processes from all users**.
6. Type the first letter of a process name to quickly find **w3wp.exe** for ASP.NET 4.5.

    ![RemoteDBG_AttachToProcess](../debugger/media/remotedbg_attachtoprocess.png "RemoteDBG_AttachToProcess")

7. Click **Attach**

8. Open the remote computer's website. In a browser, go to **http://\<remote computer name>**.
    
    You should see the ASP.NET web page.
9. In the running ASP.NET application, click the link to the **About** page.

    The breakpoint should be hit in Visual Studio.

## <a name="bkmk_openports"></a> Troubleshooting: Open required ports on Windows Server

In most setups, required ports are opened by the installation of ASP.NET and the remote debugger. However, you may need to verify that ports are open.

> [!NOTE]
> On an Azure VM, you must open ports through the [Network security group](https://docs.microsoft.com/en-us/azure/virtual-machines/virtual-machines-windows-hero-role#open-port-80). 

Required ports:

- 80 - Required for IIS
- 8172 - (Optional) Required for Web Deploy to deploy the app from Visual Studio
- 4022 - Required for remote debugging from Visual Studio 2017 (see [Remote Debugger Port Assignments](../debugger/remote-debugger-port-assignments.md) for detailed information.
- UDP 3702 - (Optional) Discovery port enables you to the **Find** button when attaching to the remote debugger in Visual Studio.

1. To open a port on Windows Server, open the **Start** menu, search for **Windows Firewall with Advanced Security**.

2. Then choose **Inbound Rules / New Rule / Port**. Choose **Next** and under **Specific local ports**, enter the port number, click **Next**, then **Allow the Connection**, click **Next** and add the name (**IIS**, **Web Deploy**, or **msvsmon**) for the Inbound Rule.

    If you want more details on configuring Windows Firewall, see [Configure the Windows Firewall for Remote Debugging](../debugger/configure-the-windows-firewall-for-remote-debugging.md).

3. Create additional rules for the other required ports.