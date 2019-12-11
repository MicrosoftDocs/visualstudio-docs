---
title: "CA1025: Replace repetitive arguments with params array | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1025"
  - "ReplaceRepetitiveArgumentsWithParamsArray"
helpviewer_keywords:
  - "ReplaceRepetitiveArgumentsWithParamsArray"
  - "CA1025"
ms.assetid: f009b340-dea3-4459-8fe1-2143aa8b5d0b
caps.latest.revision: 16
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1025: Replace repetitive arguments with params array
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|ReplaceRepetitiveArgumentsWithParamsArray|
|CheckId|CA1025|
|Category|Microsoft.Design|
|Breaking Change|Non-breaking|

## Cause
 A public or protected method in a public type has more than three parameters, and its last three parameters are the same type.

## Rule Description
 Use a parameter array instead of repeated arguments when the exact number of arguments is unknown and the variable arguments are the same type, or can be passed as the same type. For example, the <xref:System.Console.WriteLine%2A> method provides a general-purpose overload that uses a parameter array to accept any number of <xref:System.Object> arguments.

## How to Fix Violations
 To fix a violation of this rule, replace the repeated arguments with a parameter array.

## When to Suppress Warnings
 It is always safe to suppress a warning from this rule; however, this design might cause usability issues.

## Example
 The following example shows a type that violates this rule.

 [!code-csharp[FxCop.Design.RepeatArgs#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.RepeatArgs/cs/FxCop.Design.RepeatArgs.cs#1)]
