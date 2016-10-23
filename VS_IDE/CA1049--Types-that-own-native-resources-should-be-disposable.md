---
title: "CA1049: Types that own native resources should be disposable"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 084e587d-0e45-4092-b767-49eed30d6a35
caps.latest.revision: 17
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# CA1049: Types that own native resources should be disposable
|||  
|-|-|  
|TypeName|TypesThatOwnNativeResourcesShouldBeDisposable|  
|CheckId|CA1049|  
|Category|Microsoft.Design|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A type references a <xref:System.IntPtr?qualifyHint=True> field, a <xref:System.UIntPtr?qualifyHint=True> field, or a <xref:System.Runtime.InteropServices.HandleRef?qualifyHint=True> field, but does not implement <xref:System.IDisposable?qualifyHint=True>.  
  
## Rule Description  
 This rule assumes that <xref:System.IntPtr?qualifyHint=False>, <xref:System.UIntPtr?qualifyHint=False>, and <xref:System.Runtime.InteropServices.HandleRef?qualifyHint=False> fields store pointers to unmanaged resources. Types that allocate unmanaged resources should implement <xref:System.IDisposable?qualifyHint=False> to let callers to release those resources on demand and shorten the lifetimes of the objects that hold the resources.  
  
 The recommended design pattern to clean up unmanaged resources is to provide both an implicit and an explicit means to free those resources by using the <xref:System.Object.Finalize?qualifyHint=True> method and the <xref:System.IDisposable.Dispose?qualifyHint=True> method, respectively. The garbage collector calls the <xref:System.Object.Finalize?qualifyHint=False> method of an object at some indeterminate time after the object is determined to be no longer reachable. After <xref:System.Object.Finalize?qualifyHint=False> is called, an additional garbage collection is required to free the object. The <xref:System.IDisposable.Dispose?qualifyHint=False> method allows the caller to explicitly release resources on demand, earlier than the resources would be released if left to the garbage collector. After it cleans up the unmanaged resources, <xref:System.IDisposable.Dispose?qualifyHint=False> should call the <xref:System.GC.SuppressFinalize?qualifyHint=True> method to let the garbage collector know that <xref:System.Object.Finalize?qualifyHint=False> no longer has to be called; this eliminates the need for the additional garbage collection and shortens the lifetime of the object.  
  
## How to Fix Violations  
 To fix a violation of this rule, implement <xref:System.IDisposable?qualifyHint=False>.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the type does not reference an unmanaged resource. Otherwise, do not suppress a warning from this rule because failure to implement <xref:System.IDisposable?qualifyHint=False> can cause unmanaged resources to become unavailable or underused.  
  
## Example  
 The following example shows a type that implements <xref:System.IDisposable?qualifyHint=False> to clean up an unmanaged resource.  
  
 [!CODE [FxCop.Design.UnmanagedResources#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Design.UnmanagedResources#1)]  
  
## Related Rules  
 [CA2115: Call GC.KeepAlive when using native resources](../VS_IDE/CA2115--Call-GC.KeepAlive-when-using-native-resources.md)  
  
 [CA1816: Call GC.SuppressFinalize correctly](../VS_IDE/CA1816--Call-GC.SuppressFinalize-correctly.md)  
  
 [CA2216: Disposable types should declare finalizer](../VS_IDE/CA2216--Disposable-types-should-declare-finalizer.md)  
  
 [CA1001: Types that own disposable fields should be disposable](../VS_IDE/CA1001--Types-that-own-disposable-fields-should-be-disposable.md)  
  
## See Also  
 [Cleaning Up Unmanaged Resources](../Topic/Cleaning%20Up%20Unmanaged%20Resources.md)   
 [Dispose Pattern](../Topic/Dispose%20Pattern.md)