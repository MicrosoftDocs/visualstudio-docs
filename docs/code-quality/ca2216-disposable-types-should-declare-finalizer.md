---
title: "CA2216: Disposable types should declare finalizer | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-code-analysis"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "DisposableTypesShouldDeclareFinalizer"
  - "CA2216"
helpviewer_keywords: 
  - "CA2216"
  - "DisposableTypesShouldDeclareFinalizer"
ms.assetid: 0cabcc5e-b526-452b-8c2a-0cbe3b93c0ef
caps.latest.revision: 14
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# CA2216: Disposable types should declare finalizer
|||  
|-|-|  
|TypeName|DisposableTypesShouldDeclareFinalizer|  
|CheckId|CA2216|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A type that implements <xref:System.IDisposable?displayProperty=fullName>, and has fields that suggest the use of unmanaged resources, does not implement a finalizer as described by <xref:System.Object.Finalize%2A?displayProperty=fullName>.  
  
## Rule Description  
 A violation of this rule is reported if the disposable type contains fields of the following types:  
  
-   <xref:System.IntPtr?displayProperty=fullName>  
  
-   <xref:System.UIntPtr?displayProperty=fullName>  
  
-   <xref:System.Runtime.InteropServices.HandleRef?displayProperty=fullName>  
  
## How to Fix Violations  
 To fix a violation of this rule, implement a finalizer that calls your <xref:System.IDisposable.Dispose%2A> method.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the type does not implement <xref:System.IDisposable> for the purpose of releasing unmanaged resources.  
  
## Example  
 The following example shows a type that violates this rule.  
  
 [!code-csharp[FxCop.Usage.DisposeNoFinalize#1](../code-quality/codesnippet/CSharp/ca2216-disposable-types-should-declare-finalizer_1.cs)]  
  
## Related Rules  
 [CA2115: Call GC.KeepAlive when using native resources](../code-quality/ca2115-call-gc-keepalive-when-using-native-resources.md)  
  
 [CA1816: Call GC.SuppressFinalize correctly](../code-quality/ca1816-call-gc-suppressfinalize-correctly.md)  
  
 [CA1049: Types that own native resources should be disposable](../code-quality/ca1049-types-that-own-native-resources-should-be-disposable.md)  
  
## See Also  
 <xref:System.IDisposable?displayProperty=fullName>   
 <xref:System.IntPtr?displayProperty=fullName>   
 <xref:System.Runtime.InteropServices.HandleRef?displayProperty=fullName>   
 <xref:System.UIntPtr?displayProperty=fullName>   
 <xref:System.Object.Finalize%2A?displayProperty=fullName>   
 [Dispose Pattern](/dotnet/standard/design-guidelines/dispose-pattern)