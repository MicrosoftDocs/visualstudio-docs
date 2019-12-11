---
title: "CA1036: Override methods on comparable types | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1036"
  - "OverrideMethodsOnComparableTypes"
helpviewer_keywords:
  - "OverrideMethodsOnComparableTypes"
  - "CA1036"
ms.assetid: 2329f844-4cb8-426d-bee2-cd065d1346d0
caps.latest.revision: 23
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1036: Override methods on comparable types
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|OverrideMethodsOnComparableTypes|
|CheckId|CA1036|
|Category|Microsoft.Design|
|Breaking Change|Non-breaking|

## Cause
 A public or protected type implements the <xref:System.IComparable?displayProperty=fullName> interface and does not override <xref:System.Object.Equals%2A?displayProperty=fullName> or does not overload the language-specific operator for equality, inequality, less than, or greater than. The rule does not report a violation if the type inherits only an implementation of the interface.

## Rule Description
 Types that define a custom sort order implement the <xref:System.IComparable> interface. The <xref:System.IComparable.CompareTo%2A> method returns an integer value that indicates the correct sort order for two instances of the type. This rule identifies types that set a sort order; this implies that the ordinary meaning of equality, inequality, less than, and greater than do not apply. When you provide an implementation of <xref:System.IComparable>, you must usually also override <xref:System.Object.Equals%2A> so that it returns values that are consistent with <xref:System.IComparable.CompareTo%2A>. If you override <xref:System.Object.Equals%2A> and are coding in a language that supports operator overloads, you should also provide operators that are consistent with <xref:System.Object.Equals%2A>.

## How to Fix Violations
 To fix a violation of this rule, override <xref:System.Object.Equals%2A>. If your programming language supports operator overloading, supply the following operators:

- op_Equality

- op_Inequality

- op_LessThan

- op_GreaterThan

  In C#, the tokens that are used to represent these operators are as follows: ==, !=, \<, and >.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule when the violation is caused by missing operators and your programming language does not support operator overloading, as is the case with Visual Basic .NET. It is also safe to suppress a warning for from this rule when it fires on equality operators other than op_Equality if you determine that implementing the operators does not make sense in your application context. However, you should always over op_Equality and the == operator if you override Object.Equals.

## Example
 The following example contains a type that correctly implements <xref:System.IComparable>. Code comments identify the methods that satisfy various rules that are related to <xref:System.Object.Equals%2A> and the <xref:System.IComparable> interface.

 [!code-csharp[FxCop.Design.IComparable#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.IComparable/cs/FxCop.Design.IComparable.cs#1)]

## Example
 The following application tests the behavior of the <xref:System.IComparable> implementation that was shown earlier.

 [!code-csharp[FxCop.Design.TestIComparable#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.TestIComparable/cs/FxCop.Design.TestIComparable.cs#1)]

## See Also
 <xref:System.IComparable?displayProperty=fullName>
 <xref:System.Object.Equals%2A?displayProperty=fullName>
 [Equality Operators](https://msdn.microsoft.com/library/bc496a91-fefb-4ce0-ab4c-61f09964119a)
