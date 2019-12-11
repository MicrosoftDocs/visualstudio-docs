---
title: "CA1700: Do not name enum values &#39;Reserved&#39; | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1700"
  - "DoNotNameEnumValuesReserved"
helpviewer_keywords:
  - "DoNotNameEnumValuesReserved"
  - "CA1700"
ms.assetid: 7a7e01c3-ae7d-4c82-a646-91b58864a749
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1700: Do not name enum values &#39;Reserved&#39;
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|DoNotNameEnumValuesReserved|
|CheckId|CA1700|
|Category|Microsoft.Naming|
|Breaking Change|Breaking|

## Cause
 The name of an enumeration member contains the word "reserved".

## Rule Description
 This rule assumes that an enumeration member that has a name that contains "reserved" is not currently used but is a placeholder to be renamed or removed in a future version. Renaming or removing a member is a breaking change. You should not expect users to ignore a member just because its name contains "reserved", nor can you rely on users to read or abide by documentation. Furthermore, because reserved members appear in object browsers and smart integrated development environments, they can cause confusion about which members are actually being used.

 Instead of using a reserved member, add a new member to the enumeration in the future version. In most cases the addition of the new member is not a breaking change, as long as the addition does not cause the values of the original members to change.

 In a limited number of cases the addition of a member is a breaking change even when the original members retain their original values. Primarily, the new member cannot be returned from existing code paths without breaking callers that use a `switch` (`Select` in [!INCLUDE[vbprvb](../includes/vbprvb-md.md)]) statement on the return value that encompasses the whole member list and that throw an exception in the default case. A secondary concern is that client code might not handle the change in behavior from reflection methods such as <xref:System.Enum.IsDefined%2A?displayProperty=fullName>. Accordingly, if the new member has to be returned from existing methods or a known application incompatibility occurs because of poor reflection usage, the only nonbreaking solution is to:

1. Add a new enumeration that contains the original and new members.

2. Mark the original enumeration with the <xref:System.ObsoleteAttribute?displayProperty=fullName> attribute.

   Follow the same procedure for any externally visible types or members that expose the original enumeration.

## How to Fix Violations
 To fix a violation of this rule, remove or rename the member.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule for a member that is currently used or for libraries that have previously shipped.

## Related Rules
 [CA2217: Do not mark enums with FlagsAttribute](../code-quality/ca2217-do-not-mark-enums-with-flagsattribute.md)

 [CA1712: Do not prefix enum values with type name](../code-quality/ca1712-do-not-prefix-enum-values-with-type-name.md)

 [CA1028: Enum storage should be Int32](../code-quality/ca1028-enum-storage-should-be-int32.md)

 [CA1008: Enums should have zero value](../code-quality/ca1008-enums-should-have-zero-value.md)

 [CA1027: Mark enums with FlagsAttribute](../code-quality/ca1027-mark-enums-with-flagsattribute.md)
