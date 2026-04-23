---
title: "DebugBreak and __debugbreak"
description: Learn how to use the DebugBreak function and the __debugbreak intrinsic to cause your program to break, just as though a breakpoint were set. 
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "DebugBreak"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "debugging [C++], DebugBreak function"
  - "DebugBreak function"
  - "breakpoints, DebugBreak function"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# DebugBreak and __debugbreak

You can call the [DebugBreak](/windows/win32/api/debugapi/nf-debugapi-debugbreak) Win32 function or the [__debugbreak](/cpp/intrinsics/debugbreak) intrinsic at any point in your code. `DebugBreak` and `__debugbreak` have the same effect as setting a breakpoint at that location.

 Because `DebugBreak` is a call to a system function, system debug symbols must be installed to ensure the correct call stack information is displayed after breaking. Otherwise, the call stack information displayed by the debugger may be off by one frame. If you use `__debugbreak`, symbols are not required.

## Related content
- [Compiler Intrinsics](/cpp/intrinsics/compiler-intrinsics)
- [Debugger Security](../debugger/debugger-security.md)
- [Debugging Native Code](../debugger/debugging-native-code.md)
- [Specify Symbol (.pdb) and Source Files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md)
