---
title: "Get back to the function that called MFC if halted | Microsoft Docs"
ms.custom: "seodec18"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.debug.mfc"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "functions [C++], debugging"
  - "function calls, returning to calling function"
  - "debugging [MFC], returning to calling function"
  - "debugging [MFC], functions"
  - "Break command"
  - "programs, halting"
  - "functions [debugger]"
ms.assetid: d254a5a9-afbd-4923-9d7a-7422d824cabf
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Get Back to the Function that Called MFC If Halted

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Reset settings](../ide/environment-settings.md#reset-settings).

If you used the **Break** command on the **Debug** menu to halt the program and ended up in MFC, and you are sure the problem is in your code, you can use the Call Stack window to navigate back to your function. For more information, see [How to: Use the Call Stack Window](../debugger/how-to-use-the-call-stack-window.md).

Sometimes your code may break in the message pump. In that case, there is no user code on the call stack. To avoid this problem, you can use breakpoints (possibly with conditions and hit counts) instead of the **Break** command. For more information, see [Breakpoints and Tracepoints](https://msdn.microsoft.com/library/fe4eedc1-71aa-4928-962f-0912c334d583).

## Navigate to the function from which MFC was called

- Use the **Call Stack** window.

## See also

- [Debugging Native Code FAQs](../debugger/debugging-native-code-faqs.md)
- [Debugging Native Code](../debugger/debugging-native-code.md)