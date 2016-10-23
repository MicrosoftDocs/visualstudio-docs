---
title: "CA1010: Collections should implement generic interface"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c7d7126f-fa70-40be-8f93-3243e1760dc5
caps.latest.revision: 24
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
# CA1010: Collections should implement generic interface
|||  
|-|-|  
|TypeName|CollectionsShouldImplementGenericInterface|  
|CheckId|CA1010|  
|Category|Microsoft.Design|  
|Breaking Change|Non-breaking|  
  
## Cause  
 An externally visible type implements the <xref:System.Collections.IEnumerable?qualifyHint=True> interface but does not implement the <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=True> interface, and the containing assembly targets .NET Framework 2.0. This rule ignores types that implement <xref:System.Collections.IDictionary?qualifyHint=True>.  
  
## Rule Description  
 To broaden the usability of a collection, implement one of the generic collection interfaces. Then the collection can be used to populate generic collection types such as the following:  
  
-   <xref:System.Collections.Generic.List`1?qualifyHint=True>  
  
-   <xref:System.Collections.Generic.Queue`1?qualifyHint=True>  
  
-   <xref:System.Collections.Generic.Stack`1?qualifyHint=True>  
  
## How to Fix Violations  
 To fix a violation of this rule, implement one of the following generic collection interfaces:  
  
-   <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=True>  
  
-   <xref:System.Collections.Generic.ICollection`1?qualifyHint=True>  
  
-   <xref:System.Collections.Generic.IList`1?qualifyHint=True>  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule; however, the collection will have a more limited use.  
  
## Example Violation  
  
### Description  
 The following example shows a class (reference type) that derives from the non-generic `CollectionBase` class, which violates this rule.  
  
### Code  
 [!CODE [FxCop.Design.CollectionsGenericViolation#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Design.CollectionsGenericViolation#1)]  
  
### Comments  
 To fix a violation of this violation, you should either implement the generic interfaces or change the base class to a type that already implements both the generic and non-generic interfaces, such as the `Collection<T>` class.  
  
## Fix by Base Class Change  
  
### Description  
 The following example fixes the violation by changing the base class of the collection from the non-generic `CollectionBase` class to the generic `Collection<T>` (`Collection(Of T)` in Visual Basic) class.  
  
### Code  
 [!CODE [FxCop.Design.CollectionsGenericBase#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Design.CollectionsGenericBase#1)]  
  
### Comments  
 Changing the base class of an already released class is considered a breaking change to existing consumers.  
  
## Fix by Interface Implementation  
  
### Description  
 The following example fixes the violation by implementing these generic interfaces: `IEnumerable<T>`, `ICollection<T>`, and `IList<T>` (`IEnumerable(Of T)`, `ICollection(Of T)`, and `IList(Of T)` in Visual Basic).  
  
### Code  
 [!CODE [FxCop.Design.CollectionsGenericInterface#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Design.CollectionsGenericInterface#1)]  
  
## Related Rules  
 [CA1005: Avoid excessive parameters on generic types](../VS_IDE/CA1005--Avoid-excessive-parameters-on-generic-types.md)  
  
 [CA1000: Do not declare static members on generic types](../VS_IDE/CA1000--Do-not-declare-static-members-on-generic-types.md)  
  
 [CA1002: Do not expose generic lists](../VS_IDE/CA1002--Do-not-expose-generic-lists.md)  
  
 [CA1006: Do not nest generic types in member signatures](../VS_IDE/CA1006--Do-not-nest-generic-types-in-member-signatures.md)  
  
 [CA1004: Generic methods should provide type parameter](../VS_IDE/CA1004--Generic-methods-should-provide-type-parameter.md)  
  
 [CA1003: Use generic event handler instances](../VS_IDE/CA1003--Use-generic-event-handler-instances.md)  
  
 [CA1007: Use generics where appropriate](../VS_IDE/CA1007--Use-generics-where-appropriate.md)  
  
## See Also  
 [Generics](../Topic/Generics%20\(C%23%20Programming%20Guide\).md)