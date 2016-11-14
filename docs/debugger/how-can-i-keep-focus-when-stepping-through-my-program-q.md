---
title: "How Can I Keep Focus When Stepping Through My Program? | Microsoft Docs"
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
  - "vs.debug.stepping"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "C++"
helpviewer_keywords: 
  - "debugging [C++], stepping"
  - "focus, keeping"
  - "stepping, focus"
  - "windows, troubleshooting activation"
ms.assetid: 11a30580-3a1a-4be8-a241-0abdc758302e
caps.latest.revision: 18
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
# How Can I Keep Focus When Stepping Through My Program?
## Description  
 My program has a window-activation problem. Stepping through the program with the debugger interferes with my ability to reproduce the problem because my program keeps losing focus. Is there any way to avoid this?  
  
## Solution  
 If you have a second computer, use remote debugging. You can operate your program on the remote computer while you run the debugger on the host. For more information, see [How to: Select a Remote Computer](http://msdn.microsoft.com/en-us/4332ba8e-2f0b-4f62-b96a-e762b9f3c3ba).  
  
## See Also  
 [Debugging Native Code FAQs](../debugger/debugging-native-code-faqs.md)   
 [Attach to Running Processes](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md)   
 [Debugging Native Code](../debugger/debugging-native-code.md)