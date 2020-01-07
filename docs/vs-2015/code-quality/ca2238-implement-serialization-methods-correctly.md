---
title: "CA2238: Implement serialization methods correctly | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "ImplementSerializationMethodsCorrectly"
  - "CA2238"
helpviewer_keywords:
  - "ImplementSerializationMethodsCorrectly"
  - "CA2238"
ms.assetid: 00882cf9-e10d-4d40-9126-3e6753e3c934
caps.latest.revision: 17
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2238: Implement serialization methods correctly
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

For the latest documentation on Visual Studio, see [CA2238: Implement serialization methods correctly](https://docs.microsoft.com/visualstudio/code-quality/ca2238-implement-serialization-methods-correctly).

|||
|-|-|
|TypeName|ImplementSerializationMethodsCorrectly|
|CheckId|CA2238|
|Category|Microsoft.Usage|
|Breaking Change|Breaking - If the method is visible outside the assembly.<br /><br /> Non-breaking - If the method is not visible outside the assembly.|

## Cause
 A method that handles a serialization event does not have the correct signature, return type, or visibility.

## Rule Description
 A method is designated a serialization event handler by applying one of the following serialization event attributes:

- <xref:System.Runtime.Serialization.OnSerializingAttribute?displayProperty=fullName>

- <xref:System.Runtime.Serialization.OnSerializedAttribute?displayProperty=fullName>

- <xref:System.Runtime.Serialization.OnDeserializingAttribute?displayProperty=fullName>

- <xref:System.Runtime.Serialization.OnDeserializedAttribute?displayProperty=fullName>

  Serialization event handlers take a single parameter of type <xref:System.Runtime.Serialization.StreamingContext?displayProperty=fullName>, return `void`, and have `private` visibility.

## How to Fix Violations
 To fix a violation of this rule, correct the signature, return type, or visibility of the serialization event handler.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Example
 The following example shows correctly declared serialization event handlers.

 [!code-csharp[FxCop.Usage.SerializationEventHandlers#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.SerializationEventHandlers/cs/FxCop.Usage.SerializationEventHandlers.cs#1)]
 [!code-vb[FxCop.Usage.SerializationEventHandlers#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Usage.SerializationEventHandlers/vb/FxCop.Usage.SerializationEventHandlers.vb#1)]

## Related Rules
 [CA2236: Call base class methods on ISerializable types](../code-quality/ca2236-call-base-class-methods-on-iserializable-types.md)

 [CA2240: Implement ISerializable correctly](../code-quality/ca2240-implement-iserializable-correctly.md)

 [CA2229: Implement serialization constructors](../code-quality/ca2229-implement-serialization-constructors.md)

 [CA2235: Mark all non-serializable fields](../code-quality/ca2235-mark-all-non-serializable-fields.md)

 [CA2237: Mark ISerializable types with SerializableAttribute](../code-quality/ca2237-mark-iserializable-types-with-serializableattribute.md)

 [CA2239: Provide deserialization methods for optional fields](../code-quality/ca2239-provide-deserialization-methods-for-optional-fields.md)

 [CA2120: Secure serialization constructors](../code-quality/ca2120-secure-serialization-constructors.md)
