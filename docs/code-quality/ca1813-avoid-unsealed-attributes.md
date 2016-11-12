---
title: "CA1813: Avoid unsealed attributes | Microsoft Docs"
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
  - "CA1813"
  - "AvoidUnsealedAttributes"
helpviewer_keywords: 
  - "CA1813"
  - "AvoidUnsealedAttributes"
ms.assetid: f5e31b4c-9f8b-49e1-a2a8-bb5f1140729a
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
# CA1813: Avoid unsealed attributes
|||  
|-|-|  
|TypeName|AvoidUnsealedAttributes|  
|CheckId|CA1813|  
|Category|Microsoft.Performance|  
|Breaking Change|Breaking|  
  
## Cause  
 A public type inherits from <xref:System.Attribute?displayProperty=fullName>, is not abstract, and is not sealed (`NotInheritable` in Visual Basic).  
  
## Rule Description  
 The [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] class library provides methods for retrieving custom attributes. By default, these methods search the attribute inheritance hierarchy; for example <xref:System.Attribute.GetCustomAttribute%2A?displayProperty=fullName> searches for the specified attribute type, or any attribute type that extends the specified attribute type. Sealing the attribute eliminates the search through the inheritance hierarchy, and can improve performance.  
  
## How to Fix Violations  
 To fix a violation of this rule, seal the attribute type or make it abstract.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule. You should do this only if you are defining an attribute hierarchy and cannot seal the attribute or make it abstract.  
  
## Example  
 The following example shows a custom attribute that satisfies this rule.  
  
 [!code-cs[FxCop.Performance.AttributesSealed#1](../code-quality/codesnippet/CSharp/ca1813-avoid-unsealed-attributes_1.cs)]
 [!code-vb[FxCop.Performance.AttributesSealed#1](../code-quality/codesnippet/VisualBasic/ca1813-avoid-unsealed-attributes_1.vb)]  
  
## Related Rules  
 [CA1019: Define accessors for attribute arguments](../code-quality/ca1019-define-accessors-for-attribute-arguments.md)  
  
 [CA1018: Mark attributes with AttributeUsageAttribute](../code-quality/ca1018-mark-attributes-with-attributeusageattribute.md)  
  
## See Also  
 [Attributes](../Topic/Attributes1.md)