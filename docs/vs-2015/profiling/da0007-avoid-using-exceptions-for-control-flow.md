---
title: "DA0007: Avoid using exceptions for control flow | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
f1_keywords: 
  - "vs.performance.rules.DAExceptionsThrown"
  - "vs.performance.7"
  - "vs.performance.rules.DA0007"
  - "vs.performance.DA0007"
ms.assetid: ee8ba8b5-2313-46c9-b129-3f3a2a232898
caps.latest.revision: 18
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# DA0007: Avoid using exceptions for control flow
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Rule Id|DA0007|  
|Category|.NET Framework Usage|  
|Profiling methods|All|  
|Message|A high number of exceptions are consistently being thrown. Consider reducing the use of exceptions in program logic.|  
|Message type|Warning|  
  
 When you profile by using the sampling, .NET memory, or resource contention methods, you must collect at least 25 samples to trigger this rule.  
  
## Cause  
 A high rate of .NET Framework exception handlers were called in the profiling data. Consider using other control flow logic to reduce the number of exceptions that are thrown.  
  
## Rule Description  
 While the use of exception handlers to catch errors and other events that disrupt program execution is a good practice, the use of exception handler as part of the regular program execution logic can be expensive and should be avoided. In most cases, exceptions should be used only for circumstances that occur infrequently and are not expected.. Exceptions should not be used to return values as part of the typical program flow. In many cases, you can avoid raising exceptions by validating values and using conditional logic to halt the execution of statements that cause the problem.  
  
 For more information see the [Exception Management](https://go.microsoft.com/fwlink/?LinkID=177825) section of **Chapter 5 — Improving Managed Code Performance** in the **Improving .NET Application Performance and Scalability** volume of the **Microsoft Patterns and Practices** library on MSDN.  
  
## How to Investigate a Warning  
 Double-click the message in the Error List window to navigate to the Marks view. Find the column that contains the **.NET CLR Exceptions(@ProcessInstance)\\# of Exceps Thrown / sec** measurements. Determine if there are specific phases of program execution where exception handling is more frequent than others. Using a sampling profile, try to identify throw statements and try/catch blocks that generate frequent exceptions. If necessary, add logic to catch blocks to help you understand which exceptions are being handled most frequently. Where possible, replace frequently executed throw statements or catch blocks with simple flow control logic or validation code.  
  
 For example, if you were to find that your application was handling frequent DivideByZeroException exceptions, adding logic to your program to check for denominators with zero values will improve the performance of the application.
