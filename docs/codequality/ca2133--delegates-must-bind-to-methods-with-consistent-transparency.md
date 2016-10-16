---
title: "CA2133: Delegates must bind to methods with consistent transparency"
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
  - "CA2133"
ms.assetid: a09672e2-63cb-4abd-9e8f-dff515e101ce
caps.latest.revision: 11
ms.author: "douge"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# CA2133: Delegates must bind to methods with consistent transparency
|||  
|-|-|  
|TypeName|DelegatesMustBindWithConsistentTransparency|  
|CheckId|CA2133|  
|Category|Microsoft.Security|  
|Breaking Change|Breaking|  
  
> [!NOTE]
>  This warning is only applied to code that is running the CoreCLR (the version of the CLR that is specific to Silverlight Web applications).  
  
## Cause  
 This warning fires on a method that binds a delegate that is marked with the \<xref:System.Security.SecurityCriticalAttribute> to a method that is transparent or that is marked with the \<xref:System.Security.SecuritySafeCriticalAttribute>. The warning also fires a method that binds a delegate that is transparent or safe-critical to a critical method.  
  
## Rule Description  
 Delegate types and the methods that they bind to must have consistent transparency. Transparent and safe-critical delegates may only bind to other transparent or safe-critical methods. Similarly, critical delegates may only bind to critical methods. These binding rules ensure that the only code that can invoke a method via a delegate could have also invoked the same method directly. For example, binding rules prevent transparent code from calling critical code directly via a transparent delegate.  
  
## How to Fix Violations  
 To fix a violation of this warning, change the transparency of the delegate or of the method that it binds so that the transparency of the two are equivalent.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
### Code  
 [!code[FxCop.Security.CA2133.DelegatesMustBindWithConsistentTransparency#1](../codequality/codesnippet/CSharp/ca2133--delegates-must-bind-to-methods-with-consistent-transparency_1.cs)]