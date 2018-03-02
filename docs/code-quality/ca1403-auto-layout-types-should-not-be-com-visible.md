---
title: "CA1403: Auto layout types should not be COM visible | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-code-analysis"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "AutoLayoutTypesShouldNotBeComVisible"
  - "CA1403"
helpviewer_keywords: 
  - "CA1403"
  - "AutoLayoutTypesShouldNotBeComVisible"
ms.assetid: a7007714-f9b4-4730-94e0-67d3dc68991f
caps.latest.revision: 17
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# CA1403: Auto layout types should not be COM visible
|||  
|-|-|  
|TypeName|AutoLayoutTypesShouldNotBeComVisible|  
|CheckId|CA1403|  
|Category|Microsoft.Interoperability|  
|Breaking Change|Breaking|  
  
## Cause  
 A Component Object Model (COM) visible value type is marked with the <xref:System.Runtime.InteropServices.StructLayoutAttribute?displayProperty=fullName> attribute set to <xref:System.Runtime.InteropServices.LayoutKind?displayProperty=fullName>.  
  
## Rule Description  
 <xref:System.Runtime.InteropServices.LayoutKind> layout types are managed by the common language runtime. The layout of these types can change between versions of the .NET Framework, which will break COM clients that expect a specific layout. Note that if the <xref:System.Runtime.InteropServices.StructLayoutAttribute> attribute is not specified, the C#, [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)], and C++ compilers specify the <xref:System.Runtime.InteropServices.LayoutKind> layout for value types.  
  
 Unless marked otherwise, all public nongeneric types are visible to COM; all nonpublic and generic types are invisible to COM. However, to reduce false positives, this rule requires the COM visibility of the type to be explicitly stated; the containing assembly must be marked with the <xref:System.Runtime.InteropServices.ComVisibleAttribute?displayProperty=fullName> set to `false` and the type must be marked with the <xref:System.Runtime.InteropServices.ComVisibleAttribute> set to `true`.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the value of the <xref:System.Runtime.InteropServices.StructLayoutAttribute> attribute to <xref:System.Runtime.InteropServices.LayoutKind> or <xref:System.Runtime.InteropServices.LayoutKind>, or make the type invisible to COM.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows a type that violates the rule and a type that satisfies the rule.  
  
 [!code-csharp[FxCop.Interoperability.AutoLayout#1](../code-quality/codesnippet/CSharp/ca1403-auto-layout-types-should-not-be-com-visible_1.cs)]
 [!code-vb[FxCop.Interoperability.AutoLayout#1](../code-quality/codesnippet/VisualBasic/ca1403-auto-layout-types-should-not-be-com-visible_1.vb)]  
  
## Related Rules  
 [CA1408: Do not use AutoDual ClassInterfaceType](../code-quality/ca1408-do-not-use-autodual-classinterfacetype.md)  
  
## See Also  
 [Qualifying .NET Types for Interoperation](/dotnet/framework/interop/qualifying-net-types-for-interoperation)   
 [Interoperating with Unmanaged Code](/dotnet/framework/interop/index)