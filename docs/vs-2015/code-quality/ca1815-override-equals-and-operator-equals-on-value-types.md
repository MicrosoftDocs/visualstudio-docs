---
title: "CA1815: Override equals and operator equals on value types | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1815"
  - "OverrideEqualsAndOperatorEqualsOnValueTypes"
helpviewer_keywords:
  - "OverrideEqualsAndOperatorEqualsOnValueTypes"
  - "CA1815"
ms.assetid: 0a8ab3a3-ee8e-46f7-985d-dcf00c89363b
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1815: Override equals and operator equals on value types
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|OverrideEqualsAndOperatorEqualsOnValueTypes|
|CheckId|CA1815|
|Category|Microsoft.Performance|
|Breaking Change|Non-breaking|

## Cause
 A public value type does not override <xref:System.Object.Equals%2A?displayProperty=fullName>, or does not implement the equality operator (==). This rule does not check enumerations.

## Rule Description
 For value types, the inherited implementation of <xref:System.Object.Equals%2A> uses the Reflection library, and compares the contents of all fields. Reflection is computationally expensive, and comparing every field for equality might be unnecessary. If you expect users to compare or sort instances, or use them as hash table keys, your value type should implement <xref:System.Object.Equals%2A>. If your programming language supports operator overloading, you should also provide an implementation of the equality and inequality operators.

## How to Fix Violations
 To fix a violation of this rule, provide an implementation of <xref:System.Object.Equals%2A>. If you can, implement the equality operator.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule if instances of the value type will not be compared to each other.

## Example of a Violation

### Description
 The following example shows a structure (value type) that violates this rule.

### Code
 [!code-csharp[FxCop.Performance.OverrideEqualsViolation#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Performance.OverrideEqualsViolation/cs/FxCop.Performance.OverrideEqualsViolation.cs#1)]

## Example of How to Fix

### Description
 The following example fixes the previous violation by overriding <xref:System.ValueType.Equals%2A?displayProperty=fullName> and implementing the equality operators (==, !=).

### Code
 [!code-csharp[FxCop.Performance.OverrideEqualsFixed#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Performance.OverrideEqualsFixed/cs/FxCop.Performance.OverrideEqualsFixed.cs#1)]

## Related Rules
 [CA2224: Override equals on overloading operator equals](../code-quality/ca2224-override-equals-on-overloading-operator-equals.md)

 [CA2231: Overload operator equals on overriding ValueType.Equals](../code-quality/ca2231-overload-operator-equals-on-overriding-valuetype-equals.md)

 [CA2226: Operators should have symmetrical overloads](../code-quality/ca2226-operators-should-have-symmetrical-overloads.md)

## See Also
 <xref:System.Object.Equals%2A?displayProperty=fullName>
