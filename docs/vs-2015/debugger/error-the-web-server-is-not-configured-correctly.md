---
title: "Error: The web server is not configured correctly | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
f1_keywords: 
  - "vs.debug.remote.projnotconfigured"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugger, Web application errors"
ms.assetid: 875ba87f-c372-4126-8fe3-e33931cf26c0
caps.latest.revision: 25
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Error: The web server is not configured correctly
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Possible causes of this error include:  
  
- Trying to debug a .NET Web application that was copied to a different machine, manually renamed, or moved.  
  
- Not having enough IIS connections. For more information about deploying a web site to IIS, see [Create a Web Site](https://docs.microsoft.com/iis/get-started/getting-started-with-iis/create-a-web-site).  
  
- If you are trying to debug an ASP.NET application, please see [Publishing to IIS](https://docs.asp.net/en/latest/publishing/iis.html) for instructions on deploying to a remote computer running IIS 8 or higher, or [Remote Debugging ASP.NET on a Remote IIS 7.5 Computer](../debugger/remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md) for instructions on deploying to a remote computer running IIS 7.5.  
  
## See Also  
 [Debugging Web Applications: Errors and Troubleshooting](../debugger/debugging-web-applications-errors-and-troubleshooting.md)
