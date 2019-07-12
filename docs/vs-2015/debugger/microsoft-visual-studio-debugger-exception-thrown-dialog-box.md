---
title: "Microsoft Visual Studio Debugger (Exception Thrown) Dialog Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug.exceptions.thrown"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "Microsoft Visual Studio Debugger (Exception Thrown) dialog box"
  - "exception handling, during debugging"
  - "debugger, exceptions"
  - "throwing exceptions, during debugging"
ms.assetid: 1fe98d10-c8f9-4b39-a920-99169bfd542e
caps.latest.revision: 13
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Microsoft Visual Studio Debugger (Exception Thrown) Dialog Box
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

An exception has occurred in your program. This dialog box reports the kind of exception thrown. Your code needs to handle this exception. You can choose between the following options for handling the exception:  
  
 **Break**  
 Allows execution to break into the debugger. The exception handler is not invoked prior to the break. If you continue from the break, the exception handler will be invoked.  
  
 **Continue**  
 Allows execution to continue, giving the exception handler a chance to handle the exception. This option is not available for certain types of exceptions. **Continue** will allow the application to continue. In a native application, it will cause the exception to be rethrown. In a managed application, it will either cause the program to terminate or the exception to be handled by a hosting application.  
  
> [!NOTE]
> You cannot continue after an unhandled exception in managed code. Choosing **Continue** after an unhandled exception in managed code causes debugging to stop.  
  
 **Ignore**  
 Allows execution to continue without invoking the exception handler. Because the exception handler is not invoked, this can lead to further consequences, including additional exceptions and errors. This option is not available for certain types of exceptions.  
  
## See Also  
 [Managing Exceptions with the Debugger](../debugger/managing-exceptions-with-the-debugger.md)   
 [Best Practices for Exceptions](https://msdn.microsoft.com/library/f06da765-235b-427a-bfb6-47cd219af539)   
 [Exception Handling](/cpp/extensions/exception-handling-cpp-component-extensions)
