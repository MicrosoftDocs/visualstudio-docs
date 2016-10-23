---
title: "CA1006: Do not nest generic types in member signatures"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: dfc867bc-f4af-45d7-b071-db04a248f9fc
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
# CA1006: Do not nest generic types in member signatures
|||  
|-|-|  
|TypeName|DoNotNestGenericTypesInMemberSignatures|  
|CheckId|CA1006|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 An externally visible member has a signature that contains a nested type argument.  
  
## Rule Description  
 A nested type argument is a type argument that is also a generic type. To call a member whose signature contains a nested type argument, the user must instantiate one generic type and pass this type to the constructor of a second generic type. The required procedure and syntax are complex and should be avoided.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the design to remove the nested type argument.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule. Providing generics in a syntax that is easy to understand and use reduces the time that is required to learn and increases the adoption rate of new libraries.  
  
## Example  
 The following example shows a method that violates the rule and the syntax that is required to call the violating method.  
  
 [!CODE [FxCop.Design.NestedGenerics#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Design.NestedGenerics#1)]  
  
## Related Rules  
 [CA1005: Avoid excessive parameters on generic types](../VS_IDE/CA1005--Avoid-excessive-parameters-on-generic-types.md)  
  
 [CA1010: Collections should implement generic interface](../VS_IDE/CA1010--Collections-should-implement-generic-interface.md)  
  
 [CA1000: Do not declare static members on generic types](../VS_IDE/CA1000--Do-not-declare-static-members-on-generic-types.md)  
  
 [CA1002: Do not expose generic lists](../VS_IDE/CA1002--Do-not-expose-generic-lists.md)  
  
 [CA1004: Generic methods should provide type parameter](../VS_IDE/CA1004--Generic-methods-should-provide-type-parameter.md)  
  
 [CA1003: Use generic event handler instances](../VS_IDE/CA1003--Use-generic-event-handler-instances.md)  
  
 [CA1007: Use generics where appropriate](../VS_IDE/CA1007--Use-generics-where-appropriate.md)  
  
## See Also  
 [Generics](../Topic/Generics%20\(C%23%20Programming%20Guide\).md)