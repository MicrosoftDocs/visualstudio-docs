---
title: "Find which call failed when calling a function many times | Microsoft Docs"
ms.custom: "seodec18"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.debug.functions"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "conditional breakpoints"
  - "errors [debugger], function calls"
  - "breakpoints, troubleshooting"
  - "errors [debugger], finding which function call failed"
  - "failures"
  - "location breakpoint call failures"
  - "errors [Visual Studio], function calls"
  - "hit counts"
  - "function calls, failure"
  - "functions [debugger]"
  - "Skip Count"
ms.assetid: 66cfac86-f5be-4d3a-9329-d44cd74bc586
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# When Calling a Function Hundreds of Times, How Do I know Which Call Failed?
## Problem Description
 My program fails on a call to a certain function, `CnvtV`. The program probably calls that function a couple hundred times before it fails. If I set a location breakpoint on `CnvtV`, the program stops on every call to that function, and I do not want that. I do not know what conditions cause the call to fail, so I cannot set a conditional breakpoint. What can I do?

## Solution
 You can set a breakpoint on the function with the **Hit Count** field to a value so high that it will never be reached. In this case, because you believe the function `CnvtV` is called a couple hundred times, you might set **Hit Count** to 1000 or more. Then run the program and wait for the call to fail. When it fails, open the Breakpoints window and look at the list of breakpoints. The breakpoint you set on `CnvtV` appears, followed by the hit count and number of iterations remaining:

```cpp
CnvtV(int) (no condition) when hit count is equal to 1000 (currently 101)
```

 You now know that the function failed on the 101st call. If you reset the breakpoint with a hit count of 101 and run the program again, the program stops at the call to `CnvtV` that caused it to fail.

## See also
- [Debugging Native Code FAQs](../debugger/debugging-native-code-faqs.md)
- [Setting Breakpoints](https://msdn.microsoft.com/library/fe4eedc1-71aa-4928-962f-0912c334d583)
- [Debugging Native Code](../debugger/debugging-native-code.md)
