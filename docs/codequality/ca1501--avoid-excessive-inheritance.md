---
title: "CA1501: Avoid excessive inheritance"
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
  - "CA1501"
  - "AvoidExcessiveInheritance"
helpviewer_keywords: 
  - "AvoidExcessiveInheritance"
  - "CA1501"
ms.assetid: 9e934746-1a4d-492a-91e4-085201abafa4
caps.latest.revision: 17
ms.author: "douge"
manager: "douge"
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
# CA1501: Avoid excessive inheritance
|||  
|-|-|  
|TypeName|AvoidExcessiveInheritance|  
|CheckId|CA1501|  
|Category|Microsoft.Maintainability|  
|Breaking Change|Breaking|  
  
## Cause  
 A type is more than four levels deep in its inheritance hierarchy.  
  
## Rule Description  
 Deeply nested type hierarchies can be difficult to follow, understand, and maintain. This rule limits analysis to hierarchies in the same module.  
  
## How to Fix Violations  
 To fix a violation of this rule, derive the type from a base type that is less deep in the inheritance hierarchy or eliminate some of the intermediate base types.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule. However, the code might be more difficult to maintain. Note that, depending on the visibility of base types, resolving violations of this rule might create breaking changes. For example, removing public base types is a breaking change.  
  
## Example  
 The following example shows a type that violates the rule.  
  
 [!code[FxCop.Maintainability.ExcessiveInheritance#1](../codequality/codesnippet/CSharp/ca1501--avoid-excessive-inheritance_1.cs)]
[!code[FxCop.Maintainability.ExcessiveInheritance#1](../codequality/codesnippet/VisualBasic/ca1501--avoid-excessive-inheritance_1.vb)]