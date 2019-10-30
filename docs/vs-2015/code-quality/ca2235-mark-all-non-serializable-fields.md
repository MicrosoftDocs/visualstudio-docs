---
title: "CA2235: Mark all non-serializable fields | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2235"
  - "MarkAllNonSerializableFields"
helpviewer_keywords:
  - "CA2235"
  - "MarkAllNonSerializableFields"
ms.assetid: 599ad877-3a15-426c-bf17-5de15427365f
caps.latest.revision: 15
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2235: Mark all non-serializable fields
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|MarkAllNonSerializableFields|
|CheckId|CA2235|
|Category|Microsoft.Usage|
|Breaking Change|Non Breaking|

## Cause
 An instance field of a type that is not serializable is declared in a type that is serializable.

## Rule Description
 A serializable type is one that is marked with the <xref:System.SerializableAttribute?displayProperty=fullName> attribute. When the type is serialized, a <xref:System.Runtime.Serialization.SerializationException?displayProperty=fullName> exception is thrown if a type contains an instance field of a type that is not serializable.

## How to Fix Violations
 To fix a violation of this rule, apply the <xref:System.NonSerializedAttribute?displayProperty=fullName> attribute to the field that is not serializable.

## When to Suppress Warnings
 Only suppress a warning from this rule if a <xref:System.Runtime.Serialization.ISerializationSurrogate?displayProperty=fullName> type is declared that allows instances of the field to be serialized and deserialized.

## Example
 The following example shows a type that violates the rule and a type that satisfies the rule.

 [!code-csharp[FxCop.Usage.MarkNonSerializable#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.MarkNonSerializable/cs/FxCop.Usage.MarkNonSerializable.cs#1)]
 [!code-vb[FxCop.Usage.MarkNonSerializable#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Usage.MarkNonSerializable/vb/FxCop.Usage.MarkNonSerializable.vb#1)]

## Related Rules
 [CA2236: Call base class methods on ISerializable types](../code-quality/ca2236-call-base-class-methods-on-iserializable-types.md)

 [CA2240: Implement ISerializable correctly](../code-quality/ca2240-implement-iserializable-correctly.md)

 [CA2229: Implement serialization constructors](../code-quality/ca2229-implement-serialization-constructors.md)

 [CA2238: Implement serialization methods correctly](../code-quality/ca2238-implement-serialization-methods-correctly.md)

 [CA2237: Mark ISerializable types with SerializableAttribute](../code-quality/ca2237-mark-iserializable-types-with-serializableattribute.md)

 [CA2239: Provide deserialization methods for optional fields](../code-quality/ca2239-provide-deserialization-methods-for-optional-fields.md)

 [CA2120: Secure serialization constructors](../code-quality/ca2120-secure-serialization-constructors.md)
