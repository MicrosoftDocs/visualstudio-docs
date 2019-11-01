---
title: "CA2227: Collection properties should be read only | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2227"
  - "CollectionPropertiesShouldBeReadOnly"
helpviewer_keywords:
  - "CA2227"
  - "CollectionPropertiesShouldBeReadOnly"
ms.assetid: 26967aaf-6fbe-438a-b4d3-ac579b5dc0f9
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2227: Collection properties should be read only
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|CollectionPropertiesShouldBeReadOnly|
|CheckId|CA2227|
|Category|Microsoft.Usage|
|Breaking Change|Breaking|

## Cause
 An externally visible writable property is a type that implements <xref:System.Collections.ICollection?displayProperty=fullName>. Arrays, indexers (properties with the name 'Item'), and permission sets are ignored by the rule.

## Rule Description
 A writable collection property allows a user to replace the collection with a completely different collection. A read-only property stops the collection from being replaced but still allows the individual members to be set. If replacing the collection is a goal, the preferred design pattern is to include a method to remove all the elements from the collection and a method to re-populate the collection. See the <xref:System.Collections.ArrayList.Clear%2A> and <xref:System.Collections.ArrayList.AddRange%2A> methods of the <xref:System.Collections.ArrayList?displayProperty=fullName> class for an example of this pattern.

 Both binary and XML serialization support read-only properties that are collections. The <xref:System.Xml.Serialization.XmlSerializer?displayProperty=fullName> class has specific requirements for types that implement <xref:System.Collections.ICollection> and <xref:System.Collections.IEnumerable?displayProperty=fullName> in order to be serializable.

## How to Fix Violations
 To fix a violation of this rule, make the property read-only and, if the design requires it, add methods to clear and re-populate the collection.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Example
 The following example shows a type with a writable collection property and shows how the collection can be replaced directly. Additionally, the preferred manner of replacing a read-only collection property using `Clear` and `AddRange` methods is shown.

 [!code-cpp[FxCop.Usage.PropertiesReturningCollections#1](../snippets/cpp/VS_Snippets_CodeAnalysis/FxCop.Usage.PropertiesReturningCollections/cpp/FxCop.Usage.PropertiesReturningCollections.cpp#1)]
 [!code-csharp[FxCop.Usage.PropertiesReturningCollections#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.PropertiesReturningCollections/cs/FxCop.Usage.PropertiesReturningCollections.cs#1)]
 [!code-vb[FxCop.Usage.PropertiesReturningCollections#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Usage.PropertiesReturningCollections/vb/FxCop.Usage.PropertiesReturningCollections.vb#1)]

## Related Rules
 [CA1819: Properties should not return arrays](../code-quality/ca1819-properties-should-not-return-arrays.md)
