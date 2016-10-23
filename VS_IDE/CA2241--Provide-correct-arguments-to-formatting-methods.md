---
title: "CA2241: Provide correct arguments to formatting methods"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 83639bc4-4c91-4a07-a40e-dc5e49a84494
caps.latest.revision: 12
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
# CA2241: Provide correct arguments to formatting methods
|||  
|-|-|  
|TypeName|ProvideCorrectArgumentsToFormattingMethods|  
|CheckId|CA2241|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 The `format` string argument passed to a method such as <xref:System.Console.WriteLine?qualifyHint=False>,  <xref:System.Console.Write?qualifyHint=False>, or  <xref:System.String.Format?qualifyHint=True> does not contain a format item that corresponds to each object argument, or vice versa.  
  
## Rule Description  
 The arguments to methods such as <xref:System.Console.WriteLine?qualifyHint=False>, <xref:System.Console.Write?qualifyHint=False>, and <xref:System.String.Format?qualifyHint=False> consist of a format string followed by several <xref:System.Object?qualifyHint=True> instances. The format string consists of text and embedded format items of the form, {index[,alignment][:formatString]}. 'index' is a zero-based integer that indicates which of the objects to format. If an object does not have a corresponding index in the format string, the object is ignored. If the object specified by 'index' does not exist, a <xref:System.FormatException?qualifyHint=True> is thrown at runtime.  
  
## How to Fix Violations  
 To fix a violation of this rule, provide a format item for each object argument and provide an object argument for each format item.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows two violations of the rule.  
  
 [!CODE [FxCop.Usage.FormattingArguments#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.FormattingArguments#1)]