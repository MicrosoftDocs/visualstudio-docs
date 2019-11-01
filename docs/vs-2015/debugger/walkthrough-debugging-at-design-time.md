---
title: "Walkthrough: Debugging at Design Time | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugging [Visual Studio], design-time"
  - "breakpoints, design-time debugging"
  - "Immediate window, design-time debugging"
  - "design-time debugging"
ms.assetid: 35bfdd2c-6f60-4be1-ba9d-55fce70ee4d8
caps.latest.revision: 23
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Walkthrough: Debugging at Design Time
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can use the Visual Studio **Immediate** window to execute a function or subroutine while your application is not running. If the function or subroutine contains a breakpoint, Visual Studio will break execution at the appropriate point. You can then use the debugger windows to examine your program state. This feature is called debugging at design time.  
  
 The following procedure shows how you can use this feature.  
  
### To hit breakpoints from the Immediate window  
  
1. Paste the following code into a Visual Basic console application:  
  
    ```  
    Module Module1  
  
        Sub Main()  
            MySub()  
        End Sub  
  
        Function MyFunction() As Decimal  
            Static i As Integer  
            i = i + 1  
            Dim s As String  
  
            s = "Add Breakpoint here"  
            Return 4  
        End Function  
  
        Sub MySub()  
            MyFunction()  
        End Sub  
    End Module  
    ```  
  
2. Set a breakpoint on the line that reads, `s="Add BreakPoint Here"`.  
  
3. Type the following in the **Immediate** window: `?MyFunction<enter>`  
  
4. Verify that the breakpoint was hit, and that the call stack is accurate.  
  
5. On the **Debug** menu, click **Continue**, and verify that you are still in design mode.  
  
6. Type the following in the **Immediate** window: `?MyFunction<enter>`  
  
7. Type the following in the **Immediate** window: `?MySub<enter>`  
  
8. Verify that you hit the breakpoint, and examine the value of static variable `i` in the **Locals** window. It should have the value of 3.  
  
9. Verify that the call stack is accurate.  
  
10. On the **Debug** menu, click **Continue**, and verify that you are still in design mode.  
  
## See Also  
 [Debugger Security](../debugger/debugger-security.md)   
 [Debugger Basics](../debugger/debugger-basics.md)
