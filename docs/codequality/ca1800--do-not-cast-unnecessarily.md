---
title: "CA1800: Do not cast unnecessarily"
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
  - "CA1800"
  - "DoNotCastUnnecessarily"
helpviewer_keywords: 
  - "DoNotCastUnnecessarily"
  - "CA1800"
ms.assetid: b79a010a-6627-421e-8955-6007e32fa808
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
# CA1800: Do not cast unnecessarily
|||  
|-|-|  
|TypeName|DoNotCastUnnecessarily|  
|CheckId|CA1800|  
|Category|Microsoft.Performance|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A method performs duplicate casts on one of its arguments or local variables. For complete analysis by this rule, the tested assembly must be built by using debugging information and the associated program database (.pdb) file must be available.  
  
## Rule Description  
 Duplicate casts decrease performance, especially when the casts are performed in compact iteration statements. For explicit duplicate cast operations, store the result of the cast in a local variable and use the local variable instead of the duplicate cast operations.  
  
 If the C# `is` operator is used to test whether the cast will succeed before the actual cast is performed, consider testing the result of the `as` operator instead. This provides the same functionality without the implicit cast operation that is performed by the `is` operator.  
  
## How to Fix Violations  
 To fix a violation of this rule, modify the method implementation to minimize the number of cast operations.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule, or to ignore the rule completely, if performance is not a concern.  
  
## Example  
 The following example shows a method that violates the rule by using the C# `is` operator. A second method satisfies the rule by replacing the `is` operator with a test against the result of the `as` operator, which decreases the number of cast operations per iteration from two to one.  
  
 [!code[FxCop.Performance.UnnecessaryCastsAsIs#1](../codequality/codesnippet/CSharp/ca1800--do-not-cast-unnecessarily_1.cs)]  
  
## Example  
 The following example shows a method, `start_Click`, that has multiple duplicate explicit casts, which violates the rule, and a method, `reset_Click`, which satisfies the rule by storing the cast in a local variable.  
  
 [!code[FxCop.Performance.UnnecessaryCasts#1](../codequality/codesnippet/VisualBasic/ca1800--do-not-cast-unnecessarily_2.vb)]
[!code[FxCop.Performance.UnnecessaryCasts#1](../codequality/codesnippet/CSharp/ca1800--do-not-cast-unnecessarily_2.cs)]  
  
## See Also  
 [as](../Topic/as%20\(C%23%20Reference\).md)   
 [is](../Topic/is%20\(C%23%20Reference\).md)