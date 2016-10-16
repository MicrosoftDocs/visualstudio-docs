---
title: "Error: Site Uses IP Address"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.debug.error.webdbg_siteusesipaddress"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugger, Web application errors"
ms.assetid: b2b8ddc8-746d-46e3-87a6-b956b1ee048d
caps.latest.revision: 8
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
# Error: Site Uses IP Address
This error occurs when the debugger tries to auto-attach to a Web application that is using an IP address. This occurs if you change **Web site identification** to **use specific IP address** in IIS.  
  
 For auto-attach to work, you need to create the project with the specific IP address rather than just the machine name. Otherwise, the debugger will change the machine name to localhost, which will cause a failure to send the debug verb to IIS.  
  
### To correct this error  
  
1.  Use manual attach instead (from the Debug menu, choose **Attach to Process**).  
  
     —or—  
  
2.  Change the **IIS Web site identification** setting.  
  
## See Also  
 [Debugging Web Applications: Errors and Troubleshooting](../debugger/debugging-web-applications--errors-and-troubleshooting.md)