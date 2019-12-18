---
title: "CA2126: Type link demands require inheritance demands | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2126"
  - "TypeLinkDemandsRequireInheritanceDemands"
helpviewer_keywords:
  - "CA2126"
  - "TypeLinkDemandsRequireInheritanceDemands"
ms.assetid: 07b604e5-5579-4df9-a578-dadd0d8370a7
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2126: Type link demands require inheritance demands
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|TypeLinkDemandsRequireInheritanceDemands|
|CheckId|CA2126|
|Category|Microsoft.Security|
|Breaking Change|Breaking|

## Cause
 A public unsealed type is protected with a link demand, has an overridable method, and neither the type nor the method is protected with an inheritance demand.

## Rule Description
 A link demand on a method or its declaring type requires the immediate caller of the method to have the specified permission. An inheritance demand on a method requires an overriding method to have the specified permission. An inheritance demand on a type requires a deriving class to have the specified permission.

## How to Fix Violations
 To fix a violation of this rule, secure the type or the method with an inheritance demand for the same permission as the link demand.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Example
 The following example shows a type that violates the rule.

 [!code-cpp[FxCop.Security.TypesWithLinkDemands#1](../snippets/cpp/VS_Snippets_CodeAnalysis/FxCop.Security.TypesWithLinkDemands/cpp/FxCop.Security.TypesWithLinkDemands.cpp#1)]
 [!code-csharp[FxCop.Security.TypesWithLinkDemands#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Security.TypesWithLinkDemands/cs/FxCop.Security.TypesWithLinkDemands.cs#1)]
 [!code-vb[FxCop.Security.TypesWithLinkDemands#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Security.TypesWithLinkDemands/vb/FxCop.Security.TypesWithLinkDemands.vb#1)]

## Related Rules
 [CA2108: Review declarative security on value types](../code-quality/ca2108-review-declarative-security-on-value-types.md)

 [CA2112: Secured types should not expose fields](../code-quality/ca2112-secured-types-should-not-expose-fields.md)

 [CA2122: Do not indirectly expose methods with link demands](../code-quality/ca2122-do-not-indirectly-expose-methods-with-link-demands.md)

 [CA2123: Override link demands should be identical to base](../code-quality/ca2123-override-link-demands-should-be-identical-to-base.md)

## See Also
 [Secure Coding Guidelines](https://msdn.microsoft.com/library/4f882d94-262b-4494-b0a6-ba9ba1f5f177)
 [Inheritance Demands](https://msdn.microsoft.com/28b9adbb-8f08-4f10-b856-dbf59eb932d9)
 [Link Demands](https://msdn.microsoft.com/library/a33fd5f9-2de9-4653-a4f0-d9df25082c4d)
 [Demands](https://msdn.microsoft.com/e5283e28-2366-4519-b27d-ef5c1ddc1f48)
