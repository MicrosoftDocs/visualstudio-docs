---
title: "How Can I Find Out If My Pointers Corrupt a Memory Address? | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "C++"
helpviewer_keywords: 
  - "addresses, pointers corrupting memory address"
  - "memory, corruption"
  - "pointers, corrupting memory addresses"
  - "memory address corruption by pointers"
  - "debugging [C++], memory corruption"
  - "corrupted memory address"
ms.assetid: a147c939-4fb1-415c-8410-cf303781e9e8
caps.latest.revision: 22
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# How Can I Find Out If My Pointers Corrupt a Memory Address?
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The latest version of this topic can be found at [How Can I Find Out If My Pointers Corrupt a Memory Address?](https://docs.microsoft.com/visualstudio/debugger/how-can-i-find-out-if-my-pointers-corrupt-a-memory-address-q).  
  
Problem Description  
 I think that one of my pointers may be corrupting memory at address 0x00408000. How can I find out what is happening there?  
  
## Solution  
  
#### Check for heap corruption  
  
-   Most memory corruption is actually due to heap corruption. Try using the Global Flags Utility (gflags.exe) or pageheap.exe. See [http://support.microsoft.com/default.aspx?scid=kb;en-us;286470](http://support.microsoft.com/default.aspx?scid=kb;en-us;286470).  
  
#### To find where the memory address is modified  
  
1.  Set a data breakpoint at 0x00408000. See [Set a data change breakpoint (native C++ only)](../debugger/using-breakpoints#setting-a-breakpoint-with-a-memory-address-native-c-only).  
  
2.  When you hit the breakpoint, use the **Memory** window to view memory contents starting at 0x00408000. For more information, see [Memory Windows](../debugger/memory-windows.md).  
  
## See Also  
 [Debugging Native Code FAQs](../debugger/debugging-native-code-faqs.md)   
 [Debugging Native Code](../debugger/debugging-native-code.md)



