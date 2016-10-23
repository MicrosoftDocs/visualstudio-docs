---
title: "Error: Unable to Automatically Step Into the Server"
ms.custom: na
ms.date: 10/10/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
  - JScript
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
ms.assetid: 9a370ccc-d358-429c-b285-9b6c0649bc68
caps.latest.revision: 13
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
# Error: Unable to Automatically Step Into the Server
The error reads:  
  
 Unable to Automatically Step Into the Server. The debugger was not notified before the remote procedure was executed  
  
 This error can occur when you are trying to step into a web service (see [Stepping Into an XML Web Service](assetId:///8e67de38-bf5f-41cc-a457-1b88ce63d764)). It can occur whenever ASP.NET is not set up properly.  
  
 Possible causes are:  
  
-   The web.config file for your ASP.NET application does not set debug to "true" in (see [Debug Mode in ASP.NET Applications](../VS_debugger/How-to--Enable-Debugging-for-ASP.NET-Applications.md)).  
  
-   A version of ASP.NET was installed after Visual Studio was installed. ASP.NET should be installed before Visual Studio. To fix this problem, use the Windows **Control Panel**, **Programs and Features** to repair your Visual Studio installation.  
  
## See Also  
 [Remote Debugging Errors and Troubleshooting](../VS_debugger/Remote-Debugging-Errors-and-Troubleshooting.md)   
 [Remote Debugging](../VS_debugger/Remote-Debugging.md)