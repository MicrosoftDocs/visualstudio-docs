---
title: "Debugging ASP.NET and AJAX Applications"
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
ms.assetid: 9d531913-541b-47b8-864d-138021fca0c6
caps.latest.revision: 31
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
# Debugging ASP.NET and AJAX Applications
Debugging ASP.NET Web applications is similar to debugging a Windows Form or any other Windows application because both kinds of applications involve controls and events. However, there are also basic differences between the two kinds of applications:  
  
-   Keeping track of state is more complex in a Web application.  
  
-   In a Windows application, the code to be debugged is mostly in one location; in a Web application, the code can be on the client and on the server. While ASP.NET code is all on the server, there might also be JavaScript or Visual Basic code on the client.  
  
## In This Section  
 [Preparing to Debug ASP.NET](../VS_debugger/Preparing-to-Debug-ASP.NET.md)  
 Describes the steps that are required to enable debugging of ASP.NET applications.  
  
 [Debugging Web Applications](../VS_debugger/Debugging-Web-Applications.md)  
 Discusses how to debug a ASP.NET application, including AJAX-enabled script applications.  
  
## Related Sections  
 [Managing Exceptions with the Debugger](../VS_debugger/Managing-Exceptions-with-the-Debugger.md)  
 Explains why Just My Code must be enabled for debugging ASP.NET exceptions.  
  
 [Debugging and Tracing Ajax Applications Overview](../Topic/Debugging%20and%20Tracing%20Ajax%20Applications%20Overview.md)  
 Discusses some techniques and tools that can help you debug your AJAX code.  
  
 [IntelliTrace](../VS_debugger/IntelliTrace.md)  
 Debug your code faster by using IntelliTrace to record and review a history of your application's state without restarting the application as frequently. You can see information about events and calls that occur during the running of your application and start debugging from these points in time. Requires Visual Studio Ultimate.  
  
## See Also  
 [Debugger Security](../VS_debugger/Debugger-Security.md)   
 [Debugging Web Applications and Script](../VS_debugger/Debugging-Web-Applications-and-Script.md)   
 [Debugger Settings and Preparation](../VS_debugger/Debugger-Settings-and-Preparation.md)   
 [Debugger Basics](../VS_debugger/Debugger-Basics.md)