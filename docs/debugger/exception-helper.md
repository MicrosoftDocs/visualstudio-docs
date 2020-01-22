---
title: "Exception Helper - Visual Studio | Microsoft Docs"
ms.date: "1/18/2020"
ms.topic: "reference"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "JavaScript"
helpviewer_keywords:
  - "exception helper, debugger"
  - "debugging [Visual Studio], exception helper"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Exception Helper

Dealing with exceptions is a common problem, no matter your technology or level of expertise. It can be a frustrating experience figuring out why exceptions are causing problems in your code. When you are debugging an exception in Visual Studio, we want to lessen that frustration by providing you with relevant exception information to help you debug your issue faster.

![Exception Helper](media/debugger-exception-helper-default.png)


## Breaking on the Line of Code
When the debugger breaks on an exception an exception error icon will appear to the right of that line of code and the non-modal, smaller, less distracting Exception helper will pop down from that icon and stay pinned to that code line.


![Exception helper adjacent to line of code](media/debugger-exception-helper-locerror.png)

## Exception Information at a Glance
You will instantly be able to read the exception type and exception message in the Exception Helper, and whether the exception was thrown or unhandled. You can inspect and view properies of the Exception object by clicking the 'View Details' link.

## Null Reference Analysis 
Starting in VS 2017 , for both managed and native code, when you hit a NullReferenceException or an Access Violation, you will see null analysis information in the Exception Helper. The analysis is displayed as text benetath the exception message. In the screenshot below it is shown as "**s** was null.".


![Exception helper null analysis](media/debugger-exception-helper-default.png)


**Note:** Null reference analysis in managed code requires .NET version 4.6.2. Null analysis is currently not supported for Universal Windows Platform (UWP) and any other .NET Core applications. It is only available while debugging code that does not have any Just-In-Time (JIT) code optimizations.

## Configure your Exception Settings 
You can configure the debugger to break when an Exception of the current type is thrown from the "Exception Settings" section of the exception helper. If the debugger is paused at a thrown exception then you can use the checkbox to disable breaking on that exception type when thrown in the future. You can also specify that you do not want to break on this particular exception thrown in this particular module by checking the box by the module name under “Except when thrown from:” in the Exception Settings. You can apply conditions to your exceptions to only break when thrown from certain modules.

## Inner Exceptions 
If the exception has any inner exceptions ([InnerException](https://docs.microsoft.com/en-us/dotnet/api/system.exception.innerexception?view=netframework-4.8)) you can view them in the Exception Helper. If there are multiple exceptions present you can navigate between them using the arrows on the left and right side of the text that states the number of Inner Exceptions.

![Exception helper with inner exception](media/debugger-exception-helper-innerexception.png)

## Rethrown Exceptions
If the exception being displaying in the Exception Helper was previously thrown the Exception Helper will show the call stack from the first time the exception was thrown. If the exception has been thrown multiple times, only the callstack from the original exception will be shown.

![Exception helper with rethrown exceptions](media/debugger-exception-helper-innerexception.png)

## Start Live Share Session
From the exception helper you can start start a [Live Share](https://docs.microsoft.com/en-us/visualstudio/liveshare/) session using the link "Start Live Share session...". Anyone who joins the Live Share session will be able to see the exception helper and any other debug information.