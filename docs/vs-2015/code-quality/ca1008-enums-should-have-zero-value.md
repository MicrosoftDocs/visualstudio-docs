---
title: "CA1008: Enums should have zero value | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1008"
  - "EnumsShouldHaveZeroValue"
helpviewer_keywords:
  - "CA1008"
  - "EnumsShouldHaveZeroValue"
ms.assetid: 3503a73c-360c-416d-8ee4-c2aa44365a05
caps.latest.revision: 23
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1008: Enums should have zero value
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|EnumsShouldHaveZeroValue|
|CheckId|CA1008|
|Category|Microsoft.Design|
|Breaking Change|Non-breaking - When you are prompted to add a **None** value to a non-flag enumeration.Breaking - When you are prompted to rename or remove any enumeration values.|

## Cause
 An enumeration without an applied <xref:System.FlagsAttribute?displayProperty=fullName> does not define a member that has a value of zero; or an enumeration that has an applied <xref:System.FlagsAttribute> defines a member that has a value of zero but its name is not 'None', or the enumeration defines multiple zero-valued members.

## Rule Description
 The default value of an uninitialized enumeration, just like other value types, is zero. A non-flags−attributed enumeration should define a member that has the value of zero so that the default value is a valid value of the enumeration. If appropriate, name the member 'None'. Otherwise, assign zero to the most frequently used member. Note that, by default, if the value of the first enumeration member is not set in the declaration, its value is zero.

 If an enumeration that has the <xref:System.FlagsAttribute> applied defines a zero-valued member, its name should be 'None' to indicate that no values have been set in the enumeration. Using a zero-valued member for any other purpose is contrary to the use of the <xref:System.FlagsAttribute> in that the AND and OR bitwise operators are useless with the member. This implies that only one member should be assigned the value zero. Note that if multiple members that have the value zero occur in a flags-attributed enumeration, `Enum.ToString()` returns incorrect results for members that are not zero.

## How to Fix Violations
 To fix a violation of this rule for non-flags−attributed enumerations, define a member that has the value of zero; this is a non-breaking change. For flags-attributed enumerations that define a zero-valued member, name this member 'None' and delete any other members that have a value of zero; this is a breaking change.

## When to Suppress Warnings
 Do not suppress a warning from this rule except for flags-attributed enumerations that have previously shipped.

## Example
 The following example shows two enumerations that satisfy the rule and an enumeration, `BadTraceOptions`, that violates the rule.

 [!code-cpp[FxCop.Design.EnumsZeroValue#1](../snippets/cpp/VS_Snippets_CodeAnalysis/FxCop.Design.EnumsZeroValue/cpp/FxCop.Design.EnumsZeroValue.cpp#1)]
 [!code-csharp[FxCop.Design.EnumsZeroValue#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.EnumsZeroValue/cs/FxCop.Design.EnumsZeroValue.cs#1)]
 [!code-vb[FxCop.Design.EnumsZeroValue#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Design.EnumsZeroValue/vb/FxCop.Design.EnumsZeroValue.vb#1)]

## Related Rules
 [CA2217: Do not mark enums with FlagsAttribute](../code-quality/ca2217-do-not-mark-enums-with-flagsattribute.md)

 [CA1700: Do not name enum values 'Reserved'](../code-quality/ca1700-do-not-name-enum-values-reserved.md)

 [CA1712: Do not prefix enum values with type name](../code-quality/ca1712-do-not-prefix-enum-values-with-type-name.md)

 [CA1028: Enum storage should be Int32](../code-quality/ca1028-enum-storage-should-be-int32.md)

 [CA1027: Mark enums with FlagsAttribute](../code-quality/ca1027-mark-enums-with-flagsattribute.md)

## See Also
 <xref:System.Enum?displayProperty=fullName>
