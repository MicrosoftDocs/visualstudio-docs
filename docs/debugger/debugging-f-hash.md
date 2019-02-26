---
title: "Debugging F# | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "Debugging [F#]"
  - "F#, debugging"
ms.assetid: 20bcd51c-2d06-4281-9a1e-ef2b91d1a779
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Debugging F\#
Debugging F# is similar to debugging any managed language, with a few exceptions:

-   The **Autos** window does not display F# variables.

-   Edit and Continue is not supported for F#. Editing F# code during a debugging session is possible but should be avoided. Because code changes are not applied during the debugging session, editing F# code during debugging will cause a mismatch between the source code and the code being debugged.

-   The debugger does not recognize F# expressions. To enter an expression in a debugger window or a dialog box during F# debugging, you must translate the expression into C# syntax. When you translate an F# expression into C#, make sure to remember that C# uses == as the comparison operator for equality and that F# uses a single =.

## See Also
- [Debugging Managed Code](../debugger/debugging-managed-code.md)
