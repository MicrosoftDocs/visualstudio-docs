---
title: Send messages to the Output window
description: Write run-time messages to the Output window in Visual Studio using the Debug class or the Trace class, which are part of the System.Diagnostics class library.
ms.date: 10/03/2024
ms.topic: how-to
helpviewer_keywords: 
  - diagnostic messages [C#]
  - System.Diagnostics.Debug class, Output window
  - messages, diagnostic
  - Debug.Print replacements
  - diagnosis
  - Output window, diagnostic messages
  - System.Diagnostics.Trace class, Output window
  - Trace class, diagnostic messages
  - diagnostics
  - debugger, Output window
  - debugging [Visual Studio], diagnostic messages in Output window
  - Debug class
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Send messages to the Output window

You can write run-time messages to the **Output** window using the <xref:System.Diagnostics.Debug> class or the <xref:System.Diagnostics.Trace> class, which are part of the <xref:System.Diagnostics> class library. Use the <xref:System.Diagnostics.Debug> class if you only want output in the *Debug* version of your program. Use the <xref:System.Diagnostics.Trace> class if you want output in both the *Debug* and *Release* versions.

## Output methods
 The <xref:System.Diagnostics.Trace> and <xref:System.Diagnostics.Debug> classes provide the following output methods:

- Various [Write](/dotnet/api/system.diagnostics.debug#methods) methods, which output information without breaking execution. These methods replace the `Debug.Print` method used in older versions of Visual Basic.

- <xref:System.Diagnostics.Debug.Assert%2A?displayProperty=fullName> and <xref:System.Diagnostics.Trace.Assert%2A?displayProperty=fullName> methods, which break execution and output information if a specified condition fails. By default, the `Assert` method displays the information in a dialog box. For more information, see [Assertions in managed code](../debugger/assertions-in-managed-code.md).

- The <xref:System.Diagnostics.Debug.Fail%2A?displayProperty=fullName> and <xref:System.Diagnostics.Trace.Fail%2A?displayProperty=fullName> methods, which always break execution and output information. By default, the `Fail` methods display the information in a dialog box.

The **Output** window can also display information about:

- Modules the debugger has loaded or unloaded.

- Exceptions that are thrown.

- Processes that exit.

- Threads that exit.

## Related content
- [Debugger security](../debugger/debugger-security.md)
- [Output window](../ide/reference/output-window.md)
- [Trace and instrument applications](/dotnet/framework/debug-trace-profile/tracing-and-instrumenting-applications)
- [C#, F#, and Visual Basic project types](../debugger/managed-debugging-recommended-property-settings.md)
- [Debugging managed code](../debugger/debugging-managed-code.md)
