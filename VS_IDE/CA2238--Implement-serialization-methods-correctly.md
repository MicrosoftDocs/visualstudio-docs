---
title: "CA2238: Implement serialization methods correctly"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 00882cf9-e10d-4d40-9126-3e6753e3c934
caps.latest.revision: 16
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
  
-   <xref:System.Runtime.Serialization.OnSerializingAttribute?qualifyHint=True>  
  
-   <xref:System.Runtime.Serialization.OnSerializedAttribute?qualifyHint=True>  
  
-   <xref:System.Runtime.Serialization.OnDeserializingAttribute?qualifyHint=True>  
  
-   <xref:System.Runtime.Serialization.OnDeserializedAttribute?qualifyHint=True>  
  
 Serialization event handlers take a single parameter of type <xref:System.Runtime.Serialization.StreamingContext?qualifyHint=True>, return `void`, and have `private` visibility.  
  
## How to Fix Violations  
 To fix a violation of this rule, correct the signature, return type, or visibility of the serialization event handler.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows correctly declared serialization event handlers.  
  
 [!CODE [FxCop.Usage.SerializationEventHandlers#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.SerializationEventHandlers#1)]  
  
## Related Rules  
 [CA2236: Call base class methods on ISerializable types](../VS_IDE/CA2236--Call-base-class-methods-on-ISerializable-types.md)  
  
 [CA2240: Implement ISerializable correctly](../VS_IDE/CA2240--Implement-ISerializable-correctly.md)  
  
 [CA2229: Implement serialization constructors](../VS_IDE/CA2229--Implement-serialization-constructors.md)  
  
 [CA2235: Mark all non-serializable fields](../VS_IDE/CA2235--Mark-all-non-serializable-fields.md)  
  
 [CA2237: Mark ISerializable types with SerializableAttribute](../VS_IDE/CA2237--Mark-ISerializable-types-with-SerializableAttribute.md)  
  
 [CA2239: Provide deserialization methods for optional fields](../VS_IDE/CA2239--Provide-deserialization-methods-for-optional-fields.md)  
  
 [CA2120: Secure serialization constructors](../VS_IDE/CA2120--Secure-serialization-constructors.md)