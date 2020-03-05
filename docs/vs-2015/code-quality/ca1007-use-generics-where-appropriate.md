---
title: "CA1007: Use generics where appropriate | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1007"
  - "UseGenericsWhereAppropriate"
helpviewer_keywords:
  - "CA1007"
  - "UseGenericsWhereAppropriate"
ms.assetid: eab780ea-3b1f-4d32-b15a-5d48da2df46b
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1007: Use generics where appropriate
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|UseGenericsWhereAppropriate|
|CheckId|CA1007|
|Category|Microsoft.Design|
|Breaking Change|Breaking|

## Cause
 An externally visible method contains a reference parameter of type <xref:System.Object?displayProperty=fullName>, and the containing assembly targets [!INCLUDE[dnprdnlong](../includes/dnprdnlong-md.md)].

## Rule Description
 A reference parameter is a parameter that is modified by using the `ref` (`ByRef` in [!INCLUDE[vbprvb](../includes/vbprvb-md.md)]) keyword. The argument type that is supplied for a reference parameter must exactly match the reference parameter type. To use a type that is derived from the reference parameter type, the type must first be cast and assigned to a variable of the reference parameter type. Use of a generic method allows all types, subject to constraints, to be passed to the method without first casting the type to the reference parameter type.

## How to Fix Violations
 To fix a violation of this rule, make the method generic and replace the <xref:System.Object> parameter by using a type parameter.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Example
 The following example shows a general-purpose swap routine that is implemented as both nongeneric and generic methods. Note how efficiently the strings are swapped by using the generic method compared to the nongeneric method.

 [!code-csharp[FxCop.Design.UseGenerics#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.UseGenerics/cs/FxCop.Design.UseGenerics.cs#1)]
 [!code-vb[FxCop.Design.UseGenerics#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Design.UseGenerics/vb/FxCop.Design.UseGenerics.vb#1)]

## Related Rules
 [CA1005: Avoid excessive parameters on generic types](../code-quality/ca1005-avoid-excessive-parameters-on-generic-types.md)

 [CA1010: Collections should implement generic interface](../code-quality/ca1010-collections-should-implement-generic-interface.md)

 [CA1000: Do not declare static members on generic types](../code-quality/ca1000-do-not-declare-static-members-on-generic-types.md)

 [CA1002: Do not expose generic lists](../code-quality/ca1002-do-not-expose-generic-lists.md)

 [CA1006: Do not nest generic types in member signatures](../code-quality/ca1006-do-not-nest-generic-types-in-member-signatures.md)

 [CA1004: Generic methods should provide type parameter](../code-quality/ca1004-generic-methods-should-provide-type-parameter.md)

 [CA1003: Use generic event handler instances](../code-quality/ca1003-use-generic-event-handler-instances.md)

## See Also
 [Generics](https://msdn.microsoft.com/library/75ea8509-a4ea-4e7a-a2b3-cf72482e9282)
