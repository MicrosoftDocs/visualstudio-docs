---
title: "How Can I Use Debugger Windows While Debugging a Foreground Program?"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
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
caps.latest.revision: 16
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
# How Can I Use Debugger Windows While Debugging a Foreground Program?
## Problem Description  
 I am trying to debug a screen-painting problem. To observe this problem, I have to keep my program in the foreground, which means I do not have access to the debugging windows. What can I do?  
  
## Solution  
 If you have a second computer, you can use remote debugging. With a two-computer setup, you can watch the screen painting on the remote computer while you operate the debugger on the host. For more information on remote debugging, see [Setting Up Remote Debugging](../Topic/Set%20Up%20the%20Remote%20Tools%20on%20the%20Device.md).  
  
## See Also  
 [Debugging Native Code FAQs](../debugger/debugging-native-code-faqs.md)   
 [Debugging Native Code](../debugger/debugging-native-code.md)