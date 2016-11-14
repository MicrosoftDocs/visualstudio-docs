---
title: "Continuing Execution After an Exception | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
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
  - "managed exceptions, continuing execution after"
  - "exceptions, continuing execution after"
  - "debugger, exceptions"
  - "managed code, exception handling"
  - "exception handling, continuing execution after"
  - "execution, continuing after an exception"
  - "program execution"
  - "threading [Visual Studio], continuing execution after exceptions"
  - "Exceptions dialog box"
  - "programs, executing"
ms.assetid: 6fe97aac-2131-4615-bd92-d3afee741558
caps.latest.revision: 25
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Continuing Execution After an Exception
When the debugger breaks execution because of an exception, a dialog box appears. For Visual Basic or C#, you will see the [Exception Assistant](../Topic/Exception%20Assistant.md) dialog box, by default. For C++, you will see the older **Exception** dialog box. If you are using Visual Basic or C# but have disabled the **Exception Assistant** in the **Options** dialog box, you will see the **Exception** dialog box.  
  
 When the **Exception Assistant** or **Exception** dialog box appears, you can try to fix the problem that caused the exception.  
  
## Managed Code  
 In managed code, you can continue execution in the same thread after an unhandled exception. The **Exception Assistant** unwinds the call stack to the point where the exception was thrown.  
  
## Native Code  
 In native C/C++, you have two options:  
  
-   You can click **Break** and try to fix the problem. While you are in Break mode, you can unwind the call stack by right-clicking on a frame in the **Call Stack** window and selecting **Unwind to this Frame** on the shortcut menu. When you continue to debug, the **Exception** dialog box appears again if you have not fixed the problem. Otherwise, the **Exception** dialog box will not reappear.  
  
-   You can click **Continue** to continue execution without trying to fix the problem. The **Exception** dialog box reappears.  
  
## Mixed Code  
 If you hit an unhandled exception while debugging a mixed native and managed code, operating system constraints prevent unwinding the call stack. If you try rewinding the call stack using the shortcut menu, an error message explains that the debugger cannot unwind from an unhandled except during mixed-code debugging.  
  
## See Also  
 [Managing Exceptions with the Debugger](../debugger/managing-exceptions-with-the-debugger.md)