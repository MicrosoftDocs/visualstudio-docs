---
title: "CA2239: Provide deserialization methods for optional fields | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2239"
  - "ProvideDeserializationMethodsForOptionalFields"
helpviewer_keywords:
  - "ProvideDeserializationMethodsForOptionalFields"
  - "CA2239"
ms.assetid: 6480ff5e-0caa-4707-814e-2f927cdafef5
caps.latest.revision: 15
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2239: Provide deserialization methods for optional fields
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|ProvideDeserializationMethodsForOptionalFields|
|CheckId|CA2239|
|Category|Microsoft.Usage|
|Breaking Change|Non Breaking|

## Cause
 A type has a field that is marked with the <xref:System.Runtime.Serialization.OptionalFieldAttribute?displayProperty=fullName> attribute and the type does not provide de-serialization event handling methods.

## Rule Description
 The <xref:System.Runtime.Serialization.OptionalFieldAttribute> attribute has no effect on serialization; a field marked with the attribute is serialized. However, the field is ignored on de-serialization and retains the default value associated with its type. De-serialization event handlers should be declared to set the field during the de-serialization process.

## How to Fix Violations
 To fix a violation of this rule, add de-serialization event handling methods to the type.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule if the field should be ignored during the de-serialization process.

## Example
 The following example shows a type with an optional field and de-serialization event handling methods.

 [!code-csharp[FxCop.Usage.OptionalFields#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.OptionalFields/cs/FxCop.Usage.OptionalFields.cs#1)]
 [!code-vb[FxCop.Usage.OptionalFields#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Usage.OptionalFields/vb/FxCop.Usage.OptionalFields.vb#1)]

## Related Rules
 [CA2236: Call base class methods on ISerializable types](../code-quality/ca2236-call-base-class-methods-on-iserializable-types.md)

 [CA2240: Implement ISerializable correctly](../code-quality/ca2240-implement-iserializable-correctly.md)

 [CA2229: Implement serialization constructors](../code-quality/ca2229-implement-serialization-constructors.md)

 [CA2238: Implement serialization methods correctly](../code-quality/ca2238-implement-serialization-methods-correctly.md)

 [CA2235: Mark all non-serializable fields](../code-quality/ca2235-mark-all-non-serializable-fields.md)

 [CA2237: Mark ISerializable types with SerializableAttribute](../code-quality/ca2237-mark-iserializable-types-with-serializableattribute.md)

 [CA2120: Secure serialization constructors](../code-quality/ca2120-secure-serialization-constructors.md)
