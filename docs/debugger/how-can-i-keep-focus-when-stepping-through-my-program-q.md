---
title: "Keep focus when stepping through my app | Microsoft Docs"
ms.custom: "seodec18"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.debug.stepping"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "debugging [C++], stepping"
  - "focus, keeping"
  - "stepping, focus"
  - "windows, troubleshooting activation"
ms.assetid: 11a30580-3a1a-4be8-a241-0abdc758302e
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# How Can I Keep Focus When Stepping Through My App?
## Description
 My program has a window-activation problem. Stepping through the program with the debugger interferes with my ability to reproduce the problem because my program keeps losing focus. Is there any way to avoid this?

## Solution
 If you have a second computer, use remote debugging. You can operate your program on the remote computer while you run the debugger on the host. For more information, see [How to: Select a Remote Computer](/previous-versions/visualstudio/visual-studio-2010/w8wtw2f3(v=vs.100)).

## See also
- [Debugging Native Code FAQs](../debugger/debugging-native-code-faqs.md)
- [Attach to Running Processes](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md)
- [Debugging Native Code](../debugger/debugging-native-code.md)