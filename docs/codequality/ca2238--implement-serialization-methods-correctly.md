---
title: "CA2238: Implement serialization methods correctly"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ImplementSerializationMethodsCorrectly"
  - "CA2238"
helpviewer_keywords: 
  - "ImplementSerializationMethodsCorrectly"
  - "CA2238"
ms.assetid: 00882cf9-e10d-4d40-9126-3e6753e3c934
caps.latest.revision: 16
ms.author: "douge"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# CA2238: Implement serialization methods correctly
|||  
|-|-|  
|TypeName|ImplementSerializationMethodsCorrectly|  
|CheckId|CA2238|  
|Category|Microsoft.Usage|  
|Breaking Change|Breaking - If the method is visible outside the assembly.<br /><br /> Non Breaking - If the method is not visible outside the assembly.|  
  
## Cause  
 A method that handles a serialization event does not have the correct signature, return type, or visibility.  
  
## Rule Description  
 A method is designated a serialization event handler by applying one of the following serialization event attributes:  
  
-   \<xref:System.Runtime.Serialization.OnSerializingAttribute?displayProperty=fullName>  
  
-   \<xref:System.Runtime.Serialization.OnSerializedAttribute?displayProperty=fullName>  
  
-   \<xref:System.Runtime.Serialization.OnDeserializingAttribute?displayProperty=fullName>  
  
-   \<xref:System.Runtime.Serialization.OnDeserializedAttribute?displayProperty=fullName>  
  
 Serialization event handlers take a single parameter of type \<xref:System.Runtime.Serialization.StreamingContext?displayProperty=fullName>, return `void`, and have `private` visibility.  
  
## How to Fix Violations  
 To fix a violation of this rule, correct the signature, return type, or visibility of the serialization event handler.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows correctly declared serialization event handlers.  
  
 [!code[FxCop.Usage.SerializationEventHandlers#1](../codequality/codesnippet/VisualBasic/ca2238--implement-serialization-methods-correctly_1.vb)]
[!code[FxCop.Usage.SerializationEventHandlers#1](../codequality/codesnippet/CSharp/ca2238--implement-serialization-methods-correctly_1.cs)]  
  
## Related Rules  
 [CA2236: Call base class methods on ISerializable types](../codequality/ca2236--call-base-class-methods-on-iserializable-types.md)  
  
 [CA2240: Implement ISerializable correctly](../codequality/ca2240--implement-iserializable-correctly.md)  
  
 [CA2229: Implement serialization constructors](../codequality/ca2229--implement-serialization-constructors.md)  
  
 [CA2235: Mark all non-serializable fields](../codequality/ca2235--mark-all-non-serializable-fields.md)  
  
 [CA2237: Mark ISerializable types with SerializableAttribute](../codequality/ca2237--mark-iserializable-types-with-serializableattribute.md)  
  
 [CA2239: Provide deserialization methods for optional fields](../codequality/ca2239--provide-deserialization-methods-for-optional-fields.md)  
  
 [CA2120: Secure serialization constructors](../codequality/ca2120--secure-serialization-constructors.md)