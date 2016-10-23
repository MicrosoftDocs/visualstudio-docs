---
title: "CA1014: Mark assemblies with CLSCompliantAttribute"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 4fe57449-cf45-4745-bcd2-6345f1ed266d
caps.latest.revision: 18
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
# CA1014: Mark assemblies with CLSCompliantAttribute
|||  
|-|-|  
|TypeName|MarkAssembliesWithClsCompliant|  
|CheckId|CA1014|  
|Category|Microsoft.Design|  
|Breaking Change|Non-breaking|  
  
## Cause  
 An assembly does not have the <xref:System.CLSCompliantAttribute?qualifyHint=True> attribute applied to it.  
  
## Rule Description  
 The Common Language Specification (CLS) defines naming restrictions, data types, and rules to which assemblies must conform if they will be used across programming languages. Good design dictates that all assemblies explicitly indicate CLS compliance with <xref:System.CLSCompliantAttribute?qualifyHint=False>. If the attribute is not present on an assembly, the assembly is not compliant.  
  
 It is possible for a CLS-compliant assembly to contain types or type members that are not compliant.  
  
## How to Fix Violations  
 To fix a violation of this rule, add the attribute to the assembly. Instead of marking the whole assembly as noncompliant, you should determine which type or type members are not compliant and mark these elements as such. If possible, you should provide a CLS-compliant alternative for noncompliant members so that the widest possible audience can access all the functionality of your assembly.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule. If you do not want the assembly to be compliant, apply the attribute and set its value to `false`.  
  
## Example  
 The following example shows an assembly that has the <xref:System.CLSCompliantAttribute?qualifyHint=True> attribute applied that declares it CLS-compliant.  
  
 [!CODE [FxCop.Design.AssembliesCls#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Design.AssembliesCls#1)]  
  
## See Also  
 <xref:System.CLSCompliantAttribute?qualifyHint=True>   
 [Language Independence and Language-Independent Components](../Topic/Language%20Independence%20and%20Language-Independent%20Components.md)