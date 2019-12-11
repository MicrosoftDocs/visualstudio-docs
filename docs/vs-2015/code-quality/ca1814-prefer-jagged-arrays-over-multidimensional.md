---
title: "CA1814: Prefer jagged arrays over multidimensional | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "PreferJaggedArraysOverMultidimensional"
  - "CA1814"
helpviewer_keywords:
  - "PreferJaggedArraysOverMultidimensional"
  - "CA1814"
ms.assetid: b1ccf563-2ec8-42e5-b89c-731a9de1ea1d
caps.latest.revision: 16
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1814: Prefer jagged arrays over multidimensional
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

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

 [!code-csharp[FxCop.Performance.JaggedArrays#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Performance.JaggedArrays/cs/FxCop.Performance.JaggedArrays.cs#1)]
 [!code-vb[FxCop.Performance.JaggedArrays#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Performance.JaggedArrays/vb/FxCop.Performance.JaggedArrays.vb#1)]
