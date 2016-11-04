---
title: "CA1043: Use integral or string argument for indexers | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "CA1043"
  - "UseIntegralOrStringArgumentForIndexers"
helpviewer_keywords: 
  - "CA1043"
  - "UseIntegralOrStringArgumentForIndexers"
ms.assetid: d7f14b9e-2220-4f80-b6b8-48c655a05701
caps.latest.revision: 14
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# CA1043: Use integral or string argument for indexers
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
  
 [!code-cs[FxCop.Design.IntegralOrStringIndexers#1](../code-quality/codesnippet/CSharp/ca1043-use-integral-or-string-argument-for-indexers_1.cs)]
 [!code-cpp[FxCop.Design.IntegralOrStringIndexers#1](../code-quality/codesnippet/CPP/ca1043-use-integral-or-string-argument-for-indexers_1.cpp)]
 [!code-vb[FxCop.Design.IntegralOrStringIndexers#1](../code-quality/codesnippet/VisualBasic/ca1043-use-integral-or-string-argument-for-indexers_1.vb)]  
  
## Related Rules  
 [CA1023: Indexers should not be multidimensional](../code-quality/ca1023-indexers-should-not-be-multidimensional.md)  
  
 [CA1024: Use properties where appropriate](../code-quality/ca1024-use-properties-where-appropriate.md)