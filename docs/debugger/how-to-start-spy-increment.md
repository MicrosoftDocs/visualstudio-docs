---
title: "How to: Start Spy++ | Microsoft Docs"
ms.custom: ""
ms.date: "11/12/2018"
ms.technology: "vs-ide-debug"
ms.topic: "conceptual"
helpviewer_keywords: 
  - "Spy++, starting"
ms.assetid: 1d36813a-dc2a-4fda-9b3d-a38928a62ced
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload: 
  - "multiple"
---
# How to: Start Spy++
You can start Spy++ either from Visual Studio or at a command prompt.  
  
 When you start Spy++, if a message is displayed to ask permission to make changes to the computer, select **Yes**.  
  
> [!NOTE]
>  You can run only one instance of Spy++. If you try to start a second instance, it just causes the currently running instance to get the focus.  
  
### Start Spy++ from Visual Studio  
  
On the **Tools** menu, select **Spy++**.  
  
Because Spy++ runs independently, after you start it you can close Visual Studio.  
  
> [!NOTE]
>  When you log messages with Spy++, it may cause the operating system to perform more slowly.  
  
### Start Spy++ at a command prompt  
  
1.  In a Command Prompt window, change directories to the folder that contains spyxx.exe. Typically, the path to this folder is ..\\*Visual Studio installation folder*\Common7\Tools\\.  
  
2.  Enter **spyxx.exe**. 
  
## See also  
 [Using Spy++](../debugger/using-spy-increment.md)   
 [Spy++ Views](../debugger/spy-increment-views.md)   
 [Spy++ Reference](../debugger/spy-increment-reference.md)