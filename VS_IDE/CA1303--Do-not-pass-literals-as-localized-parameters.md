---
title: "CA1303: Do not pass literals as localized parameters"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 904d284e-76d0-4b8f-a4df-0094de8d7aac
caps.latest.revision: 22
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
# CA1303: Do not pass literals as localized parameters
|||  
|-|-|  
|TypeName|DoNotPassLiteralsAsLocalizedParameters|  
|CheckId|CA1303|  
|Category|Microsoft.Globalization|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A method passes a string literal as a parameter to a constructor or method in the .NET Framework class library and that string should be localizable.  
  
 This warning is raised when a literal string is passed as a value to a parameter or property and one or more of the following cases is true:  
  
-   The <xref:System.ComponentModel.LocalizableAttribute?qualifyHint=False> attribute of the parameter or property is set to true.  
  
-   The parameter or property name contains "Text", "Message", or "Caption".  
  
-   The name of the string parameter that is passed to a Console.Write or Console.WriteLine method is either "value" or "format".  
  
## Rule Description  
 String literals that are embedded in source code are difficult to localize.  
  
## How to Fix Violations  
 To fix a violation of this rule, replace the string literal with a string retrieved through an instance of the <xref:System.Resources.ResourceManager?qualifyHint=False> class.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the code library will not be localized, or if the string is not exposed to the end user or a developer using the code library.  
  
 Users can eliminate noise against methods which should not be passed localized strings by either renaming the parameter or property named, or by marking these items as conditional.  
  
## Example  
 The following example shows a method that throws an exception when either of its two arguments are out of range. For the first argument, the exception constructor is passed a literal string, which violates this rule. For the second argument, the constructor is correctly passed a string retrieved through a <xref:System.Resources.ResourceManager?qualifyHint=False>.  
  
 [!CODE [FxCop.Globalization.DoNotPassLiterals#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Globalization.DoNotPassLiterals#1)]  
  
## See Also  
 [Resources in Desktop Apps](../Topic/Resources%20in%20Desktop%20Apps.md)