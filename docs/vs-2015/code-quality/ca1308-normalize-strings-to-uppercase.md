---
title: "CA1308: Normalize strings to uppercase | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1308"
  - "NormalizeStringsToUppercase"
helpviewer_keywords:
  - "NormalizeStringsToUppercase"
  - "CA1308"
ms.assetid: 7e9a7457-3f93-4938-ac6f-1389fba8d9cc
caps.latest.revision: 13
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1308: Normalize strings to uppercase
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|NormalizeStringsToUppercase|
|CheckId|CA1308|
|Category|Microsoft.Globalization|
|Breaking Change|Non-breaking|

## Cause
 An operation normalizes a string to lowercase.

## Rule Description
 Strings should be normalized to uppercase. A small group of characters, when they are converted to lowercase, cannot make a round trip. To make a round trip means to convert the characters from one locale to another locale that represents character data differently, and then to accurately retrieve the original characters from the converted characters.

## How to Fix Violations
 Change operations that convert strings to lowercase so that the strings are converted to uppercase instead. For example, change `String.ToLower(CultureInfo.InvariantCulture)` to `String.ToUpper(CultureInfo.InvariantCulture)`.

## When to Suppress Warnings
 It is safe to suppress a warning message when you are not making security decision based on the result (for example, when you are displaying it in the UI).

## See Also
 [Globalization Warnings](../code-quality/globalization-warnings.md)
