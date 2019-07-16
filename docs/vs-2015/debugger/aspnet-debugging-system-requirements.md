---
title: "ASP.NET Debugging: System Requirements | Microsoft Docs"
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
  - "debugging ASP.NET Web applications, system requirements"
  - "debugging ASP.NET Web applications, security requirements"
ms.assetid: 7810b9b2-debf-4271-8fc7-1df031123255
caps.latest.revision: 41
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# ASP.NET Debugging: System Requirements
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This topic describes the software and security requirements for [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] debugging scenarios:  
  
- Local debugging, in which [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] and the Web application run on the same computer. There are two versions of this scenario:  
  
  - The [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] code resides on the file system.  

  - The [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] code resides in an IIS Web site.  
  
- Remote debugging, in which [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] runs on a client computer and debugs a Web application that is running on a remote server computer.  
  
## Security Requirements  
 For remote debugging, local and remote computers must be on a domain setup or a workgroup setup.  
  
 To debug the [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] worker process you must have permission to debug that process. By default, [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] applications run as the **ASPNET** user. If the worker process is running as **ASPNET**, or as **NETWORK SERVICE**, you must have Administrator privileges to debug it.  
  
 The name of the [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] worker process varies by debugging scenario and by version of IIS. For more information, see [How to: Find the Name of the ASP.NET Process](../debugger/how-to-find-the-name-of-the-aspnet-process.md).  
  
 You can change the user account that the [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] worker process runs under by editing the machine.config file on the server that is running IIS. The best way to do this is to use the **Internet Information Services (IIS) Manager**. For more information, see [How to: Run the Worker Process Under a User Account](../debugger/how-to-run-the-worker-process-under-a-user-account.md).  
  
 If you change the [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] worker process to run under your own user account, you do not have to be an Administrator on the server that is running IIS.  
  
> [!CAUTION]
> Before you change the [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] worker process to run under a different account, consider the possible consequences if the [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] worker process should be hacked while running under that account. The ASPNET and NETWORK SERVICE user accounts run with minimal permissions, reducing the possible damage if the process is hacked. If you must change the [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] worker process to run under an account that has greater permissions, the potential damage is greater.  
  
## See Also  
 [Debugging ASP.NET and AJAX Applications](../debugger/debugging-aspnet-and-ajax-applications.md)   
 [How to: Run the Worker Process Under a User Account](../debugger/how-to-run-the-worker-process-under-a-user-account.md)
