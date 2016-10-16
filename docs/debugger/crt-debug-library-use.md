---
title: "CRT Debug Library Use"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
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
caps.latest.revision: 16
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
# CRT Debug Library Use
The C run-time library provides extensive debugging support. To use one of the CRT debug libraries, you must link with [/DEBUG](../Topic/-DEBUG%20\(Generate%20Debug%20Info\).md) and compile with **/MDd**, **/MTd**, or **/LDd**.  
  
## Remarks  
 The main definitions and macros for CRT debugging can be found in the CRTDBG.h header file.  
  
 The functions in the CRT debug libraries are compiled with debug information ([/Z7, /Zd, /Zi, /ZI (Debug Information Format)](../Topic/-Z7,%20-Zi,%20-ZI%20\(Debug%20Information%20Format\).md)) and without optimization. Some functions contain assertions to verify parameters that are passed to them, and source code is provided. With this source code, you can step into CRT functions to confirm that the functions are working as you expect and check for bad parameters or memory states. (Some CRT technology is proprietary and does not provide source code for exception handling, floating point, and a few other routines.)  
  
 When you install Visual C++, you have the option of installing the C run-time library source code on your hard disk. If you do not install the source code, you will need the CD-ROM to step into CRT functions.  
  
 For more information on the various run-time libraries you can use, see [C Run-Time Libraries](../Topic/CRT%20Library%20Features.md).  
  
## See Also  
 [CRT Debugging Techniques](../debugger/crt-debugging-techniques.md)   
 [/MD, /MT, /LD (Use Run-Time Library)](../Topic/-MD,%20-MT,%20-LD%20\(Use%20Run-Time%20Library\).md)