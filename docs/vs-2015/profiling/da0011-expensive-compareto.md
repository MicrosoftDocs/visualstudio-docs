---
title: "DA0011: Expensive CompareTo | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
f1_keywords: 
  - "vs.performance.DA0011"
  - "vs.performance.rules.DAExpensiveCompareTo"
  - "vs.performance.11"
  - "vs.performance.rules.DA0011"
ms.assetid: 239a381d-0d97-4367-8668-746c93f5af2c
caps.latest.revision: 12
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# DA0011: Expensive CompareTo
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

For the latest documentation on Visual Studio, see [DA0011: Expensive CompareTo](https://docs.microsoft.com/visualstudio/profiling/da0011-expensive-compareto).  
  
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
