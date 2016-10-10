---
title: "CA2235: Mark all non-serializable fields"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 599ad877-3a15-426c-bf17-5de15427365f
caps.latest.revision: 13
manager: douge
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# CA2235: Mark all non-serializable fields
|||  
|-|-|  
|TypeName|MarkAllNonSerializableFields|  
|CheckId|CA2235|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 An instance field of a type that is not serializable is declared in a type that is serializable.  
  
## Rule Description  
 A serializable type is one that is marked with the <xref:System.SerializableAttribute?qualifyHint=True> attribute. When the type is serialized, a <xref:System.Runtime.Serialization.SerializationException?qualifyHint=True> exception is thrown if a type contains an instance field of a type that is not serializable.  
  
## How to Fix Violations  
 To fix a violation of this rule, apply the <xref:System.NonSerializedAttribute?qualifyHint=True> attribute to the field that is not serializable.  
  
## When to Suppress Warnings  
 Only suppress a warning from this rule if a <xref:System.Runtime.Serialization.ISerializationSurrogate?qualifyHint=True> type is declared that allows instances of the field to be serialized and deserialized.  
  
## Example  
 The following example shows a type that violates the rule and a type that satisfies the rule.  
  
 [!CODE [FxCop.Usage.MarkNonSerializable#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.MarkNonSerializable#1)]  
  
## Related Rules  
 [CA2236: Call base class methods on ISerializable types](../VS_IDE/CA2236--Call-base-class-methods-on-ISerializable-types.md)  
  
 [CA2240: Implement ISerializable correctly](../VS_IDE/CA2240--Implement-ISerializable-correctly.md)  
  
 [CA2229: Implement serialization constructors](../VS_IDE/CA2229--Implement-serialization-constructors.md)  
  
 [CA2238: Implement serialization methods correctly](../VS_IDE/CA2238--Implement-serialization-methods-correctly.md)  
  
 [CA2237: Mark ISerializable types with SerializableAttribute](../VS_IDE/CA2237--Mark-ISerializable-types-with-SerializableAttribute.md)  
  
 [CA2239: Provide deserialization methods for optional fields](../VS_IDE/CA2239--Provide-deserialization-methods-for-optional-fields.md)  
  
 [CA2120: Secure serialization constructors](../VS_IDE/CA2120--Secure-serialization-constructors.md)