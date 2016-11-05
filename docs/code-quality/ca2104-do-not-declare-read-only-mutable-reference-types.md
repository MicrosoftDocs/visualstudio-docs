---
title: "CA2104: Do not declare read only mutable reference types | Microsoft Docs"
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
  - "DoNotDeclareReadOnlyMutableReferenceTypes"
  - "CA2104"
helpviewer_keywords: 
  - "CA2104"
  - "DoNotDeclareReadOnlyMutableReferenceTypes"
ms.assetid: 81b83ee5-4db5-4be0-9f8d-90b53894ec3b
caps.latest.revision: 18
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
# CA2104: Do not declare read only mutable reference types
|||  
|-|-|  
|TypeName|DoNotDeclareReadOnlyMutableReferenceTypes|  
|CheckId|CA2104|  
|Category|Microsoft.Security|  
|Breaking Change|Non-breaking|  
  
## Cause  
 An externally visible type contains an externally visible read-only field that is a mutable reference type.  
  
## Rule Description  
 A mutable type is a type whose instance data can be modified. The <xref:System.Text.StringBuilder?displayProperty=fullName> class is an example of a mutable reference type. It contains members that can change the value of an instance of the class. An example of an immutable reference type is the <xref:System.String?displayProperty=fullName> class. After it has been instantiated, its value can never change.  
  
 The read-only modifier ([readonly](/dotnet/csharp/language-reference/keywords/readonly) in C#, [ReadOnly](/dotnet/visual-basic/language-reference/modifiers/readonly) in [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)], and [const](/visual-cpp/cpp/const-cpp) in C++) on a reference type field (pointer in C++) prevents the field from being replaced by a different instance of the reference type. However, the modifier does not prevent the instance data of the field from being modified through the reference type.  
  
 Read-only array fields are exempt from this rule but instead cause a violation of the [CA2105: Array fields should not be read only](../code-quality/ca2105-array-fields-should-not-be-read-only.md) rule.  
  
## How to Fix Violations  
 To fix a violation of this rule, remove the read-only modifier or, if a breaking change is acceptable, replace the field with an immutable type.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the field type is immutable.  
  
## Example  
 The following example shows a field declaration that causes a violation of this rule.  
  
 [!code-cpp[FxCop.Security.MutableReferenceTypes#1](../code-quality/codesnippet/CPP/ca2104-do-not-declare-read-only-mutable-reference-types_1.cpp)]
 [!code-cs[FxCop.Security.MutableReferenceTypes#1](../code-quality/codesnippet/CSharp/ca2104-do-not-declare-read-only-mutable-reference-types_1.cs)]
 [!code-vb[FxCop.Security.MutableReferenceTypes#1](../code-quality/codesnippet/VisualBasic/ca2104-do-not-declare-read-only-mutable-reference-types_1.vb)]