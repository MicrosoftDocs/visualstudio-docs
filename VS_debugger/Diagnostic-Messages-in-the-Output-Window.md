---
title: "Diagnostic Messages in the Output Window"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 386e9524-be17-4573-83fb-4f7c5cae0be0
caps.latest.revision: 16
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Diagnostic Messages in the Output Window
You can write run-time messages to the Output window using the Debug class or the Trace class, which are part of the <xref:System.Diagnostics?qualifyHint=False> class library. Use the Debug class if you only output in the Debug version of your program. Use the Trace class if you want output in both the Debug and Release versions.  
  
## Output Methods  
 The <xref:System.Diagnostics.Trace?qualifyHint=False> and <xref:System.Diagnostics.Debug?qualifyHint=False> classes provide the following output methods:  
  
-   Various `Write` methods, which output information without breaking execution. These methods replace the `Debug.Print` method used in previous versions of Visual Basic.  
  
-   <xref:System.Diagnostics.Debug.Assert?qualifyHint=True> and <xref:System.Diagnostics.Trace.Assert?qualifyHint=True> methods, which break execution and outputs information if a specified condition fails. By default, the `Assert` method displays the information in a dialog box. For more information, see [Assertions in Managed Code](../VS_debugger/Assertions-in-Managed-Code.md).  
  
-   The <xref:System.Diagnostics.Debug.Fail?qualifyHint=True> and <xref:System.Diagnostics.Trace.Fail?qualifyHint=True> methods, which always breaks execution and outputs information. By default, the `Fail` methods display the information in a dialog box.  
  
 In addition to program out from your application, the **Output** window can display the information about:  
  
-   Modules the debugger has loaded or unloaded.  
  
-   Exceptions that are thrown.  
  
-   Processes that exit.  
  
-   Threads that exit.  
  
## See Also  
 [Debugger Security](../VS_debugger/Debugger-Security.md)   
 [Output Window](../VS_IDE/Output-Window.md)   
 [Tracing and Instrumenting Applications](../Topic/Tracing%20and%20Instrumenting%20Applications.md)   
 [Introduction to Instrumentation and Tracing](assetId:///e924e57c-33cf-4b0e-9e7f-a45d13e38f2c)   
 [C#, F#, and Visual Basic Project Types](../VS_debugger/Debugging-Preparation--C#--F#--and-Visual-Basic-Project-Types.md)   
 [Debugging Managed Code](../VS_debugger/Debugging-Managed-Code.md)