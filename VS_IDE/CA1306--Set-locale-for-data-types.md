---
title: "CA1306: Set locale for data types"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 104297b2-5806-4de0-a8d9-c589380a796c
caps.latest.revision: 15
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
# CA1306: Set locale for data types
|||  
|-|-|  
|TypeName|SetLocaleForDataTypes|  
|CheckId|CA1306|  
|Category|Microsoft.Globalization|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A method or constructor created one or more <xref:System.Data.DataTable?qualifyHint=True> or <xref:System.Data.DataSet?qualifyHint=True> instances and did not explicitly set the locale property (<xref:System.Data.DataTable.Locale?qualifyHint=True> or <xref:System.Data.DataSet.Locale?qualifyHint=True>).  
  
## Rule Description  
 The locale determines culture-specific presentation elements for data, such as formatting used for numeric values, currency symbols, and sort order. When you create a <xref:System.Data.DataTable?qualifyHint=False> or <xref:System.Data.DataSet?qualifyHint=False>, you should set the locale explicitly. By default, the locale for these types is the current culture. For data that is stored in a database or file and is shared globally, the locale should ordinarily be set to the invariant culture (<xref:System.Globalization.CultureInfo.InvariantCulture?qualifyHint=True>). When data is shared across cultures, using the default locale can cause the contents of the <xref:System.Data.DataTable?qualifyHint=False> or <xref:System.Data.DataSet?qualifyHint=False> to be presented or interpreted incorrectly.  
  
## How to Fix Violations  
 To fix a violation of this rule, explicitly set the locale for the <xref:System.Data.DataTable?qualifyHint=False> or <xref:System.Data.DataSet?qualifyHint=False>.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule when the library or application is for a limited local audience, the data is not shared, or the default setting yields the desired behavior in all supported scenarios.  
  
## Example  
 The following example creates two <xref:System.Data.DataTable?qualifyHint=False> instances.  
  
 [!CODE [FxCop.Globalization.DataTable#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Globalization.DataTable#1)]  
  
## See Also  
 <xref:System.Data.DataTable?qualifyHint=True>   
 <xref:System.Data.DataSet?qualifyHint=True>   
 <xref:System.Globalization.CultureInfo?qualifyHint=True>   
 <xref:System.Globalization.CultureInfo.CurrentUICulture?qualifyHint=True>   
 <xref:System.Globalization.CultureInfo.InvariantCulture?qualifyHint=True>