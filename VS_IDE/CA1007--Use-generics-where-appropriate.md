---
title: "CA1007: Use generics where appropriate"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: eab780ea-3b1f-4d32-b15a-5d48da2df46b
caps.latest.revision: 19
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
# CA1007: Use generics where appropriate
|||  
|-|-|  
|TypeName|UseGenericsWhereAppropriate|  
|CheckId|CA1007|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 An externally visible method contains a reference parameter of type <xref:System.Object?qualifyHint=True>, and the containing assembly targets .NET Framework 2.0.  
  
## Rule Description  
 A reference parameter is a parameter that is modified by using the `ref` (`ByRef` in Visual Basic) keyword. The argument type that is supplied for a reference parameter must exactly match the reference parameter type. To use a type that is derived from the reference parameter type, the type must first be cast and assigned to a variable of the reference parameter type. Use of a generic method allows all types, subject to constraints, to be passed to the method without first casting the type to the reference parameter type.  
  
## How to Fix Violations  
 To fix a violation of this rule, make the method generic and replace the <xref:System.Object?qualifyHint=False> parameter by using a type parameter.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows a general-purpose swap routine that is implemented as both nongeneric and generic methods. Note how efficiently the strings are swapped by using the generic method compared to the nongeneric method.  
  
 [!CODE [FxCop.Design.UseGenerics#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Design.UseGenerics#1)]  
  
## Related Rules  
 [CA1005: Avoid excessive parameters on generic types](../VS_IDE/CA1005--Avoid-excessive-parameters-on-generic-types.md)  
  
 [CA1010: Collections should implement generic interface](../VS_IDE/CA1010--Collections-should-implement-generic-interface.md)  
  
 [CA1000: Do not declare static members on generic types](../VS_IDE/CA1000--Do-not-declare-static-members-on-generic-types.md)  
  
 [CA1002: Do not expose generic lists](../VS_IDE/CA1002--Do-not-expose-generic-lists.md)  
  
 [CA1006: Do not nest generic types in member signatures](../VS_IDE/CA1006--Do-not-nest-generic-types-in-member-signatures.md)  
  
 [CA1004: Generic methods should provide type parameter](../VS_IDE/CA1004--Generic-methods-should-provide-type-parameter.md)  
  
 [CA1003: Use generic event handler instances](../VS_IDE/CA1003--Use-generic-event-handler-instances.md)  
  
## See Also  
 [Generics](../Topic/Generics%20\(C%23%20Programming%20Guide\).md)