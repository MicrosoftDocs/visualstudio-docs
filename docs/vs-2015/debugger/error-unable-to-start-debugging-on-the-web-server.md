---
title: "Error: Unable to Start Debugging on the Web Server | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
f1_keywords: 
  - "vs.debug.error.http"
  - "vwd.nonadmin.error."
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "IIS, debugging DLLs"
  - "debugger, Web application errors"
  - "unable to start debugging error"
  - "security [debugger], Web applications"
  - "debugging [Visual Studio], errors"
  - "HTTP servers, debugging error"
  - "security settings, checking for default Web sites"
  - "errors [debugger], unable to start debugging"
  - "debugging ASP.NET Web applications, unable to start debugging error"
  - "remote debugging, errors"
ms.assetid: f62e378a-3a99-4f78-9d97-8bb63a4da181
caps.latest.revision: 40
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Error: Unable to Start Debugging on the Web Server
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

When you try to debug an ASP.NET application running on a Web server, you may get this error message: Unable to start debugging on the Web server.
  
In many cases, this error occurs because IIS is not configured correctly.

## <a name="vxtbshttpservererrorsthingstocheck"></a> Check your IIS configuration

After taking steps to resolve an issue detailed here, and before trying again to debug, you may also need to reset IIS. You can do that by opening an Administrator command prompt and typing `iisreset`, or you can do this in IIS Manager. 

* Stop and restart your Application Pools, then retry.

    The Application Pool may have stopped or another configuration change that you made may require that you stop and restart your Application Pool.
    
    > [!NOTE]
    > If the Application Pool keeps stopping, you may need to uninstall the URL Rewrite Module from the Control Panel and then reinstall it using the Web Platform Installer (WPI). This could be an issue after a significant system upgrade.

* Check your Application Pool configuration, correct it if needed, and then retry.

    If password credentials have changed, you may need to update them in your Application Pool. Also, if you have recently installed ASP.NET, the Application Pool may be configured for the wrong version of ASP.NET. Fix the issue and restart the Application Pool.
    
* Check that your Web Application folder has the right permissions.

    Make sure that you give IIS_IUSRS or IUSR (or the specific user associated with the Application Pool) read and execute rights for the Web Application folder. Fix the issue and restart your Application Pool.

* If you are using a HOSTS file with local addresses, try using the loopback address instead of the machine's IP address.

* Bring up the localhost page in the browser.

     If IIS is not installed correctly, you should get errors when you type `http://localhost` in a browser.
     
     For information about deploying to IIS, see [Remote Debugging ASP.NET on a Remote IIS Computer](../debugger/remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md) or, for ASP.NET Core, [Publishing to IIS](https://docs.asp.net/en/latest/publishing/iis.html)).

* Make sure that the correct version of ASP.NET is installed on IIS.  See [Deploy an ASP.NET Application](../debugger/remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md#BKMK_deploy_asp_net) or, for ASP.NET Core, [Publishing to IIS](https://docs.asp.net/en/latest/publishing/iis.html)).

* Create a basic ASP.NET application on the server.

     If you can't get your app to work with the debugger, try creating a basic ASP.NET application locally on the server, and try to debug the basic app. If you can debug a basic app, that may help you identify what's different between the two configurations.
  
* Resolve authentication errors if you are using only the IP address

     By default, IP addresses are assumed to be part of the Internet, and NTLM authentication is not done over the Internet. If your web site is configured in IIS to require authentication, this authentication will fail. To correct this problem, you can specify the name of the remote computer instead of the IP address.
     
## Other causes

If you are using an older version of Visual Studio:

- Restart Visual Studio with elevated privileges and try again.

    A bug in older versions (fixed later) required elevated privileges in some ASP.NET debugging scenarios.
    
- If multiple instance of Visual Studio are running, re-open your project in one instance of Visual Studio, and try again.

## See Also  
 [Debugging Web Applications: Errors and Troubleshooting](../debugger/debugging-web-applications-errors-and-troubleshooting.md)
