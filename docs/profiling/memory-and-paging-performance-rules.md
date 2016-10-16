---
title: "Memory and Paging Performance Rules"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: f37972b2-efe4-4a1c-a5d1-a246ccd76817
caps.latest.revision: 8
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
# Memory and Paging Performance Rules
Performance rules in the memory and paging category identify paging activity in a profiling run that can impact application performance and responsiveness.  
  
|||  
|-|-|  
|[DA0014: Extremely high rates of paging active memory to disk](../profiling/da0014--extremely-high-rates-of-paging-active-memory-to-disk.md)|An extremely high rate of paging active memory to and from the disk occurred throughout the profiling run. Paging rates at this level usually impact application performance and responsiveness. Consider reducing memory allocations by revising algorithms. You might also have to consider the memory requirements of your application. Try running profiling again on a computer that has more memory. This rule fires when the amount of paging activity exceeds the upper threshold of rule D0017.|  
|[DA0017: High rates of paging active memory to disk](../profiling/da0017--high-rates-of-paging-active-memory-to-disk.md)|A relatively high rate of paging active memory to and from the disk occurred throughout the profiling run. Paging rates at this level usually impact application performance and responsiveness. Consider reducing memory allocations by revising algorithms. You might also have to consider the memory requirements of your application. Try running profiling again on a computer that has more memory.|