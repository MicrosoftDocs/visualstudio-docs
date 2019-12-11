---
title: "CA1027: Mark enums with FlagsAttribute | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "MarkEnumsWithFlags"
  - "CA1027"
helpviewer_keywords:
  - "CA1027"
  - "MarkEnumsWithFlags"
ms.assetid: 249e882c-8cd1-4c00-a2de-7b6bdc1849ff
caps.latest.revision: 20
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1027: Mark enums with FlagsAttribute
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|MarkEnumsWithFlags|
|CheckId|CA1027|
|Category|Microsoft.Design|
|Breaking Change|Non-breaking|

## Cause
 The values of a public enumeration are powers of two or are combinations of other values that are defined in the enumeration, and the <xref:System.FlagsAttribute?displayProperty=fullName> attribute is not present. To reduce false positives, this rule does not report a violation for enumerations that have contiguous values.

## Rule Description
 An enumeration is a value type that defines a set of related named constants. Apply <xref:System.FlagsAttribute> to an enumeration when its named constants can be meaningfully combined. For example, consider an enumeration of the days of the week in an application that keeps track of which day's resources are available. If the availability of each resource is encoded by using the enumeration that has <xref:System.FlagsAttribute> present, any combination of days can be represented. Without the attribute, only one day of the week can be represented.

 For fields that store combinable enumerations, the individual enumeration values are treated as groups of bits in the field. Therefore, such fields are sometimes referred to as *bit fields*. To combine enumeration values for storage in a bit field, use the Boolean conditional operators. To test a bit field to determine whether a specific enumeration value is present, use the Boolean logical operators. For a bit field to store and retrieve combined enumeration values correctly, each value that is defined in the enumeration must be a power of two. Unless this is so, the Boolean logical operators will not be able to extract the individual enumeration values that are stored in the field.

## How to Fix Violations
 To fix a violation of this rule, add <xref:System.FlagsAttribute> to the enumeration.

## When to Suppress Warnings
 Suppress a warning from this rule if you do not want the enumeration values to be combinable.

## Example
 In the following example, `DaysEnumNeedsFlags` is an enumeration that meets the requirements for using <xref:System.FlagsAttribute>, but does not have it. The `ColorEnumShouldNotHaveFlag` enumeration does not have values that are powers of two, but incorrectly specifies <xref:System.FlagsAttribute>. This violates rule [CA2217: Do not mark enums with FlagsAttribute](../code-quality/ca2217-do-not-mark-enums-with-flagsattribute.md).

 [!code-csharp[FxCop.Design.EnumFlags#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.EnumFlags/cs/FxCop.Design.EnumFlags.cs#1)]

## Related Rules
 [CA2217: Do not mark enums with FlagsAttribute](../code-quality/ca2217-do-not-mark-enums-with-flagsattribute.md)

## See Also
 <xref:System.FlagsAttribute?displayProperty=fullName>
