---
title: "CA1401: P-Invokes should not be visible"
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
  - "PInvokesShouldNotBeVisible"
  - "CA1401"
helpviewer_keywords: 
  - "CA1401"
  - "PInvokesShouldNotBeVisible"
ms.assetid: 0f4d96c1-f9de-414e-b223-4dc7f691bee3
caps.latest.revision: 17
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
# CA1401: P/Invokes should not be visible
|||  
|-|-|  
|TypeName|PInvokesShouldNotBeVisible|  
|CheckId|CA1401|  
|Category|Microsoft.Interoperability|  
|Breaking Change|Breaking|  
  
## Cause  
 A public or protected method in a public type has the \<xref:System.Runtime.InteropServices.DllImportAttribute?displayProperty=fullName> attribute (also implemented by the `Declare` keyword in [!INCLUDE[vbprvb](../codequality/includes/vbprvb_md.md)]).  
  
## Rule Description  
 Methods that are marked with the \<xref:System.Runtime.InteropServices.DllImportAttribute> attribute (or methods that are defined by using the `Declare` keyword in [!INCLUDE[vbprvb](../codequality/includes/vbprvb_md.md)]) use Platform Invocation Services to access unmanaged code. Such methods should not be exposed. By keeping these methods private or internal, you make sure that your library cannot be used to breach security by allowing callers access to unmanaged APIs that they could not call otherwise.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the access level of the method.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example declares a method that violates this rule.  
  
 [!code[FxCop.Interoperability.DllImports#1](../codequality/codesnippet/VisualBasic/ca1401--p-invokes-should-not-be-visible_1.vb)]
[!code[FxCop.Interoperability.DllImports#1](../codequality/codesnippet/CSharp/ca1401--p-invokes-should-not-be-visible_1.cs)]