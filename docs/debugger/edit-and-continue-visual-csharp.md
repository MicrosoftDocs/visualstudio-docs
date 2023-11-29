---
title: "Edit and Continue (Visual C#)"
description: Edit and Continue is available for Visual C# projects. Learn what edits are supported, and how to can control whether, and when, your edits are applied.
ms.date: "02/22/2022"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "debugger, Edit and Continue"
  - "Edit and Continue [C#]"
  - "debugging [C#], Edit and Continue"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
---
# Edit and Continue (Visual C#)

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

With Hot Reload, or Edit and Continue for C#, you can make changes to your code in break or run mode while debugging. The changes can be applied without having to stop and restart the debugging session.

The basic Hot Reload experience works with most types of .NET apps and framework versions. This includes .NET Framework, .NET Core and .NET 5+ (for both C# and Visual Basic as applicable). The expectation in this scenario is that if you’re using the debugger, assume Hot Reload is available to you and give it a try!

Hot Reload supports most changes you might want to make during a debugging session, but there are some exceptions. For example, Hot Reload is not supported for optimized code or debugging sessions with the managed and native debugger enabled.

For information on other unsupported scenarios, see [Supported code changes (C# and Visual Basic)](../debugger/supported-code-changes-csharp.md). If you try to apply code changes with one of these scenarios, a message box appears stating that Hot Reload is not supported.

## Use Hot Reload

Hot Reload for C# happens automatically when you make code changes in break mode, then continue debugging by using **Continue**, **Step**, or **Set Next Statement**. If you set [Hot Reload on file save](hot-reload.md#configure-hot-reload) to true, it will also happen automatically when saving a file.

To enable or disable Hot Reload:

1. If you're in a debugging session, stop debugging (**Debug** > **Stop Debugging** or **Shift**+**F5**).

1. Open **Tools** > **Options** > **Debugging** > **.NET/C++ Hot Reload**, select or clear the **Enable Hot Reload and Edit and Continue when debugging** check box.

The setting takes effect when you start or restart the debugging session.

To use the classic Edit and Continue experience:

1. While debugging, in break mode, make a change to your source code.

1. From the **Debug** menu, click **Continue**, **Step**, or **Set Next Statement**. Debugging continues with the new, compiled code.

Some types of code changes are not supported by Edit and Continue. For more information, see [Supported code changes (C# and Visual Basic)](../debugger/supported-code-changes-csharp.md).

## See also
- [Supported Code Changes (C# and Visual Basic)](../debugger/supported-code-changes-csharp.md)
- [Write and debug running XAML code with XAML Hot Reload in Visual Studio](../xaml-tools/xaml-hot-reload.md)
