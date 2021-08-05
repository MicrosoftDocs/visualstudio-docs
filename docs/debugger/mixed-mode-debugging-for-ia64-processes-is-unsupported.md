---
title: "Mixed mode debugging for IA64 processes is unsupported"
description: Visual Studio does not support mixed-mode debugging of managed and native code in IA64 (Itanium) processes. See this article for workarounds.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.debug.error.interop_unsupported_ia64"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
ms.assetid: 20bc1e38-049b-4388-87c4-936815d85b46
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Mixed mode debugging for IA64 processes is unsupported.
Visual Studio does not support mixed-mode debugging of managed and native code in IA64 processes. This means that you cannot step from managed code to native code, or from native code to managed code, while debugging.

### Workarounds

- Debug your managed and native code in separate debugging sessions.

     -or-

     Debug your mixed code as a 32-bit process, as described in the following procedures.

### To Change the Platform to 32-bit (Visual Basic or C#)

1. In **Solution Explorer**, right-click on your project, then click **Properties** in the shortcut menu.

2. In the property pages, click the **Compile** or **Debug** tab.

3. Click **Platform** and select x86 from the list of platforms.

     By default, the Visual Basic and C# compilers default produce code to run on any CPU. On a 64-bit computer, these binaries run as 64-bit processes. To run on a 32-bit process, you must choose **Win32**, not **AnyCPU**.

### To Change the Platform to 32-bit (C/C++)

1. In **Solution Explorer**, right-click on your project, then click **Properties** in the shortcut menu.

2. In the Property Pages, click **Platform** and select Win32 from the list of platforms,

## See also
- [Debug 64-Bit Applications](../debugger/debug-64-bit-applications.md)