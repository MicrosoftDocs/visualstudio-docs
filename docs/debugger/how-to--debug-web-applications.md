---
title: "How to: Debug Web Applications"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
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
caps.latest.revision: 37
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
# How to: Debug Web Applications
[!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] is the primary technology for developing Web applications in [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)]. The [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] debugger provides powerful tools for debugging [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] Web applications locally or on a remote server. This topic describes how to debug a [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] project during development. For information about how to debug a [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] Web application already deployed on a production server, see [Debugging Deployed Web Applications](../debugger/debugging-deployed-web-applications.md).  
  
 To debug a [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] application:  
  
-   You must have required permissions. For more information, see [System Requirements](../debugger/asp.net-debugging--system-requirements.md).  
  
-   [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] debugging must be enabled in **Project Properties**.  
  
-   The configuration file of your application (Web.config) must be set to debug mode. Debug mode causes [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] to generate symbols for dynamically generated files and enables the debugger to attach to the [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] application. [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] sets this automatically when you start to debug, if you created your project from the Web projects template.  
  
-   For more information, see [How to: Enable Debugging for ASP.NET Applications](../debugger/how-to--enable-debugging-for-asp.net-applications.md).  
  
### To debug a Web application during development  
  
1.  On the **Debug** menu, click **Start** to begin debugging the Web application.  
  
     [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] builds the Web application project, deploys the application if necessary, starts the ASP.NET Development Server if you are debugging locally, and attaches to the [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] worker process.  
  
2.  Use the Debugger to set and clear breakpoints, step, and perform other debugging operations, as you would for any application.  
  
     For more information, see [Debugger Basics](../debugger/debugger-basics.md).  
  
3.  On the **Debug** menu, click **Stop Debugging** to end the debugging session, or, on the **File** menu in Internet Explorer, click **Close**.  
  
## See Also  
 [Debugging Web Applications and Script](../debugger/debugging-web-applications-and-script.md)   
 [Debugging ASP.NET and AJAX Applications](../debugger/debugging-asp.net-and-ajax-applications.md)   
 [How to: Enable Debugging for ASP.NET Applications](../debugger/how-to--enable-debugging-for-asp.net-applications.md)