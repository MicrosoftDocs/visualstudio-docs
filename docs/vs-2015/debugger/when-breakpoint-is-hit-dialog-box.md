---
title: "When Breakpoint Is Hit Dialog Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug.whenbreakpointishit"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "JScript"
  - "SQL"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: 476e3d98-cf35-4338-b124-cd0f3010d854
caps.latest.revision: 14
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# When Breakpoint Is Hit Dialog Box
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

With this dialog box, you can customize the action that occurs when a breakpoint is hit.  
  
## UIElement List  
 **Print a Message**  
 Prints a message, using DebuggerDisplay syntax. For more information, see [Using the DebuggerDisplay Attribute](../debugger/using-the-debuggerdisplay-attribute.md).  
  
 This textbox also supports special keywords (such as $ADDRESS) that can be used by themselves or within the curly braces of a DebuggerDisplay expression. The available keywords are listed on the dialog box.  
  
 **Continue Execution**  
 This control is enabled only when **Print a Message** is selected. With this control selected, you can use a breakpoint as a tracepoint to trace your program execution, rather than breaking when the location is hit.  
  
## See Also  
 [Using Breakpoints](../debugger/using-breakpoints.md)   
 [Using the DebuggerDisplay Attribute](../debugger/using-the-debuggerdisplay-attribute.md)
