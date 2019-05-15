---
title: "Debugging Preparation: ASP.NET Web Applications | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "debugging ASP.NET Web applications"
  - "debugging [Visual Studio], Web applications"
ms.assetid: bcfb1080-98d1-42f9-96af-186fb14f232a
caps.latest.revision: 38
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Debugging Preparation: ASP.NET Web Applications
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The [!INCLUDE[vstecasp](../includes/vstecasp-md.md)]Web site template creates a Web Form application. When you create a Web site using this template, [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] creates the default settings for debugging. In the **Project Properties** dialog box, you can specify whether you want the Web page to be a startup page. When you start debugging an [!INCLUDE[vstecasp](../includes/vstecasp-md.md)]Web Site with these default settings, [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] starts Internet Explorer and attaches the debugger to the [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] worker process (aspnet_wp.exe or w3wp.exe). For more information, see [System Requirements](../debugger/aspnet-debugging-system-requirements.md).  
  
### To create a Web Forms application  
  
1. On the **File** menu, choose **New Web Site**.  
  
2. In the **New Web Site** dialog box, select [!INCLUDE[vstecasp](../includes/vstecasp-md.md)]**Web Site**.  
  
3. Click **OK**.  
  
### To debug your Web form  
  
1. Set one or more breakpoints in your functions and event handlers.  
  
     For more information, see [Breakpoints and Tracepoints](https://msdn.microsoft.com/fe4eedc1-71aa-4928-962f-0912c334d583).  
  
2. When a breakpoint is hit, step through code inside the function. Observe the execution of your code until you isolate the problem.  
  
     For more information, see [Stepping](https://msdn.microsoft.com/8791dac9-64d1-4bb9-b59e-8d59af1833f9) and [Debugging Web Applications and Script](../debugger/debugging-web-applications-and-script.md).  
  
## Changing Default Configurations  
 If you want to change the default debug and release configurations created by [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], you can do so. For more information, see [How to: Set Debug and Release Configurations](../debugger/how-to-set-debug-and-release-configurations.md).  
  
#### To change the default debug configuration  
  
1. In **Solution Explorer**, right-click the Web site, and select **Property Pages** to open the **Property Pages** dialog box.  
  
2. Click **Start Options**.  
  
3. Set **Start Action** to the Web page that should be displayed first.  
  
4. Under **Debuggers**, make sure **ASP.NET debugging** is selected.  
  
     For more information, see [Property Pages Settings for Web Projects](../debugger/property-pages-settings-for-web-projects.md).  
  
## See Also  
 [Debugger Settings and Preparation](../debugger/debugger-settings-and-preparation.md)   
 [Debugger Basics](../debugger/debugger-basics.md)   
 [Debugger Security](../debugger/debugger-security.md)   
 [Debugging Managed Code](../debugger/debugging-managed-code.md)
