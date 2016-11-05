---
title: "CA1051: Do not declare visible instance fields | Microsoft Docs"
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
  - "CA1051"
  - "DoNotDeclareVisibleInstanceFields"
helpviewer_keywords: 
  - "CA1051"
  - "DoNotDeclareVisibleInstanceFields"
ms.assetid: 2805376c-824c-462c-81d1-c51aaf7cabe7
caps.latest.revision: 17
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
# CA1051: Do not declare visible instance fields
|||  
|-|-|  
|TypeName|DoNotDeclareVisibleInstanceFields|  
|CheckId|CA1051|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 An externally visible type has an externally visible instance field.  
  
## Rule Description  
 The primary use of a field should be as an implementation detail. Fields should be `private` or `internal` and should be exposed by using properties. It is as easy to access a property as it is to access a field, and the code in the accessors of a property can change as the features of the type expand without introducing breaking changes. Properties that just return the value of a private or internal field are optimized to perform on par with accessing a field; very little performance gain is associated with the use of externally visible fields over properties.  
  
 Externally visible refers to `public`, `protected`, and `protected internal` (`Public`, `Protected`, and `Protected Friend` in Visual Basic) accessibility levels.  
  
## How to Fix Violations  
 To fix a violation of this rule, make the field `private` or `internal` and expose it by using an externally visible property.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule. Externally visible fields do not provide any benefits that are unavailable to properties. Additionally, public fields cannot be protected by [Link Demands](../Topic/Link%20Demands.md). See [CA2112: Secured types should not expose fields](../code-quality/ca2112-secured-types-should-not-expose-fields.md).  
  
## Example  
 The following example shows a type (`BadPublicInstanceFields`) that violates this rule. `GoodPublicInstanceFields` shows the corrected code.  
  
 [!code-cs[FxCop.Design.TypesPublicInstanceFields#1](../code-quality/codesnippet/CSharp/ca1051-do-not-declare-visible-instance-fields_1.cs)]  
  
## Related Rules  
 [CA2112: Secured types should not expose fields](../code-quality/ca2112-secured-types-should-not-expose-fields.md)  
  
## See Also  
 [Link Demands](../Topic/Link%20Demands.md)