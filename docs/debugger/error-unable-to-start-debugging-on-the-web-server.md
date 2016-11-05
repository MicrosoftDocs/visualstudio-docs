---
title: "Error: Unable to Start Debugging on the Web Server | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
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
When you try to debug an ASP.NET application running on a Web server, you may get this error message: Unable to start debugging on the Web server.  
  
 In most cases this error occurs because IIS is not configured correctly.  
  
##  <a name="vxtbshttpservererrorsthingstocheck"></a> Make sure IIS is configured properly  
 For information about deploying to IIS 8 with an MVC 5 app, see [Publishing to IIS](https://docs.asp.net/en/latest/publishing/iis.html).  
  
 For information about deploying to IIS7.5, see [Remote Debugging ASP.NET on a Remote IIS 7.5 Computer](../debugger/remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md).  
  
##  <a name="vxtbshttpservererrorswebapplicationsonremoteservers"></a> Make sure the Visual Studio Remote Tools are installed  
 If you are trying to debug on a remote Web server, the Visual Studio Remote Tools must be installed. For information about downloading and installing the remote tools, see [Remote Debugging](../debugger/remote-debugging.md).  
  
##  <a name="vxtbshttpservererrorsanchor2"></a> Make sure ASP.NET is installed  
 **IIS 8**  
  
 For IIS 8, you install ASP.NET as part of IIS.  
  
1.  In the **Server Manager** tile, select **Dashboard**, and click **Add roles and features**.  
  
2.  On the **Installation type** page, select **Role-based or feature-based installation**, and click **Next**.  
  
3.  On the **Select destination server** page, select **Select a server from the server pool**, select your server, and click **Next**.  
  
4.  On the **Select server roles** page, select **Web Server (IIS)**, and click **Next**.  
  
5.  On the **Select features page**, click **Next**.  
  
6.  On the **Web Server Role (IIS)** page, click **Next**.  
  
7.  On the **Select role services** page, note the preselected role services that are installed by default, expand the **Application Server** node, then the **.NET Framework 4.5** node, and then select **ASP.NET 4.5**. (If you installed .NET 3.5, select **ASP.NET 3.5** also.)  
  
8.  On the **Confirm installation selections** page, click **Install**.  
  
9. On the **Installation progress** page, confirm that your installation of the Web Server (IIS) role and required role services completed successfully, and then click **Close**.  
  
 **IIS 7.5 and earlier**  
  
 For IIS 7.5 and earlier: from a command prompt window, run the following command:  
  
```  
systemroot\Microsoft.NET\Framework\ versionNumber \aspnet_regiis -i   
```  
  
## Basic Troubleshooting  
 Here are some things you can do to make sure your ASP.NET application is deployed correctly.  
  
## Bring up the localhost page in the browser  
 If IIS is not installed correctly, you should get errors when you type `http://localhost` in a browser.  
  
## Bring up the Web page in the browser  
 Start a Web browser and type the URL of the page you are trying to debug (for example: `http://localhost/MyWebApplication`). If IIS is not configured correctly, or your ASP.NET application is not deployed correctly, you should get errors that help you to fix your IIS setup and your ASP.NET deployment.  
  
## Create a basic ASP.NET application on the server  
 Try creating a basic ASP.NET application locally on the server, and try to debug it.  
  
## Resolve authentication errors if you are using only the IP address  
 By default, IP addresses are assumed to be part of the Internet, and NTLM authentication is not done over the Internet. If your web site is configured in IIS to require authentication, this authentication will fail. To correct this problem, you can specify the name of the remote computer.  
  
##  <a name="vxtbshttpservererrorsmanuallyattaching"></a> Manually attaching to the process  
 If you still get an error message when you start debugging, you may want to try debugging your application by manually attaching to the process.  
  
-   Start the application without debugging. (From the **Debug** menu, choose **Start Without Debugging**.)  
  
-   Click **Debug/Attach to Process**.  When the window appears, enable **Show processes from all users**.  
  
-   Find the appropriate process and attach to it. For ASP.NET apps prior to MVC 5, the process is w3wp.exe. For MVC 5, please see [Publishing to IIS](https://docs.asp.net/en/latest/publishing/iis.html).  
  
## See Also  
 [Debugging Web Applications: Errors and Troubleshooting](../debugger/debugging-web-applications-errors-and-troubleshooting.md)