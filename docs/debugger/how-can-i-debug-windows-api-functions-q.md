---
title: Debug Windows API functions | Microsoft Docs
description: Learn how to debug a Windows API function that has NT symbols loaded. In 32-bit code you use the decorated form of the function name to set the breakpoint.

ms.date: 06/03/2020
ms.topic: how-to
f1_keywords: 
  - vs.debug.api
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords: 
  - debugging [C++], Windows API functions
  - NT symbols and debugging Windows API functions
  - Windows API functions, debugging
  - Windows API, debugging API functions
  - APIs, debugging
ms.assetid: 7c126f57-62ab-4d94-9805-632d696ba1f0
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---
# How Can I Debug Windows API Functions?
If you want to debug a Windows API function that has NT symbols loaded, you must do the following.

### To set a breakpoint on a Windows API function with NT symbols loaded

- In the [function breakpoint](../debugger/using-breakpoints.md#BKMK_Set_a_breakpoint_in_a_source_file), enter the function name together with the name of the DLL where the function resides (see the [context operator](../debugger/context-operator-cpp.md)). In 32-bit code, use the decorated form of the function name. To set a breakpoint on **MessageBeep**, for example, you must enter the following.

    ```cpp
    {,,USER32.DLL}_MessageBeep@4
    ```

     To obtain the decorated name, see [Viewing Decorated Names](/previous-versions/5x49w699(v=vs.140)).

     You can test the decorated name and view it in disassembly code. While paused at the function in the Visual Studio debugger, right-click the function in the code editor or call stack window and choose **Go to Disassembly**.

- In 64-bit code, you can use the undecorated name.

    ```cpp
    {,,USER32.DLL}MessageBeep
    ```

## See also
- [Debugging Native Code FAQs](../debugger/debugging-native-code-faqs.md)
- [Debugging Native Code](../debugger/debugging-native-code.md)
