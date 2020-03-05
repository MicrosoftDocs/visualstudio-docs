---
title: "How Can I Use Debugger Windows While Debugging a Foreground Program? | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug.background"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "C++"
helpviewer_keywords: 
  - "foreground program debugging"
  - "remote debugging, debugging foreground programs"
  - "debugging [Visual Studio], while observing foreground programs"
  - "focus, debugging while observing foreground programs"
  - "debugging [Visual Studio], foreground programs"
ms.assetid: 9e67a308-1c81-42ab-966b-7fc3c1d2bf7a
caps.latest.revision: 19
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How Can I Use Debugger Windows While Debugging a Foreground Program?
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Problem Description  
 I am trying to debug a screen-painting problem. To observe this problem, I have to keep my program in the foreground, which means I do not have access to the debugging windows. What can I do?  
  
## Solution  
 If you have a second computer, you can use remote debugging. With a two-computer setup, you can watch the screen painting on the remote computer while you operate the debugger on the host. For more information on remote debugging, see [Setting Up Remote Debugging](https://msdn.microsoft.com/library/90f45630-0d26-4698-8c1f-63f85a12db9c).  
  
## See Also  
 [Debugging Native Code FAQs](../debugger/debugging-native-code-faqs.md)   
 [Debugging Native Code](../debugger/debugging-native-code.md)
