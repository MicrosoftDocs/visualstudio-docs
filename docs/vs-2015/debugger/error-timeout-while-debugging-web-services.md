---
title: "Error: Timeout While Debugging Web Services | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugger, Web application errors"
  - "XML Web services, timeout while debugging"
ms.assetid: 4b7df112-788a-4429-9a0c-4c6dac4fb609
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Error: Timeout While Debugging Web Services
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

When you are stepping into an XML Web service from calling code, the call may sometimes time out, with the result being that you cannot continue debugging. You may see an error message such as this.  
  
```  
An unhandled exception of type 'System.Net.WebException' occurred in   
system.Web.services.dll  
Additional information: The operation has timed-out.  
```  
  
## Solution  
 To avoid this problem, set the timeout value for the call to the XML Web service to infinite, as shown in this example:  
  
```  
Service1 obj = new Service1();  
obj.TimeOut = -1; // infinite time out.  
```  
  
## See Also  
 [Debugging Web Applications: Errors and Troubleshooting](../debugger/debugging-web-applications-errors-and-troubleshooting.md)
