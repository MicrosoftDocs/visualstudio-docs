---
title: "How to: Start Spy++ | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "Spy++, starting"
ms.assetid: 1d36813a-dc2a-4fda-9b3d-a38928a62ced
caps.latest.revision: 11
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
# How to: Start Spy++
You can start Spy++ either from Visual Studio or at a command prompt.  
  
 When you start Spy++, if a message is displayed to ask permission to make changes to the computer, click **Yes**.  
  
> [!NOTE]
>  You can run only one instance of Spy++. If you try to run another instance, it just causes the currently running instance to get the focus.  
  
### To start Spy++ from Visual Studio  
  
-   On the **Tools** menu, click **Spy++**.  
  
     Because Spy++ runs independently, after you start it, you can close Visual Studio.  
  
    > [!NOTE]
    >  When you log messages with Spy++, it may cause the operating system to perform more slowly.  
  
### To start Spy++ at a command prompt  
  
1.  In a Command Prompt window, change directories to the folder that contains spyxx.exe. Typically, the path of this folder is ..\\*Visual Studio installation folder*\Common7\Tools\\.  
  
2.  Type **spyxx.exe** and then press ENTER.  
  
## See Also  
 [Using Spy++](../debugger/using-spy-increment.md)   
 [Spy++ Views](../debugger/spy-increment-views.md)   
 [Spy++ Reference](../debugger/spy-increment-reference.md)