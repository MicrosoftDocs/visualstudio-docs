---
title: "CA1043: Use integral or string argument for indexers | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1043"
  - "UseIntegralOrStringArgumentForIndexers"
helpviewer_keywords:
  - "CA1043"
  - "UseIntegralOrStringArgumentForIndexers"
ms.assetid: d7f14b9e-2220-4f80-b6b8-48c655a05701
caps.latest.revision: 16
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1043: Use integral or string argument for indexers
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|UseIntegralOrStringArgumentForIndexers|
|CheckId|CA1043|
|Category|Microsoft.Design|
|Breaking Change|Breaking|

## Cause
 A public or protected type contains a public or protected indexer that uses an index type other than <xref:System.Int32?displayProperty=fullName>, <xref:System.Int64?displayProperty=fullName>, <xref:System.Object?displayProperty=fullName>, or <xref:System.String?displayProperty=fullName>.

## Rule Description
 Indexers, that is, indexed properties, should use integer or string types for the index. These types are typically used for indexing data structures and increase the usability of the library. Use of the <xref:System.Object> type should be restricted to those cases where the specific integer or string type cannot be specified at design time. If the design requires other types for the index, reconsider whether the type represents a logical data store. If it does not represent a logical data store, use a method.

## How to Fix Violations
 To fix a violation of this rule, change the index to an integer or string type, or use a method instead of the indexer.

## When to Suppress Warnings
 Suppress a warning from this rule only after carefully considering the need for the nonstandard indexer.

## Example
 The following example shows an indexer that uses an <xref:System.Int32> index.

 [!code-cpp[FxCop.Design.IntegralOrStringIndexers#1](../snippets/cpp/VS_Snippets_CodeAnalysis/FxCop.Design.IntegralOrStringIndexers/cpp/FxCop.Design.IntegralOrStringIndexers.cpp#1)]
 [!code-csharp[FxCop.Design.IntegralOrStringIndexers#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.IntegralOrStringIndexers/cs/FxCop.Design.IntegralOrStringIndexers.cs#1)]
 [!code-vb[FxCop.Design.IntegralOrStringIndexers#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Design.IntegralOrStringIndexers/vb/FxCop.Design.IntegralOrStringIndexers.vb#1)]

## Related Rules
 [CA1023: Indexers should not be multidimensional](../code-quality/ca1023-indexers-should-not-be-multidimensional.md)

 [CA1024: Use properties where appropriate](../code-quality/ca1024-use-properties-where-appropriate.md)
