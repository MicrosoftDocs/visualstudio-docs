---
title: "CA1010: Collections should implement generic interface | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1010"
  - "CollectionsShouldImplementGenericInterface"
helpviewer_keywords:
  - "CA1010"
  - "CollectionsShouldImplementGenericInterface"
ms.assetid: c7d7126f-fa70-40be-8f93-3243e1760dc5
caps.latest.revision: 26
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1010: Collections should implement generic interface
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|CollectionsShouldImplementGenericInterface|
|CheckId|CA1010|
|Category|Microsoft.Design|
|Breaking Change|Non-breaking|

## Cause
 An externally visible type implements the <xref:System.Collections.IEnumerable?displayProperty=fullName> interface but does not implement the <xref:System.Collections.Generic.IEnumerable%601?displayProperty=fullName> interface, and the containing assembly targets [!INCLUDE[dnprdnlong](../includes/dnprdnlong-md.md)]. This rule ignores types that implement <xref:System.Collections.IDictionary?displayProperty=fullName>.

## Rule Description
 To broaden the usability of a collection, implement one of the generic collection interfaces. Then the collection can be used to populate generic collection types such as the following:

- <xref:System.Collections.Generic.List%601?displayProperty=fullName>

- <xref:System.Collections.Generic.Queue%601?displayProperty=fullName>

- <xref:System.Collections.Generic.Stack%601?displayProperty=fullName>

## How to Fix Violations
 To fix a violation of this rule, implement one of the following generic collection interfaces:

- <xref:System.Collections.Generic.IEnumerable%601?displayProperty=fullName>

- <xref:System.Collections.Generic.ICollection%601?displayProperty=fullName>

- <xref:System.Collections.Generic.IList%601?displayProperty=fullName>

## When to Suppress Warnings
 It is safe to suppress a warning from this rule; however, the collection will have a more limited use.

## Example Violation

### Description
 The following example shows a class (reference type) that derives from the non-generic `CollectionBase` class, which violates this rule.

### Code
 [!code-csharp[FxCop.Design.CollectionsGenericViolation#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.CollectionsGenericViolation/cs/FxCop.Design.CollectionsGenericViolation.cs#1)]

### Comments
 To fix a violation of this violation, you should either implement the generic interfaces or change the base class to a type that already implements both the generic and non-generic interfaces, such as the `Collection<T>` class.

## Fix by Base Class Change

### Description
 The following example fixes the violation by changing the base class of the collection from the non-generic `CollectionBase` class to the generic `Collection<T>` (`Collection(Of T)` in [!INCLUDE[vbprvb](../includes/vbprvb-md.md)]) class.

### Code
 [!code-csharp[FxCop.Design.CollectionsGenericBase#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.CollectionsGenericBase/cs/FxCop.Design.CollectionsGenericBase.cs#1)]

### Comments
 Changing the base class of an already released class is considered a breaking change to existing consumers.

## Fix by Interface Implementation

### Description
 The following example fixes the violation by implementing these generic interfaces: `IEnumerable<T>`, `ICollection<T>`, and `IList<T>` (`IEnumerable(Of T)`, `ICollection(Of T)`, and `IList(Of T)` in [!INCLUDE[vbprvb](../includes/vbprvb-md.md)]).

### Code
 [!code-csharp[FxCop.Design.CollectionsGenericInterface#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.CollectionsGenericInterface/cs/FxCop.Design.CollectionsGenericInterface.cs#1)]

## Related Rules
 [CA1005: Avoid excessive parameters on generic types](../code-quality/ca1005-avoid-excessive-parameters-on-generic-types.md)

 [CA1000: Do not declare static members on generic types](../code-quality/ca1000-do-not-declare-static-members-on-generic-types.md)

 [CA1002: Do not expose generic lists](../code-quality/ca1002-do-not-expose-generic-lists.md)

 [CA1006: Do not nest generic types in member signatures](../code-quality/ca1006-do-not-nest-generic-types-in-member-signatures.md)

 [CA1004: Generic methods should provide type parameter](../code-quality/ca1004-generic-methods-should-provide-type-parameter.md)

 [CA1003: Use generic event handler instances](../code-quality/ca1003-use-generic-event-handler-instances.md)

 [CA1007: Use generics where appropriate](../code-quality/ca1007-use-generics-where-appropriate.md)

## See Also
 [Generics](https://msdn.microsoft.com/library/75ea8509-a4ea-4e7a-a2b3-cf72482e9282)
