---
title: "CA2229: Implement serialization constructors"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8e04d5fe-dfad-445a-972e-0648324fac45
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
# CA2229: Implement serialization constructors
|||  
|-|-|  
|TypeName|ImplementSerializationConstructors|  
|CheckId|CA2229|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 The type implements the <xref:System.Runtime.Serialization.ISerializable?qualifyHint=True> interface, is not a delegate or interface, and one of the following conditions is true:  
  
-   The type does not have a constructor that takes a <xref:System.Runtime.Serialization.SerializationInfo?qualifyHint=True> object and a <xref:System.Runtime.Serialization.StreamingContext?qualifyHint=True> object (the signature of the serialization constructor).  
  
-   The type is unsealed and the access modifier for its serialization constructor is not protected (family).  
  
-   The type is sealed and the access modifier for its serialization constructor is not private.  
  
## Rule Description  
 This rule is relevant for types that support custom serialization. A type supports custom serialization if it implements the <xref:System.Runtime.Serialization.ISerializable?qualifyHint=False> interface. The serialization constructor is required to deserialize, or re-create objects that have been serialized using the <xref:System.Runtime.Serialization.ISerializable.GetObjectData?qualifyHint=True> method.  
  
## How to Fix Violations  
 To fix a violation of this rule, implement the serialization constructor. For a sealed class, make the constructor private; otherwise, make it protected.  
  
## When to Suppress Warnings  
 Do not suppress a violation of the rule. The type will not be deserializable, and will not function in many scenarios.  
  
## Example  
 The following example shows a type that satisfies the rule.  
  
 [!CODE [FxCop.Usage.ISerializableCtor#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.ISerializableCtor#1)]  
  
## Related Rules  
 [CA2237: Mark ISerializable types with SerializableAttribute](../VS_IDE/CA2237--Mark-ISerializable-types-with-SerializableAttribute.md)  
  
## See Also  
 <xref:System.Runtime.Serialization.ISerializable?qualifyHint=True>   
 <xref:System.Runtime.Serialization.SerializationInfo?qualifyHint=True>   
 <xref:System.Runtime.Serialization.StreamingContext?qualifyHint=True>