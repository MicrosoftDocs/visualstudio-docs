---
title: "CA2240: Implement ISerializable correctly | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2240"
  - "ImplementISerializableCorrectly"
helpviewer_keywords:
  - "CA2240"
  - "ImplementISerializableCorrectly"
ms.assetid: cf05936d-0d6c-49ed-a1b4-220032e50b97
caps.latest.revision: 23
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2240: Implement ISerializable correctly
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|ImplementISerializableCorrectly|
|CheckId|CA2240|
|Category|Microsoft.Usage|
|Breaking Change|Non Breaking|

## Cause
 An externally visible type is assignable to the <xref:System.Runtime.Serialization.ISerializable?displayProperty=fullName> interface and one of the following conditions is true:

- The type inherits but does not override the <xref:System.Runtime.Serialization.ISerializable.GetObjectData%2A?displayProperty=fullName> method and the type declares instance fields that are not marked with the <xref:System.NonSerializedAttribute?displayProperty=fullName> attribute.

- The type is not sealed and the type implements a <xref:System.Runtime.Serialization.ISerializable.GetObjectData%2A> method that is not externally visible and overridable.

## Rule Description
 Instance fields that are declared in a type that inherits the <xref:System.Runtime.Serialization.ISerializable?displayProperty=fullName> interface are not automatically included in the serialization process. To include the fields, the type must implement the <xref:System.Runtime.Serialization.ISerializable.GetObjectData%2A> method and the serialization constructor. If the fields should not be serialized, apply the <xref:System.NonSerializedAttribute> attribute to the fields to explicitly indicate the decision.

 In types that are not sealed, implementations of the <xref:System.Runtime.Serialization.ISerializable.GetObjectData%2A> method should be externally visible. Therefore, the method can be called by derived types, and is overridable.

## How to Fix Violations
 To fix a violation of this rule, make the <xref:System.Runtime.Serialization.ISerializable.GetObjectData%2A> method visible and overridable and make sure all instance fields are included in the serialization process or explicitly marked with the <xref:System.NonSerializedAttribute> attribute.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Example
 The following example shows two serializable types that violate the rule.

 [!code-cpp[FxCop.Usage.ImplementISerializableCorrectly#1](../snippets/cpp/VS_Snippets_CodeAnalysis/FxCop.Usage.ImplementISerializableCorrectly/cpp/FxCop.Usage.ImplementISerializableCorrectly.cpp#1)]
 [!code-csharp[FxCop.Usage.ImplementISerializableCorrectly#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.ImplementISerializableCorrectly/cs/FxCop.Usage.ImplementISerializableCorrectly.cs#1)]
 [!code-vb[FxCop.Usage.ImplementISerializableCorrectly#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Usage.ImplementISerializableCorrectly/vb/FxCop.Usage.ImplementISerializableCorrectly.vb#1)]

## Example
 The following example fixes the two previous violations by providing an overrideable implementation of [ISerializable.GetObjectData](<!-- TODO: review code entity reference <xref:assetId:///ISerializable.GetObjectData?qualifyHint=False&amp;autoUpgrade=False>  -->) on the Book class and by providing an implementation of <!-- TODO: review code entity reference <xref:assetId:///ISerializable.GetObjectData?qualifyHint=False&amp;autoUpgrade=False>  --> on the Library class.

 [!code-cpp[FxCop.Usage.ImplementISerializableCorrectly2#1](../snippets/cpp/VS_Snippets_CodeAnalysis/FxCop.Usage.ImplementISerializableCorrectly2/cpp/FxCop.Usage.ImplementISerializableCorrectly2.cpp#1)]
 [!code-csharp[FxCop.Usage.ImplementISerializableCorrectly2#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.ImplementISerializableCorrectly2/cs/FxCop.Usage.ImplementISerializableCorrectly2.cs#1)]
 [!code-vb[FxCop.Usage.ImplementISerializableCorrectly2#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Usage.ImplementISerializableCorrectly2/vb/FxCop.Usage.ImplementISerializableCorrectly2.vb#1)]

## Related Rules
 [CA2236: Call base class methods on ISerializable types](../code-quality/ca2236-call-base-class-methods-on-iserializable-types.md)

 [CA2229: Implement serialization constructors](../code-quality/ca2229-implement-serialization-constructors.md)

 [CA2238: Implement serialization methods correctly](../code-quality/ca2238-implement-serialization-methods-correctly.md)

 [CA2235: Mark all non-serializable fields](../code-quality/ca2235-mark-all-non-serializable-fields.md)

 [CA2237: Mark ISerializable types with SerializableAttribute](../code-quality/ca2237-mark-iserializable-types-with-serializableattribute.md)

 [CA2239: Provide deserialization methods for optional fields](../code-quality/ca2239-provide-deserialization-methods-for-optional-fields.md)

 [CA2120: Secure serialization constructors](../code-quality/ca2120-secure-serialization-constructors.md)
