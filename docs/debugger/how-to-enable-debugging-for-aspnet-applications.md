---
title: Enable debugging for ASP.NET apps | Microsoft Docs
description: Learn how to enable debugging for ASP.NET and ASP.NET Core apps in Visual Studio. You can run the process on an IIS Express server or a local IIS server. 
ms.custom: SEO-VS-2020
ms.date: 10/29/2020
ms.topic: how-to
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords: 
  - debugging ASP.NET Web applications
  - Web.config configuration file, debug mode
  - debugging [Visual Studio], ASP.NET
ms.assetid: 3beed819-cece-4864-8184-bd410000973a
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - aspnet
---
# Debug ASP.NET or ASP.NET Core apps in Visual Studio

You can debug ASP.NET and ASP.NET Core apps in Visual Studio. The process differs between ASP.NET and ASP.NET Core, and whether you run it on IIS Express or a local IIS server.

>[!NOTE]
>The following steps and settings apply only to debugging apps on a local server. Debugging apps on a remote IIS server uses **Attach to Process**, and ignores these settings. For more information and instructions for remote debugging ASP.NET apps on IIS, see [Remote debug ASP.NET on an IIS computer](../debugger/remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md) or [Remote debug ASP.NET Core on a remote IIS computer](../debugger/remote-debugging-aspnet-on-a-remote-iis-computer.md).

The built-in IIS Express server is included with Visual Studio. IIS Express is the default debug server for ASP.NET and ASP.NET Core projects, and is preconfigured. It's the easiest way to debug, and ideal for initial debugging and testing.

You can also debug an ASP.NET or ASP.NET Core app on a local IIS server (version 8.0 or higher) that is configured to run the app. To debug on local IIS, you must meet the following requirements:

<a name="iis"></a>
- If it's not installed, install the **ASP.NET and web development workload**. (Rerun the Visual Studio Installer, select **Modify**, and add this workload.)

   ::: moniker range="vs-2017"
   In Visual Studio 2017, Look for the **Development time IIS support** component. Make sure it's selected when you add the workload.
   ::: moniker-end
- Run Visual Studio as an administrator.
- Install and correctly configure IIS with the appropriate version(s) of ASP.NET and/or ASP.NET Core. For more information on using IIS with ASP.NET Core, see [Host ASP.NET Core on Windows with IIS](/aspnet/core/host-and-deploy/iis/index). For ASP.NET, see [Install IIS and ASP.NET Modules](/iis/application-frameworks/scenario-build-an-aspnet-website-on-iis/configuring-step-1-install-iis-and-asp-net-modules).
- Make sure the app runs on IIS without errors.

## Debug ASP.NET apps

IIS Express is the default, and is preconfigured. If you're debugging on Local IIS, make sure you meet the [requirements for local IIS debugging](#iis).

1. Select the ASP.NET project in Visual Studio **Solution Explorer** and click the **Properties** icon, or press **Alt**+**Enter**, or right-click and choose **Properties**.

1. Select the **Web** tab.

1. In the **Properties** pane, under **Servers**,
   - For IIS Express, select **IIS Express** from the dropdown.
   - For local IIS,
     1. Select **Local IIS** from the dropdown.
     1. Next to the **Project URL** field, select **Create Virtual Directory**, if you haven't yet set up the app in IIS.

1. Under **Debuggers**, select **ASP.NET**.

   ![ASP.NET debugger settings](media/dbg-aspnet-enable-debugging2.png "ASP.NET debugger settings")

1. Choose **File** > **Save Selected Items** (or press **Ctrl**+**S**) to save any changes.

1. To debug the app, in your project, set breakpoints on some code. In the Visual Studio toolbar, make sure the configuration is set to **Debug**, and the browser you want appears in **IIS Express (\<Browser name>)** or **Local IIS (\<Browser name>)** in the emulator field.

1. To start debugging, select **IIS Express (\<Browser name>)** or **Local IIS (\<Browser name>)** in the toolbar, select **Start Debugging** from the **Debug** menu, or press **F5**. The debugger pauses at the breakpoints. If the debugger can't hit the breakpoints, see [Troubleshoot debugging](#troubleshoot-debugging).

## Debug ASP.NET Core apps

IIS Express is the default, and is preconfigured. If you're debugging on Local IIS, make sure you meet the [requirements for local IIS debugging](#iis).

1. Select the ASP.NET Core project in Visual Studio **Solution Explorer** and click the **Properties** icon, or press **Alt**+**Enter**, or right-click and choose **Properties**.

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

1. To start debugging, select **IIS Express** or **\<IIS profile name>** in the toolbar, select **Start Debugging** from the **Debug** menu, or press **F5**. The debugger pauses at the breakpoints. If the debugger can't hit the breakpoints, see [Troubleshoot debugging](#troubleshoot-debugging).

## Troubleshoot debugging

If local IIS debugging can't progress to the breakpoint, follow these steps to troubleshoot.

1. Start the web app from IIS, and make sure it runs correctly. Leave the web app running.

2. From Visual Studio, select **Debug > Attach to Process** or press **Ctrl**+**Alt**+**P**, and connect to the ASP.NET or ASP.NET Core process (typically **w3wp.exe** or **dotnet.exe**). For more information, see [Attach to Process](attach-to-running-processes-with-the-visual-studio-debugger.md) and [How to find the name of the ASP.NET process](how-to-find-the-name-of-the-aspnet-process.md).

If you can connect and hit the breakpoint by using **Attach to Process**, but not by using **Debug** > **Start Debugging** or **F5**, a setting is probably incorrect in the project properties. If you use a HOSTS file, make sure it's also configured correctly.

## Configure debugging in the web.config file

ASP.NET projects have *web.config* files by default, which contain both app configuration and launch information, including debug settings. The *web.config* files must be configured correctly for debugging. The **Properties** settings in previous sections update the *web.config* files, but you can also configure them manually.

> [!NOTE]
> ASP.NET Core projects do not initially have *web.config* files, but use *appsettings.json* and *launchSettings.json* files for app configuration and launch information. Deploying the app creates a *web.config* file or files in the project, but they do not typically contain debug information.

> [!TIP]
> Your deployment process may update the *web.config* settings, so before trying to debug, make sure the *web.config* is configured for debugging.

**To manually configure a *web.config* file for debugging:**

1. In Visual Studio, open the ASP.NET project's *web.config* file.

2. *Web.config* is an XML file, so contains nested sections marked by tags. Locate the `configuration/system.web/compilation` section. (If the `compilation` element doesn't exist, create it.)

3. Make sure that the `debug` attribute in the `compilation` element is set to `true`. (If the `compilation` element doesn't contain a `debug` attribute, add it and set it to `true`.)

   If you are using local IIS instead of the default IIS Express server, make sure that the `targetFramework` attribute value in the `compilation` element matches the framework on the IIS server.

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

[!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] automatically detects any changes to *web.config* files and applies the new configuration settings. You don't have to restart the computer or the IIS server for changes to take effect.

A website can contain several virtual directories and subdirectories, with *web.config* files in each one. [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] apps inherit configuration settings from *web.config* files at higher levels in the URL path. The hierarchical *web.config* file settings apply to all [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] apps below them in the hierarchy. Setting a different configuration in a *web.config* file lower in the hierarchy overrides the settings in the higher file.

For example, if you specify `debug="true"` in <em>www.microsoft.com/aaa/web.config</em>, any app in the *aaa* folder or in any subfolder of *aaa* inherits that setting, except if one of those apps overrides the setting with its own *web.config* file.

## Publish in debug mode using the file system

There are different ways to publish apps to IIS. These steps show how to create and deploy a debug Publish profile using the file system. To do this, you must be running Visual Studio as an administrator.

> [!IMPORTANT]
> If you change your code or rebuild, you must repeat these steps to republish.

1. In Visual Studio, right-click the project and choose **Publish**.

3. Choose **IIS, FTP, etc.** and click **Publish**.

    ![Screenshot of the Pick a publish target dialog in Visual Studio. An IIS, FTP, Web Deploy is selected and the Publish button is highlighted.](media/dbg-aspnet-local-iis.png)

4. In the **CustomProfile** dialog, for **Publish method**, choose **File system**.

5. For **Target location**, select **Browse** (**...**).

   - For ASP.NET, select **Local IIS**, select the website you created for the app, and then select **Open**.

     ![Publish to ASP.NET to IIS](media/dbg-aspnet-local-iis1.png "Publish ASP.NET to IIS")

   - For ASP.NET Core, select **File System**, select the folder you set up for the app, and then select **Open**.

1. Select **Next**.

1. Under **Configuration**, select **Debug** from the dropdown.

1. Select **Save**.

1. In the **Publish** dialog, make sure **CustomProfile** (or the name of the profile you just created) appears, and **LastUsedBuildConfiguration** is set to **Debug**.

1. Select **Publish**.

    ![Screenshot of the Publish dialog, with the CustomProfile app selected, the Publish button highlighted, and LastBuildConfiguration set to Debug.](media/dbg-aspnet-local-iis-select-site.png)

> [!IMPORTANT]
> Debug mode greatly reduces the performance of your app. For best performance, set `debug="false"` in the *web.config* and specify a Release build when you deploy a production app or conduct performance measurements.

## See also
- [ASP.NET debugging: system requirements](aspnet-debugging-system-requirements.md)
- [How to: Run the worker process under a user account](how-to-run-the-worker-process-under-a-user-account.md)
- [How to: Find the name of the ASP.NET process](how-to-find-the-name-of-the-aspnet-process.md)
- [Debug deployed web applications](debugging-deployed-web-applications.md)
- [Walkthrough: Debugging a web form](walkthrough-debugging-a-web-form.md)
- [How to: Debug ASP.NET exceptions](how-to-debug-aspnet-exceptions.md)
- [Debug web applications: Errors and troubleshooting](debugging-web-applications-errors-and-troubleshooting.md)
