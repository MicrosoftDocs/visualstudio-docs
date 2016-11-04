---
title: "CA1306: Set locale for data types | Microsoft Docs"
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
  - "CA1306"
  - "SetLocaleForDataTypes"
helpviewer_keywords: 
  - "CA1306"
  - "SetLocaleForDataTypes"
ms.assetid: 104297b2-5806-4de0-a8d9-c589380a796c
caps.latest.revision: 15
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
# CA1306: Set locale for data types
|||  
|-|-|  
|TypeName|SetLocaleForDataTypes|  
|CheckId|CA1306|  
|Category|Microsoft.Globalization|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A method or constructor created one or more <xref:System.Data.DataTable?displayProperty=fullName> or <xref:System.Data.DataSet?displayProperty=fullName> instances and did not explicitly set the locale property (<xref:System.Data.DataTable.Locale%2A?displayProperty=fullName> or <xref:System.Data.DataSet.Locale%2A?displayProperty=fullName>).  
  
## Rule Description  
 The locale determines culture-specific presentation elements for data, such as formatting used for numeric values, currency symbols, and sort order. When you create a <xref:System.Data.DataTable> or <xref:System.Data.DataSet>, you should set the locale explicitly. By default, the locale for these types is the current culture. For data that is stored in a database or file and is shared globally, the locale should ordinarily be set to the invariant culture (<xref:System.Globalization.CultureInfo.InvariantCulture%2A?displayProperty=fullName>). When data is shared across cultures, using the default locale can cause the contents of the <xref:System.Data.DataTable> or <xref:System.Data.DataSet> to be presented or interpreted incorrectly.  
  
## How to Fix Violations  
 To fix a violation of this rule, explicitly set the locale for the <xref:System.Data.DataTable> or <xref:System.Data.DataSet>.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule when the library or application is for a limited local audience, the data is not shared, or the default setting yields the desired behavior in all supported scenarios.  
  
## Example  
 The following example creates two <xref:System.Data.DataTable> instances.  
  
 [!code-cs[FxCop.Globalization.DataTable#1](../code-quality/codesnippet/CSharp/ca1306-set-locale-for-data-types_1.cs)]  
  
## See Also  
 <xref:System.Data.DataTable?displayProperty=fullName>   
 <xref:System.Data.DataSet?displayProperty=fullName>   
 <xref:System.Globalization.CultureInfo?displayProperty=fullName>   
 <xref:System.Globalization.CultureInfo.CurrentUICulture%2A?displayProperty=fullName>   
 <xref:System.Globalization.CultureInfo.InvariantCulture%2A?displayProperty=fullName>