---
title: "Send Diagnostic Messages to the Output Window | Microsoft Docs"
ms.custom: ""
ms.date: "04/25/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords: 
  - "diagnostic messages [C#]"
  - "System.Diagnostics.Debug class, Output window"
  - "messages, diagnostic"
  - "Debug.Print replacements"
  - "diagnosis"
  - "Output window, diagnostic messages"
  - "System.Diagnostics.Trace class, Output window"
  - "Trace class, diagnostic messages"
  - "diagnostics"
  - "debugger, Output window"
  - "debugging [Visual Studio], diagnostic messages in Output window"
  - "Debug class"
ms.assetid: 386e9524-be17-4573-83fb-4f7c5cae0be0
caps.latest.revision: 16
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Send Diagnostic Messages to the Output Window
You can write run-time messages to the **Output** window using the `Debug` class or the `Trace` class, which are part of the <xref:System.Diagnostics> class library. Use the Debug class if you only output in the Debug version of your program. Use the Trace class if you want output in both the Debug and Release versions.  
  
## Output Methods  
 The <xref:System.Diagnostics.Trace> and <xref:System.Diagnostics.Debug> classes provide the following output methods:  
  
-   Various `Write` methods, which output information without breaking execution. These methods replace the `Debug.Print` method used in previous versions of Visual Basic.  
  
-   <xref:System.Diagnostics.Debug.Assert%2A?displayProperty=fullName> and <xref:System.Diagnostics.Trace.Assert%2A?displayProperty=fullName> methods, which break execution and outputs information if a specified condition fails. By default, the `Assert` method displays the information in a dialog box. For more information, see [Assertions in Managed Code](../debugger/assertions-in-managed-code.md).  
  
-   The <xref:System.Diagnostics.Debug.Fail%2A?displayProperty=fullName> and <xref:System.Diagnostics.Trace.Fail%2A?displayProperty=fullName> methods, which always breaks execution and outputs information. By default, the `Fail` methods display the information in a dialog box.  
  
 In addition to program out from your application, the **Output** window can display the information about:  
  
-   Modules the debugger has loaded or unloaded.  
  
-   Exceptions that are thrown.  
  
-   Processes that exit.  
  
-   Threads that exit.  
  
## See Also  
 [Debugger Security](../debugger/debugger-security.md)   
 [Output Window](../ide/reference/output-window.md)   
 [Tracing and Instrumenting Applications](/dotnet/framework/debug-trace-profile/tracing-and-instrumenting-applications)  
 [C#, F#, and Visual Basic Project Types](../debugger/debugging-preparation-csharp-f-hash-and-visual-basic-project-types.md)   
 [Debugging Managed Code](../debugger/debugging-managed-code.md)