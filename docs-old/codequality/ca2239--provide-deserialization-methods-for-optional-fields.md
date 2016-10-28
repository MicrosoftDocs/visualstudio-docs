---
title: "CA2239: Provide deserialization methods for optional fields"
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
  - "CA2239"
  - "ProvideDeserializationMethodsForOptionalFields"
helpviewer_keywords: 
  - "ProvideDeserializationMethodsForOptionalFields"
  - "CA2239"
ms.assetid: 6480ff5e-0caa-4707-814e-2f927cdafef5
caps.latest.revision: 13
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
# CA2239: Provide deserialization methods for optional fields
|||  
|-|-|  
|TypeName|ProvideDeserializationMethodsForOptionalFields|  
|CheckId|CA2239|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A type has a field that is marked with the \<xref:System.Runtime.Serialization.OptionalFieldAttribute?displayProperty=fullName> attribute and the type does not provide de-serialization event handling methods.  
  
## Rule Description  
 The \<xref:System.Runtime.Serialization.OptionalFieldAttribute> attribute has no effect on serialization; a field marked with the attribute is serialized. However, the field is ignored on de-serialization and retains the default value associated with its type. De-serialization event handlers should be declared to set the field during the de-serialization process.  
  
## How to Fix Violations  
 To fix a violation of this rule, add de-serialization event handling methods to the type.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the field should be ignored during the de-serialization process.  
  
## Example  
 The following example shows a type with an optional field and de-serialization event handling methods.  
  
 [!code[FxCop.Usage.OptionalFields#1](../codequality/codesnippet/CSharp/ca2239--provide-deserialization-methods-for-optional-fields_1.cs)]
[!code[FxCop.Usage.OptionalFields#1](../codequality/codesnippet/VisualBasic/ca2239--provide-deserialization-methods-for-optional-fields_1.vb)]  
  
## Related Rules  
 [CA2236: Call base class methods on ISerializable types](../codequality/ca2236--call-base-class-methods-on-iserializable-types.md)  
  
 [CA2240: Implement ISerializable correctly](../codequality/ca2240--implement-iserializable-correctly.md)  
  
 [CA2229: Implement serialization constructors](../codequality/ca2229--implement-serialization-constructors.md)  
  
 [CA2238: Implement serialization methods correctly](../codequality/ca2238--implement-serialization-methods-correctly.md)  
  
 [CA2235: Mark all non-serializable fields](../codequality/ca2235--mark-all-non-serializable-fields.md)  
  
 [CA2237: Mark ISerializable types with SerializableAttribute](../codequality/ca2237--mark-iserializable-types-with-serializableattribute.md)  
  
 [CA2120: Secure serialization constructors](../codequality/ca2120--secure-serialization-constructors.md)