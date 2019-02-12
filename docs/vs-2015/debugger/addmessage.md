---
title: "AddMessage | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: 102a0404-a00c-4566-93f3-01bc8df63280
caps.latest.revision: 8
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# AddMessage
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Adds a custom message to the graphics diagnostics *HUD* (Head-Up Display).  
  
## Syntax  
  
```cpp  
void AddMessage(  
  wchar_t const * szMessage  
);  
```  
  
#### Parameters  
 `szMessage`  
 The message to be added to the HUD.  
  
## Remarks  
 The graphics diagnostics HUD is displayed in the upper-left corner of the app that's running under graphics diagnostics. It displays run-time information about the app and about graphics information capture, and messages that are added by calling this function.  
  
 To add a message to the HUD, you don't have to be actively capturing graphics information—that is, a message can be added through an instance of the `VsgDbg` class, but the [Init](../debugger/init.md) member function does not to be called first. Messages are only displayed in the HUD, they are not recorded in the graphics log file.
