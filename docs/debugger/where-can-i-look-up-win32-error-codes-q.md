---
title: "Where Can I Look Up Win32 Error Codes? | Microsoft Docs"
description: To look up a Win32 error code, enter it in Watch or QuickWatch. For example, "0x80000004,hr". The error code definitions are in INCLUDE\WINERROR.H.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vc.errors"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "error codes, Win32"
  - "Win32, error codes"
ms.assetid: 8fb4ff42-b8eb-4152-b49e-b802d194b05e
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Where Can I Look Up Win32 Error Codes?
WINERROR.H in the INCLUDE directory of your default system installation contains the error code definitions for the Win32 API functions.

 You can look up an error code by typing the code in the **Watch** window or the **QuickWatch** dialog box. For example:

`0x80000004,hr`

## See also
- [Debugging Native Code FAQs](../debugger/debugging-native-code-faqs.md)
- [Debugging Native Code](../debugger/debugging-native-code.md)