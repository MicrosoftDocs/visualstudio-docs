---
title: "CA1903: Use only API from targeted framework | Microsoft Docs"
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
  - "UseOnlyAPIFromTargetedFramework"
  - "CA1903"
helpviewer_keywords: 
  - "UseOnlyApiFromTargetedFramework"
  - "CA1903"
ms.assetid: efdb5cc7-bbd8-4fa7-9fff-02b91e59350e
caps.latest.revision: 8
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# CA1903: Use only API from targeted framework
|||  
|-|-|  
|TypeName|UseOnlyApiFromTargetedFramework|  
|CheckId|CA1903|  
|Category|Microsoft.Portability|  
|Breaking Change|Breaking - when fired against the signature of an externally visible member or type.<br /><br /> Non breaking - when fired in the body of a method.|  
  
## Cause  
 A member or type is using a member or type that was introduced in a service pack that was not included with the project's targeted framework.  
  
## Rule Description  
 New members and types were included in .NET Framework 2.0 Service Pack 1 and 2, .NET Framework 3.0 Service Pack 1 and 2, and .NET Framework 3.5 Service Pack 1. Projects that target the major versions of the .NET Framework can unintentionally take dependencies on these new APIs. To prevent this dependency, this rule fires on usages of any new members and types that were not included by default with the project's target framework.  
  
 **Target Framework and Service Pack Dependencies**  
  
|||  
|-|-|  
|When target framework is|Fires on usages of members introduced in|  
|.NET Framework 2.0|.NET Framework 2.0 SP1, .NET Framework 2.0 SP2|  
|.NET Framework 3.0|.NET Framework 2.0 SP1, .NET Framework 2.0 SP2, .NET Framework 3.0 SP1, .NET Framework 3.0 SP2|  
|.NET Framework 3.5|.NET Framework 3.5 SP1|  
|.NET Framework 4|N/A|  
  
 To change a project's target framework, see [Targeting a Specific .NET Framework Version](../ide/targeting-a-specific-dotnet-framework-version.md).  
  
## How to Fix Violations  
 To remove the dependency on the service pack, remove all usages of the new member or type. If this is a deliberate dependency, either suppress the warning or turn this rule off.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule if this was not a deliberate dependency on the specified service pack. In this situation, your application might fail to run on systems without this service pack installed. Suppress the warning or turn this rule off if this was a deliberate dependency.  
  
## Example  
 The following example shows a class that uses the type DateTimeOffset that is only available in .NET 2.0 Service Pack 1. This example requires that .NET Framework 2.0 has been selected in the Target Framework drop-down list in the Project properties.  
  
 [!code-cs[FxCop.Portability.UseOnlyApiFromTargetedFramework#1](../code-quality/codesnippet/CSharp/ca1903-use-only-api-from-targeted-framework_1.cs)]  
  
## Example  
 The following example fixes the previously described violation by replacing usages of the DateTimeOffset type with the DateTime type.  
  
 [!code-cs[FxCop.Portability.UseOnlyApiFromTargetedFramework2#1](../code-quality/codesnippet/CSharp/ca1903-use-only-api-from-targeted-framework_2.cs)]  
  
## See Also  
 [Portability Warnings](../code-quality/portability-warnings.md)   
 [Targeting a Specific .NET Framework Version](../ide/targeting-a-specific-dotnet-framework-version.md)