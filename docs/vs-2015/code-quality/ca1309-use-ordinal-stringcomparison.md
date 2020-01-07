---
title: "CA1309: Use ordinal StringComparison | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "UseOrdinalStringComparison"
  - "CA1309"
helpviewer_keywords:
  - "UseOrdinalStringComparison"
  - "CA1309"
ms.assetid: 19be0854-cb6e-4efd-a4c8-a5c1fc6f7a71
caps.latest.revision: 17
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1309: Use ordinal StringComparison
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|UseOrdinalStringComparison|
|CheckId|CA1309|
|Category|Microsoft.Globalization|
|Breaking Change|Non-breaking|

## Cause
 A string comparison operation that is nonlinguistic does not set the <xref:System.StringComparison> parameter to either **Ordinal** or **OrdinalIgnoreCase**.

## Rule Description
 Many string operations, most important the <xref:System.String.Compare%2A?displayProperty=fullName> and <xref:System.String.Equals%2A?displayProperty=fullName> methods, now provide an overload that accepts a <xref:System.StringComparison?displayProperty=fullName> enumeration value as a parameter.

 When you specify either **StringComparison.Ordinal** or **StringComparison.OrdinalIgnoreCase**, the string comparison will be nonlinguistic. That is, the features that are specific to the natural language are ignored when comparison decisions are made. This means the decisions are based on simple byte comparisons and ignore casing or equivalence tables that are parameterized by culture. As a result, by explicitly setting the parameter to either the **StringComparison.Ordinal** or **StringComparison.OrdinalIgnoreCase**, your code often gains speed, increases correctness, and becomes more reliable.

## How to Fix Violations
 To fix a violation of this rule, change the string comparison method to an overload that accepts the <xref:System.StringComparison?displayProperty=fullName> enumeration as a parameter, and specify either **Ordinal** or **OrdinalIgnoreCase**. For example, change `String.Compare(str1, str2)` to `String.Compare(str1, str2, StringComparison.Ordinal)`.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule when the library or application is intended for a limited local audience or when the semantics of the current culture should be used.

## See Also
 [Globalization Warnings](../code-quality/globalization-warnings.md)
 [CA1307: Specify StringComparison](../code-quality/ca1307-specify-stringcomparison.md)
