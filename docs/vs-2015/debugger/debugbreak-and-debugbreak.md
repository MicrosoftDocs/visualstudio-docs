---
title: "DebugBreak and __debugbreak | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
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
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# DebugBreak and __debugbreak
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can call the DebugBreak Win32 function or the [__debugbreak](https://msdn.microsoft.com/library/1d1e1c0c-891a-4613-ae4b-d790094ba830) intrinsic at any point in your code. `DebugBreak` and `__debugbreak` have the same effect as setting a breakpoint at that location.  
  
 Because `DebugBreak` is a call to a system function, system debug symbols must be installed to ensure the correct call stack information is displayed after breaking. Otherwise, the call stack information displayed by the debugger may be off by one frame. If you use `__debugbreak`, symbols are not required.  
  
## See Also  
 [Compiler Intrinsics](https://msdn.microsoft.com/library/48bb9929-7d78-4fd8-a092-ae3c9f971858)   
 [Debugger Security](../debugger/debugger-security.md)   
 [Debugging Native Code](../debugger/debugging-native-code.md)   
 [Specify Symbol (.pdb) and Source Files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md)
