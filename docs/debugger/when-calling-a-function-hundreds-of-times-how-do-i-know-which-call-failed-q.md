---
title: "When Calling a Function Hundreds of Times, How Do I know Which Call Failed? | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.debug.functions"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
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
caps.latest.revision: 17
author: "mikejo5000"
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
# When Calling a Function Hundreds of Times, How Do I know Which Call Failed?
## Problem Description  
 My program fails on a call to a certain function, `CnvtV`. The program probably calls that function a couple hundred times before it fails. If I set a location breakpoint on `CnvtV`, the program stops on every call to that function, and I do not want that. I do not know what conditions cause the call to fail, so I cannot set a conditional breakpoint. What can I do?  
  
## Solution  
 You can set a breakpoint on the function with the **Hit Count** field to a value so high that it will never be reached. In this case, because you believe the function `CnvtV` is called a couple hundred times, you might set **Hit Count** to 1000 or more. Then run the program and wait for the call to fail. When it fails, open the Breakpoints window and look at the list of breakpoints. The breakpoint you set on `CnvtV` appears, followed by the hit count and number of iterations remaining:  
  
```  
CnvtV(int) (no condition) when hit count is equal to 1000 (currently 101)  
```  
  
 You now know that the function failed on the 101st call. If you reset the breakpoint with a hit count of 101 and run the program again, the program stops at the call to `CnvtV` that caused it to fail.  
  
## See Also  
 [Debugging Native Code FAQs](../debugger/debugging-native-code-faqs.md)   
 [Setting Breakpoints](http://msdn.microsoft.com/en-us/fe4eedc1-71aa-4928-962f-0912c334d583)   
 [Debugging Native Code](../debugger/debugging-native-code.md)