---
title: "Debug Windows API functions | Microsoft Docs"
ms.custom: "seodec18"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.debug.api"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "debugging [C++], Windows API functions"
  - "NT symbols and debugging Windows API functions"
  - "Windows API functions, debugging"
  - "Windows API, debugging API functions"
  - "APIs, debugging"
ms.assetid: 7c126f57-62ab-4d94-9805-632d696ba1f0
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# How Can I Debug Windows API Functions?
If you want to debug a Windows API function that has NT symbols loaded, you must do the following.

### To set a breakpoint on a Windows API function with NT symbols loaded

- Enter the function name together with the name of the DLL where the function resides. In 32-bit code, use the decorated form of the function name. To set a breakpoint on **MessageBeep**, for example, you must enter the following.

    ```cpp
    {,,USER32.DLL}_MessageBeep@4
    ```

     To obtain the decorated name, see [Viewing Decorated Names](https://msdn.microsoft.com/library/f79e2717-a4db-4d12-a689-69830cce2be0).

## See also
- [Debugging Native Code FAQs](../debugger/debugging-native-code-faqs.md)
- [Debugging Native Code](../debugger/debugging-native-code.md)
