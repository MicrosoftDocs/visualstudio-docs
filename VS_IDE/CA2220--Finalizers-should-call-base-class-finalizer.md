---
title: "CA2220: Finalizers should call base class finalizer"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 48329f42-170d-45ee-a381-e33f55a240c5
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
# CA2220: Finalizers should call base class finalizer
|||  
|-|-|  
|TypeName|FinalizersShouldCallBaseClassFinalizer|  
|CheckId|CA2220|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A type that overrides <xref:System.Object.Finalize?qualifyHint=True> does not call the <xref:System.Object.Finalize?qualifyHint=False> method in its base class.  
  
## Rule Description  
 Finalization must be propagated through the inheritance hierarchy. To ensure this, types must call their base class <xref:System.Object.Finalize?qualifyHint=False> method from within their own <xref:System.Object.Finalize?qualifyHint=False> method. The C# compiler adds the call to the base class finalizer automatically.  
  
## How to Fix Violations  
 To fix a violation of this rule, call the base type's <xref:System.Object.Finalize?qualifyHint=False> method from your <xref:System.Object.Finalize?qualifyHint=False> method.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule. Some compilers that target the common language runtime insert a call to the base type's finalizer into the Microsoft intermediate language (MSIL). If a warning from this rule is reported, your compiler does not insert the call, and you must add it to your code.  
  
## Example  
 The following Visual Basic example shows a type `TypeB` that correctly calls the <xref:System.Object.Finalize?qualifyHint=False> method in its base class.  
  
 [!CODE [FxCop.Usage.IDisposableBaseCalled#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.IDisposableBaseCalled#1)]  
  
## See Also  
 [Dispose Pattern](../Topic/Dispose%20Pattern.md)