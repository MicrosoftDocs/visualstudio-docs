---
title: "CA1415: Declare P-Invokes correctly"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
H1: CA1415: Declare P/Invokes correctly
ms.assetid: 42a90796-0264-4460-bf97-2fb4a093dfdc
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
# CA1415: Declare P-Invokes correctly
|||  
|-|-|  
|TypeName|DeclarePInvokesCorrectly|  
|CheckId|CA1415|  
|Category|Microsoft.Interoperability|  
|Breaking Change|Non-breaking - If the P/Invoke that declares the parameter cannot be seen outside the assembly. Breaking - If the P/Invoke that declares the parameter can be seen outside the assembly.|  
  
## Cause  
 A platform invoke method is incorrectly declared.  
  
## Rule Description  
 A platform invoke method accesses unmanaged code and is defined by using the `Declare` keyword in Visual Basic or the <xref:System.Runtime.InteropServices.DllImportAttribute?qualifyHint=True>. Currently, this rule looks for platform invoke method declarations that target Win32 functions that have a pointer to an OVERLAPPED structure parameter and the corresponding managed parameter is not a pointer to a <xref:System.Threading.NativeOverlapped?qualifyHint=True> structure.  
  
## How to Fix Violations  
 To fix a violation of this rule, correctly declare the platform invoke method.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows platform invoke methods that violate the rule and satisfy the rule.  
  
 [!CODE [FxCop.Interoperability.DeclarePInvokes#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Interoperability.DeclarePInvokes#1)]  
  
## See Also  
 [Interoperating with Unmanaged Code](../Topic/Interoperating%20with%20Unmanaged%20Code.md)