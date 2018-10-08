---
title: "CA2217: Do not mark enums with FlagsAttribute"
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "DoNotMarkEnumsWithFlags"
  - "CA2217"
helpviewer_keywords:
  - "DoNotMarkEnumsWithFlags"
  - "CA2217"
dev_langs:
  - "VB"
  - "CSharp"
  - "CPP"
ms.assetid: 1b6f626c-66bf-45b0-a3e2-7c41ee9ceda7
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# CA2217: Do not mark enums with FlagsAttribute

|||
|-|-|
|TypeName|DoNotMarkEnumsWithFlags|
|CheckId|CA2217|
|Category|Microsoft.Usage|
|Breaking Change|Non Breaking|

## Cause

An externally visible enumeration is marked with <xref:System.FlagsAttribute>, and it has one or more values that are not powers of two or a combination of the other defined values on the enumeration.

## Rule description

An enumeration should have <xref:System.FlagsAttribute> present only if each value defined in the enumeration is a power of two or a combination of defined values.

## How to fix violations

To fix a violation of this rule, remove <xref:System.FlagsAttribute> from the enumeration.

## When to suppress warnings

Do not suppress a warning from this rule.

## Example that should not have the attribute

The following example shows an enumeration, `Color`, that contains the value 3. 3 is not a power of two, or a combination of any of the defined values. The `Color` enumeration shouldn't be marked with <xref:System.FlagsAttribute>.

[!code-cpp[FxCop.Usage.EnumNoFlags#1](../code-quality/codesnippet/CPP/ca2217-do-not-mark-enums-with-flagsattribute_1.cpp)]
[!code-csharp[FxCop.Usage.EnumNoFlags#1](../code-quality/codesnippet/CSharp/ca2217-do-not-mark-enums-with-flagsattribute_1.cs)]
[!code-vb[FxCop.Usage.EnumNoFlags#1](../code-quality/codesnippet/VisualBasic/ca2217-do-not-mark-enums-with-flagsattribute_1.vb)]

## Example that should have the attribute

The following example shows an enumeration, `Days`, that meets the requirements for being marked with <xref:System.FlagsAttribute>.

[!code-cpp[FxCop.Usage.EnumNoFlags2#1](../code-quality/codesnippet/CPP/ca2217-do-not-mark-enums-with-flagsattribute_2.cpp)]
[!code-csharp[FxCop.Usage.EnumNoFlags2#1](../code-quality/codesnippet/CSharp/ca2217-do-not-mark-enums-with-flagsattribute_2.cs)]
[!code-vb[FxCop.Usage.EnumNoFlags2#1](../code-quality/codesnippet/VisualBasic/ca2217-do-not-mark-enums-with-flagsattribute_2.vb)]

## Related rules

[CA1027: Mark enums with FlagsAttribute](../code-quality/ca1027-mark-enums-with-flagsattribute.md)

## See also

- <xref:System.FlagsAttribute?displayProperty=fullName>
