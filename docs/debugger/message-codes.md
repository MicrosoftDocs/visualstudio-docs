---
title: "Message Codes"
description: Learn the meanings of the message codes shown on each message line of Messages View.
ms.date: 02/05/2024
ms.topic: "conceptual"
helpviewer_keywords:
  - "message codes"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Message codes

Each message line shown in [Messages view](/previous-versions/visualstudio/visual-studio-2017/debugger/messages-view) contains a 'P,' 'S,' 's,' or 'R' code. These codes have the following meanings:

|Code|Meaning|
|----------|-------------|
|P|The message was posted to the queue with the **PostMessage** function. No information is available concerning the ultimate disposition of the message.|
|S|The message was sent with the **SendMessage** function. This means that the sender doesn't regain control until the receiver processes and returns the message. The receiver can, therefore, pass a return value back to the sender.|
|s|The message was sent, but security prevents access to the return value.|
|R|Each 'S' line has a corresponding 'R' (return) line that lists the message return value. Sometimes message calls are nested, which means that one message handler sends another message.|