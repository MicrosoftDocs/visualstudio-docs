---
title: "CA2200: Rethrow to preserve stack details | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "RethrowToPreserveStackDetails"
  - "CA2200"
helpviewer_keywords:
  - "CA2200"
  - "RethrowToPreserveStackDetails"
ms.assetid: 046e1b98-c4dc-4515-874f-9c0de2285621
caps.latest.revision: 15
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2200: Rethrow to preserve stack details
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|RethrowToPreserveStackDetails|
|CheckId|CA2200|
|Category|Microsoft.Usage|
|Breaking Change|Non Breaking|

## Cause
 An exception is re-thrown and the exception is explicitly specified in the `throw` statement.

## Rule Description
 Once an exception is thrown, part of the information it carries is the stack trace. The stack trace is a list of the method call hierarchy that starts with the method that throws the exception and ends with the method that catches the exception. If an exception is re-thrown by specifying the exception in the `throw` statement, the stack trace is restarted at the current method and the list of method calls between the original method that threw the exception and the current method is lost. To keep the original stack trace information with the exception, use the `throw` statement without specifying the exception.

## How to Fix Violations
 To fix a violation of this rule, re-throw the exception without specifying the exception explicitly.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Example
 The following example shows a method, `CatchAndRethrowExplicitly`, which violates the rule and a method, `CatchAndRethrowImplicitly`, which satisfies the rule.

 [!code-csharp[FxCop.Usage.Rethrow#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.Rethrow/cs/FxCop.Usage.Rethrow.cs#1)]
 [!code-vb[FxCop.Usage.Rethrow#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Usage.Rethrow/vb/FxCop.Usage.Rethrow.vb#1)]
