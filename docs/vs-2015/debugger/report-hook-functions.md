---
title: "Report Hook Functions | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug.hooks"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "C++"
helpviewer_keywords: 
  - "hooks, report"
  - "_CrtDbgReport function"
  - "debugger, report hook functions"
  - "memory allocation, debug heap"
  - "debugging [C++], hook functions"
  - "_CrtSetReportHook function"
  - "report hook functions"
ms.assetid: 1854bca7-d7eb-4502-89bf-b1ee64cb50ef
caps.latest.revision: 18
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Report Hook Functions
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

A report hook function, installed using [_CrtSetReportHook](https://msdn.microsoft.com/library/1ae7c64f-8c84-4797-9574-b59f00f7a509), is called every time [_CrtDbgReport](https://msdn.microsoft.com/library/6e581fb6-f7fb-4716-9432-f0145d639ecc) generates a debug report. You can use it, among other things, for filtering reports to focus on specific types of allocations. A report hook function should have a prototype like the following:  
  
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
 [Debug Hook Function Writing](../debugger/debug-hook-function-writing.md)   
 [crt_dbg2 Sample](https://msdn.microsoft.com/21e1346a-6a17-4f57-b275-c76813089167)
