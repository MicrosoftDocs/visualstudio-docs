---
title: "Use debugger windows while debugging a foreground app | Microsoft Docs"
ms.custom: "seodec18"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.debug.background"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "foreground program debugging"
  - "remote debugging, debugging foreground programs"
  - "debugging [Visual Studio], while observing foreground programs"
  - "focus, debugging while observing foreground programs"
  - "debugging [Visual Studio], foreground programs"
ms.assetid: 9e67a308-1c81-42ab-966b-7fc3c1d2bf7a
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# How Can I Use Debugger Windows While Debugging a Foreground Program?
## Problem Description
 I am trying to debug a screen-painting problem. To observe this problem, I have to keep my program in the foreground, which means I do not have access to the debugging windows. What can I do?

## Solution
 If you have a second computer, you can use remote debugging. With a two-computer setup, you can watch the screen painting on the remote computer while you operate the debugger on the host. For more information on remote debugging, see [Remote Debugging](../debugger/remote-debugging.md).

## See also
- [Debugging Native Code FAQs](../debugger/debugging-native-code-faqs.md)
- [Debugging Native Code](../debugger/debugging-native-code.md)