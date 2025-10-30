---
title: "Mixed mode debugging for x64 processes is only supported when using Microsoft.NET Framework 4 or greater"
description: .NET Framework versions earlier than 4 do not provide support for mixed-mode debugging of x64 processes. See this article for workarounds.
ms.date: "11/04/2016"
ms.topic: article
f1_keywords:
  - "vs.debug.error.interop_unsupported_x64"
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
# Mixed mode debugging for x64 processes is only supported when using Microsoft.NET Framework 4 or greater

.NET Framework versions earlier than 4 do not provide support for mixed-mode debugging of x64 processes. That means that you cannot step from managed code to native code, or from native code to managed code, while debugging.

### Workarounds

- Update your project to use Microsoft .NET Framework 4 or later.

    -or-

- Debug your managed and native code in separate debugging sessions.

    -or-

- Debug your mixed code as a 32-bit process, as described in the following procedures.

### To change the platform to 32-bit (Visual Basic or C#)

1. In **Solution Explorer**, right-click your project, and then click **Properties**.

2. In the property pages, click the **Compile** or the **Debug** tab.

3. Click **Platform** and select x86 from the list of platforms.

     By default, the Visual Basic and C# compilers default produce code to run on any CPU. On a 64-bit computer, these binaries run as 64-bit processes. To run on a 32-bit process, you must choose **Win32**, not **AnyCPU**.

### To change the platform to 32-bit (C/C++)

1. In **Solution Explorer**, right-click your project, then click **Properties**.

2. In the Property Pages, click **Platform** and select Win32 from the list of platforms.

### To correct this error

- See [Setting Up SQL Debugging](/previous-versions/visualstudio/visual-studio-2010/s4sszxst(v=vs.100)).

## Related content
- [Debug 64-Bit Applications](../debugger/debug-64-bit-applications.md)
