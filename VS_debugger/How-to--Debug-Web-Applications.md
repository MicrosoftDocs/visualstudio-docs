---
title: "How to: Debug Web Applications"
ms.custom: na
ms.date: 10/10/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 6440d12e-6b29-42c5-a958-99aeaaff480f
caps.latest.revision: 37
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# How to: Debug Web Applications
ASP.NET is the primary technology for developing Web applications in Visual Studio. The Visual Studio debugger provides powerful tools for debugging ASP.NET Web applications locally or on a remote server. This topic describes how to debug a ASP.NET project during development. For information about how to debug a ASP.NET Web application already deployed on a production server, see [Debugging Deployed Web Applications](../VS_debugger/Debugging-Deployed-Web-Applications.md).  
  
 To debug a ASP.NET application:  
  
-   You must have required permissions. For more information, see [System Requirements](../VS_debugger/ASP.NET-Debugging--System-Requirements.md).  
  
-   ASP.NET debugging must be enabled in **Project Properties**.  
  
-   The configuration file of your application (Web.config) must be set to debug mode. Debug mode causes ASP.NET to generate symbols for dynamically generated files and enables the debugger to attach to the ASP.NET application. Visual Studio sets this automatically when you start to debug, if you created your project from the Web projects template.  
  
-   For more information, see [How to: Enable Debugging for ASP.NET Applications](../VS_debugger/How-to--Enable-Debugging-for-ASP.NET-Applications.md).  
  
### To debug a Web application during development  
  
1.  On the **Debug** menu, click **Start** to begin debugging the Web application.  
  
     Visual Studio builds the Web application project, deploys the application if necessary, starts the ASP.NET Development Server if you are debugging locally, and attaches to the ASP.NET worker process.  
  
2.  Use the Debugger to set and clear breakpoints, step, and perform other debugging operations, as you would for any application.  
  
     For more information, see [Debugger Basics](../VS_debugger/Debugger-Basics.md).  
  
3.  On the **Debug** menu, click **Stop Debugging** to end the debugging session, or, on the **File** menu in Internet Explorer, click **Close**.  
  
## See Also  
 [Debugging Web Applications and Script](../VS_debugger/Debugging-Web-Applications-and-Script.md)   
 [Debugging ASP.NET and AJAX Applications](../VS_debugger/Debugging-ASP.NET-and-AJAX-Applications.md)   
 [How to: Enable Debugging for ASP.NET Applications](../VS_debugger/How-to--Enable-Debugging-for-ASP.NET-Applications.md)