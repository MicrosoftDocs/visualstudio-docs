---
title: "CA2240: Implement ISerializable correctly"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: cf05936d-0d6c-49ed-a1b4-220032e50b97
caps.latest.revision: 21
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
# CA2240: Implement ISerializable correctly
|||  
|-|-|  
|TypeName|ImplementISerializableCorrectly|  
|CheckId|CA2240|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 An externally visible type is assignable to the <xref:System.Runtime.Serialization.ISerializable?qualifyHint=True> interface and one of the following conditions is true:  
  
-   The type inherits but does not override the <xref:System.Runtime.Serialization.ISerializable.GetObjectData?qualifyHint=True> method and the type declares instance fields that are not marked with the <xref:System.NonSerializedAttribute?qualifyHint=True> attribute.  
  
-   The type is not sealed and the type implements a <xref:System.Runtime.Serialization.ISerializable.GetObjectData?qualifyHint=False> method that is not externally visible and overridable.  
  
## Rule Description  
 Instance fields that are declared in a type that inherits the <xref:System.Runtime.Serialization.ISerializable?qualifyHint=True> interface are not automatically included in the serialization process. To include the fields, the type must implement the <xref:System.Runtime.Serialization.ISerializable.GetObjectData?qualifyHint=False> method and the serialization constructor. If the fields should not be serialized, apply the <xref:System.NonSerializedAttribute?qualifyHint=False> attribute to the fields to explicitly indicate the decision.  
  
 In types that are not sealed, implementations of the <xref:System.Runtime.Serialization.ISerializable.GetObjectData?qualifyHint=False> method should be externally visible. Therefore, the method can be called by derived types, and is overridable.  
  
## How to Fix Violations  
 To fix a violation of this rule, make the <xref:System.Runtime.Serialization.ISerializable.GetObjectData?qualifyHint=False> method visible and overridable and make sure all instance fields are included in the serialization process or explicitly marked with the <xref:System.NonSerializedAttribute?qualifyHint=False> attribute.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows two serializable types that violate the rule.  
  
 [!CODE [FxCop.Usage.ImplementISerializableCorrectly#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.ImplementISerializableCorrectly#1)]  
  
## Example  
 The following example fixes the two previous violations by providing an overrideable implementation of [ISerializable.GetObjectData](assetId:///ISerializable.GetObjectData?qualifyHint=False&autoUpgrade=False) on the Book class and by providing an implementation of assetId:///ISerializable.GetObjectData?qualifyHint=False&autoUpgrade=False on the Library class.  
  
 [!CODE [FxCop.Usage.ImplementISerializableCorrectly2#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.ImplementISerializableCorrectly2#1)]  
  
## Related Rules  
 [CA2236: Call base class methods on ISerializable types](../VS_IDE/CA2236--Call-base-class-methods-on-ISerializable-types.md)  
  
 [CA2229: Implement serialization constructors](../VS_IDE/CA2229--Implement-serialization-constructors.md)  
  
 [CA2238: Implement serialization methods correctly](../VS_IDE/CA2238--Implement-serialization-methods-correctly.md)  
  
 [CA2235: Mark all non-serializable fields](../VS_IDE/CA2235--Mark-all-non-serializable-fields.md)  
  
 [CA2237: Mark ISerializable types with SerializableAttribute](../VS_IDE/CA2237--Mark-ISerializable-types-with-SerializableAttribute.md)  
  
 [CA2239: Provide deserialization methods for optional fields](../VS_IDE/CA2239--Provide-deserialization-methods-for-optional-fields.md)  
  
 [CA2120: Secure serialization constructors](../VS_IDE/CA2120--Secure-serialization-constructors.md)