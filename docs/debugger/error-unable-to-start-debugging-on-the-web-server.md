---
title: "Error: Unable to Start Debugging on the Web Server | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.debug.error.http"
  - "vwd.nonadmin.error."
dev_langs: 
  - "CSharp"
  - "VB"
  - "FSharp"
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
caps.latest.revision: 29
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
# Error: Unable to Start Debugging on the Web Server
When you try to debug an ASP.NET application running on a Web server, you may get this error message: `Unable to start debugging on the Web server`.
  
In many cases, this error occurs because IIS is not configured correctly.

##  <a name="vxtbshttpservererrorsthingstocheck"></a> Check your IIS configuration

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

* Bring up the localhost page in the browser on the server.

     If IIS is not installed correctly, you should get errors when you type `http://localhost` in a browser.
     
     For more information on deploying to IIS, see [Host on Windows with IIS](https://docs.asp.net/en/latest/publishing/iis.html).

* Make sure that the correct version of ASP.NET is installed on IIS.  See [Host on Windows with IIS](https://docs.asp.net/en/latest/publishing/iis.html).

    Mismatched versions of ASP.NET on IIS and in your Visual Studio project may cause this issue. Try setting the framework version in web.config.

* Create a basic ASP.NET application on the server.

    If you can't get your app to work with the debugger, try creating a basic ASP.NET application locally on the server (or you can use the default ASP.NET MVC template), and try to debug the basic app. If you can debug a basic app, that may help you identify what's different between the two configurations. Look for differences in settings in the web.config file, such as URL rewrite rules.
  
* Resolve authentication errors if you are using only the IP address

     By default, IP addresses are assumed to be part of the Internet, and NTLM authentication is not done over the Internet. If your web site is configured in IIS to require authentication, this authentication will fail. To correct this problem, you can specify the name of the remote computer instead of the IP address.
     
## Other causes

If the IIS configuration is not causing the issue, try these steps:

- Restart Visual Studio with elevated privileges and try again.

    Some ASP.NET debugging scenarios such as using Web Deploy require elevated privileges for Visual Studio.
    
- If multiple instance of Visual Studio are running, re-open your project in one instance of Visual Studio (with elevated privileges), and try again.

- Check the specific message immediately following `Unable to start debugging on the Web server`. This message might indicate other causes of the problem. For example:
    - If you are debugging remotely, the message might refer to msvsmon.exe. In this case, make sure you have [installed and are running the remote debugger](../debugger/remote-debugging.md).
    - If you are debugging on the same machine as the web server host, the message might say that you can't connect to the web server. Open your project properties and make sure that the project is configured to connect to your local web server when you start debugging (open **Properties / Web / Servers** or **Properties / Debug** depending on your project type).
  
## See Also  
 [Debugging Web Applications: Errors and Troubleshooting](../debugger/debugging-web-applications-errors-and-troubleshooting.md)