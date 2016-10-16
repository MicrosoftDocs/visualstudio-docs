---
title: "CA2216: Disposable types should declare finalizer"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "DisposableTypesShouldDeclareFinalizer"
  - "CA2216"
helpviewer_keywords: 
  - "CA2216"
  - "DisposableTypesShouldDeclareFinalizer"
ms.assetid: 0cabcc5e-b526-452b-8c2a-0cbe3b93c0ef
caps.latest.revision: 14
ms.author: "douge"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# CA2216: Disposable types should declare finalizer
|||  
|-|-|  
|TypeName|DisposableTypesShouldDeclareFinalizer|  
|CheckId|CA2216|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A type that implements \<xref:System.IDisposable?displayProperty=fullName>, and has fields that suggest the use of unmanaged resources, does not implement a finalizer as described by \<xref:System.Object.Finalize*?displayProperty=fullName>.  
  
## Rule Description  
 A violation of this rule is reported if the disposable type contains fields of the following types:  
  
-   \<xref:System.IntPtr?displayProperty=fullName>  
  
-   \<xref:System.UIntPtr?displayProperty=fullName>  
  
-   \<xref:System.Runtime.InteropServices.HandleRef?displayProperty=fullName>  
  
## How to Fix Violations  
 To fix a violation of this rule, implement a finalizer that calls your \<xref:System.IDisposable.Dispose*> method.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the type does not implement \<xref:System.IDisposable> for the purpose of releasing unmanaged resources.  
  
## Example  
 The following example shows a type that violates this rule.  
  
 [!code[FxCop.Usage.DisposeNoFinalize#1](../codequality/codesnippet/CSharp/ca2216--disposable-types-should-declare-finalizer_1.cs)]  
  
## Related Rules  
 [CA2115: Call GC.KeepAlive when using native resources](../codequality/ca2115--call-gc.keepalive-when-using-native-resources.md)  
  
 [CA1816: Call GC.SuppressFinalize correctly](../codequality/ca1816--call-gc.suppressfinalize-correctly.md)  
  
 [CA1049: Types that own native resources should be disposable](../codequality/ca1049--types-that-own-native-resources-should-be-disposable.md)  
  
## See Also  
 \<xref:System.IDisposable?displayProperty=fullName>   
 \<xref:System.IntPtr?displayProperty=fullName>   
 \<xref:System.Runtime.InteropServices.HandleRef?displayProperty=fullName>   
 \<xref:System.UIntPtr?displayProperty=fullName>   
 \<xref:System.Object.Finalize*?displayProperty=fullName>   
 [Dispose Pattern](../Topic/Dispose%20Pattern.md)