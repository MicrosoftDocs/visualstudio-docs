---
title: "Native Run-Time Checks Customization | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.debug.crt"
dev_langs: 
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "JScript"
helpviewer_keywords: 
  - "runtime_checks pragma"
  - "debugger, native run-time checks"
  - "/RTC compiler option [C++], native run-time checks"
  - "customizing CRT error checking"
  - "native run-time checks, customizing"
ms.assetid: 76a365fe-6439-49db-8603-34058b78e5a8
caps.latest.revision: 18
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
# Native Run-Time Checks Customization
When you compile with **/RTC** (run-time checks) or use the `runtime_checks` pragma, the C run-time library provides native run-time checks. In some cases, you might want to customize run-time checking:  
  
-   To route run-time check messages to a file or destination other than the default.  
  
-   To specify an output destination for run-time check messages under a third-party debugger.  
  
-   To report run-time check messages from a program compiled with a release version of the C run-time library. Release versions of the library do not use `_CrtDbgReportW` to report run-time errors. Instead, they display an **Assert** dialog box for each run-time error.  
  
 To customize run-time error checking, you can:  
  
-   Write a run-time error reporting function. For more information, see [How to: Write a Run-Time Error Reporting Function](../debugger/how-to-write-a-run-time-error-reporting-function.md).  
  
-   Customize the error message destination.  
  
-   Query for information about run-time check errors.  
  
## Customize the Error Message Destination  
 If you use `_CrtDbgReportW` to report errors, you can use `_CrtSetReportMode` to specify the destination of error messages.  
  
 If you use a custom reporting function, use `_RTC_SetErrorType` to associate an error with a report type.  
  
## Query for Information About Run-Time Checks  
 `_RTC_NumErrors` returns the number of error types detected by run-time error checks. To get a brief description of each error, you can loop from 0 to the return value of `_RTC_NumErrors`, passing the iteration value to `_RTC_GetErrDesc` on each loop. For more information, see [_RTC_NumErrors](/cpp/c-runtime-library/reference/rtc-numerrors) and [_RTC_GetErrDesc](/cpp/c-runtime-library/reference/rtc-geterrdesc).  
  
## See Also  
 [How to: Use Native Run-Time Checks](../debugger/how-to-use-native-run-time-checks.md)   
 [runtime_checks](/cpp/preprocessor/runtime-checks)   
 [_CrtDbgReport, _CrtDbgReportW](/cpp/c-runtime-library/reference/crtdbgreport-crtdbgreportw)