---
title: "CA1814: Prefer jagged arrays over multidimensional"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b1ccf563-2ec8-42e5-b89c-731a9de1ea1d
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
# CA1814: Prefer jagged arrays over multidimensional
|||  
|-|-|  
|TypeName|PreferJaggedArraysOverMultidimensional|  
|CheckId|CA1814|  
|Category|Microsoft.Performance|  
|Breaking Change|Breaking|  
  
## Cause  
 A member is declared as a multidimensional array.  
  
## Rule Description  
 A jagged array is an array whose elements are arrays. The arrays that make up the elements can be of different sizes, leading to less wasted space for some sets of data.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the multidimensional array to a jagged array.  
  
## When to Suppress Warnings  
 Suppress a warning from this rule if the multidimensional array does not waste space.  
  
## Example  
 The following example shows declarations for jagged and multidimensional arrays.  
  
 [!CODE [FxCop.Performance.JaggedArrays#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Performance.JaggedArrays#1)]