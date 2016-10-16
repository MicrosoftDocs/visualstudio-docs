---
title: "DA0011: Expensive CompareTo"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.performance.DA0011"
  - "vs.performance.rules.DAExpensiveCompareTo"
  - "vs.performance.11"
  - "vs.performance.rules.DA0011"
ms.assetid: 239a381d-0d97-4367-8668-746c93f5af2c
caps.latest.revision: 9
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
# DA0011: Expensive CompareTo
|||  
|-|-|  
|Rule Id|DA0011|  
|Category|.NET Framework Usage|  
|Profiling methods|Sampling<br /><br /> .NET Memory|  
|Message|CompareTo functions should be cheap and not allocate any memory. Reduce complexity of CompareTo function if possible.|  
|Rule type|Warning|  
  
## Cause  
 The CompareTo method of the type is expensive or allocates memory.  
  
## Rule Description  
 CompareTo methods should be efficient and should not allocate memory.  
  
## How to Fix Violations  
 Reduce the complexity of the CompareTo method.