---
title: "Mixed code & missing info in Call Stack window"
description: In mixed-mode programs (native and managed) the debugger can't always show the complete call stack. Learn the possible discrepancies when native code calls managed code.
ms.date: "11/04/2016"
ms.topic: article
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "JScript"
  - "SQL"
helpviewer_keywords:
  - "managed code, stepping"
  - "Call Stack window, mixed-mode debugging"
  - "Call Stack window, troubleshooting"
  - "native frames"
  - "managed call stacks"
  - "mixed-mode debugging, call stack"
  - "stepping, out of managed code"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Mixed Code and Missing Information in the Call Stack Window

Because of differences between call stacks for managed and native code, the debugger cannot always show the complete call stack when the code types mix. When native code calls managed code, you may notice the following discrepancies in the **Call Stack** window:

- The native frame immediately above the managed code may be missing from the **Call Stack** window. For more information, see [How to: Step out of Managed Code when Native Frames are Missing from the Call Stack Window](how-to-use-the-call-stack-window.md).

- For mixed-mode applications launched outside the debugger, the **Call Stack** window may display only the managed code and none of the native frames will be visible.

  Both cases are fairly rare. In most native calls to managed code, call stacks appear correctly.

## Related content
- [How to: Use the Call Stack Window](../debugger/how-to-use-the-call-stack-window.md)
