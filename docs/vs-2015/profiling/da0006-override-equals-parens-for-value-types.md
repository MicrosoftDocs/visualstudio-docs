---
title: "DA0006: Override Equals() for value types | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
f1_keywords: 
  - "vs.performance.rules.DAOverrideEquals"
  - "vs.performance.6"
  - "vs.performance.DA0006"
  - "vs.performance.rules.DA0006"
ms.assetid: 4d85bdd6-b571-47e0-afd6-ba3764e4eed5
caps.latest.revision: 17
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# DA0006: Override Equals() for value types
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Rule Id|DA0006|  
|Category|.NET Framework Usage|  
|Profiiling methods|Sampling|  
|Message|Override Equals and equality operator on value types.|  
|Messge type|Warning|  
  
## Cause  
 Calls to the Equals method or the equality operators of a  public value type are a significant proportion of the profiling data. Consider implementing a more efficient method.  
  
## Rule Description  
 For value types, the inherited implementation of Equals uses the <xref:System.Reflection> library and compares the contents of all fields in the type. Reflection is computationally expensive, and comparing every field for equality might be unnecessary. If you expect users to compare or sort instances or to use them as hash table keys, your value type should implement Equals. If your programming language supports operator overloading, you should also provide an implementation of the equality and inequality operators.  
  
 For more information about how to override Equals and the equality operators, see [Guidelines for Implementing Equals and the Equality Operator (==)](https://go.microsoft.com/fwlink/?LinkId=177818).  
  
## How to Investigate a Warning  
 For an example of implementing the Equals and equality operators, see the code analysis rule [CA1815: Override equals and operator equals on value types](../code-quality/ca1815-override-equals-and-operator-equals-on-value-types.md)
