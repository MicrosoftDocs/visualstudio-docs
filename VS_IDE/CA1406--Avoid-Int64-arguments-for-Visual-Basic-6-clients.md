---
title: "CA1406: Avoid Int64 arguments for Visual Basic 6 clients"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d5d0d3fc-f105-43da-be5b-923ab023309c
caps.latest.revision: 14
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
# CA1406: Avoid Int64 arguments for Visual Basic 6 clients
|||  
|-|-|  
|TypeName|AvoidInt64ArgumentsForVB6Clients|  
|CheckId|CA1406|  
|Category|Microsoft.Interoperability|  
|Breaking Change|Breaking|  
  
## Cause  
 A type that is specifically marked as visible to Component Object Model (COM) declares a member that takes a <xref:System.Int64?qualifyHint=True> argument.  
  
## Rule Description  
 Visual Basic 6 COM clients cannot access 64-bit integers.  
  
 By default, the following are visible to COM: assemblies, public types, public instance members in public types, and all members of public value types. However, to reduce false positives, this rule requires the COM visibility of the type to be explicitly stated; the containing assembly must be marked with the <xref:System.Runtime.InteropServices.ComVisibleAttribute?qualifyHint=True> set to `false` and the type must be marked with the <xref:System.Runtime.InteropServices.ComVisibleAttribute?qualifyHint=False> set to `true`.  
  
## How to Fix Violations  
 To fix a violation of this rule for a parameter whose value can always be expressed as a 32-bit integral, change the parameter type to <xref:System.Int32?qualifyHint=True>. If the value of the parameter might be larger than can be expressed as a 32-bit integral, change the parameter type to <xref:System.Decimal?qualifyHint=True>. Note that both <xref:System.Single?qualifyHint=True> and <xref:System.Double?qualifyHint=True> lose precision at the upper ranges of the <xref:System.Int64?qualifyHint=False> data type. If the member is not meant to be visible to COM, mark it with the <xref:System.Runtime.InteropServices.ComVisibleAttribute?qualifyHint=False> set to `false`.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if it is certain that Visual Basic 6 COM clients will not access the type.  
  
## Example  
 The following example shows a type that violates the rule.  
  
 [!CODE [FxCop.Interoperability.LongArgument#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Interoperability.LongArgument#1)]  
  
## Related Rules  
 [CA1413: Avoid non-public fields in COM visible value types](../VS_IDE/CA1413--Avoid-non-public-fields-in-COM-visible-value-types.md)  
  
 [CA1407: Avoid static members in COM visible types](../VS_IDE/CA1407--Avoid-static-members-in-COM-visible-types.md)  
  
 [CA1017: Mark assemblies with ComVisibleAttribute](../VS_IDE/CA1017--Mark-assemblies-with-ComVisibleAttribute.md)  
  
## See Also  
 [Interoperating with Unmanaged Code](../Topic/Interoperating%20with%20Unmanaged%20Code.md)   
 [Long Data Type](../Topic/Long%20Data%20Type%20\(Visual%20Basic\).md)