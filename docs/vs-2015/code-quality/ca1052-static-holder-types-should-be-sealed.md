---
title: "CA1052: Static holder types should be sealed | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "StaticHolderTypesShouldBeSealed"
  - "CA1052"
helpviewer_keywords:
  - "CA1052"
  - "StaticHolderTypesShouldBeSealed"
ms.assetid: 51a3165d-781e-4a55-aa0d-ea25fee7d4f2
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1052: Static holder types should be sealed
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|StaticHolderTypesShouldBeSealed|
|CheckId|CA1052|
|Category|Microsoft.Design|
|Breaking Change|Breaking|

## Cause
 A public or protected type contains only static members and is not declared with the [sealed](https://msdn.microsoft.com/library/8e4ed5d3-10be-47db-9488-0da2008e6f3f) ([NotInheritable](https://msdn.microsoft.com/library/5c4da7c9-9562-4653-a947-1972e992f9f9)) modifier.

## Rule Description
 This rule assumes that a type that contains only static members is not designed to be inherited, because the type does not provide any functionality that can be overridden in a derived type. A type that is not meant to be inherited should be marked with the `sealed` modifier to prohibit its use as a base type.

## How to Fix Violations
 To fix a violation of this rule, mark the type as `sealed`. If you are targeting [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] 2.0 or earlier, a better approach is to mark the type as `static`. In this manner, you avoid having to declare a private constructor to prevent the class from being created.

## When to Suppress Warnings
 Suppress a warning from this rule only if the type is designed to be inherited. The absence of the `sealed` modifier suggests that the type is useful as a base type.

## Example of a Violation

### Description
 The following example shows a type that violates the rule.

### Code
 [!code-cpp[FxCop.Design.StaticMembers#1](../snippets/cpp/VS_Snippets_CodeAnalysis/FxCop.Design.StaticMembers/cpp/FxCop.Design.StaticMembers.cpp#1)]
 [!code-csharp[FxCop.Design.StaticMembers#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.StaticMembers/cs/FxCop.Design.StaticMembers.cs#1)]
 [!code-vb[FxCop.Design.StaticMembers#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Design.StaticMembers/vb/FxCop.Design.StaticMembers.vb#1)]

## Fix with the Static Modifier

### Description
 The following example shows how to fix a violation of this rule by marking the type with the `static` modifier.

### Code
 [!code-csharp[FxCop.Design.StaticMembersFixed#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.StaticMembersFixed/cs/FxCop.Design.StaticMembersFixed.cs#1)]

## Related Rules
 [CA1053: Static holder types should not have constructors](../code-quality/ca1053-static-holder-types-should-not-have-constructors.md)
