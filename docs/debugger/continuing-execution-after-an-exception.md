---
title: Continuing Execution After an Exception
description: Learn what happens when the debugger breaks execution because of an unhandled exception. You may be able to continue execution in the same thread. 
ms.date: 11/04/2016
ms.topic: how-to
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
  - JScript
helpviewer_keywords: 
  - managed exceptions, continuing execution after
  - exceptions, continuing execution after
  - debugger, exceptions
  - managed code, exception handling
  - exception handling, continuing execution after
  - execution, continuing after an exception
  - program execution
  - threading [Visual Studio], continuing execution after exceptions
  - Exceptions dialog box
  - programs, executing
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
---
# Continuing Execution After an Exception

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
When the debugger breaks execution because of an exception, you will see the **Exception Helper**, by default. If you have disabled the **Exception Helper** in the **Options** dialog box, you will see the **Exception Assistant** (C# or Visual Basic) or the **Exception** dialog box (C++).

 When the **Exception Helper** appears, you can try to fix the problem that caused the exception.

## Managed and Native Code
 In managed and native code, you can continue execution in the same thread after an unhandled exception. The **Exception Helper** unwinds the call stack to the point where the exception was thrown.

## Mixed Code
 If you hit an unhandled exception while debugging a mixed native and managed code, operating system constraints prevent unwinding the call stack. If you try rewinding the call stack using the shortcut menu, an error message explains that the debugger cannot unwind from an unhandled except during mixed-code debugging.

## Related content

- [Managing Exceptions with the Debugger](../debugger/managing-exceptions-with-the-debugger.md)