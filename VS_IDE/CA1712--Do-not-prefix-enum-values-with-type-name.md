---
title: "CA1712: Do not prefix enum values with type name"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: df0e3a12-67bf-48f1-a10b-2ef60484a5c7
caps.latest.revision: 15
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
# CA1712: Do not prefix enum values with type name
|||  
|-|-|  
|TypeName|DoNotPrefixEnumValuesWithTypeName|  
|CheckId|CA1712|  
|Category|Microsoft.Naming|  
|Breaking Change|Breaking|  
  
## Cause  
 An enumeration contains a member whose name starts with the type name of the enumeration.  
  
## Rule Description  
 Names of enumeration members are not prefixed with the type name because type information is expected to be provided by development tools.  
  
 Naming conventions provide a common look for libraries that target the common language runtime. This reduces the time that is required for to learn a new software library, and increases customer confidence that the library was developed by someone who has expertise in developing managed code.  
  
## How to Fix Violations  
 To fix a violation of this rule, remove the type name prefix from the enumeration member.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows an incorrectly named enumeration followed by the corrected version.  
  
 [!CODE [FxCop.Naming.EnumValues#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Naming.EnumValues#1)]  
  
## Related Rules  
 [CA1711: Identifiers should not have incorrect suffix](../VS_IDE/CA1711--Identifiers-should-not-have-incorrect-suffix.md)  
  
 [CA1027: Mark enums with FlagsAttribute](../VS_IDE/CA1027--Mark-enums-with-FlagsAttribute.md)  
  
 [CA2217: Do not mark enums with FlagsAttribute](../VS_IDE/CA2217--Do-not-mark-enums-with-FlagsAttribute.md)  
  
## See Also  
 <xref:System.Enum?qualifyHint=True>