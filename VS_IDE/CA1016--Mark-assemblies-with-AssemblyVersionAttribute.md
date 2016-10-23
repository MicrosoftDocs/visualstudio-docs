---
title: "CA1016: Mark assemblies with AssemblyVersionAttribute"
ms.custom: na
ms.date: 10/04/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 4340aed8-d92b-4cde-a398-cb6963c6da5a
caps.latest.revision: 19
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
# CA1016: Mark assemblies with AssemblyVersionAttribute
|||  
|-|-|  
|TypeName|MarkAssembliesWithAssemblyVersion|  
|CheckId|CA1016|  
|Category|Microsoft.Design|  
|Breaking Change|Non-breaking|  
  
## Cause  
 The assembly does not have a version number.  
  
## Rule Description  
 The identity of an assembly is composed of the following information:  
  
-   Assembly name  
  
-   Version number  
  
-   Culture  
  
-   Public key (for strongly named assemblies).  
  
 The .NET Framework uses the version number to uniquely identify an assembly, and to bind to types in strongly named assemblies. The version number is used together with version and publisher policy. By default, applications run only with the assembly version with which they were built.  
  
## How to Fix Violations  
 To fix a violation of this rule, add a version number to the assembly by using the <xref:System.Reflection.AssemblyVersionAttribute?qualifyHint=True> attribute. See the following example.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule for assemblies that are used by third parties, or in a production environment.  
  
## Example  
 The following example shows an assembly that has the <xref:System.Reflection.AssemblyVersionAttribute?qualifyHint=False> attribute applied.  
  
 [!CODE [FxCop.Design.AssembliesVersion#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Design.AssembliesVersion#1)]  
  
## See Also  
 [Assembly Versioning](../Topic/Assembly%20Versioning.md)   
 [How to: Create a Publisher Policy](../Topic/How%20to:%20Create%20a%20Publisher%20Policy.md)