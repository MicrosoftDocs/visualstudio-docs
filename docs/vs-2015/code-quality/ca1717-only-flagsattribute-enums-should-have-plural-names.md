---
title: "CA1717: Only FlagsAttribute enums should have plural names | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1717"
  - "OnlyFlagsEnumsShouldHavePluralNames"
helpviewer_keywords:
  - "OnlyFlagsEnumsShouldHavePluralNames"
  - "CA1717"
ms.assetid: a6855d8b-d78a-42c1-834e-61c31f5572ed
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1717: Only FlagsAttribute enums should have plural names
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|OnlyFlagsEnumsShouldHavePluralNames|
|CheckId|CA1717|
|Category|Microsoft.Naming|
|Breaking Change|Breaking|

## Cause
 The name of an externally visible enumeration ends in a plural word and the enumeration is not marked with the <xref:System.FlagsAttribute?displayProperty=fullName> attribute.

## Rule Description
 Naming conventions dictate that a plural name for an enumeration indicates that more than one value of the enumeration can be specified simultaneously. The <xref:System.FlagsAttribute> tells compilers that the enumeration should be treated as a bit field that enables bitwise operations on the enumeration.

 If only one value of an enumeration can be specified at a time, the name of the enumeration should be a singular word. For example, an enumeration that defines the days of the week might be intended for use in an application where you can specify multiple days. This enumeration should have the <xref:System.FlagsAttribute> and could be called 'Days'. A similar enumeration that allows only a single day to be specified would not have the attribute, and could be called 'Day'.

 Naming conventions provide a common look for libraries that target the common language runtime. This reduces the time that is required to learn a new software library, and increases customer confidence that the library was developed by someone who has expertise in developing managed code.

## How to Fix Violations
 Make the name of the enumeration a singular word or add the <xref:System.FlagsAttribute>.

## When to Suppress Warnings
 It is safe to suppress a warning from the rule if the name ends in a singular word.

## Related Rules
 [CA1714: Flags enums should have plural names](../code-quality/ca1714-flags-enums-should-have-plural-names.md)

 [CA1027: Mark enums with FlagsAttribute](../code-quality/ca1027-mark-enums-with-flagsattribute.md)

 [CA2217: Do not mark enums with FlagsAttribute](../code-quality/ca2217-do-not-mark-enums-with-flagsattribute.md)

## See Also
 <xref:System.FlagsAttribute?displayProperty=fullName>
 [Enum Design](https://msdn.microsoft.com/library/dd53c952-9d9a-4736-86ff-9540e815d545)
