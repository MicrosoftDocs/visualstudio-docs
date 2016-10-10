---
title: "CA1018: Mark attributes with AttributeUsageAttribute"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 6ab70ec0-220f-4880-af31-45067703133c
caps.latest.revision: 17
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# CA1018: Mark attributes with AttributeUsageAttribute
|||  
|-|-|  
|TypeName|MarkAttributesWithAttributeUsage|  
|CheckId|CA1018|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 The <xref:System.AttributeUsageAttribute?qualifyHint=True> attribute is not present on the custom attribute.  
  
## Rule Description  
 When you define a custom attribute, mark it by using <xref:System.AttributeUsageAttribute?qualifyHint=False> to indicate where in the source code the custom attribute can be applied. The meaning and intended usage of an attribute will determine its valid locations in code. For example, you might define an attribute that identifies the person who is responsible for maintaining and enhancing each type in a library, and that responsibility is always assigned at the type level. In this case, compilers should enable the attribute on classes, enumerations, and interfaces, but should not enable it on methods, events, or properties. Organizational policies and procedures would dictate whether the attribute should be enabled on assemblies.  
  
 The <xref:System.AttributeTargets?qualifyHint=True> enumeration defines the targets that you can specify for a custom attribute. If you omit <xref:System.AttributeUsageAttribute?qualifyHint=False>, your custom attribute will be valid for all targets, as defined by the `All` value of <xref:System.AttributeTargets?qualifyHint=False> enumeration.  
  
## How to Fix Violations  
 To fix a violation of this rule, specify targets for the attribute by using <xref:System.AttributeUsageAttribute?qualifyHint=False>. See the following example.  
  
## When to Suppress Warnings  
 You should fix a violation of this rule instead of excluding the message. Even if the attribute inherits <xref:System.AttributeUsageAttribute?qualifyHint=False>, the attribute should be present to simplify code maintenance.  
  
## Example  
 The following example defines two attributes. `BadCodeMaintainerAttribute` incorrectly omits the <xref:System.AttributeUsageAttribute?qualifyHint=False> statement, and `GoodCodeMaintainerAttribute` correctly implements the attribute that is described earlier in this section. Note that the property `DeveloperName` is required by the design rule [CA1019: Define accessors for attribute arguments](../VS_IDE/CA1019--Define-accessors-for-attribute-arguments.md) and is included for completeness.  
  
 [!CODE [FxCop.Design.AttributeUsage#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Design.AttributeUsage#1)]  
  
## Related Rules  
 [CA1019: Define accessors for attribute arguments](../VS_IDE/CA1019--Define-accessors-for-attribute-arguments.md)  
  
 [CA1813: Avoid unsealed attributes](../VS_IDE/CA1813--Avoid-unsealed-attributes.md)  
  
## See Also  
 [Attributes](../Topic/Attributes1.md)