---
title: "Error: The Microsoft Visual Studio Remote Debugging Monitor on the remote computer does not have permission to connect to this computer | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.debug.error.access_denied_oncallback"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "remote debugging, Windows version error"
ms.assetid: ba08a59b-6dbc-4bbc-9c52-379d3bf5241f
caps.latest.revision: 21
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
# Error: The Microsoft Visual Studio Remote Debugging Monitor on the remote computer does not have permission to connect to this computer
This error occurs when the user who is trying to run the Visual Studio Remote Debugging Monitor (msvsmon) does not have an account on the local computer.  
  
### To fix this problem  
  
-   Add a user account to the Visual Studio debugger host computer, with the same name and password as the user account running msvsmon on the remote computer,  
  
     \- or -  
  
-   Run msvsmon as a user who has permission to call into the local computer. This means the user must be a domain user and an administrator on the msvsmon computer. You can specify the user account to run msvsmon in one of two ways:  
  
    -   Right-click the msvsmon icon and choose **Run As** on the shortcut menu  
  
     \- or -  
  
    -   At the Command Prompt, run `runas.exe`.  
  
## See Also  
 [Remote Debugging Across Domains](../Topic/Remote%20Debugging%20Across%20Domains.md)   
 [Remote Debugging Errors and Troubleshooting](../debugger/remote-debugging-errors-and-troubleshooting.md)   
 [Remote Debugging](../debugger/remote-debugging.md)