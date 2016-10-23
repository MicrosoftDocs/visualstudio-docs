---
title: "Prerequistes for Remote Debugging Web Applications"
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
ms.assetid: 1cd777b5-6d20-4ca6-a0df-51653b118469
caps.latest.revision: 27
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
# Prerequistes for Remote Debugging Web Applications
With the Visual Studio debugger, you can debug a Web application transparently on the local computer or a remote server. This means that the debugger functions the same way and allows you to use the same features on either computer. For remote debugging to work correctly, however, there are some prerequisites.  
  
-   Visual Studio remote debugging components must be installed on the server you want to debug. For more information, see [Setting Up Remote Debugging](../Topic/Set%20Up%20the%20Remote%20Tools%20on%20the%20Device.md).  
  
-   By default, the ASP.NET worker process runs as an ASPNET user process. As a result, you must have Administrator privileges on the computer where ASP.NET runs to debug it. The name of the ASP.NET worker process varies by debug scenario and version of IIS. For more information, see [How to: Find the Name of the ASP.NET Process](../VS_debugger/How-to--Find-the-Name-of-the-ASP.NET-Process.md).  
  
## See Also  
 [Debugging ASP.NET and AJAX Applications](../VS_debugger/Debugging-ASP.NET-and-AJAX-Applications.md)   
 [System Requirements](../VS_debugger/ASP.NET-Debugging--System-Requirements.md)