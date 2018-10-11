---
title: "ToggleHUD | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 7261e01d-3c72-46ce-9fb3-5f33b2ddb901
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# ToggleHUD
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Toggles the graphics diagnostics *HUD* (Head-Up Display) overlay on or off.  
  
## Syntax  
  
```cpp  
void ToggleHUD();  
```  
  
## Remarks  
 The graphics diagnostics HUD is displayed in the upper-left corner of the app that's running under graphics diagnostics. It displays run-time information about the app and about graphics information capture, and messages that are added by calling the [AddMessage](../debugger/addmessage.md) member function.  
  
 To toggle the HUD, you don't have to be actively capturing graphics information—that is, it can be toggled through an instance of the `VsgDbg` class, but the [Init](../debugger/init.md) member function doesn't have to be called first.



