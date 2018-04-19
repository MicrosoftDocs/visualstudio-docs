---
title: "DebugBreak and __debugbreak | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "DebugBreak"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "C++"
helpviewer_keywords: 
  - "debugging [C++], DebugBreak function"
  - "DebugBreak function"
  - "breakpoints, DebugBreak function"
ms.assetid: 9787c795-df94-4f48-bc8d-3bf899b67421
caps.latest.revision: 26
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# DebugBreak and __debugbreak
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The latest version of this topic can be found at [DebugBreak and __debugbreak](https://docs.microsoft.com/visualstudio/debugger/debugbreak-and-debugbreak).  
  
You can call the DebugBreak Win32 function or the [__debugbreak](../Topic/__debugbreak.md) intrinsic at any point in your code. `DebugBreak` and `__debugbreak` have the same effect as setting a breakpoint at that location.  
  
 Because `DebugBreak` is a call to a system function, system debug symbols must be installed to ensure the correct call stack information is displayed after breaking. Otherwise, the call stack information displayed by the debugger may be off by one frame. If you use `__debugbreak`, symbols are not required.  
  
## See Also  
 [Compiler Intrinsics](../Topic/Compiler%20Intrinsics.md)   
 [Debugger Security](../debugger/debugger-security.md)   
 [Debugging Native Code](../debugger/debugging-native-code.md)   
 [Specify Symbol (.pdb) and Source Files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md)



