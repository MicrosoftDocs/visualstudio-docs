---
title: "DA0010: Expensive GetHashCode | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
f1_keywords: 
  - "vs.performance.rules.DAExpensiveGetHashCode"
  - "vs.performance.DA0010"
  - "vs.performance.rules.DA0010"
  - "vs.performance.10"
ms.assetid: 3987e21a-5b4f-45e4-8a33-6b3f0a472c08
caps.latest.revision: 16
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# DA0010: Expensive GetHashCode
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

For the latest documentation on Visual Studio, see [DA0010: Expensive GetHashCode](https://docs.microsoft.com/visualstudio/profiling/da0010-expensive-gethashcode).  

|||  
|-|-|  
|Rule Id|DA0010|  
|Category|.NET Framework Usage|  
|Profiling methods|Sampling<br /><br /> .NET Memory|  
|Message|GetHashCode functions should be cheap and not allocate any memory. Reduce complexity of hash code function if possible.|  
|Message type|Warning|  
  
## Cause  
 Calls to the GetHashCode method of the type are a significant proportion of the profiling data or the method allocates memory.  
  
## Rule Description  
 Hashing is a technique for rapidly locating a particular item in a large collection. Because hash tables can be very large and have to support high rates of access, hash tables should be extremely efficient. An implication of this requirement is that GetHashCode methods in the .NET Framework should not allocate memory. Allocating memory increases the load on the garbage collector and exposes the method to potential delays if it becomes necessary to run garbage collection as a result of the allocation request.  
  
## How to Fix Violations  
 Reduce the complexity of the method.
