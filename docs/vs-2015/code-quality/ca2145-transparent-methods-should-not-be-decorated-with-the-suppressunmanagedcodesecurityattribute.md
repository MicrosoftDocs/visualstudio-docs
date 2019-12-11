---
title: "CA2145: Transparent methods should not be decorated with the SuppressUnmanagedCodeSecurityAttribute | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2145"
ms.assetid: 81970700-b438-4b3b-9239-16887e16f7b7
caps.latest.revision: 13
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2145: Transparent methods should not be decorated with the SuppressUnmanagedCodeSecurityAttribute
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|TransparentMethodsShouldNotUseSuppressUnmanagedCodeSecurity|
|CheckId|CA2145|
|Category|Microsoft.Security|
|Breaking Change|Breaking|

## Cause
 A transparent method, a method that is marked with the <xref:System.Security.SecuritySafeCriticalAttribute> method, or a type that contains a method is marked with the <xref:System.Security.SuppressUnmanagedCodeSecurityAttribute> attribute.

## Rule Description
 Methods decorated with the <xref:System.Security.SuppressUnmanagedCodeSecurityAttribute> attribute have an implicit LinkDemand placed upon any method that calls it. This LinkDemand requires that the calling code be security critical. Marking the method that uses SuppressUnmanagedCodeSecurity with the <xref:System.Security.SecurityCriticalAttribute> attribute makes this requirement more obvious for callers of the method.

## How to Fix Violations
 To fix a violation of this rule, mark the method or type with the <xref:System.Security.SecurityCriticalAttribute> attribute.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

### Code
 [!code-csharp[FxCop.Security.CA2145.TransparentMethodsShouldNotUseSuppressUnmanagedCodeSecurity#1](../snippets/csharp/VS_Snippets_CodeAnalysis/fxcop.security.ca2145.transparentmethodsshouldnotusesuppressunmanagedcodesecurity/cs/ca2145.cs#1)]

### Comments
