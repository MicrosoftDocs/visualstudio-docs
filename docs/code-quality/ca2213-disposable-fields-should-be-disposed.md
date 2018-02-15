---
title: "CA2213: Disposable fields should be disposed | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-code-analysis"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "DisposableFieldsShouldBeDisposed"
  - "CA2213"
helpviewer_keywords: 
  - "CA2213"
  - "DisposableFieldsShouldBeDisposed"
ms.assetid: e99442c9-70e2-47f3-b61a-d8ac003bc6e5
caps.latest.revision: 15
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# CA2213: Disposable fields should be disposed
|||  
|-|-|  
|TypeName|DisposableFieldsShouldBeDisposed|  
|CheckId|CA2213|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A type that implements <xref:System.IDisposable?displayProperty=fullName> declares fields that are of types that also implement <xref:System.IDisposable>. The <xref:System.IDisposable.Dispose%2A> method of the field is not called by the <xref:System.IDisposable.Dispose%2A> method of the declaring type.  
  
## Rule Description  
 A type is responsible for disposing of all its unmanaged resources; this is accomplished by implementing <xref:System.IDisposable>. This rule checks to see whether a disposable type `T` declares a field `F` that is an instance of a disposable type `FT`. For each field `F`, the rule attempts to locate a call to `FT.Dispose`. The rule searches the methods called by `T.Dispose`, and one level lower (the methods called by the methods called by `FT.Dispose`).  
  
## How to Fix Violations  
 To fix a violation of this rule, call <xref:System.IDisposable.Dispose%2A> on fields that are of types that implement <xref:System.IDisposable> if you are responsible for allocating and releasing the unmanaged resources held by the field.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if you are not responsible for releasing the resource held by the field, or if the call to <xref:System.IDisposable.Dispose%2A> occurs at a deeper calling level than the rule checks.  
  
## Example  
 The following example shows a type `TypeA` that implements <xref:System.IDisposable> (`FT` in the previosu discussion).  
  
 [!code-csharp[FxCop.Usage.IDisposablePattern#1](../code-quality/codesnippet/CSharp/ca2213-disposable-fields-should-be-disposed_1.cs)]  
  
## Example  
 The following example shows a type `TypeB` that violates this rule by declaring a field `aFieldOfADisposableType` (`F` in the previous discussion) as a disposable type (`TypeA`) and not calling <xref:System.IDisposable.Dispose%2A> on the field. `TypeB` corresponds to `T` in the previous discussion.  
  
 [!code-csharp[FxCop.Usage.IDisposableFields#1](../code-quality/codesnippet/CSharp/ca2213-disposable-fields-should-be-disposed_2.cs)]  
  
## See Also  
 <xref:System.IDisposable?displayProperty=fullName>   
 [Dispose Pattern](/dotnet/standard/design-guidelines/dispose-pattern)