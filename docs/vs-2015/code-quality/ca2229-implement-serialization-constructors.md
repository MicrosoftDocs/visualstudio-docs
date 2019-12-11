---
title: "CA2229: Implement serialization constructors | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2229"
  - "ImplementSerializationConstructors"
helpviewer_keywords:
  - "CA2229"
  - "ImplementSerializationConstructors"
ms.assetid: 8e04d5fe-dfad-445a-972e-0648324fac45
caps.latest.revision: 17
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2229: Implement serialization constructors
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|ImplementSerializationConstructors|
|CheckId|CA2229|
|Category|Microsoft.Usage|
|Breaking Change|Non Breaking|

## Cause
 The type implements the <xref:System.Runtime.Serialization.ISerializable?displayProperty=fullName> interface, is not a delegate or interface, and one of the following conditions is true:

- The type does not have a constructor that takes a <xref:System.Runtime.Serialization.SerializationInfo?displayProperty=fullName> object and a <xref:System.Runtime.Serialization.StreamingContext?displayProperty=fullName> object (the signature of the serialization constructor).

- The type is unsealed and the access modifier for its serialization constructor is not protected (family).

- The type is sealed and the access modifier for its serialization constructor is not private.

## Rule Description
 This rule is relevant for types that support custom serialization. A type supports custom serialization if it implements the <xref:System.Runtime.Serialization.ISerializable> interface. The serialization constructor is required to deserialize, or re-create objects that have been serialized using the <xref:System.Runtime.Serialization.ISerializable.GetObjectData%2A?displayProperty=fullName> method.

## How to Fix Violations
 To fix a violation of this rule, implement the serialization constructor. For a sealed class, make the constructor private; otherwise, make it protected.

## When to Suppress Warnings
 Do not suppress a violation of the rule. The type will not be deserializable, and will not function in many scenarios.

## Example
 The following example shows a type that satisfies the rule.

 [!code-csharp[FxCop.Usage.ISerializableCtor#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.ISerializableCtor/cs/FxCop.Usage.ISerializableCtor.cs#1)]

## Related Rules
 [CA2237: Mark ISerializable types with SerializableAttribute](../code-quality/ca2237-mark-iserializable-types-with-serializableattribute.md)

## See Also
 <xref:System.Runtime.Serialization.ISerializable?displayProperty=fullName>
 <xref:System.Runtime.Serialization.SerializationInfo?displayProperty=fullName>
 <xref:System.Runtime.Serialization.StreamingContext?displayProperty=fullName>
