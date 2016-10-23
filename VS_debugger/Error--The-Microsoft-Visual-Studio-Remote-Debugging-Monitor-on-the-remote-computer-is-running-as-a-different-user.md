---
title: "Error: The Microsoft Visual Studio Remote Debugging Monitor on the remote computer is running as a different user"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
  - JScript
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e5b18734-2daf-4c58-b5de-24ae1295703e
caps.latest.revision: 10
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Error: The Microsoft Visual Studio Remote Debugging Monitor on the remote computer is running as a different user
When trying to do remote debugging, you may get the following error message:  
  
 The Microsoft Visual Studio Remote Debugging Monitor on the remote computer is running as a different user.  
  
## Cause  
 This message occurs when you are debugging in No Authentication mode and the user who started msvsmon is not the user who is running Visual Studio.  
  
## Solution  
 The safest and best solution is to run the Remote Debugging Monitor (msvsmon.exe) under the same user account as Visual Studio. If you cannot do that, you can run Remote Debugging Monitor under the other account with the **Allow any user to debug** option selected in the Remote Debugging Monitor **Options** dialog box.  
  
> [!CAUTION]
>  Granting other users permission to connect allows the possibility of accidentally connecting to the wrong remote debugging session. Debugging in **No Authentication** mode is never secure and should be used with caution.  
  
 For more information, see [Start  the Remote Debugging Monitor](../Topic/Start%20%20the%20Remote%20Debugging%20Monitor.md).  
  
## See Also  
 [Remote Debugging Errors and Troubleshooting](../VS_debugger/Remote-Debugging-Errors-and-Troubleshooting.md)   
 [Remote Debugging](../VS_debugger/Remote-Debugging.md)