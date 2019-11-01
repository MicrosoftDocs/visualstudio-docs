---
title: "Error: Unable to Automatically Step Into the Server | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
f1_keywords: 
  - "vs.debug.error.causality_no_server_response"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "remote debugging, notification error"
ms.assetid: 9a370ccc-d358-429c-b285-9b6c0649bc68
caps.latest.revision: 16
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Error: Unable to Automatically Step Into the Server
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The error reads:  
  
 Unable to Automatically Step Into the Server. The debugger was not notified before the remote procedure was executed  
  
 This error can occur when you are trying to step into a web service (see [Stepping Into an XML Web Service](https://msdn.microsoft.com/8e67de38-bf5f-41cc-a457-1b88ce63d764)). It can occur whenever [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] is not set up properly.  
  
 Possible causes are:  
  
- The web.config file for your [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] application does not set debug to "true" in (see [Debug Mode in ASP.NET Applications](../debugger/how-to-enable-debugging-for-aspnet-applications.md)).  
  
- A version of [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] was installed after Visual Studio was installed. [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] should be installed before Visual Studio. To fix this problem, use the Windows **Control Panel**, **Programs and Features** to repair your Visual Studio installation.  
  
## See Also  
 [Remote Debugging Errors and Troubleshooting](../debugger/remote-debugging-errors-and-troubleshooting.md)   
 [Remote Debugging](../debugger/remote-debugging.md)
