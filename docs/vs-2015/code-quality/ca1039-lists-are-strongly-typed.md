---
title: "CA1039: Lists are strongly typed | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1039"
  - "ListsAreStronglyTyped"
helpviewer_keywords:
  - "CA1039"
  - "ListsAreStronglyTyped"
ms.assetid: 5ac366c4-fd87-4d5c-95d5-f755510c8e5c
caps.latest.revision: 17
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1039: Lists are strongly typed
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|Item|Value|
|-|-|
|TypeName|ListsAreStronglyTyped|
|CheckId|CA1039|
|Category|Microsoft.Design|
|Breaking Change|Breaking|

## Cause
 The public or protected type implements <xref:System.Collections.IList?displayProperty=fullName> but does not provide a strongly typed method for one or more of the following:

- IList.Item

- IList.Add

- IList.Contains

- IList.IndexOf

- IList.Insert

- IList.Remove

## Rule Description
 This rule requires <xref:System.Collections.IList> implementations to provide strongly typed members so that users are not required to cast arguments to the <xref:System.Object?displayProperty=fullName> type when they use the functionality that is provided by the interface. The <xref:System.Collections.IList> interface is implemented by collections of objects that can be accessed by index. This rule assumes that the type that implements <xref:System.Collections.IList> does this to manage a collection of instances of a type that is stronger than <xref:System.Object>.

 <xref:System.Collections.IList> implements the <xref:System.Collections.ICollection?displayProperty=fullName> and <xref:System.Collections.IEnumerable?displayProperty=fullName> interfaces. If you implement <xref:System.Collections.IList>, you must provide the required strongly typed members for <xref:System.Collections.ICollection>. If the objects in the collection extend <xref:System.ValueType?displayProperty=fullName>, you must provide a strongly typed member for <xref:System.Collections.IEnumerable.GetEnumerator%2A> to avoid the decrease in performance that is caused by boxing; this is not required when the objects of the collection are a reference type.

 To comply with this rule, implement the interface members explicitly by using names in the form InterfaceName.InterfaceMemberName, such as <xref:System.Collections.IList.Add%2A>. The explicit interface members use the data types that are declared by the interface. Implement the strongly typed members by using the interface member name, such as `Add`. Declare the strongly typed members as public, and declare parameters and return values to be of the strong type that is managed by the collection. The strong types replace weaker types such as <xref:System.Object> and <xref:System.Array> that are declared by the interface.

## How to Fix Violations
 To fix a violation of this rule, explicitly implement <xref:System.Collections.IList> members and provide strongly typed alternatives for the members that were noted previously. For code that correctly implements the <xref:System.Collections.IList> interface and provides the required strongly typed members, see the following example.

## When to Suppress Warnings
 Suppress a warning from this rule when you implement a new object-based collection, such as a linked list, where types that extend the new collection determine the strong type. These types should comply with this rule and expose strongly typed members.

## Example
 In the following example, the type `YourType` extends <xref:System.Collections.CollectionBase?displayProperty=fullName>, as should all strongly typed collections. Note that <xref:System.Collections.CollectionBase> provides the explicit implementation of the <xref:System.Collections.IList> interface for you. Therefore, you must only provide the strongly typed members for <xref:System.Collections.IList> and <xref:System.Collections.ICollection>.

 [!code-csharp[FxCop.Design.IListStrongTypes#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.IListStrongTypes/cs/FxCop.Design.IListStrongTypes.cs#1)]

## Related Rules
 [CA1035: ICollection implementations have strongly typed members](../code-quality/ca1035-icollection-implementations-have-strongly-typed-members.md)

 [CA1038: Enumerators should be strongly typed](../code-quality/ca1038-enumerators-should-be-strongly-typed.md)

## See Also
 <xref:System.Collections.CollectionBase?displayProperty=fullName>
 <xref:System.Collections.ICollection?displayProperty=fullName>
 <xref:System.Collections.IEnumerable?displayProperty=fullName>
 <xref:System.Collections.IList?displayProperty=fullName>
 <xref:System.Object?displayProperty=fullName>
