---
title: "CA1023: Indexers should not be multidimensional"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IndexersShouldNotBeMultidimensional"
  - "CA1023"
helpviewer_keywords: 
  - "CA1023"
  - "IndexersShouldNotBeMultidimensional"
ms.assetid: ae499879-97f6-434e-a61d-1fedd231d2fb
caps.latest.revision: 14
ms.author: "douge"
manager: "douge"
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
# CA1023: Indexers should not be multidimensional
|||  
|-|-|  
|TypeName|IndexersShouldNotBeMultidimensional|  
|CheckId|CA1023|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 A public or protected type contains a public or protected indexer that uses more than one index.  
  
## Rule Description  
 Indexers, that is, indexed properties, should use a single index. Multi-dimensional indexers can significantly reduce the usability of the library. If the design requires multiple indexes, reconsider whether the type represents a logical data store. If not, use a method.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the design to use a lone integer or string index, or use a method instead of the indexer.  
  
## When to Suppress Warnings  
 Suppress a warning from this rule only after carefully considering the need for the nonstandard indexer.  
  
## Example  
 The following example shows a type, `DayOfWeek03`, with a multi-dimensional indexer that violates the rule. The indexer can be seen as a type of conversion and therefore is more appropriately exposed as a method. The type is redesigned in `RedesignedDayOfWeek03` to satisfy the rule.  
  
 [!code[FxCop.Design.OneDimensionForIndexer#1](../codequality/codesnippet/VisualBasic/ca1023--indexers-should-not-be-multidimensional_1.vb)]
[!code[FxCop.Design.OneDimensionForIndexer#1](../codequality/codesnippet/CPP/ca1023--indexers-should-not-be-multidimensional_1.cpp)]
[!code[FxCop.Design.OneDimensionForIndexer#1](../codequality/codesnippet/CSharp/ca1023--indexers-should-not-be-multidimensional_1.cs)]  
  
## Related Rules  
 [CA1043: Use integral or string argument for indexers](../codequality/ca1043--use-integral-or-string-argument-for-indexers.md)  
  
 [CA1024: Use properties where appropriate](../codequality/ca1024--use-properties-where-appropriate.md)