---
title: "How to: Debug Web Applications | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "Web services, debugging"
  - "ASP.NET Web Forms, debugging"
  - "ASP.NET, debugging Web applications"
  - "debugging ASP.NET Web applications, during development"
ms.assetid: 6440d12e-6b29-42c5-a958-99aeaaff480f
caps.latest.revision: 40
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Debug Web Applications
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

[!INCLUDE[vstecasp](../includes/vstecasp-md.md)] is the primary technology for developing Web applications in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. The [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] debugger provides powerful tools for debugging [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] Web applications locally or on a remote server. This topic describes how to debug a [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] project during development. For information about how to debug a [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] Web application already deployed on a production server, see [Debugging Deployed Web Applications](../debugger/debugging-deployed-web-applications.md).  
  
 To debug a [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] application:  
  
- You must have required permissions. For more information, see [System Requirements](../debugger/aspnet-debugging-system-requirements.md).  
  
- [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] debugging must be enabled in **Project Properties**.  
  
- The configuration file of your application (Web.config) must be set to debug mode. Debug mode causes [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] to generate symbols for dynamically generated files and enables the debugger to attach to the [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] application. [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] sets this automatically when you start to debug, if you created your project from the Web projects template.  
  
- For more information, see [How to: Enable Debugging for ASP.NET Applications](../debugger/how-to-enable-debugging-for-aspnet-applications.md).  
  
### To debug a Web application during development  
  
1. On the **Debug** menu, click **Start** to begin debugging the Web application.  
  
     [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] builds the Web application project, deploys the application if necessary, starts the ASP.NET Development Server if you are debugging locally, and attaches to the [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] worker process.  
  
2. Use the Debugger to set and clear breakpoints, step, and perform other debugging operations, as you would for any application.  
  
     For more information, see [Debugger Basics](../debugger/debugger-basics.md).  
  
3. On the **Debug** menu, click **Stop Debugging** to end the debugging session, or, on the **File** menu in Internet Explorer, click **Close**.  
  
## See Also  
 [Debugging Web Applications and Script](../debugger/debugging-web-applications-and-script.md)   
 [Debugging ASP.NET and AJAX Applications](../debugger/debugging-aspnet-and-ajax-applications.md)   
 [How to: Enable Debugging for ASP.NET Applications](../debugger/how-to-enable-debugging-for-aspnet-applications.md)
