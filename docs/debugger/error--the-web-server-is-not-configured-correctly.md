---
title: "Error: The web server is not configured correctly"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
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
caps.latest.revision: 22
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Error: The web server is not configured correctly
Possible causes of this error include:  
  
-   Trying to debug a .NET Web application that was copied to a different machine, manually renamed, or moved.  
  
-   Not having enough IIS connections. For more information about deploying a web site to IIS, see [Create a Web Site](http://www.iis.net/learn/get-started/getting-started-with-iis/create-a-web-site).  
  
-   If you are trying to debug an ASP.NET application, please see [Publishing to IIS](https://docs.asp.net/en/latest/publishing/iis.html) for instructions on deploying to a remote computer running IIS 8 or higher, or [Remote Debugging ASP.NET on a Remote IIS 7.5 Computer](../debugger/remote-debugging-asp.net-on-a-remote-iis-7.5-computer.md) for instructions on deploying to a remote computer running IIS 7.5.  
  
## See Also  
 [Debugging Web Applications: Errors and Troubleshooting](../debugger/debugging-web-applications--errors-and-troubleshooting.md)