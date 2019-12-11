---
title: "CA2236: Call base class methods on ISerializable types | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2236"
  - "CallBaseClassMethodsOnISerializableTypes"
helpviewer_keywords:
  - "CA2236"
  - "CallBaseClassMethodsOnISerializableTypes"
ms.assetid: 5a15b20d-769c-4640-b31a-36e07077daae
caps.latest.revision: 17
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2236: Call base class methods on ISerializable types
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|CallBaseClassMethodsOnISerializableTypes|
|CheckId|CA2236|
|Category|Microsoft.Usage|
|Breaking Change|Non Breaking|

## Cause
 A type derives from a type that implements the <xref:System.Runtime.Serialization.ISerializable?displayProperty=fullName> interface, and one of the following conditions is true:

- The type implements the serialization constructor, that is, a constructor with the <xref:System.Runtime.Serialization.SerializationInfo?displayProperty=fullName>, <xref:System.Runtime.Serialization.StreamingContext?displayProperty=fullName> parameter signature, but does not call the serialization constructor of the base type.

- The type implements the <xref:System.Runtime.Serialization.ISerializable.GetObjectData%2A?displayProperty=fullName> method but does not call the <xref:System.Runtime.Serialization.ISerializable.GetObjectData%2A> method of the base type.

## Rule Description
 In a custom serialization process, a type implements the <xref:System.Runtime.Serialization.ISerializable.GetObjectData%2A> method to serialize its fields and the serialization constructor to de-serialize the fields. If the type derives from a type that implements the <xref:System.Runtime.Serialization.ISerializable> interface, the base type <xref:System.Runtime.Serialization.ISerializable.GetObjectData%2A> method and serialization constructor should be called to serialize/de-serialize the fields of the base type. Otherwise, the type will not be serialized and de-serialized correctly. Note that if the derived type does not add any new fields, the type does not need to implement the <xref:System.Runtime.Serialization.ISerializable.GetObjectData%2A> method nor the serialization constructor or call the base type equivalents.

## How to Fix Violations
 To fix a violation of this rule, call the base type <xref:System.Runtime.Serialization.ISerializable.GetObjectData%2A> method or serialization constructor from the corresponding derived type method or constructor.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Example
 The following example shows a derived type that satisfies the rule by calling the serialization constructor and <xref:System.Runtime.Serialization.ISerializable.GetObjectData%2A> method of the base class.

 [!code-csharp[FxCop.Usage.CallBaseISerializable#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.CallBaseISerializable/cs/FxCop.Usage.CallBaseISerializable.cs#1)]
 [!code-vb[FxCop.Usage.CallBaseISerializable#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Usage.CallBaseISerializable/vb/FxCop.Usage.CallBaseISerializable.vb#1)]

## Related Rules
 [CA2240: Implement ISerializable correctly](../code-quality/ca2240-implement-iserializable-correctly.md)

 [CA2229: Implement serialization constructors](../code-quality/ca2229-implement-serialization-constructors.md)

 [CA2238: Implement serialization methods correctly](../code-quality/ca2238-implement-serialization-methods-correctly.md)

 [CA2235: Mark all non-serializable fields](../code-quality/ca2235-mark-all-non-serializable-fields.md)

 [CA2237: Mark ISerializable types with SerializableAttribute](../code-quality/ca2237-mark-iserializable-types-with-serializableattribute.md)

 [CA2239: Provide deserialization methods for optional fields](../code-quality/ca2239-provide-deserialization-methods-for-optional-fields.md)

 [CA2120: Secure serialization constructors](../code-quality/ca2120-secure-serialization-constructors.md)
