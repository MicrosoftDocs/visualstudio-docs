---
title: "CA2222: Do not decrease inherited member visibility"
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
  - "DoNotDecreaseInheritedMemberVisibility"
  - "CA2222"
helpviewer_keywords: 
  - "DoNotDecreaseInheritedMemberVisibility"
  - "CA2222"
ms.assetid: 066c8675-381f-43cc-956c-d757cc494028
caps.latest.revision: 14
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
# CA2222: Do not decrease inherited member visibility
|||  
|-|-|  
|TypeName|DoNotDecreaseInheritedMemberVisibility|  
|CheckId|CA2222|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A private method in an unsealed type has a signature that is identical to a public method declared in a base type. The private method is not final.  
  
## Rule Description  
 You should not change the access modifier for inherited members. Changing an inherited member to private does not prevent callers from accessing the base class implementation of the method. If the member is made private and the type is unsealed, inheriting types can call the last public implementation of the method in the inheritance hierarchy. If you must change the access modifier, either the method should be marked final or its type should be sealed to prevent the method from being overridden.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the access to be non-private. Alternatively, if your programming language supports it, you can make the method final.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows a type that violates this rule.  
  
 [!code[FxCop.Usage.InheritedPublic#1](../codequality/codesnippet/VisualBasic/ca2222--do-not-decrease-inherited-member-visibility_1.vb)]
[!code[FxCop.Usage.InheritedPublic#1](../codequality/codesnippet/CSharp/ca2222--do-not-decrease-inherited-member-visibility_1.cs)]