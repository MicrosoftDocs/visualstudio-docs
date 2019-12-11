---
title: "CA1006: Do not nest generic types in member signatures | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "DoNotNestGenericTypesInMemberSignatures"
  - "CA1006"
helpviewer_keywords:
  - "CA1006"
  - "DoNotNestGenericTypesInMemberSignatures"
ms.assetid: dfc867bc-f4af-45d7-b071-db04a248f9fc
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1006: Do not nest generic types in member signatures
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|DoNotNestGenericTypesInMemberSignatures|
|CheckId|CA1006|
|Category|Microsoft.Design|
|Breaking Change|Breaking|

## Cause
 An externally visible member has a signature that contains a nested type argument.

## Rule Description
 A nested type argument is a type argument that is also a generic type. To call a member whose signature contains a nested type argument, the user must instantiate one generic type and pass this type to the constructor of a second generic type. The required procedure and syntax are complex and should be avoided.

## How to Fix Violations
 To fix a violation of this rule, change the design to remove the nested type argument.

## When to Suppress Warnings
 Do not suppress a warning from this rule. Providing generics in a syntax that is easy to understand and use reduces the time that is required to learn and increases the adoption rate of new libraries.

## Example
 The following example shows a method that violates the rule and the syntax that is required to call the violating method.

 [!code-csharp[FxCop.Design.NestedGenerics#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.NestedGenerics/cs/FxCop.Design.NestedGenerics.cs#1)]
 [!code-vb[FxCop.Design.NestedGenerics#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Design.NestedGenerics/vb/FxCop.Design.NestedGenerics.vb#1)]

## Related Rules
 [CA1005: Avoid excessive parameters on generic types](../code-quality/ca1005-avoid-excessive-parameters-on-generic-types.md)

 [CA1010: Collections should implement generic interface](../code-quality/ca1010-collections-should-implement-generic-interface.md)

 [CA1000: Do not declare static members on generic types](../code-quality/ca1000-do-not-declare-static-members-on-generic-types.md)

 [CA1002: Do not expose generic lists](../code-quality/ca1002-do-not-expose-generic-lists.md)

 [CA1004: Generic methods should provide type parameter](../code-quality/ca1004-generic-methods-should-provide-type-parameter.md)

 [CA1003: Use generic event handler instances](../code-quality/ca1003-use-generic-event-handler-instances.md)

 [CA1007: Use generics where appropriate](../code-quality/ca1007-use-generics-where-appropriate.md)

## See Also
 [Generics](https://msdn.microsoft.com/library/75ea8509-a4ea-4e7a-a2b3-cf72482e9282)
