---
title: "CA1816: Call GC.SuppressFinalize correctly"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 47915fbb-103f-4333-b157-1da16bf49660
caps.latest.revision: 19
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
# CA1816: Call GC.SuppressFinalize correctly
|||  
|-|-|  
|TypeName|CallGCSuppressFinalizeCorrectly|  
|CheckId|CA1816|  
|Category|Microsoft. Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
  
-   A method that is an implementation of <xref:System.IDisposable.Dispose?qualifyHint=True> does not call <xref:System.GC.SuppressFinalize?qualifyHint=True>.  
  
-   A method that is not an implementation of <xref:System.IDisposable.Dispose?qualifyHint=True> calls <xref:System.GC.SuppressFinalize?qualifyHint=True>.  
  
-   A method calls <xref:System.GC.SuppressFinalize?qualifyHint=True> and passes something other than this (Me in Visual Basic).  
  
## Rule Description  
 The <xref:System.IDisposable.Dispose?qualifyHint=True> method lets users release resources at any time before the object becoming available for garbage collection. If the <xref:System.IDisposable.Dispose?qualifyHint=True> method is called, it frees resources of the object. This makes finalization unnecessary. <xref:System.IDisposable.Dispose?qualifyHint=True> should call <xref:System.GC.SuppressFinalize?qualifyHint=True> so the garbage collector does not call the finalizer of the object.  
  
 To prevent derived types with finalizers from having to re-implement [System.IDisposable](assetId:///System.IDisposable?qualifyHint=True&autoUpgrade=False) and to call it, unsealed types without finalizers should still call <xref:System.GC.SuppressFinalize?qualifyHint=True>.  
  
## How to Fix Violations  
 To fix a violation of this rule:  
  
 If the method is an implementation of <xref:System.IDisposable.Dispose?qualifyHint=False>, add a call to <xref:System.GC.SuppressFinalize?qualifyHint=True>.  
  
 If the method is not an implementation of <xref:System.IDisposable.Dispose?qualifyHint=False>, either remove the call to <xref:System.GC.SuppressFinalize?qualifyHint=True> or move it to the type's <xref:System.IDisposable.Dispose?qualifyHint=False> implementation.  
  
 Change all calls to <xref:System.GC.SuppressFinalize?qualifyHint=True> to pass this (Me in Visual Basic).  
  
## When to Suppress Warnings  
 Only suppress a warning from this rule if you are deliberating using <xref:System.GC.SuppressFinalize?qualifyHint=True> to control the lifetime of other objects. Do not suppress a warning from this rule if an implementation of <xref:System.IDisposable.Dispose?qualifyHint=False> does not call <xref:System.GC.SuppressFinalize?qualifyHint=True>. In this situation, failing to suppress finalization degrades performance and provide no benefits.  
  
## Example  
 The following example shows a method that incorrectly calls <xref:System.GC.SuppressFinalize?qualifyHint=True>.  
  
 [!CODE [FxCop.Usage.CallGCSuppressFinalizeCorrectly#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.CallGCSuppressFinalizeCorrectly#1)]  
  
## Example  
 The following example shows a method that correctly calls <xref:System.GC.SuppressFinalize?qualifyHint=True>.  
  
 [!CODE [FxCop.Usage.CallGCSuppressFinalizeCorrectly2#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.CallGCSuppressFinalizeCorrectly2#1)]  
  
## Related Rules  
 [CA2215: Dispose methods should call base class dispose](../VS_IDE/CA2215--Dispose-methods-should-call-base-class-dispose.md)  
  
 [CA2216: Disposable types should declare finalizer](../VS_IDE/CA2216--Disposable-types-should-declare-finalizer.md)  
  
## See Also  
 [Dispose Pattern](../Topic/Dispose%20Pattern.md)