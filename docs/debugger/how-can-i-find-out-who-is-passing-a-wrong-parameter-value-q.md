---
title: Find out who is passing a wrong parameter value | Microsoft Docs
description: You can find out what code is calling your function and passing an incorrect parameter value. Learn how to use a conditional breakpoint to do this.

ms.date: 11/04/2016
ms.topic: how-to
f1_keywords: 
  - vs.debug.parameters
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords: 
  - debugging [C++], parameters
  - parameters [debugger]
  - passing parameters, troubleshooting wrong values
  - functions [debugger], detecting wrong parameter values
  - parameter values, troubleshooting
ms.assetid: 1f1ae455-0e25-4e9d-b33f-53908f5bd6ce
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---
# How Can I Find Out Who Is Passing a Wrong Parameter Value?
## Problem Description
 The wrong parameter value is being passed to one of my functions. This function is called from all over the place. How can I find out what is passing it the wrong value?

## Solution

#### To resolve this problem

1. Set a location breakpoint at the beginning of the function.

2. Right-click the breakpoint and select **Condition**.

3. In the **Breakpoint Condition** dialog box, click on the **Condition** check box. See [Advanced Breakpoints](../debugger/using-breakpoints.md#BKMK_Specify_a_breakpoint_condition_using_a_code_expression).

4. Enter an expression, such as `Var==3`, into the text box, where `Var` is the name of the parameter that contains the bad value, and `3` is the bad value passed to it.

5. Select the **is True** radio button, and click the **OK** button.

6. Now run the program again. The breakpoint causes the program to halt at the beginning of the function when the `Var` parameter has the value `3`.

7. Use the Call Stack window to find the calling function and navigate to its source code. For more information, see [How to: Use the Call Stack Window](../debugger/how-to-use-the-call-stack-window.md).

## See also
- [Debugging Native Code FAQs](../debugger/debugging-native-code-faqs.md)
- [Breakpoints](/previous-versions/ktf38f66(v=vs.100))
- [Debugging Native Code](../debugger/debugging-native-code.md)
