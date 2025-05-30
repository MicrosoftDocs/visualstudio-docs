---
title: "Debugging F#"
description: Review a list of differences between debugging F# compared with debugging other managed languages in Visual Studio.
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
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Debugging F\#

Debugging F# is similar to debugging any managed language, with a few exceptions:

- The **Autos** window does not display F# variables.

- Edit and Continue is not supported for F#. Editing F# code during a debugging session is possible but should be avoided. Because code changes are not applied during the debugging session, editing F# code during debugging will cause a mismatch between the source code and the code being debugged.

- The debugger does not recognize F# expressions. To enter an expression in a debugger window or a dialog box during F# debugging, you must translate the expression into C# syntax. When you translate an F# expression into C#, make sure to remember that C# uses == as the comparison operator for equality and that F# uses a single =.

## Related content
- [Debugging Managed Code](/visualstudio/debugger/)
