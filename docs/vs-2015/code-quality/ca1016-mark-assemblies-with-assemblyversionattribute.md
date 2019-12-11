---
title: "CA1016: Mark assemblies with AssemblyVersionAttribute | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "MarkAssembliesWithAssemblyVersion"
  - "CA1016"
helpviewer_keywords:
  - "CA1016"
  - "MarkAssembliesWithAssemblyVersion"
ms.assetid: 4340aed8-d92b-4cde-a398-cb6963c6da5a
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1016: Mark assemblies with AssemblyVersionAttribute
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|MarkAssembliesWithAssemblyVersion|
|CheckId|CA1016|
|Category|Microsoft.Design|
|Breaking Change|Non-breaking|

## Cause
 The assembly does not have a version number.

## Rule Description
 The identity of an assembly is composed of the following information:

- Assembly name

- Version number

- Culture

- Public key (for strongly named assemblies).

  The [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] uses the version number to uniquely identify an assembly, and to bind to types in strongly named assemblies. The version number is used together with version and publisher policy. By default, applications run only with the assembly version with which they were built.

## How to Fix Violations
 To fix a violation of this rule, add a version number to the assembly by using the <xref:System.Reflection.AssemblyVersionAttribute?displayProperty=fullName> attribute. See the following example.

## When to Suppress Warnings
 Do not suppress a warning from this rule for assemblies that are used by third parties, or in a production environment.

## Example
 The following example shows an assembly that has the <xref:System.Reflection.AssemblyVersionAttribute> attribute applied.

 [!code-cpp[FxCop.Design.AssembliesVersion#1](../snippets/cpp/VS_Snippets_CodeAnalysis/FxCop.Design.AssembliesVersion/cpp/FxCop.Design.AssembliesVersion.cpp#1)]
 [!code-csharp[FxCop.Design.AssembliesVersion#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.AssembliesVersion/cs/FxCop.Design.AssembliesVersion.cs#1)]
 [!code-vb[FxCop.Design.AssembliesVersion#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Design.AssembliesVersion/vb/FxCop.Design.AssembliesVersion.vb#1)]

## See Also
 [Assembly Versioning](https://msdn.microsoft.com/library/775ad4fb-914f-453c-98ef-ce1089b6f903)
 [How to: Create a Publisher Policy](https://msdn.microsoft.com/library/8046bc5d-2fa9-4277-8a5e-6dcc96c281d9)
