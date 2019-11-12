---
title: "CA1017: Mark assemblies with ComVisibleAttribute | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1017"
  - "MarkAssembliesWithComVisible"
helpviewer_keywords:
  - "MarkAssembliesWithComVisible"
  - "CA1017"
ms.assetid: 4842cb49-8dd8-4e5d-a2d6-ceeaf6c6cf8e
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1017: Mark assemblies with ComVisibleAttribute
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|MarkAssembliesWithComVisible|
|CheckId|CA1017|
|Category|Microsoft.Design|
|Breaking Change|Non-breaking|

## Cause
 An assembly does not have the <xref:System.Runtime.InteropServices.ComVisibleAttribute?displayProperty=fullName> attribute applied to it.

## Rule Description
 The <xref:System.Runtime.InteropServices.ComVisibleAttribute> attribute determines how COM clients access managed code. Good design dictates that assemblies explicitly indicate COM visibility. COM visibility can be set for a whole assembly and then overridden for individual types and type members. If the attribute is not present, the contents of the assembly are visible to COM clients.

## How to Fix Violations
 To fix a violation of this rule, add the attribute to the assembly. If you do not want the assembly to be visible to COM clients, apply the attribute and set its value to `false`.

## When to Suppress Warnings
 Do not suppress a warning from this rule. If you want the assembly to be visible, apply the attribute and set its value to `true`.

## Example
 The following example shows an assembly that has the <xref:System.Runtime.InteropServices.ComVisibleAttribute> attribute applied to prevent it from being visible to COM clients.

 [!code-cpp[FxCop.Design.AssembliesCom#1](../snippets/cpp/VS_Snippets_CodeAnalysis/FxCop.Design.AssembliesCom/cpp/FxCop.Design.AssembliesCom.cpp#1)]
 [!code-csharp[FxCop.Design.AssembliesCom#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.AssembliesCom/cs/FxCop.Design.AssembliesCom.cs#1)]
 [!code-vb[FxCop.Design.AssembliesCom#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Design.AssembliesCom/vb/FxCop.Design.AssembliesCom.vb#1)]

## See Also
 [Interoperating with Unmanaged Code](https://msdn.microsoft.com/library/ccb68ce7-b0e9-4ffb-839d-03b1cd2c1258)
 [Qualifying .NET Types for Interoperation](https://msdn.microsoft.com/library/4b8afb52-fb8d-4e65-b47c-fd82956a3cdd)
