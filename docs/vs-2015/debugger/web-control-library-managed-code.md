---
title: "Web Control Library (Managed Code) | Microsoft Docs"
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
  - "debugging DLLs"
  - "debugging [Visual Studio], Web control libraries"
ms.assetid: 2413883f-9e88-406d-b874-0ed743b75d40
caps.latest.revision: 29
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Web Control Library (Managed Code)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Web Control Library project template creates a DLL. Because the class library is a DLL, you cannot run it directly. You must create a [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] page that embeds the control. For more information, see [Web Control Library Template](https://msdn.microsoft.com/00666b07-71d2-4ace-a13c-cc130a3ce372).  
  
### To debug a Web Control Library (Method 1)  
  
1. Open an existing Web Control Library project, or create a new one.  
  
2. Create a [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] page that embeds the control.  
  
3. In the Web site that is hosting the [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] test harness, create a subdirectory called `/Code`.  
  
4. Copy the source code for the control into the `/Code` subdirectory.  
  
5. Open the source code in the `/Code` subdirectory and set breakpoints.  
  
6. Open a browser window with a URL that points to the test harness. A breakpoint in the control will be hit, and you can start debugging.  
  
### To debug a Web Control Library (Method 2)  
  
1. Create the host application project and the Web control project in the same solution.  
  
2. In **Solution Explorer**, right-click the host application and choose **Add Reference**.  
  
3. Add a reference to the web control project.  
  
## See Also  
 [ASP.NET Web Applications](../debugger/debugging-preparation-aspnet-web-applications.md)
