---
title: "CA1403: Auto layout types should not be COM visible"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a7007714-f9b4-4730-94e0-67d3dc68991f
caps.latest.revision: 17
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
# CA1403: Auto layout types should not be COM visible
|||  
|-|-|  
|TypeName|AutoLayoutTypesShouldNotBeComVisible|  
|CheckId|CA1403|  
|Category|Microsoft.Interoperability|  
|Breaking Change|Breaking|  
  
## Cause  
 A Component Object Model (COM) visible value type is marked with the <xref:System.Runtime.InteropServices.StructLayoutAttribute?qualifyHint=True> attribute set to <xref:System.Runtime.InteropServices.LayoutKind?qualifyHint=True>.  
  
## Rule Description  
 <xref:System.Runtime.InteropServices.LayoutKind?qualifyHint=False> layout types are managed by the common language runtime. The layout of these types can change between versions of the .NET Framework, which will break COM clients that expect a specific layout. Note that if the <xref:System.Runtime.InteropServices.StructLayoutAttribute?qualifyHint=False> attribute is not specified, the C#, Visual Basic, and C++ compilers specify the <xref:System.Runtime.InteropServices.LayoutKind?qualifyHint=False> layout for value types.  
  
 Unless marked otherwise, all public nongeneric types are visible to COM; all nonpublic and generic types are invisible to COM. However, to reduce false positives, this rule requires the COM visibility of the type to be explicitly stated; the containing assembly must be marked with the <xref:System.Runtime.InteropServices.ComVisibleAttribute?qualifyHint=True> set to `false` and the type must be marked with the <xref:System.Runtime.InteropServices.ComVisibleAttribute?qualifyHint=False> set to `true`.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the value of the <xref:System.Runtime.InteropServices.StructLayoutAttribute?qualifyHint=False> attribute to <xref:System.Runtime.InteropServices.LayoutKind?qualifyHint=False> or <xref:System.Runtime.InteropServices.LayoutKind?qualifyHint=False>, or make the type invisible to COM.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows a type that violates the rule and a type that satisfies the rule.  
  
 [!CODE [FxCop.Interoperability.AutoLayout#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Interoperability.AutoLayout#1)]  
  
## Related Rules  
 [CA1408: Do not use AutoDual ClassInterfaceType](../VS_IDE/CA1408--Do-not-use-AutoDual-ClassInterfaceType.md)  
  
## See Also  
 [Introducing the Class Interface](assetId:///733c0dd2-12e5-46e6-8de1-39d5b25df024)   
 [Qualifying .NET Types for Interoperation](../Topic/Qualifying%20.NET%20Types%20for%20Interoperation.md)   
 [Interoperating with Unmanaged Code](../Topic/Interoperating%20with%20Unmanaged%20Code.md)