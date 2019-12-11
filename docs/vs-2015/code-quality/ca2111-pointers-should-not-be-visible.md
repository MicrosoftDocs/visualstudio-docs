---
title: "CA2111: Pointers should not be visible | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "PointersShouldNotBeVisible"
  - "CA2111"
helpviewer_keywords:
  - "CA2111"
  - "PointersShouldNotBeVisible"
ms.assetid: b3a8d466-895b-43bc-a2df-5d7058fe915f
caps.latest.revision: 16
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2111: Pointers should not be visible
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|PointersShouldNotBeVisible|
|CheckId|CA2111|
|Category|Microsoft.Security|
|Breaking Change|Breaking|

## Cause
 A public or protected <xref:System.IntPtr?displayProperty=fullName> or <xref:System.UIntPtr?displayProperty=fullName> field is not read-only.

## Rule Description
 <xref:System.IntPtr> and <xref:System.UIntPtr> are pointer types that are used to access unmanaged memory. If a pointer is not private, internal, or read-only, malicious code can change the value of the pointer, potentially allowing access to arbitrary locations in memory or causing application or system failures.

 If you intend to secure access to the type that contains the pointer field, see [CA2112: Secured types should not expose fields](../code-quality/ca2112-secured-types-should-not-expose-fields.md).

## How to Fix Violations
 Secure the pointer by making it read-only, internal, or private.

## When to Suppress Warnings
 Suppress a warning from this rule if you do not rely on the value of the pointer.

## Example
 The following code shows pointers that violate and satisfy the rule. Notice that the non-private pointers also violate the rule [CA1051: Do not declare visible instance fields](../code-quality/ca1051-do-not-declare-visible-instance-fields.md).

 [!code-csharp[FxCop.Security.PointersArePrivate#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Security.PointersArePrivate/cs/FxCop.Security.PointersArePrivate.cs#1)]

## Related Rules
 [CA2112: Secured types should not expose fields](../code-quality/ca2112-secured-types-should-not-expose-fields.md)

 [CA1051: Do not declare visible instance fields](../code-quality/ca1051-do-not-declare-visible-instance-fields.md)

## See Also
 <xref:System.IntPtr?displayProperty=fullName>
 <xref:System.UIntPtr?displayProperty=fullName>
