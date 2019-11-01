---
title: "CA1038: Enumerators should be strongly typed | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "EnumeratorsShouldBeStronglyTyped"
  - "CA1038"
helpviewer_keywords:
  - "EnumeratorsShouldBeStronglyTyped"
  - "CA1038"
ms.assetid: 8919f526-d487-42a4-87dc-2b2ee25260c4
caps.latest.revision: 18
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1038: Enumerators should be strongly typed
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|EnumeratorsShouldBeStronglyTyped|
|CheckId|CA1038|
|Category|Microsoft.Design|
|Breaking Change|Breaking|

## Cause
 A public or protected type implements <xref:System.Collections.IEnumerator?displayProperty=fullName> but does not provide a strongly typed version of the <xref:System.Collections.IEnumerator.Current%2A?displayProperty=fullName> property. Types that are derived from the following types are exempt from this rule:

- <xref:System.Collections.CollectionBase?displayProperty=fullName>

- <xref:System.Collections.DictionaryBase?displayProperty=fullName>

- <xref:System.Collections.ReadOnlyCollectionBase?displayProperty=fullName>

## Rule Description
 This rule requires <xref:System.Collections.IEnumerator> implementations to also provide a strongly typed version of the <xref:System.Collections.IEnumerator.Current%2A> property so that users are not required to cast the return value to the strong type when they use the functionality that is provided by the interface. This rule assumes that the type that implements <xref:System.Collections.IEnumerator> contains a collection of instances of a type that is stronger than <xref:System.Object>.

## How to Fix Violations
 To fix a violation of this rule, implement the interface property explicitly (declare it as `IEnumerator.Current`). Add a public strongly typed version of the property, declared as `Current`, and have it return a strongly typed object.

## When to Suppress Warnings
 Suppress a warning from this rule when you implement an object-based enumerator for use with an object-based collection, such as a binary tree. Types that extend the new collection will define the strongly typed enumerator and expose the strongly typed property.

## Example
 The following example demonstrates the correct way to implement a strongly typed <xref:System.Collections.IEnumerator> type.

 [!code-csharp[FxCop.Design.IEnumeratorStrongTypes#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.IEnumeratorStrongTypes/cs/FxCop.Design.IEnumeratorStrongTypes.cs#1)]

## Related Rules
 [CA1035: ICollection implementations have strongly typed members](../code-quality/ca1035-icollection-implementations-have-strongly-typed-members.md)

 [CA1039: Lists are strongly typed](../code-quality/ca1039-lists-are-strongly-typed.md)

## See Also
 <xref:System.Collections.IEnumerator?displayProperty=fullName>
 <xref:System.Collections.CollectionBase?displayProperty=fullName>
 <xref:System.Collections.DictionaryBase?displayProperty=fullName>
 <xref:System.Collections.ReadOnlyCollectionBase?displayProperty=fullName>
