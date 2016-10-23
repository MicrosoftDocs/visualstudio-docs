---
title: "CA2126: Type link demands require inheritance demands"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 07b604e5-5579-4df9-a578-dadd0d8370a7
caps.latest.revision: 17
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
# CA2126: Type link demands require inheritance demands
|||  
|-|-|  
|TypeName|TypeLinkDemandsRequireInheritanceDemands|  
|CheckId|CA2126|  
|Category|Microsoft.Security|  
|Breaking Change|Breaking|  
  
## Cause  
 A public unsealed type is protected with a link demand, has an overridable method, and neither the type nor the method is protected with an inheritance demand.  
  
## Rule Description  
 A link demand on a method or its declaring type requires the immediate caller of the method to have the specified permission. An inheritance demand on a method requires an overriding method to have the specified permission. An inheritance demand on a type requires a deriving class to have the specified permission.  
  
## How to Fix Violations  
 To fix a violation of this rule, secure the type or the method with an inheritance demand for the same permission as the link demand.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows a type that violates the rule.  
  
 [!CODE [FxCop.Security.TypesWithLinkDemands#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Security.TypesWithLinkDemands#1)]  
  
## Related Rules  
 [CA2108: Review declarative security on value types](../VS_IDE/CA2108--Review-declarative-security-on-value-types.md)  
  
 [CA2112: Secured types should not expose fields](../VS_IDE/CA2112--Secured-types-should-not-expose-fields.md)  
  
 [CA2122: Do not indirectly expose methods with link demands](../VS_IDE/CA2122--Do-not-indirectly-expose-methods-with-link-demands.md)  
  
 [CA2123: Override link demands should be identical to base](../VS_IDE/CA2123--Override-link-demands-should-be-identical-to-base.md)  
  
## See Also  
 [Secure Coding Guidelines](../Topic/Secure%20Coding%20Guidelines.md)   
 [Inheritance Demands](assetId:///28b9adbb-8f08-4f10-b856-dbf59eb932d9)   
 [Link Demands](../Topic/Link%20Demands.md)   
 [Demands](assetId:///e5283e28-2366-4519-b27d-ef5c1ddc1f48)