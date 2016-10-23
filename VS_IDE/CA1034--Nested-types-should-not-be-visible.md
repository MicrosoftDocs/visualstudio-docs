---
title: "CA1034: Nested types should not be visible"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e9789a2c-2540-42a1-8705-ae7104011194
caps.latest.revision: 18
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
# CA1034: Nested types should not be visible
|||  
|-|-|  
|TypeName|NestedTypesShouldNotBeVisible|  
|CheckId|CA1034|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 An externally visible type contains an externally visible type declaration. Nested enumerations and protected types are exempt from this rule.  
  
## Rule Description  
 A nested type is a type declared within the scope of another type. Nested types are useful for encapsulating private implementation details of the containing type. Used for this purpose, nested types should not be externally visible.  
  
 Do not use externally visible nested types for logical grouping or to avoid name collisions; instead, use namespaces.  
  
 Nested types include the notion of member accessibility, which some programmers do not understand clearly.  
  
 Protected types can be used in subclasses and nested types in advance customization scenarios.  
  
## How to Fix Violations  
 If you do not intend the nested type to be externally visible, change the type's accessibility. Otherwise, remove the nested type from its parent. If the purpose of the nesting is to categorize the nested type, use a namespace to create the hierarchy instead.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows a type that violates the rule.  
  
 [!CODE [FxCop.Design.NestedTypes#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Design.NestedTypes#1)]