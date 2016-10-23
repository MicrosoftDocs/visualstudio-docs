---
title: "CA2213: Disposable fields should be disposed"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e99442c9-70e2-47f3-b61a-d8ac003bc6e5
caps.latest.revision: 15
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
# CA2213: Disposable fields should be disposed
|||  
|-|-|  
|TypeName|DisposableFieldsShouldBeDisposed|  
|CheckId|CA2213|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A type that implements <xref:System.IDisposable?qualifyHint=True> declares fields that are of types that also implement <xref:System.IDisposable?qualifyHint=False>. The <xref:System.IDisposable.Dispose?qualifyHint=False> method of the field is not called by the <xref:System.IDisposable.Dispose?qualifyHint=False> method of the declaring type.  
  
## Rule Description  
 A type is responsible for disposing of all its unmanaged resources; this is accomplished by implementing <xref:System.IDisposable?qualifyHint=False>. This rule checks to see whether a disposable type `T` declares a field `F` that is an instance of a disposable type `FT`. For each field `F`, the rule attempts to locate a call to `FT.Dispose`. The rule searches the methods called by `T.Dispose`, and one level lower (the methods called by the methods called by `FT.Dispose`).  
  
## How to Fix Violations  
 To fix a violation of this rule, call <xref:System.IDisposable.Dispose?qualifyHint=False> on fields that are of types that implement <xref:System.IDisposable?qualifyHint=False> if you are responsible for allocating and releasing the unmanaged resources held by the field.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if you are not responsible for releasing the resource held by the field, or if the call to <xref:System.IDisposable.Dispose?qualifyHint=False> occurs at a deeper calling level than the rule checks.  
  
## Example  
 The following example shows a type `TypeA` that implements <xref:System.IDisposable?qualifyHint=False> (`FT` in the previosu discussion).  
  
 [!CODE [FxCop.Usage.IDisposablePattern#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.IDisposablePattern#1)]  
  
## Example  
 The following example shows a type `TypeB` that violates this rule by declaring a field `aFieldOfADisposableType` (`F` in the previous discussion) as a disposable type (`TypeA`) and not calling <xref:System.IDisposable.Dispose?qualifyHint=False> on the field. `TypeB` corresponds to `T` in the previous discussion.  
  
 [!CODE [FxCop.Usage.IDisposableFields#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.IDisposableFields#1)]  
  
## See Also  
 <xref:System.IDisposable?qualifyHint=True>   
 [Dispose Pattern](../Topic/Dispose%20Pattern.md)