---
title: "CA1046: Do not overload operator equals on reference types | Microsoft Docs"
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
  - "DoNotOverloadOperatorEqualsOnReferenceTypes"
  - "CA1046"
helpviewer_keywords: 
  - "CA1046"
  - "DoNotOverloadOperatorEqualsOnReferenceTypes"
ms.assetid: c1dfbfe3-63f9-4005-a81a-890427b77e79
caps.latest.revision: 14
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
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
# CA1046: Do not overload operator equals on reference types
|||  
|-|-|  
|TypeName|DoNotOverloadOperatorEqualsOnReferenceTypes|  
|CheckId|CA1046|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 A public or nested public reference type overloads the equality operator.  
  
## Rule Description  
 For reference types, the default implementation of the equality operator is almost always correct. By default, two references are equal only if they point to the same object.  
  
## How to Fix Violations  
 To fix a violation of this rule, remove the implementation of the equality operator.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule when the reference type behaves like a built-in value type. If it is meaningful to do addition or subtraction on instances of the type, it is probably correct to implement the equality operator and suppress the violation.  
  
## Example  
 The following example demonstrates the default behavior when comparing two references.  
  
 [!code-cs[FxCop.Design.RefTypesNoEqualityOp#1](../code-quality/codesnippet/CSharp/ca1046-do-not-overload-operator-equals-on-reference-types_1.cs)]  
  
## Example  
 The following application compares some references.  
  
 [!code-cs[FxCop.Design.TestRefTypesNoEqualityOp#1](../code-quality/codesnippet/CSharp/ca1046-do-not-overload-operator-equals-on-reference-types_2.cs)]  
  
 This example produces the following output.  
  
 **a = new (2,2) and b = new (2,2) are equal? No**  
**c and a are equal? Yes**  
**b and a are == ? No**  
**c and a are == ? Yes**   
## Related Rules  
 [CA1013: Overload operator equals on overloading add and subtract](../code-quality/ca1013-overload-operator-equals-on-overloading-add-and-subtract.md)  
  
## See Also  
 <xref:System.Object.Equals%2A?displayProperty=fullName>   
 [Equality Operators](../Topic/Equality%20Operators.md)