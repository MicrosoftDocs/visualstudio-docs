---
title: "CA1819: Properties should not return arrays | Microsoft Docs"
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
  - "PropertiesShouldNotReturnArrays"
  - "CA1819"
helpviewer_keywords: 
  - "PropertiesShouldNotReturnArrays"
  - "CA1819"
ms.assetid: 85fcf312-57f8-438a-8b10-34441fe0bdeb
caps.latest.revision: 22
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
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
 [!code-cs[FxCop.Performance.PropertyArrayViolation#1](../code-quality/codesnippet/CSharp/ca1819-properties-should-not-return-arrays_1.cs)]
 [!code-vb[FxCop.Performance.PropertyArrayViolation#1](../code-quality/codesnippet/VisualBasic/ca1819-properties-should-not-return-arrays_1.vb)]  
  
### Comments  
 To fix a violation of this rule, either make the property a method or change the property to return a collection instead of an array.  
  
## Change the Property to a Method Example  
  
### Description  
 The following example fixes the violation by changing the property to a method.  
  
### Code  
 [!code-vb[FxCop.Performance.PropertyArrayFixedMethod#1](../code-quality/codesnippet/VisualBasic/ca1819-properties-should-not-return-arrays_2.vb)]
 [!code-cs[FxCop.Performance.PropertyArrayFixedMethod#1](../code-quality/codesnippet/CSharp/ca1819-properties-should-not-return-arrays_2.cs)]  
  
## Return a Collection Example  
  
### Description  
 The following example fixes the violation by changing the property to return a  
  
 <xref:System.Collection.ObjectModel.ReadOnlyCollection?displayProperty=fullName>.  
  
### Code  
 [!code-cs[FxCop.Performance.PropertyArrayFixedCollection#1](../code-quality/codesnippet/CSharp/ca1819-properties-should-not-return-arrays_3.cs)]
 [!code-vb[FxCop.Performance.PropertyArrayFixedCollection#1](../code-quality/codesnippet/VisualBasic/ca1819-properties-should-not-return-arrays_3.vb)]  
  
## Allowing Users to Modify a Property  
  
### Description  
 You might want to allow the consumer of the class to modify a property. The following example shows a read/write property that violates this rule.  
  
### Code  
 [!code-cs[FxCop.Performance.PropertyModifyViolation#1](../code-quality/codesnippet/CSharp/ca1819-properties-should-not-return-arrays_4.cs)]
 [!code-vb[FxCop.Performance.PropertyModifyViolation#1](../code-quality/codesnippet/VisualBasic/ca1819-properties-should-not-return-arrays_4.vb)]  
  
### Comments  
 The following example fixes the violation by changing the property to return a <xref:System.Collection.ObjectModel.Collection?displayProperty=fullName>.  
  
### Code  
 [!code-vb[FxCop.Performance.PropertyModifyFixed#1](../code-quality/codesnippet/VisualBasic/ca1819-properties-should-not-return-arrays_5.vb)]
 [!code-cs[FxCop.Performance.PropertyModifyFixed#1](../code-quality/codesnippet/CSharp/ca1819-properties-should-not-return-arrays_5.cs)]  
  
## Related Rules  
 [CA1024: Use properties where appropriate](../code-quality/ca1024-use-properties-where-appropriate.md)