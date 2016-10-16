---
title: "CA1708: Identifiers should differ by more than case"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IdentifiersShouldDifferByMoreThanCase"
  - "CA1708"
helpviewer_keywords: 
  - "CA1708"
  - "IdentifiersShouldDifferByMoreThanCase"
ms.assetid: dac0f01d-dd21-484d-add1-c8cd2bf6969f
caps.latest.revision: 21
ms.author: "douge"
manager: "douge"
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
# CA1708: Identifiers should differ by more than case
|||  
|-|-|  
|TypeName|IdentifiersShouldDifferByMoreThanCase|  
|CheckId|CA1708|  
|Category|Microsoft.Naming|  
|Breaking Change|Breaking|  
  
## Cause  
 The names of two types, members, parameters, or fully qualified namespaces are identical when they are converted to lowercase.  
  
## Rule Description  
 Identifiers for namespaces, types, members, and parameters cannot differ only by case because languages that target the common language runtime are not required to be case-sensitive. For example, [!INCLUDE[vbprvb](../codequality/includes/vbprvb_md.md)] is a widely used case-insensitive language.  
  
 This rule fires on publicly visible members only.  
  
## How to Fix Violations  
 Select a name that is unique when it is compared to other identifiers in a case-insensitive manner.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule. The library might not be usable in all available languages in the [!INCLUDE[dnprdnshort](../codequality/includes/dnprdnshort_md.md)].  
  
## Example of a Violation  
 The following example demonstrates a violation of this rule.  
  
 [!code[FxCop.Naming.IdentifiersShouldDifferByMoreThanCase#1](../codequality/codesnippet/CSharp/ca1708--identifiers-should-differ-by-more-than-case_1.cs)]  
  
## Related Rules  
 [CA1709: Identifiers should be cased correctly](../codequality/ca1709--identifiers-should-be-cased-correctly.md)