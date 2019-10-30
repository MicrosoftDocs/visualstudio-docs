---
title: "Edit and Continue (Visual C#) | Microsoft Docs"
ms.date: "10/11/2017"
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
manager: jillfra
ms.workload:
  - "dotnet"
---
# Edit and Continue (Visual C#)
 With Edit and Continue for C#, you can make changes to your code in break mode while debugging. The changes can be applied without having to stop and restart the debugging session. In run mode, the source editor is read-only.

 Edit and Continue supports most changes you might want to make during a debugging session, but there are some exceptions. For more information, see [Supported Code Changes (C# and Visual Basic)](../debugger/supported-code-changes-csharp.md).

 Edit and Continue is supported in UWP in Windows 10, and x86 and x64 apps that target the .NET Framework 4.6 desktop or later versions (the .NET Framework is a desktop version only).

 > [!NOTE]
 > Unsupported apps and platforms include ASP.NET 5, Silverlight 5, and Windows 8.1.

 When Edit and Continue is enabled, supported changes are applied automatically when you use a debugger execution command, such as **Continue**, **Step**, **Set Next Statement**, or perform a function evaluation in a debugger window.

 For more information, see [How to: Use Edit and Continue (C#)](../debugger/how-to-use-edit-and-continue-csharp.md).

## See also
- [How to: Use Edit and Continue (C#)](../debugger/how-to-use-edit-and-continue-csharp.md)
- [Supported Code Changes (C# and Visual Basic)](../debugger/supported-code-changes-csharp.md)
- [Write and debug running XAML code with XAML Hot Reload in Visual Studio](../xaml-tools/xaml-hot-reload.md)
