---
title: "CA1820: Test for empty strings using string length | Microsoft Docs"
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
  - "TestForEmptyStringsUsingStringLength"
  - "CA1820"
helpviewer_keywords: 
  - "TestForEmptyStringsUsingStringLength"
  - "CA1820"
ms.assetid: da1e70c8-b1dc-46b9-8b8f-4e6e48339681
caps.latest.revision: 21
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# CA1820: Test for empty strings using string length
|||  
|-|-|  
|TypeName|TestForEmptyStringsUsingStringLength|  
|CheckId|CA1820|  
|Category|Microsoft.Performance|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A string is compared to the empty string by using <xref:System.Object.Equals%2A?displayProperty=fullName>.  
  
## Rule Description  
 Comparing strings using the <xref:System.String.Length%2A?displayProperty=fullName> property or the <xref:System.String.IsNullOrEmpty%2A?displayProperty=fullName> method is significantly faster than using <xref:System.Object.Equals%2A>. This is because <xref:System.Object.Equals%2A> executes significantly more MSIL instructions than either <xref:System.String.IsNullOrEmpty%2A> or the number of instructions executed to retrieve the <xref:System.String.Length%2A> property value and compare it to zero.  
  
 You should be aware that <xref:System.Object.Equals%2A> and <xref:System.String.Length%2A> == 0 behave differently for null strings. If you try to get the value of the <xref:System.String.Length%2A> property on a null string, the common language runtime throws a <xref:System.NullReferenceException?displayProperty=fullName>. If you perform a comparison between a null string and the empty string, the common language runtime does not throw an exception; the comparison returns `false`. Testing for null does not significantly affect the relative performance of these two approaches. When targeting [!INCLUDE[dnprdnlong](../code-quality/includes/dnprdnlong_md.md)], use the <xref:System.String.IsNullOrEmpty%2A> method. Otherwise, use the <xref:System.String.Length%2A> == comparison whenever possible.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the comparison to use the <xref:System.String.Length%2A> property and test for the null string. If targeting [!INCLUDE[dnprdnlong](../code-quality/includes/dnprdnlong_md.md)], use the <xref:System.String.IsNullOrEmpty%2A> method.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if performance is not an issue.  
  
## Example  
 The following example illustrates the different techniques that are used to look for an empty string.  
  
 [!code-cs[FxCop.Performance.StringTest#1](../code-quality/codesnippet/CSharp/ca1820-test-for-empty-strings-using-string-length_1.cs)]