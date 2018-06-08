---
title: "Deploy ASP.NET to IIS using Web Deploy"
ms.custom: ""
ms.date: "06/04/2018"
ms.technology: "vs-ide-deployment"
ms.topic: "tutorial"
ms.assetid: 9cb339b5-3caf-4755-aad1-4a5da54b2a23
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload: 
  - "aspnet"
---
# Deploy ASP.NET to a remote IIS computer using Web Deploy in Visual Studio

This article explains how to set up and configure a Visual Studio 2017 ASP.NET MVC 4.5.2 application and deploy it to IIS. This article includes steps on setting up a basic configuration of IIS on Windows server and deploying the app from Visual Studio. These steps are included to make sure that the server has required components installed and that you are ready to deploy. If you are deploying an ASP.NET Core application, some steps are different. To deploy an ASP.NET Core app, see [Publish an application to IIS by importing publish settings](../deployment/tutorial-import-publish-settings-iis.md) for instructions. In some ASP.NET and ASP.NET Core scenarios, it is faster to deploy to IIS by importing publish settings.

These procedures have been tested on these server configurations:
* Windows Server 2012 R2 and IIS 8 (For Windows Server 2008 R2, the server steps are different)

## Create the ASP.NET 4.5.2 application on the Visual Studio computer
  
1. On the computer running Visual Studio, choose **File** > **New Project**.

1. Under **Visual C#** or **Visual Basic**, choose **Web**, and then in the middle pane choose either **ASP.NET Web Application (.NET Framework)** and then click **OK**.

    If you don't see the specified project templates, click the **Open Visual Studio Installer** link in the left pane of the **New Project** dialog box. The Visual Studio Installer launches. See the prerequisites in this article to identify the required Visual Studio workloads, which you must install.

1. Choose **MVC** (.NET Framework) and make sure that **No Authentication** is selected, and then click **OK**.

1. Type a name like **MyWebApp** and click **OK**.

    Visual Studio creates the project.

1. Choose **Build** > **Build Solution** to build the project.

## <a name="bkmk_configureIIS"></a> Install and configure IIS on Windows Server

[!INCLUDE [remote-debugger-install-iis-role](../debugger/includes/remote-debugger-install-iis-role.md)]

## Update browser security settings on Windows Server

If Enhanced Security Configuration is enabled in Internet Explorer (it is enabled by default), then you may need to add some domains as trusted sites to enable you to download some of the web server components. Add the trusted sites by going to **Internet Options** > **Security** > **Trusted Sites** > **Sites**. Add the following domains.

- microsoft.com
- go.microsoft.com
- download.microsoft.com
- iis.net

When you download the software, you may get requests to grant permission to load various web site scripts and resources. Some of these resources are not required, but to simplify the process, click **Add** when prompted.

## <a name="BKMK_deploy_asp_net"></a> Install ASP.NET 4.5 on Windows Server

If you want more detailed information to install ASP.NET on IIS, see [IIS 8.0 Using ASP.NET 3.5 and ASP.NET 4.5](/iis/get-started/whats-new-in-iis-8/iis-80-using-aspnet-35-and-aspnet-45).

1. In the left pane of Server Manager, select **IIS**. Right-click the server and select **Internet Information Services (IIS) Manager**.

1. Use the Web Platform Installer (WebPI) to install ASP.NET 4.5 (from the Server node in Windows Server 2012 R2, choose **Get New Web Platform Components** and then search for ASP.NET)

    ![RemoteDBG_IIS_AspNet_45](../debugger/media/remotedbg_iis_aspnet_45.png "RemoteDBG_IIS_AspNet_45")

    > [!NOTE]
    > If you are using Windows Server 2008 R2, install ASP.NET 4 instead using this command:

     **C:\Windows\Microsoft.NET\Framework64\v4.0.30319\aspnet_regiis.exe -ir**

2. Restart the system (or execute **net stop was /y** followed by **net start w3svc** from a command prompt to pick up a change to the system PATH).

## <a name="BKMK_install_webdeploy"></a> Install Web Deploy 3.6 on Windows Server

[!INCLUDE [remote-debugger-install-web-deploy](../debugger/includes/remote-debugger-install-web-deploy.md)]

## <a name="BKMK_deploy_asp_net"></a> Configure ASP.NET Web site on the Windows Server computer

1. Open Windows Explorer and create a new folder, **C:\Publish**, where you will later deploy the ASP.NET project.

2. If it's not already open, open the **Internet Information Services (IIS) Manager**. (In the left pane of Server Manager, select **IIS**. Right-click the server and select **Internet Information Services (IIS) Manager**.)

3. Under **Connections** in the left pane, go to **Sites**.

4. Select the **Default Web Site**, choose **Basic Settings**, and set the **Physical path** to **C:\Publish**.

5. Right-click the **Default Web Site** node and select **Add Application**.

6. Set the **Alias** field to **MyASPApp**, accept the default Application Pool (**DefaultAppPool**), and set the **Physical path** to **C:\Publish**.

7. Under **Connections**, select **Application Pools**. Open **DefaultAppPool** and set the Application pool field to **ASP.NET v4.0** (ASP.NET 4.5 is not an option for the Application pool).

8. With the site selected in the IIS Manager, choose **Edit Permissions**, and make sure that IUSR, IIS_IUSRS, or the user configured for the Application Pool is an authorized user with Read & Execute rights. If none of these users are present, add IUSR as a user with Read & Execute rights.

## <a name="bkmk_webdeploy"></a> Publish and deploy the app using Web Deploy from Visual Studio

[!INCLUDE [deploy-app-web-deploy](../deployment/includes/deploy-app-web-deploy.md)]

Also, you may need to read the section on [Troubleshoot ports](#bkmk_openports).

## <a name="bkmk_openports"></a> Troubleshoot: Open required ports on Windows Server

In most setups, required ports are opened by the installation of ASP.NET and Web Deploy. However, you may need to verify that ports are open.

> [!NOTE]
> On an Azure VM, you must open ports through the [Network security group](/azure/virtual-machines/virtual-machines-windows-hero-role#open-port-80). 

Required ports:

* 80 - Required for IIS
* 8172 - Required for Web Deploy to deploy the app from Visual Studio

1. To open a port on Windows Server, open the **Start** menu, search for **Windows Firewall with Advanced Security**.

2. Then choose **Inbound Rules** > **New Rule** > **Port**. Choose **Next** and under **Specific local ports**, enter the port number, click **Next**, then **Allow the Connection**, click Next, and add the name (**IIS**, **Web Deploy**, or **msvsmon**) for the Inbound Rule.

    If you want more details on configuring Windows Firewall, see [Configure the Windows Firewall for Remote Debugging](../debugger/configure-the-windows-firewall-for-remote-debugging.md).

3. Create additional rules for the other required ports.

## Next steps

In this tutorial, you created a publish settings file, imported it into Visual Studio, and deployed an ASP.NET app to IIS. You can also deploy by importing publish settings.

> [!div class="nextstepaction"]
> [Deploy to IIS by importing publish settings](../deployment/tutorial-import-publish-settings-iis.md)