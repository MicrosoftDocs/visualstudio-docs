---
title: "CA1004: Generic methods should provide type parameter | Microsoft Docs"
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
  - "CA1004"
  - "GenericMethodsShouldProvideTypeParameter"
helpviewer_keywords: 
  - "GenericMethodsShouldProvideTypeParameter"
  - "CA1004"
ms.assetid: 38755f6a-fb45-4bf2-932e-0354ad826499
caps.latest.revision: 17
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
# CA1004: Generic methods should provide type parameter
|||  
|-|-|  
|TypeName|GenericMethodsShouldProvideTypeParameter|  
|CheckId|CA1004|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 The parameter signature of an externally visible generic method does not contain types that correspond to all the type parameters of the method.  
  
## Rule Description  
 Inference is how the type argument of a generic method is determined by the type of argument that is passed to the method, instead of by the explicit specification of the type argument. To enable inference, the parameter signature of a generic method must include a parameter that is of the same type as the type parameter for the method. In this case, the type argument does not have to be specified. When you use inference for all type parameters, the syntax for calling generic and nongeneric instance methods is identical. This simplifies the usability of generic methods.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the design so that the parameter signature contains the same type for each type parameter of the method.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule. Providing generics in a syntax that is easy to understand and use reduces the time that is required to learn and increases the adoption rate of new libraries.  
  
## Example  
 The following example shows the syntax for calling two generic methods. The type argument for `InferredTypeArgument` is inferred, and the type argument for `NotInferredTypeArgument` must be explicitly specified.  
  
 [!code-vb[FxCop.Design.Inference#1](../code-quality/codesnippet/VisualBasic/ca1004-generic-methods-should-provide-type-parameter_1.vb)]
 [!code-cs[FxCop.Design.Inference#1](../code-quality/codesnippet/CSharp/ca1004-generic-methods-should-provide-type-parameter_1.cs)]  
  
## Related Rules  
 [CA1005: Avoid excessive parameters on generic types](../code-quality/ca1005-avoid-excessive-parameters-on-generic-types.md)  
  
 [CA1010: Collections should implement generic interface](../code-quality/ca1010-collections-should-implement-generic-interface.md)  
  
 [CA1000: Do not declare static members on generic types](../code-quality/ca1000-do-not-declare-static-members-on-generic-types.md)  
  
 [CA1002: Do not expose generic lists](../code-quality/ca1002-do-not-expose-generic-lists.md)  
  
 [CA1006: Do not nest generic types in member signatures](../code-quality/ca1006-do-not-nest-generic-types-in-member-signatures.md)  
  
 [CA1003: Use generic event handler instances](../code-quality/ca1003-use-generic-event-handler-instances.md)  
  
 [CA1007: Use generics where appropriate](../code-quality/ca1007-use-generics-where-appropriate.md)  
  
## See Also  
 [Generics](/dotnet/csharp/programming-guide/generics/index)