---
title: "CA1820: Test for empty strings using string length"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: da1e70c8-b1dc-46b9-8b8f-4e6e48339681
caps.latest.revision: 21
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# CA1820: Test for empty strings using string length
|||  
|-|-|  
|TypeName|TestForEmptyStringsUsingStringLength|  
|CheckId|CA1820|  
|Category|Microsoft.Performance|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A string is compared to the empty string by using <xref:System.Object.Equals?qualifyHint=True>.  
  
## Rule Description  
 Comparing strings using the <xref:System.String.Length?qualifyHint=True> property or the <xref:System.String.IsNullOrEmpty?qualifyHint=True> method is significantly faster than using <xref:System.Object.Equals?qualifyHint=False>. This is because <xref:System.Object.Equals?qualifyHint=False> executes significantly more MSIL instructions than either <xref:System.String.IsNullOrEmpty?qualifyHint=False> or the number of instructions executed to retrieve the <xref:System.String.Length?qualifyHint=False> property value and compare it to zero.  
  
 You should be aware that <xref:System.Object.Equals?qualifyHint=False> and <xref:System.String.Length?qualifyHint=False> == 0 behave differently for null strings. If you try to get the value of the <xref:System.String.Length?qualifyHint=False> property on a null string, the common language runtime throws a <xref:System.NullReferenceException?qualifyHint=True>. If you perform a comparison between a null string and the empty string, the common language runtime does not throw an exception; the comparison returns `false`. Testing for null does not significantly affect the relative performance of these two approaches. When targeting .NET Framework 2.0, use the <xref:System.String.IsNullOrEmpty?qualifyHint=False> method. Otherwise, use the <xref:System.String.Length?qualifyHint=False> == comparison whenever possible.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the comparison to use the <xref:System.String.Length?qualifyHint=False> property and test for the null string. If targeting .NET Framework 2.0, use the <xref:System.String.IsNullOrEmpty?qualifyHint=False> method.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if performance is not an issue.  
  
## Example  
 The following example illustrates the different techniques that are used to look for an empty string.  
  
 [!CODE [FxCop.Performance.StringTest#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Performance.StringTest#1)]