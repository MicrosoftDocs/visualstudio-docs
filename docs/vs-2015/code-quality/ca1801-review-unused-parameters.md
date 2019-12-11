---
title: "CA1801: Review unused parameters | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "AvoidUnusedParameters"
  - "CA1801"
  - "ReviewUnusedParameters"
helpviewer_keywords:
  - "CA1801"
  - "ReviewUnusedParameters"
ms.assetid: 5d73545c-e153-4b7c-a7b2-be6bf5aca5be
caps.latest.revision: 31
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1801: Review unused parameters
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

For the latest documentation on Visual Studio, see [CA1801: Review unused parameters](https://docs.microsoft.com/visualstudio/code-quality/ca1801-review-unused-parameters).

|||
|-|-|
|TypeName|ReviewUnusedParameters|
|CheckId|CA1801|
|Category|Microsoft.Usage|
|Breaking Change|Non-breaking - If the member is not visible outside the assembly, regardless of the change you make.<br /><br /> Non-breaking - If you change the member to use the parameter within its body.<br /><br /> Breaking - If you remove the parameter and it is visible outside the assembly.|

## Cause
 A method signature includes a parameter that is not used in the method body. This rule does not examine the following methods:

- Methods referenced by a delegate.

- Methods used as event handlers.

- Methods declared with the `abstract` (`MustOverride` in Visual Basic) modifier.

- Methods declared with the `virtual` (`Overridable` in Visual Basic) modifier.

- Methods declared with the `override` (`Overrides` in Visual Basic) modifier.

- Methods declared with the `extern` (`Declare` statement in Visual Basic) modifier.

## Rule Description
 Review parameters in non-virtual methods that are not used in the method body to make sure no correctness exists around failure to access them. Unused parameters incur maintenance and performance costs.

 Sometimes a violation of this rule can point to an implementation bug in the method. For example, the parameter should have been used in the method body. Suppress warnings of this rule if the parameter has to exist because of backward compatibility.

## How to Fix Violations
 To fix a violation of this rule, remove the unused parameter (a breaking change) or use the parameter in the method body (a non-breaking change).

## When to Suppress Warnings
 It is safe to suppress a warning from this rule for previously shipped code for which the fix would be a breaking change.

## Example
 The following example shows two methods. One method violates the rule and the other method satisfies the rule.

 [!code-csharp[FxCop.Usage.ReviewUnusedParameters#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.ReviewUnusedParameters/cs/FxCop.Usage.ReviewUnusedPerameters.cs#1)]

## Related Rules
 [CA1811: Avoid uncalled private code](../code-quality/ca1811-avoid-uncalled-private-code.md)

 [CA1812: Avoid uninstantiated internal classes](../code-quality/ca1812-avoid-uninstantiated-internal-classes.md)

 [CA1804: Remove unused locals](../code-quality/ca1804-remove-unused-locals.md)
