---
title: "CA2217: Do not mark enums with FlagsAttribute"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 1b6f626c-66bf-45b0-a3e2-7c41ee9ceda7
caps.latest.revision: 20
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
# CA2217: Do not mark enums with FlagsAttribute
|||  
|-|-|  
|TypeName|DoNotMarkEnumsWithFlags|  
|CheckId|CA2217|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 An externally visible enumeration is marked with <xref:System.FlagsAttribute?qualifyHint=False> and it has one or more values that are not powers of two or a combination of the other defined values on the enumeration.  
  
## Rule Description  
 An enumeration should have <xref:System.FlagsAttribute?qualifyHint=False> present only if each value defined in the enumeration is a power of two, or a combination of defined values.  
  
## How to Fix Violations  
 To fix a violation of this rule, remove <xref:System.FlagsAttribute?qualifyHint=False> from the enumeration.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows an enumeration, Color, that contains the value 3, which is neither a power of two, nor a combination of any of the defined values. The Color enumeration should not be marked with the <xref:System.FlagsAttribute?qualifyHint=False>.  
  
 [!CODE [FxCop.Usage.EnumNoFlags#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.EnumNoFlags#1)]  
  
## Example  
 The following example shows an enumeration, Days, that meets the requirements for being marked with the System.FlagsAttribute.  
  
 [!CODE [FxCop.Usage.EnumNoFlags2#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.EnumNoFlags2#1)]  
  
## Related Rules  
 [CA1027: Mark enums with FlagsAttribute](../VS_IDE/CA1027--Mark-enums-with-FlagsAttribute.md)  
  
## See Also  
 <xref:System.FlagsAttribute?qualifyHint=True>