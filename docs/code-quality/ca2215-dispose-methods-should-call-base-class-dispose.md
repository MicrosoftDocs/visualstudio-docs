---
title: "CA2215: Dispose methods should call base class dispose | Microsoft Docs"
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
  - "CA2215"
  - "DisposeMethodsShouldCallBaseClassDispose"
  - "Dispose methods should call base class dispose"
helpviewer_keywords: 
  - "DisposeMethodsShouldCallBaseClassDispose"
  - "CA2215"
ms.assetid: c772e7a6-a87e-425c-a70e-912664ae9042
caps.latest.revision: 16
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
# CA2215: Dispose methods should call base class dispose
|||  
|-|-|  
|TypeName|DisposeMethodsShouldCallBaseClassDispose|  
|CheckId|CA2215|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A type that implements <xref:System.IDisposable?displayProperty=fullName> inherits from a type that also implements <xref:System.IDisposable>. The <xref:System.IDisposable.Dispose%2A> method of the inheriting type does not call the <xref:System.IDisposable.Dispose%2A> method of the parent type.  
  
## Rule Description  
 If a type inherits from a disposable type, it must call the <xref:System.IDisposable.Dispose%2A> method of the base type from within its own <xref:System.IDisposable.Dispose%2A> method. Calling the base type method Dispose ensures that any resources created by the base type are released.  
  
## How to Fix Violations  
 To fix a violation of this rule, call `base`.<xref:System.IDisposable.Dispose%2A> in your <xref:System.IDisposable.Dispose%2A> method.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the call to `base`.<xref:System.IDisposable.Dispose%2A> occurs at a deeper calling level than the rule checks.  
  
## Example  
 The following example shows a type `TypeA` that implements <xref:System.IDisposable>.  
  
 [!code-cs[FxCop.Usage.IDisposablePattern#1](../code-quality/codesnippet/CSharp/ca2215-dispose-methods-should-call-base-class-dispose_1.cs)]  
  
## Example  
 The following example shows a type `TypeB` that inherits from type `TypeA` and correctly calls its <xref:System.IDisposable.Dispose%2A> method.  
  
 [!code-vb[FxCop.Usage.IDisposableBaseCalled#1](../code-quality/codesnippet/VisualBasic/ca2215-dispose-methods-should-call-base-class-dispose_2.vb)]  
  
## See Also  
 <xref:System.IDisposable?displayProperty=fullName>   
 [Dispose Pattern](../Topic/Dispose%20Pattern.md)