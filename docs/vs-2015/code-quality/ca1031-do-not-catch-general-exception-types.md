---
title: "CA1031: Do not catch general exception types | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1031"
  - "DoNotCatchGeneralExceptionTypes"
helpviewer_keywords:
  - "CA1031"
  - "DoNotCatchGeneralExceptionTypes"
ms.assetid: cbc283ae-2a46-4ec0-940e-85aa189b118f
caps.latest.revision: 22
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1031: Do not catch general exception types
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|DoNotCatchGeneralExceptionTypes|
|CheckId|CA1031|
|Category|Microsoft.Design|
|Breaking Change|Non-breaking|

## Cause
 A general exception such as <xref:System.Exception?displayProperty=fullName> or <xref:System.SystemException?displayProperty=fullName> is caught in a `catch` statement, or a general catch clause such as `catch()` is used.

## Rule Description
 General exceptions should not be caught.

## How to Fix Violations
 To fix a violation of this rule, catch a more specific exception, or rethrow the general exception as the last statement in the `catch` block.

## When to Suppress Warnings
 Do not suppress a warning from this rule. Catching general exception types can hide run-time problems from the library user and can make debugging more difficult.

> [!NOTE]
> Starting with the [!INCLUDE[net_v40_long](../includes/net-v40-long-md.md)], the common language runtime (CLR) no longer delivers corrupted state exceptions that occur in the operating system and managed code, such as access violations in [!INCLUDE[TLA#tla_mswin](../includes/tlasharptla-mswin-md.md)], to be handled by managed code. If you want to compile an application in the [!INCLUDE[net_v40_short](../includes/net-v40-short-md.md)] or later versions and maintain handling of corrupted state exceptions, you can apply the <xref:System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute> attribute to the method that handles the corrupted state exception.

## Example
 The following example shows a type that violates this rule and a type that correctly implements the `catch` block.

 [!code-cpp[FxCop.Design.ExceptionAndSystemException#1](../snippets/cpp/VS_Snippets_CodeAnalysis/FxCop.Design.ExceptionAndSystemException/cpp/FxCop.Design.ExceptionAndSystemException.cpp#1)]
 [!code-csharp[FxCop.Design.ExceptionAndSystemException#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.ExceptionAndSystemException/cs/FxCop.Design.ExceptionAndSystemException.cs#1)]
 [!code-vb[FxCop.Design.ExceptionAndSystemException#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Design.ExceptionAndSystemException/vb/FxCop.Design.ExceptionAndSystemException.vb#1)]

## Related Rules
 [CA2200: Rethrow to preserve stack details](../code-quality/ca2200-rethrow-to-preserve-stack-details.md)
