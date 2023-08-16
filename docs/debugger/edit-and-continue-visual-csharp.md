---
title: "Edit and Continue (Visual C#) | Microsoft Docs"
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
ms.assetid: 591bd1b7-ef10-4d10-817b-3f92ca4be006
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "dotnet"
---
# Edit and Continue (Visual C#)

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

With Edit and Continue for C#, you can make changes to your code in break mode while debugging. The changes can be applied without having to stop and restart the debugging session. In run mode, the source editor is read-only.

Edit and Continue is supported in UWP in Windows 10 or later, and x86 and x64 apps that target the .NET Framework 4.6 desktop or later versions (the .NET Framework is a desktop version only).

Edit and Continue supports most changes you might want to make during a debugging session, but there are some exceptions. Edit and Continue is not supported for optimized, mixed, or SQL Server common language runtime (CLR) integration code. For information on other unsupported scenarios, see [Supported code changes (C# and Visual Basic)](../debugger/supported-code-changes-csharp.md). If you try to Edit and Continue with one of these scenarios, a message box appears stating that Edit and Continue is not supported.

## Use Edit and Continue

Edit and Continue for C# happens automatically when you make code changes in break mode, then continue debugging by using **Continue**, **Step**, or **Set Next Statement**, or evaluate a function in a debugger window.

To enable or disable Edit and Continue:

1. If you're in a debugging session, stop debugging (**Debug** > **Stop Debugging** or **Shift**+**F5**).

1. In **Tools** > **Options** (or **Debug** > **Options**) > **Debugging** > **General**, select or clear the **Enable Edit and Continue** check box.

The setting takes effect when you start or restart the debugging session.

To use Edit and Continue:

1. While debugging, in break mode, make a change to your source code.

1. From the **Debug** menu, click **Continue**, **Step**, or **Set Next Statement**, or evaluate a function in a debugger window.

   Debugging continues with the new, compiled code.

Some types of code changes are not supported by Edit and Continue. For more information, see [Supported code changes (C# and Visual Basic)](../debugger/supported-code-changes-csharp.md).

## See also
- [Supported Code Changes (C# and Visual Basic)](../debugger/supported-code-changes-csharp.md)
- [Write and debug running XAML code with XAML Hot Reload in Visual Studio](../xaml-tools/xaml-hot-reload.md)
