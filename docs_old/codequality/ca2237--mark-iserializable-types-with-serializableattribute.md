---
title: "CA2237: Mark ISerializable types with SerializableAttribute"
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
  - "CA2237"
  - "MarkISerializableTypesWithSerializable"
helpviewer_keywords: 
  - "MarkISerializableTypesWithSerializable"
  - "CA2237"
ms.assetid: 9bd6bb24-a527-43dd-9952-043c0c694f46
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
# CA2237: Mark ISerializable types with SerializableAttribute
|||  
|-|-|  
|TypeName|MarkISerializableTypesWithSerializable|  
|CheckId|CA2237|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 An externally visible type implements the \<xref:System.Runtime.Serialization.ISerializable?displayProperty=fullName> interface and the type is not marked with the \<xref:System.SerializableAttribute?displayProperty=fullName> attribute. The rule ignores derived types whose base type is not serializable.  
  
## Rule Description  
 To be recognized by the common language runtime as serializable, types must be marked with the \<xref:System.SerializableAttribute> attribute even if the type uses a custom serialization routine through implementation of the \<xref:System.Runtime.Serialization.ISerializable> interface.  
  
## How to Fix Violations  
 To fix a violation of this rule, apply the \<xref:System.SerializableAttribute> attribute to the type.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule for exception classes because they must be serializable to work correctly across application domains.  
  
## Example  
 The following example shows a type that violates the rule. Uncomment the \<xref:System.SerializableAttribute> attribute line to satisfy the rule.  
  
 [!code[FxCop.Usage.MarkSerializable#1](../codequality/codesnippet/VisualBasic/ca2237--mark-iserializable-types-with-serializableattribute_1.vb)]
[!code[FxCop.Usage.MarkSerializable#1](../codequality/codesnippet/CSharp/ca2237--mark-iserializable-types-with-serializableattribute_1.cs)]  
  
## Related Rules  
 [CA2236: Call base class methods on ISerializable types](../codequality/ca2236--call-base-class-methods-on-iserializable-types.md)  
  
 [CA2240: Implement ISerializable correctly](../codequality/ca2240--implement-iserializable-correctly.md)  
  
 [CA2229: Implement serialization constructors](../codequality/ca2229--implement-serialization-constructors.md)  
  
 [CA2238: Implement serialization methods correctly](../codequality/ca2238--implement-serialization-methods-correctly.md)  
  
 [CA2235: Mark all non-serializable fields](../codequality/ca2235--mark-all-non-serializable-fields.md)  
  
 [CA2239: Provide deserialization methods for optional fields](../codequality/ca2239--provide-deserialization-methods-for-optional-fields.md)  
  
 [CA2120: Secure serialization constructors](../codequality/ca2120--secure-serialization-constructors.md)