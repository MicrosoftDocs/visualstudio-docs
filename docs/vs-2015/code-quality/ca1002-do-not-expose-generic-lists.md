---
title: "CA1002: Do not expose generic lists | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "DoNotExposeGenericLists"
  - "CA1002"
helpviewer_keywords:
  - "CA1002"
  - "DoNotExposeGenericLists"
ms.assetid: 5caac810-1a79-47df-a27b-c46c5040bf34
caps.latest.revision: 22
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1002: Do not expose generic lists
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|DoNotExposeGenericLists|
|CheckId|CA1002|
|Category|Microsoft.Design|
|Breaking Change|Breaking|

## Cause
 A type contains an externally visible member that is a <xref:System.Collections.Generic.List%601?displayProperty=fullName> type, returns a <xref:System.Collections.Generic.List%601?displayProperty=fullName> type, or whose signature includes a <xref:System.Collections.Generic.List%601?displayProperty=fullName> parameter.

## Rule Description
 <xref:System.Collections.Generic.List%601?displayProperty=fullName> is a generic collection that is designed for performance and not inheritance. <xref:System.Collections.Generic.List%601?displayProperty=fullName> does not contain virtual members that make it easier to change the behavior of an inherited class. The following generic collections are designed for inheritance and should be exposed instead of <xref:System.Collections.Generic.List%601?displayProperty=fullName>.

- <xref:System.Collections.ObjectModel.Collection%601?displayProperty=fullName>

- <xref:System.Collections.ObjectModel.ReadOnlyCollection%601?displayProperty=fullName>

- <xref:System.Collections.ObjectModel.KeyedCollection%602?displayProperty=fullName>

## How to Fix Violations
 To fix a violation of this rule, change the <xref:System.Collections.Generic.List%601?displayProperty=fullName> type to one of the generic collections that is designed for inheritance.

## When to Suppress Warnings
 Do not suppress a warning from this rule unless the assembly that raises this warning is not meant to be a reusable library. For example, it would be safe to suppress this warning in a performance tuned application where a performance benefit was gained from the use of generic lists.

## Related Rules
 [CA1005: Avoid excessive parameters on generic types](../code-quality/ca1005-avoid-excessive-parameters-on-generic-types.md)

 [CA1010: Collections should implement generic interface](../code-quality/ca1010-collections-should-implement-generic-interface.md)

 [CA1000: Do not declare static members on generic types](../code-quality/ca1000-do-not-declare-static-members-on-generic-types.md)

 [CA1006: Do not nest generic types in member signatures](../code-quality/ca1006-do-not-nest-generic-types-in-member-signatures.md)

 [CA1004: Generic methods should provide type parameter](../code-quality/ca1004-generic-methods-should-provide-type-parameter.md)

 [CA1003: Use generic event handler instances](../code-quality/ca1003-use-generic-event-handler-instances.md)

 [CA1007: Use generics where appropriate](../code-quality/ca1007-use-generics-where-appropriate.md)

## See Also
 [Generics](https://msdn.microsoft.com/library/75ea8509-a4ea-4e7a-a2b3-cf72482e9282)
