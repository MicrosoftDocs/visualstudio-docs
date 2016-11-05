---
title: "CA2237: Mark ISerializable types with SerializableAttribute | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "CA2237"
  - "MarkISerializableTypesWithSerializable"
helpviewer_keywords: 
  - "MarkISerializableTypesWithSerializable"
  - "CA2237"
ms.assetid: 9bd6bb24-a527-43dd-9952-043c0c694f46
caps.latest.revision: 13
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
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
 An externally visible type implements the <xref:System.Runtime.Serialization.ISerializable?displayProperty=fullName> interface and the type is not marked with the <xref:System.SerializableAttribute?displayProperty=fullName> attribute. The rule ignores derived types whose base type is not serializable.  
  
## Rule Description  
 To be recognized by the common language runtime as serializable, types must be marked with the <xref:System.SerializableAttribute> attribute even if the type uses a custom serialization routine through implementation of the <xref:System.Runtime.Serialization.ISerializable> interface.  
  
## How to Fix Violations  
 To fix a violation of this rule, apply the <xref:System.SerializableAttribute> attribute to the type.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule for exception classes because they must be serializable to work correctly across application domains.  
  
## Example  
 The following example shows a type that violates the rule. Uncomment the <xref:System.SerializableAttribute> attribute line to satisfy the rule.  
  
 [!code-vb[FxCop.Usage.MarkSerializable#1](../code-quality/codesnippet/VisualBasic/ca2237-mark-iserializable-types-with-serializableattribute_1.vb)]
 [!code-cs[FxCop.Usage.MarkSerializable#1](../code-quality/codesnippet/CSharp/ca2237-mark-iserializable-types-with-serializableattribute_1.cs)]  
  
## Related Rules  
 [CA2236: Call base class methods on ISerializable types](../code-quality/ca2236-call-base-class-methods-on-iserializable-types.md)  
  
 [CA2240: Implement ISerializable correctly](../code-quality/ca2240-implement-iserializable-correctly.md)  
  
 [CA2229: Implement serialization constructors](../code-quality/ca2229-implement-serialization-constructors.md)  
  
 [CA2238: Implement serialization methods correctly](../code-quality/ca2238-implement-serialization-methods-correctly.md)  
  
 [CA2235: Mark all non-serializable fields](../code-quality/ca2235-mark-all-non-serializable-fields.md)  
  
 [CA2239: Provide deserialization methods for optional fields](../code-quality/ca2239-provide-deserialization-methods-for-optional-fields.md)  
  
 [CA2120: Secure serialization constructors](../code-quality/ca2120-secure-serialization-constructors.md)