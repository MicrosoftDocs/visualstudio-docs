---
title: "Prerequisites for Remote Debugging Web Applications | Microsoft Docs"
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
  - "debugging ASP.NET Web applications, remote servers"
  - "remote debugging, prerequisites"
  - "remote servers, debugging Web applications"
ms.assetid: 1cd777b5-6d20-4ca6-a0df-51653b118469
caps.latest.revision: 30
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Prerequisites for Remote Debugging Web Applications
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

With the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] debugger, you can debug a Web application transparently on the local computer or a remote server. This means that the debugger functions the same way and allows you to use the same features on either computer. For remote debugging to work correctly, however, there are some prerequisites.  
  
- [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] remote debugging components must be installed on the server you want to debug. For more information, see [Setting Up Remote Debugging](https://msdn.microsoft.com/library/90f45630-0d26-4698-8c1f-63f85a12db9c).  
  
- By default, the [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] worker process runs as an ASPNET user process. As a result, you must have Administrator privileges on the computer where [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] runs to debug it. The name of the [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] worker process varies by debug scenario and version of IIS. For more information, see [How to: Find the Name of the ASP.NET Process](../debugger/how-to-find-the-name-of-the-aspnet-process.md).  
  
## See Also  
 [Debugging ASP.NET and AJAX Applications](../debugger/debugging-aspnet-and-ajax-applications.md)   
 [System Requirements](../debugger/aspnet-debugging-system-requirements.md)
