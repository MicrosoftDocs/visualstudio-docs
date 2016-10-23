---
title: "CA1413: Avoid non-public fields in COM visible value types"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 1352e7eb-fefc-4239-8847-25edc7804a54
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
# CA1413: Avoid non-public fields in COM visible value types
|||  
|-|-|  
|TypeName|AvoidNonpublicFieldsInComVisibleValueTypes|  
|CheckId|CA1413|  
|Category|Microsoft.Interoperability|  
|Breaking Change|Breaking|  
  
## Cause  
 A value type that is specifically marked as visible to Component Object Model (COM) declares a nonpublic instance field.  
  
## Rule Description  
 Nonpublic instance fields of COM-visible value types are visible to COM clients. Review the content of the field for information that should not be exposed, or that will have an unintended design or security effect.  
  
 By default, all public value types are visible to COM. However, to reduce false positives, this rule requires the COM visibility of the type to be explicitly stated. The containing assembly must be marked with the <xref:System.Runtime.InteropServices.ComVisibleAttribute?qualifyHint=True> set to `false` and the type must be marked with the <xref:System.Runtime.InteropServices.ComVisibleAttribute?qualifyHint=False> set to `true`.  
  
## How to Fix Violations  
 To fix a violation of this rule and keep the field hidden, change the value type to a reference type or remove the <xref:System.Runtime.InteropServices.ComVisibleAttribute?qualifyHint=False> attribute from the type.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if public exposure of the field is acceptable.  
  
## Example  
 The following example shows a type that violates the rule.  
  
 [!CODE [FxCop.Interoperability.NonpublicField#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Interoperability.NonpublicField#1)]  
  
## Related Rules  
 [CA1407: Avoid static members in COM visible types](../VS_IDE/CA1407--Avoid-static-members-in-COM-visible-types.md)  
  
 [CA1017: Mark assemblies with ComVisibleAttribute](../VS_IDE/CA1017--Mark-assemblies-with-ComVisibleAttribute.md)  
  
## See Also  
 [Interoperating with Unmanaged Code](../Topic/Interoperating%20with%20Unmanaged%20Code.md)   
 [Qualifying .NET Types for Interoperation](../Topic/Qualifying%20.NET%20Types%20for%20Interoperation.md)