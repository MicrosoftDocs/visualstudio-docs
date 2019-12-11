---
title: "CA1712: Do not prefix enum values with type name | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1712"
  - "DoNotPrefixEnumValuesWithTypeName"
helpviewer_keywords:
  - "CA1712"
  - "DoNotPrefixEnumValuesWithTypeName"
ms.assetid: df0e3a12-67bf-48f1-a10b-2ef60484a5c7
caps.latest.revision: 17
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1712: Do not prefix enum values with type name
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|DoNotPrefixEnumValuesWithTypeName|
|CheckId|CA1712|
|Category|Microsoft.Naming|
|Breaking Change|Breaking|

## Cause
 An enumeration contains a member whose name starts with the type name of the enumeration.

## Rule Description
 Names of enumeration members are not prefixed with the type name because type information is expected to be provided by development tools.

 Naming conventions provide a common look for libraries that target the common language runtime. This reduces the time that is required for to learn a new software library, and increases customer confidence that the library was developed by someone who has expertise in developing managed code.

## How to Fix Violations
 To fix a violation of this rule, remove the type name prefix from the enumeration member.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Example
 The following example shows an incorrectly named enumeration followed by the corrected version.

 [!code-cpp[FxCop.Naming.EnumValues#1](../snippets/cpp/VS_Snippets_CodeAnalysis/FxCop.Naming.EnumValues/cpp/FxCop.Naming.EnumValues.cpp#1)]
 [!code-csharp[FxCop.Naming.EnumValues#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Naming.EnumValues/cs/FxCop.Naming.EnumValues.cs#1)]
 [!code-vb[FxCop.Naming.EnumValues#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Naming.EnumValues/vb/FxCop.Naming.EnumValues.vb#1)]

## Related Rules
 [CA1711: Identifiers should not have incorrect suffix](../code-quality/ca1711-identifiers-should-not-have-incorrect-suffix.md)

 [CA1027: Mark enums with FlagsAttribute](../code-quality/ca1027-mark-enums-with-flagsattribute.md)

 [CA2217: Do not mark enums with FlagsAttribute](../code-quality/ca2217-do-not-mark-enums-with-flagsattribute.md)

## See Also
 <xref:System.Enum?displayProperty=fullName>
