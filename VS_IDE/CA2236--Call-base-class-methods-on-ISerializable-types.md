---
title: "CA2236: Call base class methods on ISerializable types"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 5a15b20d-769c-4640-b31a-36e07077daae
caps.latest.revision: 15
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
# CA2236: Call base class methods on ISerializable types
|||  
|-|-|  
|TypeName|CallBaseClassMethodsOnISerializableTypes|  
|CheckId|CA2236|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A type derives from a type that implements the <xref:System.Runtime.Serialization.ISerializable?qualifyHint=True> interface, and one of the following conditions is true:  
  
-   The type implements the serialization constructor, that is, a constructor with the <xref:System.Runtime.Serialization.SerializationInfo?qualifyHint=True>, <xref:System.Runtime.Serialization.StreamingContext?qualifyHint=True> parameter signature, but does not call the serialization constructor of the base type.  
  
-   The type implements the <xref:System.Runtime.Serialization.ISerializable.GetObjectData?qualifyHint=True> method but does not call the <xref:System.Runtime.Serialization.ISerializable.GetObjectData?qualifyHint=False> method of the base type.  
  
## Rule Description  
 In a custom serialization process, a type implements the <xref:System.Runtime.Serialization.ISerializable.GetObjectData?qualifyHint=False> method to serialize its fields and the serialization constructor to de-serialize the fields. If the type derives from a type that implements the <xref:System.Runtime.Serialization.ISerializable?qualifyHint=False> interface, the base type <xref:System.Runtime.Serialization.ISerializable.GetObjectData?qualifyHint=False> method and serialization constructor should be called to serialize/de-serialize the fields of the base type. Otherwise, the type will not be serialized and de-serialized correctly. Note that if the derived type does not add any new fields, the type does not need to implement the <xref:System.Runtime.Serialization.ISerializable.GetObjectData?qualifyHint=False> method nor the serialization constructor or call the base type equivalents.  
  
## How to Fix Violations  
 To fix a violation of this rule, call the base type <xref:System.Runtime.Serialization.ISerializable.GetObjectData?qualifyHint=False> method or serialization constructor from the corresponding derived type method or constructor.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows a derived type that satisfies the rule by calling the serialization constructor and <xref:System.Runtime.Serialization.ISerializable.GetObjectData?qualifyHint=False> method of the base class.  
  
 [!CODE [FxCop.Usage.CallBaseISerializable#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.CallBaseISerializable#1)]  
  
## Related Rules  
 [CA2240: Implement ISerializable correctly](../VS_IDE/CA2240--Implement-ISerializable-correctly.md)  
  
 [CA2229: Implement serialization constructors](../VS_IDE/CA2229--Implement-serialization-constructors.md)  
  
 [CA2238: Implement serialization methods correctly](../VS_IDE/CA2238--Implement-serialization-methods-correctly.md)  
  
 [CA2235: Mark all non-serializable fields](../VS_IDE/CA2235--Mark-all-non-serializable-fields.md)  
  
 [CA2237: Mark ISerializable types with SerializableAttribute](../VS_IDE/CA2237--Mark-ISerializable-types-with-SerializableAttribute.md)  
  
 [CA2239: Provide deserialization methods for optional fields](../VS_IDE/CA2239--Provide-deserialization-methods-for-optional-fields.md)  
  
 [CA2120: Secure serialization constructors](../VS_IDE/CA2120--Secure-serialization-constructors.md)