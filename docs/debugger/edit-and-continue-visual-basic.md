---
title: "Edit and Continue (Visual Basic) | Microsoft Docs"
ms.date: "10/11/2017"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "Edit and Continue, 64-bit"
  - "Edit and Continue [Visual Basic]"
  - "debugging [Visual Basic], Edit and Continue"
  - "Visual Basic, Edit and Continue"
  - "64-bit Edit and Continue"
ms.assetid: 7e90f34f-e699-45ab-a4c9-a4b527c498c8
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Edit and Continue (Visual Basic)
Edit and Continue is a feature for [!INCLUDE [vbprvb](../code-quality/includes/vbprvb_md.md)] debugging that enables you to change your code while it is executing in Break mode. After code edits have been applied, you can resume code execution with the new edits in place and see the effect.

 You can use the Edit and Continue feature whenever you enter Break mode. In Break mode, the instruction pointer, a yellow arrowhead in the source window, points to the line containing an executable statement in a method or property body that will be executed next.

 Edit and Continue supports most changes you might want to make during a debugging session, but there are some exceptions. For more information, see [Supported Code Changes (C# and Visual Basic)](../debugger/supported-code-changes-csharp.md).

 When you make an unauthorized edit, the change is marked with a purple wavy underline and a task is displayed in the Task List. You must undo an unauthorized edit if you want to continue to use Edit and Continue. Certain unauthorized edits may be permitted if done outside Edit and Continue. If you want to retain the results of such an unauthorized edit, you must stop debugging and restart your application.

 Edit and Continue is supported in UWP apps for Windows 10, and x86 and x64 apps that target the .NET Framework 4.6 desktop or later versions (the .NET Framework is a desktop version only).

 > [!NOTE]
 > Unsupported apps and platforms include ASP.NET 5, Silverlight 5, and Windows 8.1.

 Edit and Continue is not supported when you start debugging using **Attach to Process**. Edit and Continue is not supported for optimized code or mixed managed and native code. For more information, see [Supported Code Changes (C# and Visual Basic)](../debugger/supported-code-changes-csharp.md).

 The topics in this section provide additional details about how to use this feature and what kinds of changes are not allowed.

## In This Section
 [How to: Apply Edits in Break Mode with Edit and Continue](../debugger/how-to-apply-edits-in-break-mode-with-edit-and-continue.md)
 Explains how to apply code edits in Break mode.

 [Supported Code Changes (C# and Visual Basic)](../debugger/supported-code-changes-csharp.md)
 Describes what types of edits cannot be performed in [!INCLUDE [vb_current_short](../debugger/includes/vb_current_short_md.md)] Edit and Continue.

## Related Sections
 [Edit and Continue](../debugger/edit-and-continue.md)
 Provides a list of topics on Edit and Continue.
