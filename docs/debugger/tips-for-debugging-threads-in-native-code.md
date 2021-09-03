---
title: "Tips for Debugging Threads in Native Code | Microsoft Docs"
description: Read a list of tips for debugging threads in native code if you are debugging multithreaded apps in Visual Studio.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "threading [Visual Studio], debugging"
  - "debugging [Visual Studio], threads"
ms.assetid: 0374c8c6-57a3-4cfe-8047-2effef5ff5dc
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "cplusplus"
---
# Tips for Debugging Threads in Native Code
Here are some tips you can use when debugging threads in native code:

- You can view the contents of the Thread Information Block by typing `@TIB` in the **Watch** window or **QuickWatch** dialog box.

- You can view the last error code for the current thread by entering `@Err` in the **Watch** window or **QuickWatch** dialog box.

- C Run-Time Libraries (CRT) functions can be useful for debugging a multithreaded application. For more information, see [_malloc_dbg](/cpp/c-runtime-library/reference/malloc-dbg).

## See also
- [Debug Multithreaded Applications](../debugger/debug-multithreaded-applications-in-visual-studio.md)
- [Debugging Native Code](../debugger/debugging-native-code.md)