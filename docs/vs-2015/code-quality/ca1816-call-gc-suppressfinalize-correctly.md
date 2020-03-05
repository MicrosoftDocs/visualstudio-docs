---
title: "CA1816: Call GC.SuppressFinalize correctly | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1816"
  - "DisposeMethodsShouldCallSuppressFinalize"
helpviewer_keywords:
  - "DisposeMethodsShouldCallSuppressFinalize"
  - "CA1816"
ms.assetid: 47915fbb-103f-4333-b157-1da16bf49660
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1816: Call GC.SuppressFinalize correctly
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|CallGCSuppressFinalizeCorrectly|
|CheckId|CA1816|
|Category|Microsoft. Usage|
|Breaking Change|Non Breaking|

## Cause

- A method that is an implementation of <xref:System.IDisposable.Dispose%2A?displayProperty=fullName> does not call <xref:System.GC.SuppressFinalize%2A?displayProperty=fullName>.

- A method that is not an implementation of <xref:System.IDisposable.Dispose%2A?displayProperty=fullName> calls <xref:System.GC.SuppressFinalize%2A?displayProperty=fullName>.

- A method calls <xref:System.GC.SuppressFinalize%2A?displayProperty=fullName> and passes something other than this (Me in Visual Basic).

## Rule Description
 The <xref:System.IDisposable.Dispose%2A?displayProperty=fullName> method lets users release resources at any time before the object becoming available for garbage collection. If the <xref:System.IDisposable.Dispose%2A?displayProperty=fullName> method is called, it frees resources of the object. This makes finalization unnecessary. <xref:System.IDisposable.Dispose%2A?displayProperty=fullName> should call <xref:System.GC.SuppressFinalize%2A?displayProperty=fullName> so the garbage collector does not call the finalizer of the object.

 To prevent derived types with finalizers from having to re-implement [System.IDisposable](<!-- TODO: review code entity reference <xref:assetId:///System.IDisposable?qualifyHint=True&amp;autoUpgrade=False>  -->) and to call it, unsealed types without finalizers should still call <xref:System.GC.SuppressFinalize%2A?displayProperty=fullName>.

## How to Fix Violations
 To fix a violation of this rule:

 If the method is an implementation of <xref:System.IDisposable.Dispose%2A>, add a call to <xref:System.GC.SuppressFinalize%2A?displayProperty=fullName>.

 If the method is not an implementation of <xref:System.IDisposable.Dispose%2A>, either remove the call to <xref:System.GC.SuppressFinalize%2A?displayProperty=fullName> or move it to the type's <xref:System.IDisposable.Dispose%2A> implementation.

 Change all calls to <xref:System.GC.SuppressFinalize%2A?displayProperty=fullName> to pass this (Me in Visual Basic).

## When to Suppress Warnings
 Only suppress a warning from this rule if you are deliberating using <xref:System.GC.SuppressFinalize%2A?displayProperty=fullName> to control the lifetime of other objects. Do not suppress a warning from this rule if an implementation of <xref:System.IDisposable.Dispose%2A> does not call <xref:System.GC.SuppressFinalize%2A?displayProperty=fullName>. In this situation, failing to suppress finalization degrades performance and provide no benefits.

## Example
 The following example shows a method that incorrectly calls <xref:System.GC.SuppressFinalize%2A?displayProperty=fullName>.

 [!code-csharp[FxCop.Usage.CallGCSuppressFinalizeCorrectly#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.CallGCSuppressFinalizeCorrectly/CS/FxCop.Usage.CallGCSuppressFinalizeCorrectly.cs#1)]
 [!code-vb[FxCop.Usage.CallGCSuppressFinalizeCorrectly#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Usage.CallGCSuppressFinalizeCorrectly/VB/FxCop.Usage.CallGCSuppressFinalizeCorrectly.vb#1)]

## Example
 The following example shows a method that correctly calls <xref:System.GC.SuppressFinalize%2A?displayProperty=fullName>.

 [!code-csharp[FxCop.Usage.CallGCSuppressFinalizeCorrectly2#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.CallGCSuppressFinalizeCorrectly2/CS/FxCop.Usage.CallGCSuppressFinalizeCorrectly2.cs#1)]
 [!code-vb[FxCop.Usage.CallGCSuppressFinalizeCorrectly2#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Usage.CallGCSuppressFinalizeCorrectly2/VB/FxCop.Usage.CallGCSuppressFinalizeCorrectly2.vb#1)]

## Related Rules
 [CA2215: Dispose methods should call base class dispose](../code-quality/ca2215-dispose-methods-should-call-base-class-dispose.md)

 [CA2216: Disposable types should declare finalizer](../code-quality/ca2216-disposable-types-should-declare-finalizer.md)

## See Also
 [Dispose Pattern](https://msdn.microsoft.com/library/31a6c13b-d6a2-492b-9a9f-e5238c983bcb)
