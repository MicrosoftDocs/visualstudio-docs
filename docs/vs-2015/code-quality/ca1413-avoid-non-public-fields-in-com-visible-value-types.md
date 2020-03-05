---
title: "CA1413: Avoid non-public fields in COM visible value types | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1413"
  - "AvoidNonpublicFieldsInComVisibleValueTypes"
helpviewer_keywords:
  - "CA1413"
  - "AvoidNonpublicFieldsInComVisibleValueTypes"
ms.assetid: 1352e7eb-fefc-4239-8847-25edc7804a54
caps.latest.revision: 17
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1413: Avoid non-public fields in COM visible value types
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|AvoidNonpublicFieldsInComVisibleValueTypes|
|CheckId|CA1413|
|Category|Microsoft.Interoperability|
|Breaking Change|Breaking|

## Cause
 A value type that is specifically marked as visible to Component Object Model (COM) declares a nonpublic instance field.

## Rule Description
 Nonpublic instance fields of COM-visible value types are visible to COM clients. Review the content of the field for information that should not be exposed, or that will have an unintended design or security effect.

 By default, all public value types are visible to COM. However, to reduce false positives, this rule requires the COM visibility of the type to be explicitly stated. The containing assembly must be marked with the <xref:System.Runtime.InteropServices.ComVisibleAttribute?displayProperty=fullName> set to `false` and the type must be marked with the <xref:System.Runtime.InteropServices.ComVisibleAttribute> set to `true`.

## How to Fix Violations
 To fix a violation of this rule and keep the field hidden, change the value type to a reference type or remove the <xref:System.Runtime.InteropServices.ComVisibleAttribute> attribute from the type.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule if public exposure of the field is acceptable.

## Example
 The following example shows a type that violates the rule.

 [!code-csharp[FxCop.Interoperability.NonpublicField#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Interoperability.NonpublicField/cs/FxCop.Interoperability.NonpublicField.cs#1)]
 [!code-vb[FxCop.Interoperability.NonpublicField#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Interoperability.NonpublicField/vb/FxCop.Interoperability.NonpublicField.vb#1)]

## Related Rules
 [CA1407: Avoid static members in COM visible types](../code-quality/ca1407-avoid-static-members-in-com-visible-types.md)

 [CA1017: Mark assemblies with ComVisibleAttribute](../code-quality/ca1017-mark-assemblies-with-comvisibleattribute.md)

## See Also
 [Interoperating with Unmanaged Code](https://msdn.microsoft.com/library/ccb68ce7-b0e9-4ffb-839d-03b1cd2c1258)
 [Qualifying .NET Types for Interoperation](https://msdn.microsoft.com/library/4b8afb52-fb8d-4e65-b47c-fd82956a3cdd)
