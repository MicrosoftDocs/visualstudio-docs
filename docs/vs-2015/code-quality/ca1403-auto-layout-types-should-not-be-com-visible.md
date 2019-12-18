---
title: "CA1403: Auto layout types should not be COM visible | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "AutoLayoutTypesShouldNotBeComVisible"
  - "CA1403"
helpviewer_keywords:
  - "CA1403"
  - "AutoLayoutTypesShouldNotBeComVisible"
ms.assetid: a7007714-f9b4-4730-94e0-67d3dc68991f
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1403: Auto layout types should not be COM visible
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|AutoLayoutTypesShouldNotBeComVisible|
|CheckId|CA1403|
|Category|Microsoft.Interoperability|
|Breaking Change|Breaking|

## Cause
 A Component Object Model (COM) visible value type is marked with the <xref:System.Runtime.InteropServices.StructLayoutAttribute?displayProperty=fullName> attribute set to <xref:System.Runtime.InteropServices.LayoutKind?displayProperty=fullName>.

## Rule Description
 <xref:System.Runtime.InteropServices.LayoutKind> layout types are managed by the common language runtime. The layout of these types can change between versions of the .NET Framework, which will break COM clients that expect a specific layout. Note that if the <xref:System.Runtime.InteropServices.StructLayoutAttribute> attribute is not specified, the C#, [!INCLUDE[vbprvb](../includes/vbprvb-md.md)], and C++ compilers specify the <xref:System.Runtime.InteropServices.LayoutKind> layout for value types.

 Unless marked otherwise, all public nongeneric types are visible to COM; all nonpublic and generic types are invisible to COM. However, to reduce false positives, this rule requires the COM visibility of the type to be explicitly stated; the containing assembly must be marked with the <xref:System.Runtime.InteropServices.ComVisibleAttribute?displayProperty=fullName> set to `false` and the type must be marked with the <xref:System.Runtime.InteropServices.ComVisibleAttribute> set to `true`.

## How to Fix Violations
 To fix a violation of this rule, change the value of the <xref:System.Runtime.InteropServices.StructLayoutAttribute> attribute to <xref:System.Runtime.InteropServices.LayoutKind> or <xref:System.Runtime.InteropServices.LayoutKind>, or make the type invisible to COM.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Example
 The following example shows a type that violates the rule and a type that satisfies the rule.

 [!code-csharp[FxCop.Interoperability.AutoLayout#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Interoperability.AutoLayout/cs/FxCop.Interoperability.AutoLayout.cs#1)]
 [!code-vb[FxCop.Interoperability.AutoLayout#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Interoperability.AutoLayout/vb/FxCop.Interoperability.AutoLayout.vb#1)]

## Related Rules
 [CA1408: Do not use AutoDual ClassInterfaceType](../code-quality/ca1408-do-not-use-autodual-classinterfacetype.md)

## See Also
 [Introducing the Class Interface](https://msdn.microsoft.com/733c0dd2-12e5-46e6-8de1-39d5b25df024)
 [Qualifying .NET Types for Interoperation](https://msdn.microsoft.com/library/4b8afb52-fb8d-4e65-b47c-fd82956a3cdd)
 [Interoperating with Unmanaged Code](https://msdn.microsoft.com/library/ccb68ce7-b0e9-4ffb-839d-03b1cd2c1258)
