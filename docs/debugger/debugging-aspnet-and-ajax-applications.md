---
title: "Debugging ASP.NET and AJAX Applications | Microsoft Docs"
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
  - "debugging, WCF"
  - "debugging ASP.NET Web applications"
  - "debugging [ASP.NET], about ASP.NET debugging"
  - "WCF, debugging"
ms.assetid: 9d531913-541b-47b8-864d-138021fca0c6
caps.latest.revision: 31
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
# Debugging ASP.NET and AJAX Applications
Debugging [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] Web applications is similar to debugging a Windows Form or any other Windows application because both kinds of applications involve controls and events. However, there are also basic differences between the two kinds of applications:  
  
-   Keeping track of state is more complex in a Web application.  
  
-   In a Windows application, the code to be debugged is mostly in one location; in a Web application, the code can be on the client and on the server. While [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] code is all on the server, there might also be JavaScript or [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] code on the client.  
  
## In This Section  
 [Preparing to Debug ASP.NET](../debugger/preparing-to-debug-aspnet.md)  
 Describes the steps that are required to enable debugging of [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] applications.  
  
 [Debugging Web Applications](../debugger/debugging-web-applications.md)  
 Discusses how to debug a [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] application, including AJAX-enabled script applications.  
  
## Related Sections  
 [Managing Exceptions with the Debugger](../debugger/managing-exceptions-with-the-debugger.md)  
 Explains why Just My Code must be enabled for debugging [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] exceptions.  
  
 [Debugging and Tracing Ajax Applications Overview](../Topic/Debugging%20and%20Tracing%20Ajax%20Applications%20Overview.md)  
 Discusses some techniques and tools that can help you debug your AJAX code.  
  
 [IntelliTrace](../debugger/intellitrace.md)  
 Debug your code faster by using IntelliTrace to record and review a history of your application's state without restarting the application as frequently. You can see information about events and calls that occur during the running of your application and start debugging from these points in time. Requires Visual Studio Ultimate.  
  
## See Also  
 [Debugger Security](../debugger/debugger-security.md)   
 [Debugging Web Applications and Script](../debugger/debugging-web-applications-and-script.md)   
 [Debugger Settings and Preparation](../debugger/debugger-settings-and-preparation.md)   
 [Debugger Basics](../debugger/debugger-basics.md)