---
title: "Message Codes | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "message codes"
ms.assetid: 9f91f4e2-c1f1-4349-9f11-2fbbf59654be
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Message Codes
Each message line shown in [Messages View](../debugger/messages-view.md) contains a 'P,' 'S,' 's,' or 'R' code. These codes have the following meanings:  
  
|Code|Meaning|  
|----------|-------------|  
|P|The message was posted to the queue with the **PostMessage** function. No information is available concerning the ultimate disposition of the message.|  
|S|The message was sent with the **SendMessage** function. This means that the sender doesn't regain control until the receiver processes and returns the message. The receiver can, therefore, pass a return value back to the sender.|  
|s|The message was sent, but security prevents access to the return value.|  
|R|Each 'S' line has a corresponding 'R' (return) line that lists the message return value. Sometimes message calls are nested, which means that one message handler sends another message.|