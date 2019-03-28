---
title: "Macros for Reporting | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug.macros"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "C++"
helpviewer_keywords: 
  - "macros, CRT reporting macros"
  - "macros, debugging with"
  - "_RPTFn macro"
  - "CRT, reporting macros"
  - "debugging [CRT], reporting macros"
  - "_RPTn macro"
ms.assetid: f2085314-a3a8-4caf-a5a4-2af9ad5aad05
caps.latest.revision: 18
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Macros for Reporting
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can use the **_RPTn**, and **_RPTFn** macros, defined in CRTDBG.H, to replace the use of `printf` statements for debugging. These macros automatically disappear in your release build when **_DEBUG** is not defined, so there is no need to enclose them in **#ifdef**s.  
  
|Macro|Description|  
|-----------|-----------------|  
|**_RPT0**, **_RPT1**, **_RPT2**, **_RPT3**, **_RPT4**|Outputs a message string and zero to four arguments. For _RPT1 through **_RPT4**, the message string serves as a printf-style formatting string for the arguments.|  
|**_RPTF0**, **_RPTF1**, **,_RPTF2**, **_RPTF4**|Same as **_RPTn** , but these macros also output the file name and line number where the macro is located.|  
  
 Consider the following example:  
  
```  
#ifdef _DEBUG  
    if ( someVar > MAX_SOMEVAR )  
        printf( "OVERFLOW! In NameOfThisFunc( ),  
               someVar=%d, otherVar=%d.\n",  
               someVar, otherVar );  
#endif  
```  
  
 This code outputs the values of `someVar` and `otherVar` to **stdout**. You can use the following call to `_RPTF2` to report these same values and, additionally, the file name and line number:  
  
```  
if (someVar > MAX_SOMEVAR) _RPTF2(_CRT_WARN, "In NameOfThisFunc( ), someVar= %d, otherVar= %d\n", someVar, otherVar );  
```  
  
 If you find that a particular application needs debug reporting that the macros supplied with the C run-time library do not provide, you can write a macro designed specifically to fit your own requirements. In one of your header files, for example, you could include code like the following to define a macro called **ALERT_IF2**:  
  
```  
#ifndef _DEBUG                  /* For RELEASE builds */  
#define  ALERT_IF2(expr, msg, arg1, arg2)  do {} while (0)  
#else                           /* For DEBUG builds   */  
#define  ALERT_IF2(expr, msg, arg1, arg2) \  
    do { \  
        if ((expr) && \  
            (1 == _CrtDbgReport(_CRT_ERROR, \  
                __FILE__, __LINE__, msg, arg1, arg2))) \  
            _CrtDbgBreak( ); \  
    } while (0)  
#endif  
```  
  
 One call to **ALERT_IF2** could perform all the functions of the **printf** code at the start of this topic:  
  
```  
ALERT_IF2(someVar > MAX_SOMEVAR, "OVERFLOW! In NameOfThisFunc( ),   
someVar=%d, otherVar=%d.\n", someVar, otherVar );  
```  
  
 Because a custom macro can easily be changed to report more or less information to different destinations (depending on what is more convenient), this approach can be particularly useful as your debugging requirements evolve.  
  
## See Also  
 [CRT Debugging Techniques](../debugger/crt-debugging-techniques.md)
