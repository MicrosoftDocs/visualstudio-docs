---
title: "CA2218: Override GetHashCode on overriding Equals | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2218"
  - "OverrideGetHashCodeOnOverridingEquals"
helpviewer_keywords:
  - "OverrideGetHashCodeOnOverridingEquals"
  - "CA2218"
ms.assetid: 69b020cd-29e8-45a6-952e-32cf3ce2e21d
caps.latest.revision: 22
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2218: Override GetHashCode on overriding Equals
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|OverrideGetHashCodeOnOverridingEquals|
|CheckId|CA2218|
|Category|Microsoft.Usage|
|Breaking Change|Non Breaking|

## Cause
 A public type overrides <xref:System.Object.Equals%2A?displayProperty=fullName> but does not override <xref:System.Object.GetHashCode%2A?displayProperty=fullName>.

## Rule Description
 <xref:System.Object.GetHashCode%2A> returns a value, based on the current instance, that is suited for hashing algorithms and data structures such as a hash table. Two objects that are the same type and are equal must return the same hash code to ensure that instances of the following types work correctly:

- <xref:System.Collections.Hashtable?displayProperty=fullName>

- <xref:System.Collections.SortedList?displayProperty=fullName>

- <xref:System.Collections.Generic.Dictionary%602?displayProperty=fullName>

- <xref:System.Collections.Generic.SortedDictionary%602?displayProperty=fullName>

- <xref:System.Collections.Generic.SortedList%602?displayProperty=fullName>

- <xref:System.Collections.Specialized.HybridDictionary?displayProperty=fullName>

- <xref:System.Collections.Specialized.ListDictionary?displayProperty=fullName>

- <xref:System.Collections.Specialized.OrderedDictionary?displayProperty=fullName>

- Types that implement <xref:System.Collections.Generic.IEqualityComparer%601?displayProperty=fullName>

## How to Fix Violations
 To fix a violation of this rule, provide an implementation of <xref:System.Object.GetHashCode%2A>. For a pair of objects of the same type, you must ensure that the implementation returns the same value if your implementation of <xref:System.Object.Equals%2A> returns `true` for the pair.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Class Example

### Description
 The following example shows a class (reference type) that violates this rule.

### Code
 [!code-csharp[FxCop.Usage.GetHashCodeErrorClass#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.GetHashCodeErrorClass/cs/FxCop.Usage.GetHashCodeErrorClass.cs#1)]

### Comments
 The following example fixes the violation by overriding <xref:System.Object.GetHashCode>.

### Code
 [!code-csharp[FxCop.Usage.GetHashCodeFixedClass#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.GetHashCodeFixedClass/cs/FxCop.Usage.GetHashCodeFixedClass.cs#1)]

## Structure Example

### Description
 The following example shows a structure (value type) that violates this rule.

### Code
 [!code-csharp[FxCop.Usage.GetHashCodeErrorStruct#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.GetHashCodeErrorStruct/cs/FxCop.Usage.GetHashCodeErrorStruct.cs#1)]

### Comments
 The following example fixes the violation by overriding <xref:System.Object.GetHashCode>.

### Code
 [!code-csharp[FxCop.Usage.GetHashCodeFixedStruct#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.GetHashCodeFixedStruct/cs/FxCop.Usage.GetHashCodeFixedStruct.cs#1)]

## Related Rules
 [CA1046: Do not overload operator equals on reference types](../code-quality/ca1046-do-not-overload-operator-equals-on-reference-types.md)

 [CA2225: Operator overloads have named alternates](../code-quality/ca2225-operator-overloads-have-named-alternates.md)

 [CA2226: Operators should have symmetrical overloads](../code-quality/ca2226-operators-should-have-symmetrical-overloads.md)

 [CA2224: Override equals on overloading operator equals](../code-quality/ca2224-override-equals-on-overloading-operator-equals.md)

 [CA2231: Overload operator equals on overriding ValueType.Equals](../code-quality/ca2231-overload-operator-equals-on-overriding-valuetype-equals.md)

## See also

- <xref:System.Object.Equals%2A?displayProperty=fullName>
- <xref:System.Object.GetHashCode%2A?displayProperty=fullName>
- <xref:System.Collections.Hashtable?displayProperty=fullName>
- [Equality Operators](https://msdn.microsoft.com/library/bc496a91-fefb-4ce0-ab4c-61f09964119a)