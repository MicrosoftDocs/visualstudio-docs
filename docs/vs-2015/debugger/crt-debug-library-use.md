---
title: "CRT Debug Library Use | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "c.debug.runtime"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "C++"
helpviewer_keywords: 
  - "/DEBUG linker option [C++]"
  - "crtdbg.h file"
  - "debug library"
  - "MDd compiler option [C++]"
  - "libraries, CRT debug library"
  - "MTd compiler option [C++]"
  - "LDd compiler function [C++]"
  - "/MTd compiler option [C++]"
  - "/MDd compiler option [C++]"
  - "debugging [CRT], CRT debug library"
  - "DEBUG linker option [C++]"
  - "/LDd compiler function [C++]"
ms.assetid: 464de16b-4215-4787-9bfa-921aaff9d9f4
caps.latest.revision: 19
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# CRT Debug Library Use
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The C run-time library provides extensive debugging support. To use one of the CRT debug libraries, you must link with [/DEBUG](https://msdn.microsoft.com/library/1af389ae-3f8b-4d76-a087-1cdf861e9103) and compile with **/MDd**, **/MTd**, or **/LDd**.  
  
## Remarks  
 The main definitions and macros for CRT debugging can be found in the CRTDBG.h header file.  
  
 The functions in the CRT debug libraries are compiled with debug information ([/Z7, /Zd, /Zi, /ZI (Debug Information Format)](https://msdn.microsoft.com/library/ce9fa7e1-0c9b-47e3-98ea-26d1a16257c8)) and without optimization. Some functions contain assertions to verify parameters that are passed to them, and source code is provided. With this source code, you can step into CRT functions to confirm that the functions are working as you expect and check for bad parameters or memory states. (Some CRT technology is proprietary and does not provide source code for exception handling, floating point, and a few other routines.)  
  
 When you install Visual C++, you have the option of installing the C run-time library source code on your hard disk. If you do not install the source code, you will need the CD-ROM to step into CRT functions.  
  
 For more information on the various run-time libraries you can use, see [C Run-Time Libraries](https://msdn.microsoft.com/library/a889fd39-807d-48f2-807f-81492612463f).  
  
## See Also  
 [CRT Debugging Techniques](../debugger/crt-debugging-techniques.md)   
 [/MD, /MT, /LD (Use Run-Time Library)](https://msdn.microsoft.com/library/cf7ed652-dc3a-49b3-aab9-ad60e5395579)
