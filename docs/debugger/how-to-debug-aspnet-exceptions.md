---
title: Debug ASP.NET Exceptions
description: Learn to configure so that the debugger stops for unhandled exceptions in your ASP.NET application. You can assure that the break occurs in non-system code.
ms.date: 07/21/2023
ms.topic: how-to
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords: 
  - debugging [Visual Studio], ASP.NET exceptions
  - ASP.NET, exceptions
  - exceptions, ASP.NET
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Debug ASP.NET Exceptions

Debugging exceptions is an important part of developing a robust ASP.NET application. General information about how to debug exceptions is at [Managing Exceptions with the Debugger](../debugger/managing-exceptions-with-the-debugger.md).

 To debug unhandled ASP.NET exceptions, you must make sure that the debugger stops for them. The ASP.NET runtime has a top-level exception handler. Therefore, the debugger never breaks on unhandled exceptions by default. To break into the debugger when an exception is thrown, you must select **Break when Thrown** setting for that specific exception in the **Exceptions** dialog box.

 If you have enabled Just My Code, **Break when Thrown** doesn't cause the debugger to break immediately if an exception is thrown in a .NET method or other system code. Instead, execution continues until the debugger hits non-system code, then it breaks. As a result, you don't have to step through the system code when an exception occurs.

 Just My Code gives you another option that can be useful: **Continue When Unhandled in User Code**. If you disable this setting for an exception, the debugger will break execution in user code, but only if the exception isn't caught and handled by the user code. This setting negates the effect of the top-level ASP.NET exception handler, because that handler is in non-user code.

### To enable debugging of ASP.NET exceptions with Just My Code

1. On the **Debug** menu, click **Windows** > **Exception settings**.

     The **Exceptions** dialog box appears.

1. Under **Common Language Runtime Exceptions**, select the row for the exception that you want to break when it's thrown.

1. If you want to disable **Continue When Unhandled in User Code**, right-click the row and deselect the option, if it's already selected.

     To use the **User-unhandled** setting, **Just My Code** must be enabled.

### To use best practices for ASP.NET exception handling

- Place `try ... catch` blocks around code that can throw exceptions that you can anticipate and know how to handle. For example, if the application is making calls to an XML Web Service or directly to a SQL Server, that code should be in **try ... catch** blocks because there are numerous exceptions that can occur.

## Related content
- [Debug ASP.NET Applications](../debugger/how-to-enable-debugging-for-aspnet-applications.md)
