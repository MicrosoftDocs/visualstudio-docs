---
title: "Prerequistes for Remote Debugging Web Applications | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
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
caps.latest.revision: 27
author: "mikejo5000"
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
# Prerequistes for Remote Debugging Web Applications
With the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] debugger, you can debug a Web application transparently on the local computer or a remote server. This means that the debugger functions the same way and allows you to use the same features on either computer. For remote debugging to work correctly, however, there are some prerequisites.  
  
-   [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] remote debugging components must be installed on the server you want to debug. For more information, see [Setting Up Remote Debugging](../Topic/Set%20Up%20the%20Remote%20Tools%20on%20the%20Device.md).  
  
-   By default, the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] worker process runs as an ASPNET user process. As a result, you must have Administrator privileges on the computer where [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] runs to debug it. The name of the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] worker process varies by debug scenario and version of IIS. For more information, see [How to: Find the Name of the ASP.NET Process](../debugger/how-to-find-the-name-of-the-aspnet-process.md).  
  
## See Also  
 [Debugging ASP.NET and AJAX Applications](../debugger/debugging-aspnet-and-ajax-applications.md)   
 [System Requirements](../debugger/aspnet-debugging-system-requirements.md)