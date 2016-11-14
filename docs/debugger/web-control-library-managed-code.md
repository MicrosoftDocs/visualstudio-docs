---
title: "Web Control Library (Managed Code) | Microsoft Docs"
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
  - "debugging DLLs"
  - "debugging [Visual Studio], Web control libraries"
ms.assetid: 2413883f-9e88-406d-b874-0ed743b75d40
caps.latest.revision: 26
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
# Web Control Library (Managed Code)
The Web Control Library project template creates a DLL. Because the class library is a DLL, you cannot run it directly. You must create a [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] page that embeds the control. For more information, see [Web Control Library Template](http://msdn.microsoft.com/en-us/00666b07-71d2-4ace-a13c-cc130a3ce372).  
  
### To debug a Web Control Library (Method 1)  
  
1.  Open an existing Web Control Library project, or create a new one.  
  
2.  Create a [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] page that embeds the control.  
  
3.  In the Web site that is hosting the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] test harness, create a subdirectory called `/Code`.  
  
4.  Copy the source code for the control into the `/Code` subdirectory.  
  
5.  Open the source code in the `/Code` subdirectory and set breakpoints.  
  
6.  Open a browser window with a URL that points to the test harness. A breakpoint in the control will be hit, and you can start debugging.  
  
### To debug a Web Control Library (Method 2)  
  
1.  Create the host application project and the Web control project in the same solution.  
  
2.  In **Solution Explorer**, right-click the host application and choose **Add Reference**.  
  
3.  Add a reference to the web control project.  
  
## See Also  
 [ASP.NET Web Applications](../debugger/debugging-preparation-aspnet-web-applications.md)