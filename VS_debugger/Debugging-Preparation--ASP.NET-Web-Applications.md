---
title: "Debugging Preparation: ASP.NET Web Applications"
ms.custom: na
ms.date: 10/10/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
  - VB
  - CSharp
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: bcfb1080-98d1-42f9-96af-186fb14f232a
caps.latest.revision: 35
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
# Debugging Preparation: ASP.NET Web Applications
The ASP.NETWeb site template creates a Web Form application. When you create a Web site using this template, Visual Studio creates the default settings for debugging. In the **Project Properties** dialog box, you can specify whether you want the Web page to be a startup page. When you start debugging an ASP.NETWeb Site with these default settings, Visual Studio starts Internet Explorer and attaches the debugger to the ASP.NET worker process (aspnet_wp.exe or w3wp.exe). For more information, see [System Requirements](../VS_debugger/ASP.NET-Debugging--System-Requirements.md).  
  
### To create a Web Forms application  
  
1.  On the **File** menu, choose **New Web Site**.  
  
2.  In the **New Web Site** dialog box, select ASP.NET**Web Site**.  
  
3.  Click **OK**.  
  
### To debug your Web form  
  
1.  Set one or more breakpoints in your functions and event handlers.  
  
     For more information, see [Breakpoints and Tracepoints](assetId:///fe4eedc1-71aa-4928-962f-0912c334d583).  
  
2.  When a breakpoint is hit, step through code inside the function. Observe the execution of your code until you isolate the problem.  
  
     For more information, see [Stepping](assetId:///8791dac9-64d1-4bb9-b59e-8d59af1833f9) and [Debugging Web Applications and Script](../VS_debugger/Debugging-Web-Applications-and-Script.md).  
  
## Changing Default Configurations  
 If you want to change the default debug and release configurations created by Visual Studio, you can do so. For more information, see [How to: Set Debug and Release Configurations](../VS_debugger/How-to--Set-Debug-and-Release-Configurations.md).  
  
#### To change the default debug configuration  
  
1.  In **Solution Explorer**, right-click the Web site, and select **Property Pages** to open the **Property Pages** dialog box.  
  
2.  Click **Start Options**.  
  
3.  Set **Start Action** to the Web page that should be displayed first.  
  
4.  Under **Debuggers**, make sure **ASP.NET debugging** is selected.  
  
     For more information, see [Property Pages Settings for Web Projects](../VS_debugger/Property-Pages-Settings-for-Web-Projects.md).  
  
## See Also  
 [Debugger Settings and Preparation](../VS_debugger/Debugger-Settings-and-Preparation.md)   
 [Debugger Basics](../VS_debugger/Debugger-Basics.md)   
 [Debugger Security](../VS_debugger/Debugger-Security.md)   
 [Debugging Managed Code](../VS_debugger/Debugging-Managed-Code.md)