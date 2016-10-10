---
title: "CA1052: Static holder types should be sealed"
ms.custom: na
ms.date: 10/04/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 51a3165d-781e-4a55-aa0d-ea25fee7d4f2
caps.latest.revision: 19
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
# CA1052: Static holder types should be sealed
|||  
|-|-|  
|TypeName|StaticHolderTypesShouldBeSealed|  
|CheckId|CA1052|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 A public or protected type contains only static members and is not declared with the [sealed](../Topic/sealed%20\(C%23%20Reference\).md) ([NotInheritable](../Topic/NotInheritable%20\(Visual%20Basic\).md)) modifier.  
  
## Rule Description  
 This rule assumes that a type that contains only static members is not designed to be inherited, because the type does not provide any functionality that can be overridden in a derived type. A type that is not meant to be inherited should be marked with the `sealed` modifier to prohibit its use as a base type.  
  
## How to Fix Violations  
 To fix a violation of this rule, mark the type as `sealed`. If you are targeting .NET Framework 2.0 or earlier, a better approach is to mark the type as `static`. In this manner, you avoid having to declare a private constructor to prevent the class from being created.  
  
## When to Suppress Warnings  
 Suppress a warning from this rule only if the type is designed to be inherited. The absence of the `sealed` modifier suggests that the type is useful as a base type.  
  
## Example of a Violation  
  
### Description  
 The following example shows a type that violates the rule.  
  
### Code  
 [!CODE [FxCop.Design.StaticMembers#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Design.StaticMembers#1)]  
  
## Fix with the Static Modifier  
  
### Description  
 The following example shows how to fix a violation of this rule by marking the type with the `static` modifier.  
  
### Code  
 [!CODE [FxCop.Design.StaticMembersFixed#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Design.StaticMembersFixed#1)]  
  
## Related Rules  
 [CA1053: Static holder types should not have constructors](../VS_IDE/CA1053--Static-holder-types-should-not-have-constructors.md)