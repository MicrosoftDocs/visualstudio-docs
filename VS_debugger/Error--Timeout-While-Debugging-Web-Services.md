---
title: "Error: Timeout While Debugging Web Services"
ms.custom: na
ms.date: 10/03/2016
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
ms.assetid: 4b7df112-788a-4429-9a0c-4c6dac4fb609
caps.latest.revision: 8
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
# Error: Timeout While Debugging Web Services
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
 [Debugging Web Applications: Errors and Troubleshooting](../VS_debugger/Debugging-Web-Applications--Errors-and-Troubleshooting.md)