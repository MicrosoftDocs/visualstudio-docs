---
title: "CA1711: Identifiers should not have incorrect suffix"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a63359ab-386d-44ae-b381-ee3a983aca29
caps.latest.revision: 18
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
# CA1711: Identifiers should not have incorrect suffix
|||  
|-|-|  
|TypeName|IdentifiersShouldNotHaveIncorrectSuffix|  
|CheckId|CA1711|  
|Category|Microsoft.Naming|  
|Breaking Change|Breaking|  
  
## Cause  
 An identifier has an incorrect suffix.  
  
## Rule Description  
 By convention, only the names of types that extend certain base types or that implement certain interfaces, or types derived from these types, should end with specific reserved suffixes. Other type names should not use these reserved suffixes.  
  
 The following table lists the reserved suffixes and the base types and interfaces with which they are associated.  
  
|Suffix|Base type/Interface|  
|------------|--------------------------|  
|Attribute|<xref:System.Attribute?qualifyHint=True>|  
|Collection|<xref:System.Collections.ICollection?qualifyHint=True><br /><br /> <xref:System.Collections.IEnumerable?qualifyHint=True><br /><br /> <xref:System.Collections.Queue?qualifyHint=True><br /><br /> <xref:System.Collections.Stack?qualifyHint=True><br /><br /> <xref:System.Collections.Generic.ICollection`1?qualifyHint=True><br /><br /> <xref:System.Data.DataSet?qualifyHint=True><br /><br /> <xref:System.Data.DataTable?qualifyHint=True>|  
|Dictionary|<xref:System.Collections.IDictionary?qualifyHint=True><br /><br /> <xref:System.Collections.Generic.IDictionary`2?qualifyHint=True>|  
|EventArgs|<xref:System.EventArgs?qualifyHint=True>|  
|EventHandler|An event-handler delegate|  
|Exception|<xref:System.Exception?qualifyHint=True>|  
|Permission|<xref:System.Security.IPermission?qualifyHint=True>|  
|Queue|<xref:System.Collections.Queue?qualifyHint=True>|  
|Stack|<xref:System.Collections.Stack?qualifyHint=True>|  
|Stream|<xref:System.IO.Stream?qualifyHint=True>|  
  
 In addition, the following suffixes should **not** be used:  
  
-   Delegate  
  
-   Enum  
  
-   Impl - use 'Core' instead  
  
-   Ex or similar suffix to distinguish it from an earlier version of the same type  
  
 Naming conventions provide a common look for libraries that target the common language runtime. This reduces the learning curve that is required for new software libraries, and increases customer confidence that the library was developed by someone who has expertise in developing managed code.  
  
## How to Fix Violations  
 Remove the suffix from the type name.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule unless the suffix has an unambiguous meaning in the application domain.  
  
## Related Rules  
 [CA1710: Identifiers should have correct suffix](../VS_IDE/CA1710--Identifiers-should-have-correct-suffix.md)  
  
## See Also  
 [Attributes](../Topic/Attributes1.md)   
 [NIB: Events and Delegates](assetId:///d98fd58b-fa4f-4598-8378-addf4355a115)