---
title: "CA1815: Override equals and operator equals on value types"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 0a8ab3a3-ee8e-46f7-985d-dcf00c89363b
caps.latest.revision: 17
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# CA1815: Override equals and operator equals on value types
|||  
|-|-|  
|TypeName|OverrideEqualsAndOperatorEqualsOnValueTypes|  
|CheckId|CA1815|  
|Category|Microsoft.Performance|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A public value type does not override <xref:System.Object.Equals?qualifyHint=True>, or does not implement the equality operator (==). This rule does not check enumerations.  
  
## Rule Description  
 For value types, the inherited implementation of <xref:System.Object.Equals?qualifyHint=False> uses the Reflection library, and compares the contents of all fields. Reflection is computationally expensive, and comparing every field for equality might be unnecessary. If you expect users to compare or sort instances, or use them as hash table keys, your value type should implement <xref:System.Object.Equals?qualifyHint=False>. If your programming language supports operator overloading, you should also provide an implementation of the equality and inequality operators.  
  
## How to Fix Violations  
 To fix a violation of this rule, provide an implementation of <xref:System.Object.Equals?qualifyHint=False>. If you can, implement the equality operator.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if instances of the value type will not be compared to each other.  
  
## Example of a Violation  
  
### Description  
 The following example shows a structure (value type) that violates this rule.  
  
### Code  
 [!CODE [FxCop.Performance.OverrideEqualsViolation#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Performance.OverrideEqualsViolation#1)]  
  
## Example of How to Fix  
  
### Description  
 The following example fixes the previous violation by overriding <xref:System.ValueType.Equals?qualifyHint=True> and implementing the equality operators (==, !=).  
  
### Code  
 [!CODE [FxCop.Performance.OverrideEqualsFixed#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Performance.OverrideEqualsFixed#1)]  
  
## Related Rules  
 [CA2224: Override equals on overloading operator equals](../VS_IDE/CA2224--Override-equals-on-overloading-operator-equals.md)  
  
 [CA2231: Overload operator equals on overriding ValueType.Equals](../VS_IDE/CA2231--Overload-operator-equals-on-overriding-ValueType.Equals.md)  
  
 [CA2226: Operators should have symmetrical overloads](../VS_IDE/CA2226--Operators-should-have-symmetrical-overloads.md)  
  
## See Also  
 <xref:System.Object.Equals?qualifyHint=True>