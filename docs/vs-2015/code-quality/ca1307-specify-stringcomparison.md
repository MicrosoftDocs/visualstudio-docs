---
title: "CA1307: Specify StringComparison | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1307"
  - "SpecifyStringComparison"
helpviewer_keywords:
  - "CA1307"
  - "SpecifyStringComparison"
ms.assetid: 9b0d5e71-1683-4a0d-bc4a-68b2fbd8af71
caps.latest.revision: 13
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1307: Specify StringComparison
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|SpecifyStringComparison|
|CheckId|CA1307|
|Category|Microsoft.Globalization|
|Breaking Change|Non-breaking|

## Cause
 A string comparison operation uses a method overload that does not set a <xref:System.StringComparison> parameter.

## Rule Description
 Many string operations, most important the <xref:System.String.Compare%2A> and <xref:System.String.Equals%2A> methods, provide an overload that accepts a <xref:System.StringComparison> enumeration value as a parameter.

 Whenever an overload exists that takes a <xref:System.StringComparison> parameter, it should be used instead of an overload that does not take this parameter. By explicitly setting this parameter, your code is often made clearer and easier to maintain.

## How to Fix Violations
 To fix a violation of this rule, change string comparison methods to overloads that accept the <xref:System.StringComparison> enumeration as a parameter. For example: change `String.Compare(str1, str2)` to `String.Compare(str1, str2, StringComparison.Ordinal)`.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule when the library or application is intended for a limited local audience and will therefore not be localized.

## See Also
 [Globalization Warnings](../code-quality/globalization-warnings.md)
 [CA1309: Use ordinal StringComparison](../code-quality/ca1309-use-ordinal-stringcomparison.md)
