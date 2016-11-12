---
title: "Error: Windows file sharing has been configured... | Microsoft Docs"
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
  - "vs.debug.error.remote_credentials_prohibited"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: c45a1b74-61ec-4c64-9e2c-13051a4f50a5
caps.latest.revision: 8
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
# Error: Windows file sharing has been configured...
Windows file sharing has been configured so that you will connect to the remote computer using a different user name. This is incompatible with remote debugging  
  
 The current file sharing configuration is set up to connect to the remote computer using a different user name. Remote debugging is not possible in this scenario.  
  
 To correct this error, log onto the computer using the other account name, or change file sharing to use the account name you are debugging under.  
  
 If you want to connect to the remote computer using this user name, you must first disconnect from the remote computer.  
  
### To correct this error  
  
1.  Log onto your local machine, the machine you are debugging from, using the other account name.  
  
     —or—  
  
     . Disconnect from the remote computer, and then reconfigure file sharing to connect to the other machine using your account name:  
  
    1.  On the **Start** menu, point to **Accessories**, and then click **Command Prompt**.  
  
    2.  At the Windows command prompt, type:  
  
         `net use /delete computer_name`  
  
    3.  Change your file-sharing settings using any of the methods documented in Windows help.