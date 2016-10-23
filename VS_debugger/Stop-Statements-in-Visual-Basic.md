---
title: "Stop Statements in Visual Basic"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
  - VB
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 4ad3fe5c-3dfb-4913-b2eb-a0b635751c18
caps.latest.revision: 13
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
# Stop Statements in Visual Basic
The Visual Basic Stop statement provides a programmatic alternative to setting a breakpoint. When the debugger encounters a Stop statement, it breaks execution of the program (enters break mode). C# programmers can achieve the same effect using a call to System.Diagnostics.Debugger.Break.  
  
 You set or remove a Stop statement by editing your source code. You cannot set or clear Stop statements using debugger commands, as you would a breakpoint.  
  
 Unlike an End statement, the Stop statement does not reset variables or return you to design mode. You can choose Continue from the Debug menu to continue running the application.  
  
 When you run a Visual Basic application outside of the debugger, a Stop statement will launch the debugger if Just-in-Time debugging is enabled. If Just-in-Time debugging is not enabled, the Stop statement behaves as if it were an End statement, terminating execution. No QueryUnload or Unload event occurs, so you must remove all Stop statements from the Release version of your Visual Basic application. For more information, see [Just-In-Time Debugging](../VS_debugger/Just-In-Time-Debugging-in-Visual-Studio.md).  
  
 To avoid the necessity of removing Stop statements, you can use conditional compilation:  
  
```  
#If DEBUG Then  
   Stop  
#Else  
   ' Don't stop  
#End If  
```  
  
 Another alternative is to use an Assert statement instead of the Stop statement. A Debug.Assert statement breaks execution only when a specified condition is not met and is automatically removed when you build a Release version. For more information, see [Assertions in Managed Code](../VS_debugger/Assertions-in-Managed-Code.md). If you want an Assert statement that always breaks execution in the Debug version, you can do this:  
  
```  
Debug.Assert(false)  
```  
  
 Yet another alternative is to use the Debug.Fail method:  
  
```  
Debug.Fail("a clever output string goes here")  
```  
  
## See Also  
 [Debugger Security](../VS_debugger/Debugger-Security.md)   
 [C#, F#, and Visual Basic Project Types](../VS_debugger/Debugging-Preparation--C#--F#--and-Visual-Basic-Project-Types.md)   
 [Debugging Managed Code](../VS_debugger/Debugging-Managed-Code.md)