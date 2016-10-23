---
title: "CA1043: Use integral or string argument for indexers"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d7f14b9e-2220-4f80-b6b8-48c655a05701
caps.latest.revision: 14
manager: douge
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# CA1043: Use integral or string argument for indexers
|||  
|-|-|  
|TypeName|UseIntegralOrStringArgumentForIndexers|  
|CheckId|CA1043|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 A public or protected type contains a public or protected indexer that uses an index type other than <xref:System.Int32?qualifyHint=True>, <xref:System.Int64?qualifyHint=True>, <xref:System.Object?qualifyHint=True>, or <xref:System.String?qualifyHint=True>.  
  
## Rule Description  
 Indexers, that is, indexed properties, should use integer or string types for the index. These types are typically used for indexing data structures and increase the usability of the library. Use of the <xref:System.Object?qualifyHint=False> type should be restricted to those cases where the specific integer or string type cannot be specified at design time. If the design requires other types for the index, reconsider whether the type represents a logical data store. If it does not represent a logical data store, use a method.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the index to an integer or string type, or use a method instead of the indexer.  
  
## When to Suppress Warnings  
 Suppress a warning from this rule only after carefully considering the need for the nonstandard indexer.  
  
## Example  
 The following example shows an indexer that uses an <xref:System.Int32?qualifyHint=False> index.  
  
 [!CODE [FxCop.Design.IntegralOrStringIndexers#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Design.IntegralOrStringIndexers#1)]  
  
## Related Rules  
 [CA1023: Indexers should not be multidimensional](../VS_IDE/CA1023--Indexers-should-not-be-multidimensional.md)  
  
 [CA1024: Use properties where appropriate](../VS_IDE/CA1024--Use-properties-where-appropriate.md)