---
title: "CA2146: Types must be at least as critical as their base types and interfaces | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2146"
ms.assetid: 241fb784-1f6b-46e5-8ceb-c438e341d38e
caps.latest.revision: 13
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2146: Types must be at least as critical as their base types and interfaces
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|TypesMustBeAtLeastAsCriticalAsBaseTypes|
|CheckId|CA2146|
|Category|Microsoft.Security|
|Breaking Change|Breaking|

## Cause
 A transparent type is derived from a type that is marked with the <xref:System.Security.SecuritySafeCriticalAttribute> or the <xref:System.Security.SecurityCriticalAttribute>, or a type that is marked with the <xref:System.Security.SecuritySafeCriticalAttribute> attribute is derived from a type that is marked with the <xref:System.Security.SecurityCriticalAttribute> attribute.

## Rule Description
 This rule fires when a derived type has a security transparency attribute that is not as critical as its base type or implemented interface. Only critical types can derive from critical base types or implement critical interfaces, and only critical or safe-critical types can derive from safe-critical base types or implement safe-critical interfaces. Violations of this rule in level 2 transparency result in a <xref:System.TypeLoadException> for the derived type.

## How to Fix Violations
 To fix this violation, mark the derived or implementing type with a transparency attribute that is at least as critical as the base type or interface.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Example
 [!code-csharp[FxCop.Security.CA2146.TypesMustBeAtLeastAsCriticalAsBaseTypes#1](../snippets/csharp/VS_Snippets_CodeAnalysis/fxcop.security.ca2146.typesmustbeatleastascriticalasbasetypes/cs/ca2146 - typesmustbeatleastascriticalasbasetypes.cs#1)]
