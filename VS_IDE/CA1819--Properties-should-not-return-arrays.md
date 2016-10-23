---
title: "CA1819: Properties should not return arrays"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 85fcf312-57f8-438a-8b10-34441fe0bdeb
caps.latest.revision: 22
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
# CA1819: Properties should not return arrays
|||  
|-|-|  
|TypeName|PropertiesShouldNotReturnArrays|  
|CheckId|CA1819|  
|Category|Microsoft.Performance|  
|Breaking Change|Breaking|  
  
## Cause  
 A public or protected property in a public type returns an array.  
  
## Rule Description  
 Arrays returned by properties are not write-protected, even if the property is read-only. To keep the array tamper-proof, the property must return a copy of the array. Typically, users will not understand the adverse performance implications of calling such a property. Specifically, they might use the property as an indexed property.  
  
## How to Fix Violations  
 To fix a violation of this rule, either make the property a method or change the property to return a collection.  
  
## When to Suppress Warnings  
 Attributes can contain properties that return arrays, but cannot contain properties that return collections. You can suppress a warning that is raised for a property of an attribute that is derived from the [System.Attribute](assetId:///System.Attribute?qualifyHint=False&autoUpgrade=True) class. Otherwise, do not suppress a warning from this rule.  
  
## Example Violation  
  
### Description  
 The following example shows a property that violates this rule.  
  
### Code  
 [!CODE [FxCop.Performance.PropertyArrayViolation#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Performance.PropertyArrayViolation#1)]  
  
### Comments  
 To fix a violation of this rule, either make the property a method or change the property to return a collection instead of an array.  
  
## Change the Property to a Method Example  
  
### Description  
 The following example fixes the violation by changing the property to a method.  
  
### Code  
 [!CODE [FxCop.Performance.PropertyArrayFixedMethod#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Performance.PropertyArrayFixedMethod#1)]  
  
## Return a Collection Example  
  
### Description  
 The following example fixes the violation by changing the property to return a  
  
 <xref:System.Collection.ObjectModel.ReadOnlyCollection?qualifyHint=True>.  
  
### Code  
 [!CODE [FxCop.Performance.PropertyArrayFixedCollection#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Performance.PropertyArrayFixedCollection#1)]  
  
## Allowing Users to Modify a Property  
  
### Description  
 You might want to allow the consumer of the class to modify a property. The following example shows a read/write property that violates this rule.  
  
### Code  
 [!CODE [FxCop.Performance.PropertyModifyViolation#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Performance.PropertyModifyViolation#1)]  
  
### Comments  
 The following example fixes the violation by changing the property to return a <xref:System.Collection.ObjectModel.Collection?qualifyHint=True>.  
  
### Code  
 [!CODE [FxCop.Performance.PropertyModifyFixed#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Performance.PropertyModifyFixed#1)]  
  
## Related Rules  
 [CA1024: Use properties where appropriate](../VS_IDE/CA1024--Use-properties-where-appropriate.md)