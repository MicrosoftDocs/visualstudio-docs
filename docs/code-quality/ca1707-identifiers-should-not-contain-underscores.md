---
title: "CA1707: Identifiers should not contain underscores"
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "IdentifiersShouldNotContainUnderscores"
  - "CA1707"
helpviewer_keywords:
  - "CA1707"
  - "IdentifiersShouldNotContainUnderscores"
ms.assetid: 5fb539ef-c304-4323-90c0-b14386da9774
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# CA1707: Identifiers should not contain underscores

|||
|-|-|
|TypeName|IdentifiersShouldNotContainUnderscores|
|CheckId|CA1707|
|Category|Microsoft.Naming|
|Breaking change|Breaking - when raised on assemblies<br /><br /> Non-breaking - when raised on type parameters|

## Cause

The name of an identifier contains the underscore (\_) character.

## Rule description

By convention, identifier names do not contain the underscore (\_) character. The rule checks namespaces, types, members, and parameters.

Naming conventions provide a common look for libraries that target the common language runtime. This reduces the learning curve that is required for new software libraries, and increases customer confidence that the library was developed by someone who has expertise in developing managed code.

## How to fix violations

Remove all underscore characters from the name.

## When to suppress warnings

Do not suppress a warning from this rule.

## Related rules

- [CA1709: Identifiers should be cased correctly](../code-quality/ca1709-identifiers-should-be-cased-correctly.md)
- [CA1708: Identifiers should differ by more than case](../code-quality/ca1708-identifiers-should-differ-by-more-than-case.md)
