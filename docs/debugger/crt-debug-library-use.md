---
title: "CRT Debug Library Use | Microsoft Docs"
description: Learn how the C run-time (CRT) library supports your debugging efforts, and what you must do to use the CRT debug libraries.
ms.custom: SEO-VS-2020
ms.date: "10/03/2019"
ms.topic: "conceptual"
f1_keywords:
  - "c.debug.runtime"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
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
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# CRT Debug Library Use
The C run-time library provides extensive debugging support. To use one of the CRT debug libraries, you must link with [/DEBUG](/cpp/build/reference/debug-generate-debug-info) and compile with **/MDd**, **/MTd**, or **/LDd**.

## Remarks
 The main definitions and macros for CRT debugging can be found in the CRTDBG.h header file.

 The functions in the CRT debug libraries are compiled with debug information ([/Z7, /Zd, /Zi, /ZI (Debug Information Format)](/cpp/build/reference/z7-zi-zi-debug-information-format)) and without optimization. Some functions contain assertions to verify parameters that are passed to them, and source code is provided. With this source code, you can step into CRT functions to confirm that the functions are working as you expect and check for bad parameters or memory states. (Some CRT technology is proprietary and does not provide source code for exception handling, floating point, and a few other routines.)

 For more information on the various run-time libraries you can use, see [C Run-Time Libraries](/cpp/c-runtime-library/crt-library-features).

## See also

- [CRT Debugging Techniques](../debugger/crt-debugging-techniques.md)
- [/MD, /MT, /LD (Use Run-Time Library)](/cpp/build/reference/md-mt-ld-use-run-time-library)