---
title: "CA1034: Nested types should not be visible | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "NestedTypesShouldNotBeVisible"
  - "CA1034"
helpviewer_keywords:
  - "NestedTypesShouldNotBeVisible"
  - "CA1034"
ms.assetid: e9789a2c-2540-42a1-8705-ae7104011194
caps.latest.revision: 20
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1034: Nested types should not be visible
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|NestedTypesShouldNotBeVisible|
|CheckId|CA1034|
|Category|Microsoft.Design|
|Breaking Change|Breaking|

## Cause
 An externally visible type contains an externally visible type declaration. Nested enumerations and protected types are exempt from this rule.

## Rule Description
 A nested type is a type declared within the scope of another type. Nested types are useful for encapsulating private implementation details of the containing type. Used for this purpose, nested types should not be externally visible.

 Do not use externally visible nested types for logical grouping or to avoid name collisions; instead, use namespaces.

 Nested types include the notion of member accessibility, which some programmers do not understand clearly.

 Protected types can be used in subclasses and nested types in advance customization scenarios.

## How to Fix Violations
 If you do not intend the nested type to be externally visible, change the type's accessibility. Otherwise, remove the nested type from its parent. If the purpose of the nesting is to categorize the nested type, use a namespace to create the hierarchy instead.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Example
 The following example shows a type that violates the rule.

 [!code-cpp[FxCop.Design.NestedTypes#1](../snippets/cpp/VS_Snippets_CodeAnalysis/FxCop.Design.NestedTypes/cpp/FxCop.Design.NestedTypes.cpp#1)]
 [!code-csharp[FxCop.Design.NestedTypes#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.NestedTypes/cs/FxCop.Design.NestedTypes.cs#1)]
 [!code-vb[FxCop.Design.NestedTypes#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Design.NestedTypes/vb/FxCop.Design.NestedTypes.vb#1)]
