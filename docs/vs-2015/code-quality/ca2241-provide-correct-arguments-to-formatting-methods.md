---
title: "CA2241: Provide correct arguments to formatting methods | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2241"
  - "Provide correct arguments to formatting methods"
  - "ProvideCorrectArgumentsToFormattingMethods"
helpviewer_keywords:
  - "ProvideCorrectArgumentsToFormattingMethods"
  - "CA2241"
ms.assetid: 83639bc4-4c91-4a07-a40e-dc5e49a84494
caps.latest.revision: 14
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2241: Provide correct arguments to formatting methods
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|ProvideCorrectArgumentsToFormattingMethods|
|CheckId|CA2241|
|Category|Microsoft.Usage|
|Breaking Change|Non Breaking|

## Cause
 The `format` string argument passed to a method such as <xref:System.Console.WriteLine%2A>,  <xref:System.Console.Write%2A>, or  <xref:System.String.Format%2A?displayProperty=fullName> does not contain a format item that corresponds to each object argument, or vice versa.

## Rule Description
 The arguments to methods such as <xref:System.Console.WriteLine%2A>, <xref:System.Console.Write%2A>, and <xref:System.String.Format%2A> consist of a format string followed by several <xref:System.Object?displayProperty=fullName> instances. The format string consists of text and embedded format items of the form, {index[,alignment][:formatString]}. 'index' is a zero-based integer that indicates which of the objects to format. If an object does not have a corresponding index in the format string, the object is ignored. If the object specified by 'index' does not exist, a <xref:System.FormatException?displayProperty=fullName> is thrown at runtime.

## How to Fix Violations
 To fix a violation of this rule, provide a format item for each object argument and provide an object argument for each format item.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Example
 The following example shows two violations of the rule.

 [!code-csharp[FxCop.Usage.FormattingArguments#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.FormattingArguments/cs/FxCop.Usage.FormattingArguments.cs#1)]
 [!code-vb[FxCop.Usage.FormattingArguments#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Usage.FormattingArguments/vb/FxCop.Usage.FormattingArguments.vb#1)]
