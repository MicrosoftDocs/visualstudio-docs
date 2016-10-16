---
title: "CA2215: Dispose methods should call base class dispose"
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
  - "CA2215"
  - "DisposeMethodsShouldCallBaseClassDispose"
  - "Dispose methods should call base class dispose"
helpviewer_keywords: 
  - "DisposeMethodsShouldCallBaseClassDispose"
  - "CA2215"
ms.assetid: c772e7a6-a87e-425c-a70e-912664ae9042
caps.latest.revision: 16
ms.author: "douge"
manager: "douge"
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
# CA2215: Dispose methods should call base class dispose
|||  
|-|-|  
|TypeName|DisposeMethodsShouldCallBaseClassDispose|  
|CheckId|CA2215|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A type that implements \<xref:System.IDisposable?displayProperty=fullName> inherits from a type that also implements \<xref:System.IDisposable>. The \<xref:System.IDisposable.Dispose*> method of the inheriting type does not call the \<xref:System.IDisposable.Dispose*> method of the parent type.  
  
## Rule Description  
 If a type inherits from a disposable type, it must call the \<xref:System.IDisposable.Dispose*> method of the base type from within its own \<xref:System.IDisposable.Dispose*> method. Calling the base type method Dispose ensures that any resources created by the base type are released.  
  
## How to Fix Violations  
 To fix a violation of this rule, call `base`.\<xref:System.IDisposable.Dispose*> in your \<xref:System.IDisposable.Dispose*> method.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the call to `base`.\<xref:System.IDisposable.Dispose*> occurs at a deeper calling level than the rule checks.  
  
## Example  
 The following example shows a type `TypeA` that implements \<xref:System.IDisposable>.  
  
 [!code[FxCop.Usage.IDisposablePattern#1](../codequality/codesnippet/CSharp/ca2215--dispose-methods-should-call-base-class-dispose_1.cs)]  
  
## Example  
 The following example shows a type `TypeB` that inherits from type `TypeA` and correctly calls its \<xref:System.IDisposable.Dispose*> method.  
  
 [!code[FxCop.Usage.IDisposableBaseCalled#1](../codequality/codesnippet/VisualBasic/ca2215--dispose-methods-should-call-base-class-dispose_2.vb)]  
  
## See Also  
 \<xref:System.IDisposable?displayProperty=fullName>   
 [Dispose Pattern](../Topic/Dispose%20Pattern.md)