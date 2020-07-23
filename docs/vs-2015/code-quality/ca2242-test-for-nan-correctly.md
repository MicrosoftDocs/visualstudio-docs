---
title: "CA2242: Test for NaN correctly | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "TestForNaNCorrectly"
  - "CA2242"
helpviewer_keywords:
  - "CA2242"
ms.assetid: e12dcffc-e255-4e1e-8fdf-3c6054d44abe
caps.latest.revision: 13
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2242: Test for NaN correctly
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|Item|Value|
|-|-|
|TypeName|TestForNaNCorrectly|
|CheckId|CA2242|
|Category|Microsoft.Usage|
|Breaking Change|Non Breaking|

## Cause
 An expression tests a value against <xref:System.Single.NaN?displayProperty=fullName> or <xref:System.Double.NaN?displayProperty=fullName>.

## Rule Description
 <xref:System.Double.NaN?displayProperty=fullName>, which represents not-a-number, results when an arithmetic operation is undefined. Any expression that tests equality between a value and <xref:System.Double.NaN?displayProperty=fullName> always returns `false`. Any expression that tests inequality between a value and <xref:System.Double.NaN?displayProperty=fullName> always returns `true`.

## How to Fix Violations
 To fix a violation of this rule and accurately determine whether a value represents <xref:System.Double.NaN?displayProperty=fullName>, use <xref:System.Single.IsNaN%2A?displayProperty=fullName> or <xref:System.Double.IsNaN%2A?displayProperty=fullName> to test the value.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Example
 The following example shows two expressions that incorrectly test a value against <xref:System.Double.NaN?displayProperty=fullName> and an expression that correctly uses <xref:System.Double.IsNaN%2A?displayProperty=fullName> to test the value.

 [!code-csharp[FxCop.Usage.TestForNaN#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.TestForNaN/cs/FxCop.Usage.TestForNaN.cs#1)]
 [!code-vb[FxCop.Usage.TestForNaN#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Usage.TestForNaN/vb/FxCop.Usage.TestForNaN.vb#1)]
