---
title: "CA1014: Mark assemblies with CLSCompliantAttribute | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1014"
  - "MarkAssembliesWithClsCompliant"
helpviewer_keywords:
  - "CA1014"
  - "MarkAssembliesWithClsCompliant"
ms.assetid: 4fe57449-cf45-4745-bcd2-6345f1ed266d
caps.latest.revision: 20
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1014: Mark assemblies with CLSCompliantAttribute
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|MarkAssembliesWithClsCompliant|
|CheckId|CA1014|
|Category|Microsoft.Design|
|Breaking Change|Non-breaking|

## Cause
 An assembly does not have the <xref:System.CLSCompliantAttribute?displayProperty=fullName> attribute applied to it.

## Rule Description
 The Common Language Specification (CLS) defines naming restrictions, data types, and rules to which assemblies must conform if they will be used across programming languages. Good design dictates that all assemblies explicitly indicate CLS compliance with <xref:System.CLSCompliantAttribute>. If the attribute is not present on an assembly, the assembly is not compliant.

 It is possible for a CLS-compliant assembly to contain types or type members that are not compliant.

## How to Fix Violations
 To fix a violation of this rule, add the attribute to the assembly. Instead of marking the whole assembly as noncompliant, you should determine which type or type members are not compliant and mark these elements as such. If possible, you should provide a CLS-compliant alternative for noncompliant members so that the widest possible audience can access all the functionality of your assembly.

## When to Suppress Warnings
 Do not suppress a warning from this rule. If you do not want the assembly to be compliant, apply the attribute and set its value to `false`.

## Example
 The following example shows an assembly that has the <xref:System.CLSCompliantAttribute?displayProperty=fullName> attribute applied that declares it CLS-compliant.

 [!code-cpp[FxCop.Design.AssembliesCls#1](../snippets/cpp/VS_Snippets_CodeAnalysis/FxCop.Design.AssembliesCls/cpp/FxCop.Design.AssembliesCls.cpp#1)]
 [!code-csharp[FxCop.Design.AssembliesCls#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.AssembliesCls/cs/FxCop.Design.AssembliesCls.cs#1)]
 [!code-vb[FxCop.Design.AssembliesCls#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Design.AssembliesCls/vb/FxCop.Design.AssembliesCls.vb#1)]

## See Also
 <xref:System.CLSCompliantAttribute?displayProperty=fullName>
 [Language Independence and Language-Independent Components](https://msdn.microsoft.com/library/4f0b77d0-4844-464f-af73-6e06bedeafc6)
