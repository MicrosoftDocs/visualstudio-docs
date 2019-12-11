---
title: "CA2220: Finalizers should call base class finalizer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2220"
  - "FinalizersShouldCallBaseClassFinalizer"
helpviewer_keywords:
  - "CA2220"
  - "FinalizersShouldCallBaseClassFinalizer"
ms.assetid: 48329f42-170d-45ee-a381-e33f55a240c5
caps.latest.revision: 16
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2220: Finalizers should call base class finalizer
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|FinalizersShouldCallBaseClassFinalizer|
|CheckId|CA2220|
|Category|Microsoft.Usage|
|Breaking Change|Non Breaking|

## Cause
 A type that overrides <xref:System.Object.Finalize%2A?displayProperty=fullName> does not call the <xref:System.Object.Finalize%2A> method in its base class.

## Rule Description
 Finalization must be propagated through the inheritance hierarchy. To ensure this, types must call their base class <xref:System.Object.Finalize%2A> method from within their own <xref:System.Object.Finalize%2A> method. The C# compiler adds the call to the base class finalizer automatically.

## How to Fix Violations
 To fix a violation of this rule, call the base type's <xref:System.Object.Finalize%2A> method from your <xref:System.Object.Finalize%2A> method.

## When to Suppress Warnings
 Do not suppress a warning from this rule. Some compilers that target the common language runtime insert a call to the base type's finalizer into the Microsoft intermediate language (MSIL). If a warning from this rule is reported, your compiler does not insert the call, and you must add it to your code.

## Example
 The following Visual Basic example shows a type `TypeB` that correctly calls the <xref:System.Object.Finalize%2A> method in its base class.

 [!code-vb[FxCop.Usage.IDisposableBaseCalled#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Usage.IDisposableBaseCalled/vb/FxCop.Usage.IDisposableBaseCalled.vb#1)]

## See Also
 [Dispose Pattern](https://msdn.microsoft.com/library/31a6c13b-d6a2-492b-9a9f-e5238c983bcb)
