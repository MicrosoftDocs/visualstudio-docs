---
title: "Hosting Process (vshost.exe) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "vshost.exe"
  - "hosting process"
ms.assetid: c6b9e2be-f18d-4d75-ac52-56d55784734b
caps.latest.revision: 10
author: "kempb"
ms.author: "kempb"
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
# Hosting Process (vshost.exe)
The hosting process is a feature in Visual Studio that improves debugging performance, enables partial trust debugging, and enables design time expression evaluation. The hosting process files contain vshost in the file name and are placed in the output folder of your project. For more information, see [Debugging and the Hosting Process](../debugger/debugging-and-the-hosting-process.md).  
  
> [!NOTE]
>  Hosting process files (.vshost.exe) are for use by Visual Studio and should not be run directly or deployed with your application.  
  
## Improved Debugging Performance  
 The hosting process creates an application domain and associates the debugger with the application. Performing these tasks can introduce a noticeable delay between the time debugging is started and the time the application begins running. The hosting process helps increase performance by creating the application domain and associating the debugger in the background, and saving the application domain and debugger state between runs of the application. For more information on application domains, see [Application Domains](../Topic/Application%20Domains.md).  
  
## Partial Trust Debugging  
 An application can be specified as a partial trust application in the [Security page](../ide/reference/security-page-project-designer.md) of the **Project Designer**. Debugging a partial trust application requires special initialization of the application domain. This initialization is handled by the hosting process.  
  
## Design-Time Expression Evaluation  
 Design-time expression evaluation enables you to test code from the **Immediate** window without having to run the application. The hosting process executes this code during design time expression evaluation. For more information, see [Immediate Window](../ide/reference/immediate-window.md).  
  
## See Also  
 [Debugging and the Hosting Process](../debugger/debugging-and-the-hosting-process.md)   
 [How to: Disable the Hosting Process](../ide/how-to-disable-the-hosting-process.md)   
 [Immediate Window](../ide/reference/immediate-window.md)   
 [Application Domains](../Topic/Application%20Domains.md)