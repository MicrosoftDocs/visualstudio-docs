---
title: "CA2135: Level 2 assemblies should not contain LinkDemands | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2135"
ms.assetid: 7a775285-42d2-4f13-8434-3fdb0deeebe6
caps.latest.revision: 12
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2135: Level 2 assemblies should not contain LinkDemands
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|SecurityRuleSetLevel2MethodsShouldNotBeProtectedWithLinkDemands|
|CheckId|CA2135|
|Category|Microsoft.Security|
|Breaking Change|Breaking|

## Cause
 A class or class member is using a <xref:System.Security.Permissions.SecurityAction> in an application that is using Level 2 security.

## Rule Description
 LinkDemands are deprecated in the level 2 security rule set. Instead of using LinkDemands to enforce security at just-in-time (JIT) compilation time, mark the methods, types, and fields with the <xref:System.Security.SecurityCriticalAttribute> attribute.

## How to Fix Violations
 To fix a violation of this rule, remove the <xref:System.Security.Permissions.SecurityAction> and mark the type or member with the <xref:System.Security.SecurityCriticalAttribute> attribute.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Example
 In the following example, the <xref:System.Security.Permissions.SecurityAction> should be removed and the method marked with the <xref:System.Security.SecurityCriticalAttribute> attribute.

 [!code-csharp[FxCop.Security.CA2135.SecurityRuleSetLevel2MethodsShouldNotBeProtectedWithLinkDemands#1](../snippets/csharp/VS_Snippets_CodeAnalysis/fxcop.security.ca2135.securityrulesetlevel2methodsshouldnotbeprotectedwithlinkdemands/cs/ca2135.cs#1)]
