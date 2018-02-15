---
title: "SDI Server Applications | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords: 
  - "SDI server applications"
  - "SDI server applications, debugging"
ms.assetid: 09713718-1376-4753-b119-26f36639693e
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# SDI Server Applications
If you are debugging an SDI server application, you must specify `/Embedding` or `/Automation` in the **Command line arguments** property in the *Project* Property Pages dialog box for C/C++, C#, or Visual Basic projects.  
  
 With these command line arguments, the debugger can launch the server application as though it were launched from a container. Starting the container from Program Manager or File Manager will then cause the container to use the instance of the server started in the debugger.  
  
## Finding the Command Line Arguments Property  
 To access the *Project* Property Pages dialog box, right-click your project in Solution Explorer, and then choose Properties from the shortcut menu. To find the Command line arguments property, expand the Configuration Properties category and click the Debugging page.  
  
## See Also  
 [COM and ActiveX Debugging](../debugger/com-and-activex-debugging.md)   
 [How to: Debug COM Servers](../debugger/how-to-debug-com-servers.md)