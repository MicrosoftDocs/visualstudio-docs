---
title: "Debug ASP.NET Applications | Microsoft Docs"
ms.custom: ""
ms.date: "09/18/17"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords: 
  - "debugging ASP.NET Web applications"
  - "Web.config configuration file, debug mode"
  - "debugging [Visual Studio], ASP.NET"
ms.assetid: b4ce0bfd-84dc-4820-8db9-6190a18e1b9d
caps.latest.revision: 37
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---

# Debug ASP.NET Applications in Visual Studio

You can debug ASP.NET applications from Visual Studio.

If the web server is remote, the remote debugger must be running on the remote computer. To debug on a remote IIS server, see [Remote Debug ASP.NET on an IIS Computer](../debugger/remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md). If you want to debug in browser developer tools rather than use the Visual Studio debugger, see F12 for Edge or Internet Explorer, and see X for Google Chrome.

## Requirements

To follow the instructions in this topic, you need:

- IIS Express, which is included by default in Visual Studio 2012 and later, or

- A local IIS web server that is configured correctly and can run the ASP.NET application without errors.

If the server is remote, the remote debugger must be running on the remote computer. To debug on a remote IIS server, see [Remote Debug ASP.NET on an IIS Computer](../debugger/remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md). 

## Configure debug settings

### Enable ASP.NET debugging in the project properties (Visual Basic, C#)

1. Open your ASP.NET project in Visual Studio.

2. Right-click the project in **Solution Explorer**, choose **Properties**, and then click the **Web** tab.

    For some project types, select **Properties > Debug** instead. For a Web Forms ASP.NET project, select **Property Pages > Start Options**.
  
3.  Under **Debuggers**, select the **ASP.NET** check box.

    ![Debugger settings](../debugger/media/dbg-aspnet-enable-debugging.png "Debugger settings")

### Enable debugging in the web.config file  

In ASP.NET versions prior to ASP.NET Core, you must enable debugging in the application's web.config file. 
  
1.  In Visual Studio, open the project's web.config file.  
  
    > [!NOTE]  
    > You cannot access the web.config file remotely by using a Web browser. For security reasons, [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] configures Microsoft IIS to help prevent direct browser access to Web.config files. If you try to access a configuration file by using a browser, you will get HTTP access error 403 (forbidden).  
  
2.  Locate the `configuration/system.web/compilation` element. If the compilation element does not exist, create it.

    Web.config is an XML file, and so contains nested sections marked by tags.
  
3.  If the `compilation` element does not contain a `debug` attribute, add the attribute to the element.  
  
4.  Make sure the `debug` attribute value is set to `true`.  
  
The web.config file should look like the following example.

> [!NOTE]
> This is a partial web.config file. Additional XML sections are usually present between the configuration and system.web elements. The compilation element might also contain other attributes and elements.
  
#### Example  
  
```  
<configuration>  
    ...  
    <system.web>  
        <compilation  
            debug="true"  
            ...  
        >  
        ...  
        </compilation>  
    </system.web>  
</configuration>  
```

> [!TIP]
> If you are using an external server instead of the default IIS Express server, you must also make sure that the `targetFramework` attribute value matches the configuration on the server.

## Configure project settings for the server

For debugging on a local web server, set project properties. For debugging on a remote server, you will need more comprehensive instructions described in [Remote Debugging ASP.NET on IIS](../debugger/remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md).

1. In the **Web** tab of the project properties, select either **IIS Express** or **External Server** under the **Server** settings.

    For some project types, these settings appear under the **Debug** tab instead.

    ![Server settings](../debugger/media/dbg-aspnet-server-settings.png "Server settings")

    IIS Express is the default server for ASP.NET and does not require any special configuration. This is the easiest way to debug an ASP.NET application.

    For a Web Forms ASP.NET project, the **Use custom server** appears under **Start Options** in the **Property Pages**.

    ![Server settings for Web Forms app](../debugger/media/dbg-aspnet-server-settings-webforms.png "Server settings for Web Forms app")

2. If you choose an external (or custom) server, enter the correct URL in the **Project URL** (or **Base URL**) field.

    If the external server is remote, the [remote debugger](../debugger/remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md) must be running on the remote computer.

    If the external server is local IIS, IIS must be configured correctly. For example, the correct version of ASP.NET must be configured in IIS. For more information, see [IIS 8.0 Using ASP.NET 3.5 and ASP.NET 4.5](https://docs.microsoft.com/en-us/iis/get-started/whats-new-in-iis-8/iis-80-using-aspnet-35-and-aspnet-45). If you want to test deployment as well as debugging, see [Deploying to test](https://docs.microsoft.com/en-us/aspnet/web-forms/overview/deployment/visual-studio-web-deployment/deploying-to-iis).

## (local IIS web server) Configure deployment

For IIS Express, the web app is deployed automatically when you start debugging. For local IIS, follow these steps.

1. Make sure that IIS is configured correctly. For more information, see [IIS 8.0 Using ASP.NET 3.5 and ASP.NET 4.5](https://docs.microsoft.com/en-us/iis/get-started/whats-new-in-iis-8/iis-80-using-aspnet-35-and-aspnet-45).

2. In Visual Studio, right-click the project and choose **Publish** (for Web Forms, **Publish Web App**).

3. Choose **IIS, FTP, etc.** and click **Publish**.

    ![Publish to IIS](../debugger/media/dbg-aspnet-local-iis.png "Publish to IIS")

    For a Web Forms app, choose **Custom** in the Publish dialog box, enter a profile name and choose **OK**.

4. In the **Publish method** field, choose **File system**.

5. For the **Target location**, click the **Browse** button.

6. Choose **Local IIS**, and select a web site for deployment, and then click **Open**.

7. Click **Save** to save the publish settings, and then click **Publish**.

    > [!CAUTION]
    >  If you need to make changes to the code or rebuild, you must republish and repeat this step. The executable you copied to the remote machine must exactly match your local source and symbols.

## Set a breakpoint and start debugging

1. In your project in Visual Studio, set a breakpoint on some C# or Visual Basic code that you know you can hit.

2. If you are using IIS Express, press **F5** to start debugging.

3. Take actions to run the code that contains the breakpoint.

    The debugger will pause where you set the breakpoint.

3. (local IIS web server) If you have difficulty hitting the breakpoint:

    1. Start the Web app from IIS and make sure it runs correctly.

    2. From Visual Studio, select **Debug > Attach to Process** and connect to the ASP.NET process (typically **w3wp.exe**). For more information, see [Attach to Process](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md).

  
## Robust Programming  
[!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] automatically detects any changes to Web.config files and applies the new configuration settings. You do not have to restart the computer or restart the IIS server for changes to take effect.  
  
A Web site can contain multiple virtual directories and subdirectories, and Web.config files may exist in each one. [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] applications inherit settings from Web.config files at higher levels in the URL path. Hierarchical configuration files allow you to change settings for several [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] applications at the same time, such as for all applications below it in the hierarchy. However, if `debug` is set in a file lower in the hierarchy, it will override the higher value.  
  
For example, you could specify `debug="true"` in www.microsoft.com/aaa/Web.config, and any application in the aaa folder or in any subfolder of aaa will inherit that setting. So if your [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] application is at www.microsoft.com/aaa/bbb, it will inherit that setting, as will any [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] applications in www.microsoft.com/aaa/ccc, www.microsoft.com/aaa/ddd, and so on. The only exception is if one of those applications overrides the setting by means of its own lower Web.config file.  
  
Enabling debug mode will greatly affect the performance of your [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] application. Remember to disable debug mode before you deploy a release application or conduct performance measurements.  
  
## See Also  
[Debugging ASP.NET and AJAX Applications](../debugger/debugging-aspnet-and-ajax-applications.md)  
  
