---
title: "CA1001: Types that own disposable fields should be disposable"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c85c126c-2b16-4505-940a-b5ddf873fb22
caps.latest.revision: 22
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
# CA1001: Types that own disposable fields should be disposable
|||  
|-|-|  
|TypeName|TypesThatOwnDisposableFieldsShouldBeDisposable|  
|CheckId|CA1001|  
|Category|Microsoft.Design|  
|Breaking Change|Non-breaking - If the type is not visible outside the assembly.<br /><br /> Breaking - If the type is visible outside the assembly.|  
  
## Cause  
 A class declares and implements an instance field that is a <xref:System.IDisposable?qualifyHint=True> type and the class does not implement <xref:System.IDisposable?qualifyHint=False>.  
  
## Rule Description  
 A class implements the <xref:System.IDisposable?qualifyHint=False> interface to dispose of unmanaged resources that it owns. An instance field that is an <xref:System.IDisposable?qualifyHint=False> type indicates that the field owns an unmanaged resource. A class that declares an <xref:System.IDisposable?qualifyHint=False> field indirectly owns an unmanaged resource and should implement the <xref:System.IDisposable?qualifyHint=False> interface. If the class does not directly own any unmanaged resources, it should not implement a finalizer.  
  
## How to Fix Violations  
 To fix a violation of this rule, implement <xref:System.IDisposable?qualifyHint=False> and from the <xref:System.IDisposable.Dispose?qualifyHint=True> method call the <xref:System.IDisposable.Dispose?qualifyHint=False> method of the field.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows a class that violates the rule and a class that satisfies the rule by implementing <xref:System.IDisposable?qualifyHint=False>. The class does not implement a finalizer because the class does not directly own any unmanaged resources.  
  
 [!CODE [FxCop.Design.DisposableFields#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Design.DisposableFields#1)]  
  
## Related Rules  
 [CA2213: Disposable fields should be disposed](../VS_IDE/CA2213--Disposable-fields-should-be-disposed.md)  
  
 [CA2216: Disposable types should declare finalizer](../VS_IDE/CA2216--Disposable-types-should-declare-finalizer.md)  
  
 [CA2215: Dispose methods should call base class dispose](../VS_IDE/CA2215--Dispose-methods-should-call-base-class-dispose.md)  
  
 [CA1049: Types that own native resources should be disposable](../VS_IDE/CA1049--Types-that-own-native-resources-should-be-disposable.md)