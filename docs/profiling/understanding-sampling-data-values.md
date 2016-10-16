---
title: "Understanding Sampling Data Values"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "sampling profiling method"
  - "Profiling Tools, sampling"
ms.assetid: fad540a8-24b6-4ff9-91ce-e67e9a58399d
caps.latest.revision: 22
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Understanding Sampling Data Values
The *sampling* profiling method of the [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] Profiling Tools interrupts the computer processor at set intervals and collects the function call stack. A *call stack* is a dynamic structure that stores information about the functions that are executing on the processor.  
  
 **Requirements**  
  
-   [!INCLUDE[vsUltLong](../codequality/includes/vsultlong_md.md)], [!INCLUDE[vsPreLong](../codequality/includes/vsprelong_md.md)], [!INCLUDE[vsPro](../codequality/includes/vspro_md.md)]  
  
 The profiler analysis determines whether the processor is executing code in the target process. If the processor is not executing code in the target process, the sample is discarded.  
  
 If the processor is executing the target code, the profiler increments the sample counts for each function on the call stack. At the time that the sample is taken, only one function on the call stack is currently executing code. The other functions on the stack are parents in the hierarchy of function calls that are waiting for their children to return.  
  
 For the sample event, the profiler increments the *exclusive* sample count of the function that is currently executing its instructions. Because an exclusive sample is also part of the total (*inclusive*) samples of the function, the inclusive sample count of the currently active function is also incremented.  
  
 The profiler increments the inclusive sample count of all other functions on the call stack.  
  
## Inclusive samples  
 The total number of samples that are collected during the execution of the target function.  
  
 This includes samples that are collected during the direct execution of the function code and samples that are collected during the execution of child functions that are called by the target function.  
  
## Exclusive samples  
 The number of samples that are collected during the direct execution of the instructions of the target function.  
  
 Exclusive samples do not include samples that are collected during the execution of functions that are called by the target function.  
  
## Inclusive percent  
 The percentage of the total number of inclusive samples in the profiling run that are inclusive samples of the function or data range.  
  
## Exclusive percent  
 The percentage of the total number of exclusive samples in the profiling run that are exclusive samples of the function or data range.  
  
## See Also  
 [How to: Choose Collection Methods](../profiling/how-to--choose-collection-methods.md)   
 [Analyzing Performance Tools Data](../profiling/analyzing-performance-tools-data.md)