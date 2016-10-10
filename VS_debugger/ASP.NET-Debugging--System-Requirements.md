---
title: "ASP.NET Debugging: System Requirements"
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
ms.assetid: 7810b9b2-debf-4271-8fc7-1df031123255
caps.latest.revision: 38
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# ASP.NET Debugging: System Requirements
This topic describes the software and security requirements for ASP.NET debugging scenarios:  
  
-   Local debugging, in which Visual Studio and the Web application run on the same computer. There are two versions of this scenario:  
  
    -   The ASP.NET code resides on the file system.  
  
    -   The ASP.NET code resides in an IIS Web site.  
  
-   Remote debugging, in which Visual Studio runs on a client computer and debugs a Web application that is running on a remote server computer.  
  
## Security Requirements  
 For remote debugging, local and remote computers must be on a domain setup or a workgroup setup.  
  
 To debug the ASP.NET worker process you must have permission to debug that process. By default, ASP.NET applications run as the **ASPNET** user. If the worker process is running as **ASPNET**, or as **NETWORK SERVICE**, you must have Administrator privileges to debug it.  
  
 The name of the ASP.NET worker process varies by debugging scenario and by version of IIS. For more information, see [How to: Find the Name of the ASP.NET Process](../VS_debugger/How-to--Find-the-Name-of-the-ASP.NET-Process.md).  
  
 You can change the user account that the ASP.NET worker process runs under by editing the machine.config file on the server that is running IIS. The best way to do this is to use the **Internet Information Services (IIS) Manager**. For more information, see [How to: Run the Worker Process Under a User Account](../VS_debugger/How-to--Run-the-Worker-Process-Under-a-User-Account.md).  
  
 If you change the ASP.NET worker process to run under your own user account, you do not have to be an Administrator on the server that is running IIS.  
  
> [!CAUTION]
>  Before you change the ASP.NET worker process to run under a different account, consider the possible consequences if the ASP.NET worker process should be hacked while running under that account. The ASPNET and NETWORK SERVICE user accounts run with minimal permissions, reducing the possible damage if the process is hacked. If you must change the ASP.NET worker process to run under an account that has greater permissions, the potential damage is greater.  
  
## See Also  
 [Debugging ASP.NET and AJAX Applications](../VS_debugger/Debugging-ASP.NET-and-AJAX-Applications.md)   
 [How to: Run the Worker Process Under a User Account](../VS_debugger/How-to--Run-the-Worker-Process-Under-a-User-Account.md)