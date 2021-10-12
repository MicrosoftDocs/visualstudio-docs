---
title: "Microsoft Visual Studio Debugger (Exception Thrown) Dialog Box | Microsoft Docs"
titleSuffix: ""
description: "Learn what to do when an exception occurs that your program needs to handle. You can: 1) break into the debugger; 2) continue; or 3) ignore."

ms.date: "11/04/2016"
ms.topic: "reference"
f1_keywords:
  - "vs.debug.exceptions.thrown"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "Microsoft Visual Studio Debugger (Exception Thrown) dialog box"
  - "exception handling, during debugging"
  - "debugger, exceptions"
  - "throwing exceptions, during debugging"
ms.assetid: 1fe98d10-c8f9-4b39-a920-99169bfd542e
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Microsoft Visual Studio Debugger (Exception Thrown) Dialog Box
An exception has occurred in your program. This dialog box reports the kind of exception thrown. Your code needs to handle this exception. You can choose between the following options for handling the exception:

 **Break**
 Allows execution to break into the debugger. The exception handler is not invoked prior to the break. If you continue from the break, the exception handler will be invoked.

 **Continue**
 Allows execution to continue, giving the exception handler a chance to handle the exception. This option is not available for certain types of exceptions. **Continue** will allow the application to continue. In a native application, it will cause the exception to be rethrown. In a managed application, it will either cause the program to terminate or the exception to be handled by a hosting application.

> [!NOTE]
> You cannot continue after an unhandled exception in managed code. Choosing **Continue** after an unhandled exception in managed code causes debugging to stop.

 **Ignore**
 Allows execution to continue without invoking the exception handler. Because the exception handler is not invoked, this can lead to further consequences, including additional exceptions and errors. This option is not available for certain types of exceptions.

## See also
- [Managing Exceptions with the Debugger](../debugger/managing-exceptions-with-the-debugger.md)
- [Best Practices for Exceptions](/dotnet/standard/exceptions/best-practices-for-exceptions)
- [Exception Handling](/cpp/extensions/exception-handling-cpp-component-extensions)