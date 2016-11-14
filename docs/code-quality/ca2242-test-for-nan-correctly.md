---
title: "CA2242: Test for NaN correctly | Microsoft Docs"
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
  - "TestForNaNCorrectly"
  - "CA2242"
helpviewer_keywords: 
  - "CA2242"
ms.assetid: e12dcffc-e255-4e1e-8fdf-3c6054d44abe
caps.latest.revision: 11
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
# CA2242: Test for NaN correctly
|||  
|-|-|  
|TypeName|TestForNaNCorrectly|  
|CheckId|CA2242|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 An expression tests a value against <xref:System.Single.Nan?displayProperty=fullName> or <xref:System.Double.Nan?displayProperty=fullName>.  
  
## Rule Description  
 <xref:System.Double.NaN?displayProperty=fullName>, which represents not-a-number, results when an arithmetic operation is undefined. Any expression that tests equality between a value and <xref:System.Double.NaN?displayProperty=fullName> always returns `false`. Any expression that tests inequality between a value and <xref:System.Double.NaN?displayProperty=fullName> always returns `true`.  
  
## How to Fix Violations  
 To fix a violation of this rule and accurately determine whether a value represents <xref:System.Double.NaN?displayProperty=fullName>, use <xref:System.Single.IsNan%2A?displayProperty=fullName> or <xref:System.Double.IsNan%2A?displayProperty=fullName> to test the value.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows two expressions that incorrectly test a value against <xref:System.Double.NaN?displayProperty=fullName> and an expression that correctly uses <xref:System.Double.IsNaN%2A?displayProperty=fullName> to test the value.  
  
 [!code-vb[FxCop.Usage.TestForNaN#1](../code-quality/codesnippet/VisualBasic/ca2242-test-for-nan-correctly_1.vb)]
 [!code-cs[FxCop.Usage.TestForNaN#1](../code-quality/codesnippet/CSharp/ca2242-test-for-nan-correctly_1.cs)]