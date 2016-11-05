---
title: "CA2131: Security critical types may not participate in type equivalence | Microsoft Docs"
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
  - "CA2131"
ms.assetid: 4170f3b1-6086-430d-8fba-837d5538c573
caps.latest.revision: 10
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
# CA2131: Security critical types may not participate in type equivalence
|||  
|-|-|  
|TypeName|CriticalTypesMustNotParticipateInTypeEquivalence|  
|CheckId|CA2131|  
|Category|Microsoft.Security|  
|Breaking Change|Breaking|  
  
## Cause  
 A type participates in type equivalence and a either the type itself, or a member or field of the type, is marked with the <xref:System.Security.SecurityCriticalAttribute> attribute.  
  
## Rule Description  
 This rule fires on any critical types or types that contain critical methods or fields that are participating in type equivalence. When the CLR detects such a type, it fails to load it with a <xref:System.TypeLoadException> at run time. Typically, this rule fires only when users implement type equivalence manually rather than by relying on tlbimp and the compilers to do the type equivalence.  
  
## How to Fix Violations  
 To fix a violation of this rule, remove the SecurityCritical attribute.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following examples demonstrate an interface, a method, and a field that will cause this rule to fire.  
  
 [!code-cs[FxCop.Security.CA2131.CriticalTypesMustNotParticipateInTypeEquivalence#1](../code-quality/codesnippet/CSharp/ca2131-security-critical-types-may-not-participate-in-type-equivalence_1.cs)]  
  
## See Also  
 [Security-Transparent Code, Level 2](../Topic/Security-Transparent%20Code,%20Level%202.md)