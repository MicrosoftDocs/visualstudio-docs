---
title: "CA2242: Test for NaN correctly"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e12dcffc-e255-4e1e-8fdf-3c6054d44abe
caps.latest.revision: 11
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
# CA2242: Test for NaN correctly
|||  
|-|-|  
|TypeName|TestForNaNCorrectly|  
|CheckId|CA2242|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 An expression tests a value against <xref:System.Single.Nan?qualifyHint=True> or <xref:System.Double.Nan?qualifyHint=True>.  
  
## Rule Description  
 <xref:System.Double.NaN?qualifyHint=True>, which represents not-a-number, results when an arithmetic operation is undefined. Any expression that tests equality between a value and <xref:System.Double.NaN?qualifyHint=True> always returns `false`. Any expression that tests inequality between a value and <xref:System.Double.NaN?qualifyHint=True> always returns `true`.  
  
## How to Fix Violations  
 To fix a violation of this rule and accurately determine whether a value represents <xref:System.Double.NaN?qualifyHint=True>, use <xref:System.Single.IsNan?qualifyHint=True> or <xref:System.Double.IsNan?qualifyHint=True> to test the value.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows two expressions that incorrectly test a value against <xref:System.Double.NaN?qualifyHint=True> and an expression that correctly uses <xref:System.Double.IsNaN?qualifyHint=True> to test the value.  
  
 [!CODE [FxCop.Usage.TestForNaN#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.TestForNaN#1)]