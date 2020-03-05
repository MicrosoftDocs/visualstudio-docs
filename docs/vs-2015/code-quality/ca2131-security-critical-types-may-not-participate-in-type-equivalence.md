---
title: "CA2131: Security critical types may not participate in type equivalence | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2131"
ms.assetid: 4170f3b1-6086-430d-8fba-837d5538c573
caps.latest.revision: 12
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2131: Security critical types may not participate in type equivalence
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

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

 [!code-csharp[FxCop.Security.CA2131.CriticalTypesMustNotParticipateInTypeEquivalence#1](../snippets/csharp/VS_Snippets_CodeAnalysis/fxcop.security.ca2131.criticaltypesmustnotparticipateintypeequivalence/cs/ca2131 - criticaltypesmustnotparticipateintypeequivalence.cs#1)]

## See Also
 [Security-Transparent Code, Level 2](https://msdn.microsoft.com/library/4d05610a-0da6-4f08-acea-d54c9d6143c0)
