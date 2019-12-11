---
title: "CA1028: Enum storage should be Int32 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1028"
  - "EnumStorageShouldBeInt32"
helpviewer_keywords:
  - "EnumStorageShouldBeInt32"
  - "CA1028"
ms.assetid: 87160825-9f39-4142-8d7f-a31fe7ac7b84
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1028: Enum storage should be Int32
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|EnumStorageShouldBeInt32|
|CheckId|CA1028|
|Category|Microsoft.Design|
|Breaking Change|Breaking|

## Cause
 The underlying type of a public enumeration is not <xref:System.Int32?displayProperty=fullName>.

## Rule Description
 An enumeration is a value type that defines a set of related named constants. By default, the <xref:System.Int32?displayProperty=fullName> data type is used to store the constant value. Even though you can change this underlying type, it is not necessary or recommended for most scenarios. Note that no significant performance gain is achieved by using a data type that is smaller than <xref:System.Int32>. If you cannot use the default data type, you should use one of the Common Language System (CLS)-compliant integral types, <xref:System.Byte>, <xref:System.Int16>, <xref:System.Int32>, or <xref:System.Int64> to make sure that all values of the enumeration can be represented in CLS-compliant programming languages.

## How to Fix Violations
 To fix a violation of this rule, unless size or compatibility issues exist, use <xref:System.Int32>. For situations where <xref:System.Int32> is not large enough to hold the values, use <xref:System.Int64>. If backward compatibility requires a smaller data type, use <xref:System.Byte> or <xref:System.Int16>.

## When to Suppress Warnings
 Suppress a warning from this rule only if backward compatibility issues require it. In applications, failure to comply with this rule usually does not cause problems. In libraries, where language interoperability is required, failure to comply with this rule might adversely affect your users.

## Example of a Violation

### Description
 The following example shows two enumerations that do not use the recommended underlying data type.

### Code
 [!code-csharp[FxCop.Design.EnumIntegralType#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.EnumIntegralType/cs/FxCop.Design.EnumIntegralType.cs#1)]
 [!code-vb[FxCop.Design.EnumIntegralType#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Design.EnumIntegralType/vb/FxCop.Design.EnumIntegralType.vb#1)]

## Example of How to Fix

### Description
 The following example fixes the previous violation by changing the underlying data type to <xref:System.Int32>.

### Code
 [!code-csharp[FxCop.Design.EnumIntegralTypeFixed#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.EnumIntegralTypeFixed/cs/FxCop.Design.EnumIntegralTypeFixed.cs#1)]
 [!code-vb[FxCop.Design.EnumIntegralTypeFixed#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Design.EnumIntegralTypeFixed/vb/FxCop.Design.EnumIntegralTypeFixed.vb#1)]

## Related Rules
 [CA1008: Enums should have zero value](../code-quality/ca1008-enums-should-have-zero-value.md)

 [CA1027: Mark enums with FlagsAttribute](../code-quality/ca1027-mark-enums-with-flagsattribute.md)

 [CA2217: Do not mark enums with FlagsAttribute](../code-quality/ca2217-do-not-mark-enums-with-flagsattribute.md)

 [CA1700: Do not name enum values 'Reserved'](../code-quality/ca1700-do-not-name-enum-values-reserved.md)

 [CA1712: Do not prefix enum values with type name](../code-quality/ca1712-do-not-prefix-enum-values-with-type-name.md)

## See Also
 <xref:System.Byte?displayProperty=fullName>
 <xref:System.Int16?displayProperty=fullName>
 <xref:System.Int32?displayProperty=fullName>
 <xref:System.Int64?displayProperty=fullName>
