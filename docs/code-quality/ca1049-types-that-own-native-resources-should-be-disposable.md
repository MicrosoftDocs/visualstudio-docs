---
title: "CA1049: Types that own native resources should be disposable | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "CA1049"
  - "TypesThatOwnNativeResourcesShouldBeDisposable"
helpviewer_keywords: 
  - "TypesThatOwnNativeResourcesShouldBeDisposable"
  - "CA1049"
ms.assetid: 084e587d-0e45-4092-b767-49eed30d6a35
caps.latest.revision: 17
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# CA1049: Types that own native resources should be disposable
|||  
|-|-|  
|TypeName|TypesThatOwnNativeResourcesShouldBeDisposable|  
|CheckId|CA1049|  
|Category|Microsoft.Design|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A type references a <xref:System.IntPtr?displayProperty=fullName> field, a <xref:System.UIntPtr?displayProperty=fullName> field, or a <xref:System.Runtime.InteropServices.HandleRef?displayProperty=fullName> field, but does not implement <xref:System.IDisposable?displayProperty=fullName>.  
  
## Rule Description  
 This rule assumes that <xref:System.IntPtr>, <xref:System.UIntPtr>, and <xref:System.Runtime.InteropServices.HandleRef> fields store pointers to unmanaged resources. Types that allocate unmanaged resources should implement <xref:System.IDisposable> to let callers to release those resources on demand and shorten the lifetimes of the objects that hold the resources.  
  
 The recommended design pattern to clean up unmanaged resources is to provide both an implicit and an explicit means to free those resources by using the <xref:System.Object.Finalize%2A?displayProperty=fullName> method and the <xref:System.IDisposable.Dispose%2A?displayProperty=fullName> method, respectively. The garbage collector calls the <xref:System.Object.Finalize%2A> method of an object at some indeterminate time after the object is determined to be no longer reachable. After <xref:System.Object.Finalize%2A> is called, an additional garbage collection is required to free the object. The <xref:System.IDisposable.Dispose%2A> method allows the caller to explicitly release resources on demand, earlier than the resources would be released if left to the garbage collector. After it cleans up the unmanaged resources, <xref:System.IDisposable.Dispose%2A> should call the <xref:System.GC.SuppressFinalize%2A?displayProperty=fullName> method to let the garbage collector know that <xref:System.Object.Finalize%2A> no longer has to be called; this eliminates the need for the additional garbage collection and shortens the lifetime of the object.  
  
## How to Fix Violations  
 To fix a violation of this rule, implement <xref:System.IDisposable>.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the type does not reference an unmanaged resource. Otherwise, do not suppress a warning from this rule because failure to implement <xref:System.IDisposable> can cause unmanaged resources to become unavailable or underused.  
  
## Example  
 The following example shows a type that implements <xref:System.IDisposable> to clean up an unmanaged resource.  
  
 [!code-cs[FxCop.Design.UnmanagedResources#1](../code-quality/codesnippet/CSharp/ca1049-types-that-own-native-resources-should-be-disposable_1.cs)]
 [!code-vb[FxCop.Design.UnmanagedResources#1](../code-quality/codesnippet/VisualBasic/ca1049-types-that-own-native-resources-should-be-disposable_1.vb)]  
  
## Related Rules  
 [CA2115: Call GC.KeepAlive when using native resources](../code-quality/ca2115-call-gc-keepalive-when-using-native-resources.md)  
  
 [CA1816: Call GC.SuppressFinalize correctly](../code-quality/ca1816-call-gc-suppressfinalize-correctly.md)  
  
 [CA2216: Disposable types should declare finalizer](../code-quality/ca2216-disposable-types-should-declare-finalizer.md)  
  
 [CA1001: Types that own disposable fields should be disposable](../code-quality/ca1001-types-that-own-disposable-fields-should-be-disposable.md)  
  
## See Also  
 [Cleaning Up Unmanaged Resources](../Topic/Cleaning%20Up%20Unmanaged%20Resources.md)   
 [Dispose Pattern](../Topic/Dispose%20Pattern.md)