---
title: Maintainability Warnings
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "vs.codeanalysis.maintainabilityrules"
helpviewer_keywords:
  - "warnings, maintainability"
  - "managed code analysis warnings, maintainability warnings"
  - "maintainability warnings"
ms.assetid: 537e70ca-a88c-49df-bfc7-0ee63bbe4f16
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Maintainability warnings

Maintainability warnings support library and application maintenance.

## In this section

| Rule | Description |
|-----------|-----------------------------------|
| [CA1500: Variable names should not match field names](../code-quality/ca1500.md) | An instance method declares a parameter or a local variable whose name matches an instance field of the declaring type, which leads to errors. |
| [CA1501: Avoid excessive inheritance](../code-quality/ca1501.md) | A type is more than four levels deep in its inheritance hierarchy. Deeply nested type hierarchies can be difficult to follow, understand, and maintain. |
| [CA1502: Avoid excessive complexity](../code-quality/ca1502.md) | This rule measures the number of linearly independent paths through the method, which is determined by the number and complexity of conditional branches. |
| [CA1504: Review misleading field names](../code-quality/ca1504.md) | The name of an instance field starts with "s_", or the name of a static (Shared in [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)]) field starts with "m_". |
| [CA1505: Avoid unmaintainable code](../code-quality/ca1505.md) | A type or method has a low maintainability index value. A low maintainability index indicates that a type or method is probably difficult to maintain and would be a good candidate for redesign. |
| [CA1506: Avoid excessive class coupling](../code-quality/ca1506.md) | This rule measures class coupling by counting the number of unique type references that a type or method contains. |
| [CA1507: Use nameof in place of string](../code-quality/ca1507.md) | A string literal is used as an argument where a `nameof` expression could be used. |

## See also

- [Measure Complexity and Maintainability of Managed Code](../code-quality/code-metrics-values.md)
