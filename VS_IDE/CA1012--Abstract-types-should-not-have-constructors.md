---
title: "CA1012: Abstract types should not have constructors"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 09f458ac-dd88-4cd7-a47f-4106c1e80ece
caps.latest.revision: 25
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
# CA1012: Abstract types should not have constructors
|||  
|-|-|  
|TypeName|AbstractTypesShouldNotHaveConstructors|  
|CheckId|CA1012|  
|Category|Microsoft.Design|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A public type is abstract and has a public constructor.  
  
## Rule Description  
 Constructors on abstract types can be called only by derived types. Because public constructors create instances of a type, and you cannot create instances of an abstract type, an abstract type that has a public constructor is incorrectly designed.  
  
## How to Fix Violations  
 To fix a violation of this rule, either make the constructor protected or do not declare the type as abstract.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule. The abstract type has a public constructor.  
  
## Example  
 The following example contains an abstract type that violates this rule.  
  
 [!CODE [FxCop.Design.AbstractTypeBad#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Design.AbstractTypeBad#1)]  
  
## Example  
 The following example fixes the previous violation by changing the accessibility of the constructor from `public` to `protected`.  
  
 [!CODE [FxCop.Design.AbstractTypeGood#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Design.AbstractTypeGood#1)]