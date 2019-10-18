---
title: "CA1035: ICollection implementations have strongly typed members | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "ICollectionImplementationsHaveStronglyTypedMembers"
  - "CA1035"
helpviewer_keywords:
  - "CA1035"
  - "ICollectionImplementationsHaveStronglyTypedMembers"
ms.assetid: ad404eb5-cf6a-44b7-b78a-8ebfb654bc7f
caps.latest.revision: 18
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1035: ICollection implementations have strongly typed members
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|ICollectionImplementationsHaveStronglyTypedMembers|
|CheckId|CA1035|
|Category|Microsoft.Design|
|Breaking Change|Breaking|

## Cause
 A public or protected type implements <xref:System.Collections.ICollection?displayProperty=fullName> but does not provide a strongly typed method for <xref:System.Collections.ICollection.CopyTo%2A?displayProperty=fullName>. The strongly typed version of <xref:System.Collections.ICollection.CopyTo%2A> must accept two parameters and cannot have a <xref:System.Array?displayProperty=fullName> or an array of <xref:System.Object?displayProperty=fullName> as its first parameter.

## Rule Description
 This rule requires <xref:System.Collections.ICollection> implementations to provide strongly typed members so that users are not required to cast arguments to the <xref:System.Object> type when they use the functionality that is provided by the interface. This rule assumes that the type that implements <xref:System.Collections.ICollection> does so to manage a collection of instances of a type that is stronger than <xref:System.Object>.

 <xref:System.Collections.ICollection> implements the <xref:System.Collections.IEnumerable?displayProperty=fullName> interface. If the objects in the collection extend <xref:System.ValueType?displayProperty=fullName>, you must provide a strongly typed member for <xref:System.Collections.IEnumerable.GetEnumerator%2A> to avoid the decrease in performance that is caused by boxing. This is not required when the objects of the collection are a reference type.

 To implement a strongly typed version of an interface member, implement the interface members explicitly by using names in the form `InterfaceName.InterfaceMemberName`, such as <xref:System.Collections.ICollection.CopyTo%2A>. The explicit interface members use the data types that are declared by the interface. Implement the strongly typed members by using the interface member name, such as <xref:System.Collections.ICollection.CopyTo%2A>. Declare the strongly typed members as public, and declare parameters and return values to be of the strong type that is managed by the collection. The strong types replace weaker types such as <xref:System.Object> and <xref:System.Array> that are declared by the interface.

## How to Fix Violations
 To fix a violation of this rule, implement the interface member explicitly (declare it as <xref:System.Collections.ICollection.CopyTo%2A>). Add the public strongly typed member, declared as `CopyTo`, and have it take a strongly typed array as its first parameter.

## When to Suppress Warnings
 Suppress a warning from this rule if you implement a new object-based collection, such as a binary tree, where types that extend the new collection determine the strong type. These types should comply with this rule and expose strongly typed members.

## Example
 The following example demonstrates the correct way to implement <xref:System.Collections.ICollection>.

 [!code-csharp[FxCop.Design.ICollectionStrongTypes#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.ICollectionStrongTypes/cs/FxCop.Design.ICollectionStrongTypes.cs#1)]

## Related Rules
 [CA1038: Enumerators should be strongly typed](../code-quality/ca1038-enumerators-should-be-strongly-typed.md)

 [CA1039: Lists are strongly typed](../code-quality/ca1039-lists-are-strongly-typed.md)

## See Also
 <xref:System.Array?displayProperty=fullName>
 <xref:System.Collections.IEnumerable?displayProperty=fullName>
 <xref:System.Collections.ICollection?displayProperty=fullName>
 <xref:System.Object?displayProperty=fullName>
