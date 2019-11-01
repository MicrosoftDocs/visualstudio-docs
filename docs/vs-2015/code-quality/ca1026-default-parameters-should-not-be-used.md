---
title: "CA1026: Default parameters should not be used | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1026"
  - "DefaultParametersShouldNotBeUsed"
helpviewer_keywords:
  - "CA1026"
  - "DefaultParametersShouldNotBeUsed"
ms.assetid: 09643415-36ef-4d0f-9411-5721e14e2512
caps.latest.revision: 20
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1026: Default parameters should not be used
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|DefaultParametersShouldNotBeUsed|
|CheckId|CA1026|
|Category|Microsoft.Design|
|Breaking Change|Breaking|

## Cause
 An externally visible type contains an externally visible method that uses a default parameter.

## Rule Description
 Methods that use default parameters are allowed under the Common Language Specification (CLS); however, the CLS allows compilers to ignore the values that are assigned to these parameters. Code that is written for compilers that ignore default parameter values must explicitly provide arguments for each default parameter. To maintain the behavior that you want across programming languages, methods that use default parameters should be replaced with method overloads that provide the default parameters.

 The compiler ignores the values of default parameters for Managed Extension for C++ when it accesses managed code. The Visual Basic compiler supports methods that have default parameters that use the [Optional](https://msdn.microsoft.com/library/4571ce88-a539-4115-b230-54eb277c6aa7) keyword.

## How to Fix Violations
 To fix a violation of this rule, replace the method that uses default parameters with method overloads that supply the default parameters.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Example
 The following example shows a method that uses default parameters, and the overloaded methods that provide an equivalent functionality.

 [!code-vb[FxCop.Design.DefaultParameters#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Design.DefaultParameters/vb/FxCop.Design.DefaultParameters.vb#1)]

## Related Rules
 [CA1025: Replace repetitive arguments with params array](../code-quality/ca1025-replace-repetitive-arguments-with-params-array.md)

## See Also
 [Language Independence and Language-Independent Components](https://msdn.microsoft.com/library/4f0b77d0-4844-464f-af73-6e06bedeafc6)
