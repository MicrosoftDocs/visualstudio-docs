---
title: "DA0006: Override Equals() for value types"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 4d85bdd6-b571-47e0-afd6-ba3764e4eed5
caps.latest.revision: 12
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# DA0006: Override Equals() for value types
|||  
|-|-|  
|Rule Id|DA0006|  
|Category|.NET Framework Usage|  
|Profiiling methods|Sampling|  
|Message|Override Equals and equality operator on value types.|  
|Messge type|Warning|  
  
## Cause  
 Calls to the Equals method or the equality operators of a  public value type are a significant proportion of the profiling data. Consider implementing a more efficient method.  
  
## Rule Description  
 For value types, the inherited implementation of Equals uses the <xref:System.Reflection?qualifyHint=False> library and compares the contents of all fields in the type. Reflection is computationally expensive, and comparing every field for equality might be unnecessary. If you expect users to compare or sort instances or to use them as hash table keys, your value type should implement Equals. If your programming language supports operator overloading, you should also provide an implementation of the equality and inequality operators.  
  
 For more information about how to override Equals and the equality operators, see [Guidelines for Implementing Equals and the Equality Operator (==)](http://go.microsoft.com/fwlink/?LinkId=177818).  
  
## How to Investigate a Warning  
 For an example of implementing the Equals and equality operators, see the code analysis rule [CA1815: Override equals and operator equals on value types](../VS_IDE/CA1815--Override-equals-and-operator-equals-on-value-types.md)