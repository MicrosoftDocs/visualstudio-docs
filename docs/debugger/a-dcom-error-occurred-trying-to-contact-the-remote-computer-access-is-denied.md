---
title: "A DCOM error occurred trying to contact the remote computer. Access is denied. | Microsoft Docs"
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
  - "vs.debug.remote.dcom_access_denied"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "JScript"
helpviewer_keywords: 
  - "remote debugging, DCOM error"
  - "remote DCOM access denied error"
  - "DCOM, access errors"
ms.assetid: 9d7dfc1b-9fe0-4f54-9c50-9c0e0f8358c5
caps.latest.revision: 27
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# A DCOM error occurred trying to contact the remote computer. Access is denied.
Remote debugging uses DCOM to communicate between the local and remote computers in the following situations:  
  
-   The debugger is set to **Native Compatibility Mode** or **Managed Compatibility Mode** is checked in the **Tools / Options / Debugging** page  
  
-   You are debugging managed C++ (C++/CLI) code.  
  
-   In Visual Studio 2013, when **Enable native Edit and Continue** is checked in the **Tools / Options / Debugging** page  
  
-   Some third party debugging scenarios  
  
 This error occurs when the Visual Studio process cannot authenticate itself (or the supplied credentials were deemed insufficient) to the remote debugger process over DCOM. One or more of the following workarounds might resolve the issue:  
  
-   Turn off  **Native Compatibility Mode** and **Managed Compatibility Mode**.  
  
-   In Visual Studio 2013, turn off **Enable native Edit and Continue**.  
  
-   Reboot both computers.  
  
-   If remote debugging requires entering credentials, check the option to save the credentials.  
  
## See Also  
 [Remote Debugging Errors and Troubleshooting](../debugger/remote-debugging-errors-and-troubleshooting.md)   
 [Remote Debugging](../debugger/remote-debugging.md)