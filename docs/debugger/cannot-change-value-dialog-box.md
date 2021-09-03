---
title: "Cannot Change Value Dialog Box | Microsoft Docs"
description: Review the Cannot Change Value dialog box, which appears in Visual Studio if you try to change a variable to an illegal value in a debugger window or QuickWatch.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "reference"
f1_keywords:
  - "vs.debug.variables.failededit"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "Cannot Change Value dialog box"
  - "variables [debugger], editing"
ms.assetid: 19e930c2-5fbf-4c83-aae8-a1dc3f8fcae8
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Cannot Change Value Dialog Box
## Error
 `The value of this variable cannot be changed` &#124; `The name` *name* `does not exist in the current context` &#124; *various other messages*

 This message box appears when you try to change the contents of a variable to an illegal value in a debugger window (Autos, Watch, or Locals windows) or in the QuickWatch dialog box. For example, if you try to set the value of an integer variable to a character string, this message box appears.

## Solution
 Make sure the input you type into the debugger window or QuickWatch dialog box represents a legal value for the variable you are trying to set.

## See also

- [Expressions in the Debugger](../debugger/expressions-in-the-debugger.md)