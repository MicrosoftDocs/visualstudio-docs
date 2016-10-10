---
title: "CA2216: Disposable types should declare finalizer"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 0cabcc5e-b526-452b-8c2a-0cbe3b93c0ef
caps.latest.revision: 14
manager: douge
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# CA2216: Disposable types should declare finalizer
|||  
|-|-|  
|TypeName|DisposableTypesShouldDeclareFinalizer|  
|CheckId|CA2216|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A type that implements <xref:System.IDisposable?qualifyHint=True>, and has fields that suggest the use of unmanaged resources, does not implement a finalizer as described by <xref:System.Object.Finalize?qualifyHint=True>.  
  
## Rule Description  
 A violation of this rule is reported if the disposable type contains fields of the following types:  
  
-   <xref:System.IntPtr?qualifyHint=True>  
  
-   <xref:System.UIntPtr?qualifyHint=True>  
  
-   <xref:System.Runtime.InteropServices.HandleRef?qualifyHint=True>  
  
## How to Fix Violations  
 To fix a violation of this rule, implement a finalizer that calls your <xref:System.IDisposable.Dispose?qualifyHint=False> method.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the type does not implement <xref:System.IDisposable?qualifyHint=False> for the purpose of releasing unmanaged resources.  
  
## Example  
 The following example shows a type that violates this rule.  
  
 [!CODE [FxCop.Usage.DisposeNoFinalize#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.DisposeNoFinalize#1)]  
  
## Related Rules  
 [CA2115: Call GC.KeepAlive when using native resources](../VS_IDE/CA2115--Call-GC.KeepAlive-when-using-native-resources.md)  
  
 [CA1816: Call GC.SuppressFinalize correctly](../VS_IDE/CA1816--Call-GC.SuppressFinalize-correctly.md)  
  
 [CA1049: Types that own native resources should be disposable](../VS_IDE/CA1049--Types-that-own-native-resources-should-be-disposable.md)  
  
## See Also  
 <xref:System.IDisposable?qualifyHint=True>   
 <xref:System.IntPtr?qualifyHint=True>   
 <xref:System.Runtime.InteropServices.HandleRef?qualifyHint=True>   
 <xref:System.UIntPtr?qualifyHint=True>   
 <xref:System.Object.Finalize?qualifyHint=True>   
 [Dispose Pattern](../Topic/Dispose%20Pattern.md)