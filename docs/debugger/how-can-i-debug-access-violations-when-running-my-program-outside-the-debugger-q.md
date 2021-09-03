---
title: Debug access violations when running app outside Visual Studio
titleSuffix: ""
description: Use the Just-in-Time Debugger to debug an access violation that occurs outside the Visual Studio environment.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
f1_keywords: 
  - vs.debug.access
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords: 
  - access violation debugging
  - debugging [Visual Studio], access violations
ms.assetid: 780a298a-132e-4245-8370-8c82ca27c6c1
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---
# How Can I Debug Access Violations When Running My Program Outside the Debugger?

## Problem Description
 My program runs fine in the Visual Studio environment, but when I run it stand-alone with the Windows operating system, it produces an access violation. How can I debug this problem?

## Solution
 Set the [Just-in-time debugging](../debugger/just-in-time-debugging-in-visual-studio.md) option and run your program stand-alone until the access violation occurs. Then, in the **Access Violation** dialog box, you can click **Cancel** to start the debugger.

## See also
- [Debugging Native Code FAQs](../debugger/debugging-native-code-faqs.md)
- [Debugging Native Code](../debugger/debugging-native-code.md)