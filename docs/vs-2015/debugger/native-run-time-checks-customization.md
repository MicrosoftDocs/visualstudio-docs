---
title: "Native Run-Time Checks Customization | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug.crt"
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
  - "runtime_checks pragma"
  - "debugger, native run-time checks"
  - "/RTC compiler option [C++], native run-time checks"
  - "customizing CRT error checking"
  - "native run-time checks, customizing"
ms.assetid: 76a365fe-6439-49db-8603-34058b78e5a8
caps.latest.revision: 23
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Native Run-Time Checks Customization
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

When you compile with **/RTC** (run-time checks) or use the `runtime_checks` pragma, the C run-time library provides native run-time checks. In some cases, you might want to customize run-time checking:  
  
- To route run-time check messages to a file or destination other than the default.  
  
- To specify an output destination for run-time check messages under a third-party debugger.  
  
- To report run-time check messages from a program compiled with a release version of the C run-time library. Release versions of the library do not use `_CrtDbgReportW` to report run-time errors. Instead, they display an **Assert** dialog box for each run-time error.  
  
  To customize run-time error checking, you can:  
  
- Write a run-time error reporting function. For more information, see [How to: Write a Run-Time Error Reporting Function](../debugger/how-to-write-a-run-time-error-reporting-function.md).  
  
- Customize the error message destination.  
  
- Query for information about run-time check errors.  
  
## Customize the Error Message Destination  
 If you use `_CrtDbgReportW` to report errors, you can use `_CrtSetReportMode` to specify the destination of error messages.  
  
 If you use a custom reporting function, use `_RTC_SetErrorType` to associate an error with a report type.  
  
## Query for Information About Run-Time Checks  
 `_RTC_NumErrors` returns the number of error types detected by run-time error checks. To get a brief description of each error, you can loop from 0 to the return value of `_RTC_NumErrors`, passing the iteration value to `_RTC_GetErrDesc` on each loop. For more information, see [_RTC_NumErrors](https://msdn.microsoft.com/library/7e82adae-38e2-4f8b-bc0b-37bda8109fd1) and [_RTC_GetErrDesc](https://msdn.microsoft.com/library/7994ec2b-5488-4fd4-806d-a166c9a9f927).  
  
## See Also  
 [How to: Use Native Run-Time Checks](../debugger/how-to-use-native-run-time-checks.md)   
 [runtime_checks](https://msdn.microsoft.com/library/ae50b43f-f88d-47ad-a2db-3389e9e7df5b)   
 [_CrtDbgReport, _CrtDbgReportW](https://msdn.microsoft.com/library/6e581fb6-f7fb-4716-9432-f0145d639ecc)
