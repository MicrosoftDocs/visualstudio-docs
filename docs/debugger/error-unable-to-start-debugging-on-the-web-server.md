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

## Restart the app and then try restarting IIS
Try these steps first as a potential quick fix.

1. Press Shift + F5 (or **Debug**, **Stop Debugging**) to stop the app and then F5 (or **Debug**, **Start Debugging**).

2. If you see the same error, reset IIS and retry. Take these steps:

     * On the server, open a command prompt as an Administrator (right-click and choose **Run as Administrator**).
     * Type ``iisreset /restart``.
     * In Visual Studio, restart debugging (press F5).

3. If you still see the same error, start a Web browser and type the URL of the page you are trying to debug (for example: `http://localhost/MyWebApplication` or `http://<remote computer name>`). If IIS is not configured correctly, or your ASP.NET application is not deployed correctly, you should get errors that help you to fix your IIS setup and your ASP.NET deployment. Also, see [Check your IIS configuration](#vxtbshttpservererrorsthingstocheck).

##  <a name="vxtbshttpservererrorsmanuallyattaching"></a> If the web server is local, try attaching to the server process
If you still get an error message when you try starting the app with the debugger attached (for example, using F5), try debugging your application by manually attaching to the process instead.
  
1. Start the application without debugging. (From the **Debug** menu, choose **Start Without Debugging**.)  
  
2. Click **Debug/Attach to Process** (**Ctrl + Alt + P**).  When the window appears, enable **Show processes from all users**.

3. Select the correct process for IIS.
  
     To quickly find the process you need, type the first letter of the process you want to attach to. For ASP.NET apps prior to ASP.NET Core, the IIS process is w3wp.exe. For ASP.NET Core, the IIS process is dnx.exe (Please see [Remote Debugging ASP.NET on a Remote IIS Computer](../debugger/remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md) or, for ASP.NET Core, see [Publishing to IIS](https://docs.asp.net/en/latest/publishing/iis.html)).

4. Choose **Attach**.

##  <a name="vxtbshttpservererrorswebapplicationsonremoteservers"></a> If the web server is remote, make sure the remote debugger is running

If you are trying to debug on a remote Web server:

1. Make sure the Visual Studio Remote Tools are installed.

     For information about downloading and installing the remote tools, see [Remote Debugging](../debugger/remote-debugging.md).  
     
     > [!IMPORTANT]
     > To do remote debugging of ASP.NET applications, you can either run the remote debugger application as an Administrator or start the remote debugger as a service. Details about how to run the remote debugger as a service can be found in [Remote Debugging](../debugger/remote-debugging.md).
     
2. Once the remote debugger installed, make sure the remote debugger is running on the target machine. (If it's not, search for **Remote Debugger** in the **Start** menu. ) The remote debugger window looks like this. (4020 is the default port number)

![RemoteDebuggerWindow](../debugger/media/remotedebuggerwindow.png "RemoteDebuggerWindow")

3. In Visual Studio, use **Debug/Attach to Process** (**Ctrl + Alt + P**) to attach to IIS.

     If you can't connect to the remote debugger using the computer name, try the IP address and port number.

4. Make sure that the build of the app running in IIS is the same build as the one you have open in Visual Studio.

     For more information, see [Remote Debugging ASP.NET on a Remote IIS Computer](../debugger/remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md).

##  <a name="vxtbshttpservererrorsthingstocheck"></a> Check your IIS configuration
If you need to correct your IIS configuration, you can try these steps.

* Bring up the localhost page in the browser

     If IIS is not installed correctly, you should get errors when you type `http://localhost` in a browser.
     
     For information about deploying to IIS with an ASP.NET Core see [Remote Debugging ASP.NET on a Remote IIS Computer](../debugger/remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md) or, for ASP.NET Core, [Publishing to IIS](https://docs.asp.net/en/latest/publishing/iis.html)).

* Make sure that ASP.NET is installed on IIS.  See [Deploy an ASP.NET Application[(../debugger/remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md#BKMK_deploy_asp_net) or, for ASP.NET Core, [Publishing to IIS](https://docs.asp.net/en/latest/publishing/iis.html)).

* Make sure that you have an application pool for the app running in IIS.

     It is possible that application pool has stopped.

* Create a basic ASP.NET application on the server.

     If you can't get your app to work with the debugger, try creating a basic ASP.NET application locally on the server, and try to debug the basic app. If you can debug a basic app, that may help you identify what's different between the two configurations.
  
* Resolve authentication errors if you are using only the IP address

     By default, IP addresses are assumed to be part of the Internet, and NTLM authentication is not done over the Internet. If your web site is configured in IIS to require authentication, this authentication will fail. To correct this problem, you can specify the name of the remote computer instead of the IP address.
  
## See Also  
 [Debugging Web Applications: Errors and Troubleshooting](../debugger/debugging-web-applications-errors-and-troubleshooting.md)