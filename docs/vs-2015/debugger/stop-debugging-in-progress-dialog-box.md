---
title: "Stop Debugging In Progress Dialog Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug.stopnow"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "JScript"
  - "SQL"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "Stop Debugging in Progress dialog box"
ms.assetid: ed7ef49d-e25f-4a4d-9396-9bc7b4143117
caps.latest.revision: 10
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Stop Debugging In Progress Dialog Box
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This dialog box appears when the debugger is trying to stop a debugging session, but stopping the session is going to take some time. Stopping a debugging session is normally very fast and this dialog box does not appear. Sometimes, however, it takes additional time to detach from all the processes being debugged. If stopping the session takes more than a few seconds (or if a detach error occurs), this dialog box appears. If this occurs frequently, it may be due to an internal problem and you may want to contact Product Support Services.  
  
 You can wait for the processes to detach and this dialog box to disappear, or use the **Stop Now** button to force immediate termination.  
  
 **Stop Now**  
 Click this button to end the debugging session immediately. Using **Stop Now**will terminate rather than detaching the processes being debugged. If you are debugging system processes, terminating those processes with **Stop Now** can have unexpected and undesired effects.  
  
## See Also  
 [Debugger Security](../debugger/debugger-security.md)   
 [Detaching Programs](https://msdn.microsoft.com/f2c756c2-8079-474b-94c2-01c19a141a01)
