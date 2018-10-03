---
title: "Enable debugging for ASP.NET apps | Microsoft Docs"
ms.custom: "H1HackMay2017"
ms.date: "09/21/18"
ms.technology: "vs-ide-debug"
ms.topic: "conceptual"
dev_langs: 
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords: 
  - "debugging ASP.NET Web applications"
  - "Web.config configuration file, debug mode"
  - "debugging [Visual Studio], ASP.NET"
ms.assetid: 3beed819-cece-4864-8184-bd410000973a
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload: 
  - "aspnet"
---
# Debug ASP.NET or ASP.NET Core apps in Visual Studio

You can debug ASP.NET and ASP.NET Core apps from Visual Studio. The process differs between ASP.NET and ASP.NET Core, and whether you are running it on IIS Express or a local IIS server. 

The built-in, preconfigured IIS Express server is included by default with Visual Studio, and is the easiest way to debug an ASP.NET or ASP.NET Core app. New ASP.NET and ASP.NET Core projects in Visual Studio are already configured to debug with IIS Express. It is ideal for initial debugging and testing. 

You can also debug an ASP.NET or ASP.NET Core app on a local IIS server (version 8.0 or higher) that is configured to run the app. To debug ASP.NET apps on local IIS in Visual Studio, you must:

- Select **Development time IIS support** when installing Visual Studio. (If necessary, rerun the Visual Studio Installer, select **Modify**, and add this component.)
- Be running Visual Studio as an administrator. 
- Install and correctly configure IIS, the appropriate version of ASP.NET and/or ASP.NET Core, and application pools. For details, see [Configure IIS for ASP.NET and ASP.NET Core](#configure-iis-for-aspnet-and-aspnet-core).

>[!NOTE]
>The following steps and settings apply only to debugging apps on a local server. Debugging apps on a remote IIS server uses **Attach to Process**, and ignores these settings. For more information and instructions for remote debugging ASP.NET apps on IIS, see [Remote debug ASP.NET on an IIS computer](../debugger/remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md) or [Remote debug ASP.NET Core on a remote IIS computer](../debugger/remote-debugging-aspnet-on-a-remote-iis-computer.md).

## Debug ASP.NET apps

>[!NOTE]
>The IIS Express settings are already selected for new ASP.NET projects. 

1. Select the ASP.NET project in Visual Studio **Solution Explorer** and click the **Properties** icon, press **Alt**+**Enter**, or right-click and choose **Properties**.
   
1. Select the **Web** tab.
   
1. In the **Properties** pane, under **Servers**, 
   - For IIS Express, select **IIS Express** from the dropdown.
   - For local IIS,
     1. Select **Local IIS** from the dropdown.
     1. Next to the **Project URL** field, select **Create Virtual Directory**, if you have not yet added the app in IIS Manager.
   
1. Under **Debuggers**, select **ASP.NET**.
   
   ![ASP.NET debugger settings](media/dbg-aspnet-enable-debugging2.png "ASP.NET debugger settings")
   
1. Use **File** > **Save Selected Items** or **Ctrl**+**S** to save any changes. 
   
1. To debug the app, in your project, set breakpoints on some code. In the Visual Studio toolbar, make sure the configuration is set to **Debug**, and the browser you want appears in **IIS Express (\<Browser name>)** or **Local IIS (\<Browser name>)** in the emulator field. 
   
1. To start debugging, select **IIS Express (\<Browser name>)** or **Local IIS (\<Browser name>)** in the toolbar, select **Start Debugging** from the **Debug** menu, or press **F5**. The debugger pauses at the breakpoints. If the debugger cannot hit the breakpoints, see [Troubleshoot debugging](#troubleshoot-debugging).

## Debug ASP.NET Core apps 

>[!NOTE]
>The IIS Express settings are already selected for new ASP.NET Core projects. 

1. Select the ASP.NET Core project in Visual Studio **Solution Explorer** and click the **Properties** icon, press **Alt**+**Enter**, or right-click and choose **Properties**.

1. Select the **Debug** tab.
   
1. In the **Properties** pane, next to **Profile**, 
   - For IIS Express, select **IIS Express** from the dropdown.
   - For local IIS, select the app name from the dropdown, or select **New**, create a new profile name, and select **OK**.
   
1. Next to **Launch**, select either **IIS Express** or **IIS** from the dropdown. 
   
1. Make sure **Launch browser** is selected.
   
1. Under **Environment variables**, make sure that **ASPNETCORE_ENVIRONMENT** is present with a value of **Development**. If not, select **Add** and add it.
   
   ![ASP.NET Core debugger settings](../debugger/media/dbg-aspnet-enable-debugging3.png "ASP.NET Core debugger settings")
   
1. Use **File** > **Save Selected Items** or **Ctrl**+**S** to save any changes. 
   
1. To debug the app, in your project, set breakpoints on some code. In the Visual Studio toolbar, make sure the configuration is set to **Debug**, and either **IIS Express**, or the new IIS profile name, appears in the emulator field. 
   
1. To start debugging, select **IIS Express** or **\<IIS profile name>** in the toolbar, select **Start Debugging** from the **Debug** menu, or press **F5**. The debugger pauses at the breakpoints. If the debugger cannot hit the breakpoints, see [Troubleshoot debugging](#troubleshoot-debugging).

## Troubleshoot debugging

If local IIS debugging cannot progress to the breakpoint, follow these steps to troubleshoot. 

1. Start the web app from IIS, and make sure it runs correctly. Leave the web app running.
   
2. From Visual Studio, select **Debug > Attach to Process** or press **Ctrl**+**Alt**+**P**, and connect to the ASP.NET or ASP.NET Core process (typically **w3wp.exe** or **dotnet.exe**). For more information, see [Attach to Process](attach-to-running-processes-with-the-visual-studio-debugger.md) and [How to find the name of the ASP.NET process](how-to-find-the-name-of-the-aspnet-process.md).

If you are able to connect and hit the breakpoint by using **Attach to Process**, but not by using **Debug** > **Start Debugging** or **F5**, a setting is probably incorrect in the project properties. If you use a HOSTS file, make sure it is also configured correctly.

## Configure debugging in the web.config file  

ASP.NET projects have *web.config* files by default, which contain both app configuration and launch information, including debug settings. The *web.config* files must be configured correctly for debugging. The **Properties** settings in previous sections update the *web.config* files, but you can also configure them manually. 

> [!NOTE]
> ASP.NET Core projects do not initially have *web.config* files, but use *appsettings.json* and *launchSettings.json* files for app configuration and launch information. Deploying the app creates a *web.config* file or files in the project, but they do not typically contain debug information.

**To manually configure a *web.config* file for debugging:**

> [!TIP]
> Your deployment process may update the *web.config* settings, so before trying to debug, make sure the *web.config* is configured for debugging.
  
1. In Visual Studio, open the ASP.NET project's *web.config* file.  
  
2. *Web.config* is an XML file, so contains nested sections marked by tags. Locate the `configuration/system.web/compilation` section. (If the `compilation` element does not exist, create it.)
  
3. Ensure that the `debug` attribute in the `compilation` element is set to `true`. (If the `compilation` element does not contain a `debug` attribute, add it and set it to `true`.) 
  
  If you are using local IIS instead of the default IIS Express server, ensure that the `targetFramework` attribute value in the `compilation` element matches the framework on the IIS server.
  
  The `compilation` element of the *web.config* file should look like the following example:

  > [!NOTE]
  > This example is a partial *web.config* file. There are usually additional XML sections in the `configuration` and `system.web` elements, and the `compilation` element might also contain other attributes and elements.
  
  ```xml
  <configuration>  
      ...  
      <system.web>  
          <compilation  debug="true"  targetFramework="4.6.1" ... > 
             ...  
          </compilation>  
      </system.web>  
  </configuration>  
  ```

[!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] automatically detects any changes to *web.config* files and applies the new configuration settings. You do not have to restart the computer or the IIS server for changes to take effect.  
  
A website can contain several virtual directories and subdirectories, with *web.config* files in each one. [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] apps inherit configuration settings from *web.config* files at higher levels in the URL path. The hierarchical *web.config* file settings apply to all [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] apps below them in the hierarchy. Setting a different configuration in a *web.config* file lower in the hierarchy overrides the settings in the higher file.  
  
For example, if you specify `debug="true"` in *www.microsoft.com/aaa/web.config*, any app in the *aaa* folder or in any subfolder of *aaa* inherits that setting, except if one of those apps overrides the setting with its own *web.config* file.  
  
## Publish to IIS in debug mode using the file system

There are different ways to publish apps to IIS. These steps show how to create and deploy a debug Publish profile using the file system. To do this, you must be running Visual Studio as an administrator. 

> [!IMPORTANT]
>  If you change your code or rebuild, you must repeat these steps to republish. 

1. In Visual Studio, right-click the project and choose **Publish**.

3. Choose **IIS, FTP, etc** and click **Publish**.

    ![Publish to IIS](media/dbg-aspnet-local-iis.png "Publish to IIS")

4. In the **CustomProfile** dialog, for **Publish method**, choose **File system**.

5. For **Target location**, enter the location of the app on your machine.

1. Select **Next**. 

1. Under **Configuration**, select **Debug** from the dropdown.

1. Select **Save**.

1. In the **Publish** dialog, make sure **CustomProfile** (or the name of the profile you just created) appears, and **LastUsedBuildConfiguration** is set to **Debug**. 

1. Select **Publish**.

    ![Publish to IIS](media/dbg-aspnet-local-iis-select-site.png "Publish to IIS")

> [!IMPORTANT]
> Debug mode greatly reduces the performance of your app. For best performance, set `debug="false"` in the *web.config* and specify a Release build when you deploy a production app or conduct performance measurements.  

## Configure IIS for ASP.NET and ASP.NET Core

For more information about configuring IIS for ASP.NET and ASP.NET Core, see [IIS 8.0 Using ASP.NET 3.5 and ASP.NET 4.5](/iis/get-started/whats-new-in-iis-8/iis-80-using-aspnet-35-and-aspnet-45) and [Host ASP.NET Core on Windows with IIS](https://docs.microsoft.com/aspnet/core/host-and-deploy/iis/index). 
   
1. Install IIS, ASP.NET, and/or ASP.NET Core.
   - To install IIS and ASP.NET in Windows Server: 
     1. Use **Add Roles and Features** and select the **Web Server (IIS)** Server Role. 
     1. Under **Role Services**, select at least the defaults under **Management Tools** and **Web Server**. 
     1. For ASP.NET support, under **Application Development**, select **ASP.NET 4.5** (and/or 3.5, if necessary for your app(s)). 
     1. Select **Install**. 
     
   - To install IIS and ASP.NET in Windows desktop: 
     1. In Control Panel **Programs**, select **Turn Windows features on or off**, and select at least the defaults under **Internet Information Services**. 
     1. For ASP.NET support, under **Application Development**, select **ASP.NET 4.7** (and/or 3.5, if necessary for your app(s)). 
     1. Select **OK**.
     
   - To install ASP.NET Core support, install the ASP.NET Core Module, which allows IIS to support ASP.NET Core apps in a reverse proxy configuration. For details and instructions, see [Install the .NET Core Hosting Bundle](https://docs.microsoft.com/aspnet/core/host-and-deploy/iis/index#install-the-net-core-hosting-bundle). 
   
1. If necessary, create or configure application pools in Internet Information Services (IIS) Manager. 
   
   1. In the IIS Manager **Connections** pane, select **Application Pools**. 
   1. To create a new application pool, right-click and select **Add Application Pool**, or select **Add Application Pool** in the **Actions** pane.
   1. Or, to reconfigure an application pool, right-click the app pool in the **Application Pools** list and select **Basic settings**, or select **Basic Settings** in the **Actions** pane.
   1. In the **Add Application Pool** or **Edit Application Pool** dialog, under **.NET CLR settings**, choose the correct setting: **Version 4.0.x** for ASP.NET 4.x, **Version 2.0.x** for ASP.NET 3.x, or **No Managed Code** for ASP.NET Core. 
   1. Select **OK**.  
   
   >[!NOTE]
   >The **Application Pools** pane in IIS Manager lists the **DefaultAppPool** and any app pools that were automatically created by installing ASP.NET or ASP.NET Core Module. 
   >- If you installed ASP.NET, the DefaultAppPool is automatically configured to run the highest installed version of ASP.NET. (For ASP.NET 4.x, the .NET CLR version is v4.0.) 
   >- If you installed ASP.NET Core but not ASP.NET, the DefaultAppPool is automatically configured to run under .NET Core (.NET CLR = No Managed Code). 
   >- To support both ASP.NET and ASP.NET Core apps, they must run under different application pools. 
   
1. If necessary, add your app to IIS, and assign or reassign its application pool.
   - To add an app:
     1. In the Internet Information Services (IIS) Manager **Connections** pane, under **Sites**, right-click the website and select **Add Application**.
     2. Under **Alias**, type the app name. Under **Application Pool**, select the appropriate app pool.
     3. Under **Physical path**, enter the location of the app on your machine. 
     4. Select **OK**.  
   
   - To reassign an application pool:
     1. In the IIS Manager **Connections** pane, select the app, and select **Basic settings** in the **Actions** pane. 
     1. Under **Application pool**, select the correct app pool. 
     1. Select **OK**.  
   
   >[!NOTE]
   >Deploying an ASP.NET app to IIS in Visual Studio automatically adds it in IIS Manager, so you may not need to add an app manually, unless you need to configure it before deployment. To update the list of existing apps in IIS, right-click **Sites** in the IIS Manager **Connections** pane, and select **Refresh**. 
   

## See also  
[ASP.NET debugging: system requirements](aspnet-debugging-system-requirements.md)   
[How to: Run the worker process under a user account](how-to-run-the-worker-process-under-a-user-account.md)   
[How to: Find the name of the ASP.NET process](how-to-find-the-name-of-the-aspnet-process.md)   
[Debug deployed web applications](debugging-deployed-web-applications.md)   
[Walkthrough: Debugging a web form](walkthrough-debugging-a-web-form.md)   
[How to: Debug ASP.NET exceptions](how-to-debug-aspnet-exceptions.md)   
[Debug web applications: Errors and troubleshooting](debugging-web-applications-errors-and-troubleshooting.md)
  
