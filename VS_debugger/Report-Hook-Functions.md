---
title: "Report Hook Functions"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 1854bca7-d7eb-4502-89bf-b1ee64cb50ef
caps.latest.revision: 15
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
# Report Hook Functions
A report hook function, installed using [_CrtSetReportHook](../Topic/_CrtSetReportHook.md), is called every time [_CrtDbgReport](../Topic/_CrtDbgReport,%20_CrtDbgReportW.md) generates a debug report. You can use it, among other things, for filtering reports to focus on specific types of allocations. A report hook function should have a prototype like the following:  
  
```  
int YourReportHook(int nRptType, char *szMsg, int *retVal);  
```  
  
 The pointer that you pass to **_CrtSetReportHook** is of type **_CRT_REPORT_HOOK**, as defined in CRTDBG.H:  
  
```  
typedef int (__cdecl *_CRT_REPORT_HOOK)(int, char *, int *);  
```  
  
 When the run-time library calls your hook function, the *nRptType* argument contains the category of the report (**_CRT_WARN**, **_CRT_ERROR**, or **_CRT_ASSERT**), *szMsg* contains a pointer to a fully assembled report message string, and *retVal* specifies whether `_CrtDbgReport` should continue normal execution after generating the report or start the debugger. (A *retVal* value of zero continues execution, a value of 1 starts the debugger.)  
  
 If the hook handles the message in question completely, so that no further reporting is required, it should return **TRUE**. If it returns **FALSE**, `_CrtDbgReport` will report the message normally.  
  
## See Also  
 [Debug Hook Function Writing](../VS_debugger/Debug-Hook-Function-Writing.md)   
 [crt_dbg2 Sample](assetId:///21e1346a-6a17-4f57-b275-c76813089167)