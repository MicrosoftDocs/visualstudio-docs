---
title: "CA1804: Remove unused locals | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1804"
  - "RemoveUnusedLocals"
helpviewer_keywords:
  - "RemoveUnusedLocals"
  - "CA1804"
ms.assetid: cc332e67-6543-4813-bd8a-6f6fc75bf22a
caps.latest.revision: 20
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1804: Remove unused locals
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|RemoveUnusedLocals|
|CheckId|CA1804|
|Category|Microsoft.Performance|
|Breaking Change|Non-breaking|

## Cause
 A method declares a local variable but does not use the variable except possibly as the recipient of an assignment statement. For analysis by this rule, the tested assembly must be built with debugging information and the associated program database (.pdb) file must be available.

## Rule Description
 Unused local variables and unnecessary assignments increase the size of an assembly and decrease performance.

## How to Fix Violations
 To fix a violation of this rule, remove or use the local variable. Note that the C# compiler that is included with [!INCLUDE[dnprdnlong](../includes/dnprdnlong-md.md)] removes unused local variables when the `optimize` option is enabled.

## When to Suppress Warnings
 Suppress a warning from this rule if the variable was compiler emitted. It is also safe to suppress a warning from this rule, or to disable the rule, if performance and code maintenance are not primary concerns.

## Example
 The following example shows several unused local variables.

 [!code-csharp[FxCop.Performance.UnusedLocals#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Performance.UnusedLocals/cs/FxCop.Performance.UnusedLocals.cs#1)]
 [!code-vb[FxCop.Performance.UnusedLocals#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Performance.UnusedLocals/vb/FxCop.Performance.UnusedLocals.vb#1)]

## Related Rules
 [CA1809: Avoid excessive locals](../code-quality/ca1809-avoid-excessive-locals.md)

 [CA1811: Avoid uncalled private code](../code-quality/ca1811-avoid-uncalled-private-code.md)

 [CA1812: Avoid uninstantiated internal classes](../code-quality/ca1812-avoid-uninstantiated-internal-classes.md)

 [CA1801: Review unused parameters](../code-quality/ca1801-review-unused-parameters.md)
