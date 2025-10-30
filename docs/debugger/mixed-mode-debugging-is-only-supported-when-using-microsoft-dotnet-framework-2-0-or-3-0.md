---
title: "Mixed Mode Debugging Is Only Supported when Using Microsoft .NET Framework 2.0 or 3.0"
description: Versions of the Microsoft .NET Framework earlier than 2.0 do not provide support for mixed-mode debugging of 64-bit processes. See this article for workarounds.
ms.date: "11/04/2016"
ms.topic: article
f1_keywords:
  - "vs.debug.error.interop_unsupported_to_old"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Mixed Mode Debugging Is Only Supported when Using Microsoft .NET Framework 2.0 or 3.0

Versions of the Microsoft .NET Framework earlier than 2.0 do not provide support for mixed-mode debugging of 64-bit processes. This means that you cannot step from managed code to native code, or from native code to managed code, while you are debugging.

 To work around this problem, you can:

- Update your project to use either Microsoft .NET Framework 2.0 or 3.0.

- Debug your managed and native code in separate debugging sessions.

- Debug your mixed code as a 32-bit process, as described in the following procedures.

### To change the operating system to 32-bit (Visual Basic or C#)

1. In **Solution Explorer**, right-click your project, and then click **Properties** in the shortcut menu.

2. In the property pages, click the **Compile** or **Debug** tab.

3. Click **Platform**, and then select **x86** from the list of platforms.

     By default, the Visual Basic and C# compilers produce code to run on any CPU. On a 64-bit computer, these binaries run as 64-bit processes. To run on a 32-bit process, you must choose **Win32**, not **AnyCPU**.

### To change the operating system to 32-bit (C/C++)

1. In **Solution Explorer**, right-click your project, and then click **Properties** in the shortcut menu.

     In the property pages, click **Platform**, and then select **Win32** from the list of platforms.

### To correct this error

- See [Setting Up SQL Debugging](/previous-versions/visualstudio/visual-studio-2010/s4sszxst(v=vs.100)).

## Related content
- [Debug 64-Bit Applications](../debugger/debug-64-bit-applications.md)
