---
title: "CA1708: Identifiers should differ by more than case | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "IdentifiersShouldDifferByMoreThanCase"
  - "CA1708"
helpviewer_keywords:
  - "CA1708"
  - "IdentifiersShouldDifferByMoreThanCase"
ms.assetid: dac0f01d-dd21-484d-add1-c8cd2bf6969f
caps.latest.revision: 23
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1708: Identifiers should differ by more than case
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|IdentifiersShouldDifferByMoreThanCase|
|CheckId|CA1708|
|Category|Microsoft.Naming|
|Breaking Change|Breaking|

## Cause
 The names of two types, members, parameters, or fully qualified namespaces are identical when they are converted to lowercase.

## Rule Description
 Identifiers for namespaces, types, members, and parameters cannot differ only by case because languages that target the common language runtime are not required to be case-sensitive. For example, [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] is a widely used case-insensitive language.

 This rule fires on publicly visible members only.

## How to Fix Violations
 Select a name that is unique when it is compared to other identifiers in a case-insensitive manner.

## When to Suppress Warnings
 Do not suppress a warning from this rule. The library might not be usable in all available languages in the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)].

## Example of a Violation
 The following example demonstrates a violation of this rule.

 [!code-csharp[FxCop.Naming.IdentifiersShouldDifferByMoreThanCase#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Naming.IdentifiersShouldDifferByMoreThanCase/cs/FxCop.Naming.IdentifiersShouldDifferByMoreThanCase.cs#1)]

## Related Rules
 [CA1709: Identifiers should be cased correctly](../code-quality/ca1709-identifiers-should-be-cased-correctly.md)
