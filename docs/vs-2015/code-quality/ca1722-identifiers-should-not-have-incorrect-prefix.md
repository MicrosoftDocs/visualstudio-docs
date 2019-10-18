---
title: "CA1722: Identifiers should not have incorrect prefix | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "IdentifiersShouldNotHaveIncorrectPrefix"
  - "CA1722"
helpviewer_keywords:
  - "CA1722"
  - "IdentifiersShouldNotHaveIncorrectPrefix"
ms.assetid: c3313c51-d004-4f9a-a0d1-6c4c4a1fb1e6
caps.latest.revision: 18
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1722: Identifiers should not have incorrect prefix
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|IdentifiersShouldNotHaveIncorrectPrefix|
|CheckId|CA1722|
|Category|Microsoft.Naming|
|Breaking Change|Breaking|

## Cause
 An identifier has an incorrect prefix.

## Rule Description
 By convention, only certain programming elements have names that begin with a specific prefix.

 Type names do not have a specific prefix and should not be prefixed with a 'C'. This rule reports violations for type names such as 'CMyClass' and does not report violations for type names such as 'Cache'.

 Naming conventions provide a common look for libraries that target the common language runtime. This reduces the learning curve that is required for new software libraries, and increases customer confidence that the library was developed by someone who has expertise in developing managed code.

## How to Fix Violations
 Remove the prefix from the identifier.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Related Rules
 [CA1715: Identifiers should have correct prefix](../code-quality/ca1715-identifiers-should-have-correct-prefix.md)
