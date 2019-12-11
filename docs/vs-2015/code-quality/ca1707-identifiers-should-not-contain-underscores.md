---
title: "CA1707: Identifiers should not contain underscores | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "IdentifiersShouldNotContainUnderscores"
  - "CA1707"
helpviewer_keywords:
  - "CA1707"
  - "IdentifiersShouldNotContainUnderscores"
ms.assetid: 5fb539ef-c304-4323-90c0-b14386da9774
caps.latest.revision: 20
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1707: Identifiers should not contain underscores
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

For the latest documentation on Visual Studio, see [CA1707: Identifiers should not contain underscores](https://docs.microsoft.com/visualstudio/code-quality/ca1707-identifiers-should-not-contain-underscores).

|||
|-|-|
|TypeName|IdentifiersShouldNotContainUnderscores|
|CheckId|CA1707|
|Category|Microsoft.Naming|
|Breaking Change|Breaking - when raised on assemblies<br /><br /> Non-breaking - when raised on type parameters|

## Cause
 The name of an identifier contains the underscore (_) character.

## Rule Description
 By convention, identifier names do not contain the underscore (_) character. The rule checks namespaces, types, members, and parameters.

 Naming conventions provide a common look for libraries that target the common language runtime. This reduces the learning curve that is required for new software libraries, and increases customer confidence that the library was developed by someone who has expertise in developing managed code.

## How to Fix Violations
 Remove all underscore characters from the name.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Related Rules
 [CA1709: Identifiers should be cased correctly](../code-quality/ca1709-identifiers-should-be-cased-correctly.md)

 [CA1708: Identifiers should differ by more than case](../code-quality/ca1708-identifiers-should-differ-by-more-than-case.md)
