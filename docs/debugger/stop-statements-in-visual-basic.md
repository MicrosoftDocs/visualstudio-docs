---
title: "Stop Statements in Visual Basic"
description: Review the Visual Basic Stop statement, which provides a programmatic alternative to setting a breakpoint in Visual Studio.
ms.date: "11/04/2016"
ms.topic: how-to
dev_langs:
  - "CSharp"
  - "VB"
helpviewer_keywords:
  - "End statements"
  - "breakpoints, Stop statements"
  - "debugging managed code, Stop statements vs breakpoints"
  - "Stop statements, about Stop statements"
  - "debugging [Visual Basic], Stop statements vs. breakpoints"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Stop statements in Visual Basic

The Visual Basic Stop statement provides a programmatic alternative to setting a breakpoint. When the debugger encounters a Stop statement, it breaks execution of the program (enters break mode). C# programmers can achieve the same effect using a call to <xref:System.Diagnostics.Debugger.Break%2A?displayProperty=nameWithType>.

You set or remove a Stop statement by editing your source code. You cannot set or clear Stop statements using debugger commands, as you would a breakpoint.

Unlike an End statement, the Stop statement does not reset variables or return you to design mode. You can choose Continue from the Debug menu to continue running the application.

When you run a Visual Basic application outside of the debugger, a Stop statement launches the debugger if Just-in-Time debugging is enabled. If Just-in-Time debugging is not enabled, the Stop statement behaves as if it were an End statement and terminates execution. No QueryUnload or Unload event occurs, so you must remove all Stop statements from the Release version of your Visual Basic application. For more information, see [Just-In-Time Debugging](just-in-time-debugging-in-visual-studio.md).

 To avoid the necessity of removing Stop statements, you can use conditional compilation:

```vb
#If DEBUG Then
   Stop
#Else
   ' Don't stop
#End If
```

Another alternative is to use a <xref:System.Diagnostics.Debug.Assert%2A?displayProperty=nameWithType> statement instead of the Stop statement. A <xref:System.Diagnostics.Debug.Assert%2A?displayProperty=nameWithType> statement breaks execution only when a specified condition is not met. <xref:System.Diagnostics.Debug.Assert%2A> statements are automatically removed when you build a Release version. For more information, see [Assertions in Managed Code](assertions-in-managed-code.md). If you want an <xref:System.Diagnostics.Debug.Assert%2A> statement that always breaks execution in the Debug version, you can do this:

### [C#](#tab/csharp)
```csharp
Debug.Assert(false);
```

### [VB](#tab/vb)
```vb
Debug.Assert(False)
```
---

Yet another alternative is to use the <xref:System.Diagnostics.Debug.Fail%2A?displayProperty=nameWithType> method:

### [C#](#tab/csharp)
```csharp
Debug.Fail("a clever output string goes here");
```

### [VB](#tab/vb)
```vb
Debug.Fail("a clever output string goes here")
```
---

## Related content

- [Debugger Security](debugger-security.md)
- [Managed debugging: Recommended project settings](managed-debugging-recommended-property-settings.md)
- [Debugging Managed Code](/visualstudio/debugger/)
