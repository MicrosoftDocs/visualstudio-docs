---
title: "Maintainability Warnings | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
f1_keywords:
  - "vs.codeanalysis.maintainabilityrules"
helpviewer_keywords:
  - "warnings, maintainability"
  - "managed code analysis warnings, maintainability warnings"
  - "maintainability warnings"
ms.assetid: 537e70ca-a88c-49df-bfc7-0ee63bbe4f16
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# Maintainability Warnings
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Maintainability warnings support library and application maintenance.

## In This Section

|Rule|Description|
|----------|-----------------|
|[CA1500: Variable names should not match field names](../code-quality/ca1500-variable-names-should-not-match-field-names.md)|An instance method declares a parameter or a local variable whose name matches an instance field of the declaring type, which leads to errors.|
|[CA1501: Avoid excessive inheritance](../code-quality/ca1501-avoid-excessive-inheritance.md)|A type is more than four levels deep in its inheritance hierarchy. Deeply nested type hierarchies can be difficult to follow, understand, and maintain.|
|[CA1502: Avoid excessive complexity](../code-quality/ca1502-avoid-excessive-complexity.md)|This rule measures the number of linearly independent paths through the method, which is determined by the number and complexity of conditional branches.|
|[CA1504: Review misleading field names](../code-quality/ca1504-review-misleading-field-names.md)|The name of an instance field starts with "s_", or the name of a static (Shared in [!INCLUDE[vbprvb](../includes/vbprvb-md.md)]) field starts with "m_".|
|[CA1505: Avoid unmaintainable code](../code-quality/ca1505-avoid-unmaintainable-code.md)|A type or method has a low maintainability index value. A low maintainability index indicates that a type or method is probably difficult to maintain and would be a good candidate for redesign.|
|[CA1506: Avoid excessive class coupling](../code-quality/ca1506-avoid-excessive-class-coupling.md)|This rule measures class coupling by counting the number of unique type references that a type or method contains.|

## See Also
 [Measuring Complexity and Maintainability of Managed Code](../code-quality/measuring-complexity-and-maintainability-of-managed-code.md)
