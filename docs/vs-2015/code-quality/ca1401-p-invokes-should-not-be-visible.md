---
title: "CA1401: P-Invokes should not be visible | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "PInvokesShouldNotBeVisible"
  - "CA1401"
helpviewer_keywords:
  - "CA1401"
  - "PInvokesShouldNotBeVisible"
ms.assetid: 0f4d96c1-f9de-414e-b223-4dc7f691bee3
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1401: P/Invokes should not be visible
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|PInvokesShouldNotBeVisible|
|CheckId|CA1401|
|Category|Microsoft.Interoperability|
|Breaking Change|Breaking|

## Cause
 A public or protected method in a public type has the <xref:System.Runtime.InteropServices.DllImportAttribute?displayProperty=fullName> attribute (also implemented by the `Declare` keyword in [!INCLUDE[vbprvb](../includes/vbprvb-md.md)]).

## Rule Description
 Methods that are marked with the <xref:System.Runtime.InteropServices.DllImportAttribute> attribute (or methods that are defined by using the `Declare` keyword in [!INCLUDE[vbprvb](../includes/vbprvb-md.md)]) use Platform Invocation Services to access unmanaged code. Such methods should not be exposed. By keeping these methods private or internal, you make sure that your library cannot be used to breach security by allowing callers access to unmanaged APIs that they could not call otherwise.

## How to Fix Violations
 To fix a violation of this rule, change the access level of the method.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Example
 The following example declares a method that violates this rule.

 [!code-csharp[FxCop.Interoperability.DllImports#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Interoperability.DllImports/cs/FxCop.Interoperability.DllImports.cs#1)]
 [!code-vb[FxCop.Interoperability.DllImports#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Interoperability.DllImports/vb/FxCop.Interoperability.DllImports.vb#1)]
