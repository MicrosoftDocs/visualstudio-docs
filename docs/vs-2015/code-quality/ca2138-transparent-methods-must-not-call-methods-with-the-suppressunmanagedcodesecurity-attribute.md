---
title: "CA2138: Transparent methods must not call methods with the SuppressUnmanagedCodeSecurity attribute | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2138"
ms.assetid: a14c4d32-f079-4f3a-956c-a1657cde0f66
caps.latest.revision: 14
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2138: Transparent methods must not call methods with the SuppressUnmanagedCodeSecurity attribute
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|TransparentMethodsMustNotCallSuppressUnmanagedCodeSecurityMethods|
|CheckId|CA2138|
|Category|Microsoft.Security|
|Breaking Change|Breaking|

## Cause
 A security transparent method calls a method that is marked with the <xref:System.Security.SuppressUnmanagedCodeSecurityAttribute> attribute.

## Rule Description
 This rule fires on any transparent method that calls directly into native code, for example, by using a via a P/Invoke (platform invoke) call. P/Invoke and COM interop methods that are marked with the <xref:System.Security.SuppressUnmanagedCodeSecurityAttribute> attribute result in a LinkDemand being done against the calling method. Because security transparent code cannot satisfy LinkDemands, the code also cannot call methods that are marked with the SuppressUnmanagedCodeSecurity attribute, or methods of class that is marked with SuppressUnmanagedCodeSecurity attribute. The method will fail, or the demand will be converted to a full demand.

 Violations of this rule lead to a <xref:System.MethodAccessException> in the Level 2 security transparency model, and a full demand for <xref:System.Security.Permissions.SecurityPermissionAttribute.UnmanagedCode%2A> in the Level 1 transparency model.

## How to Fix Violations
 To fix a violation of this rule, remove the <xref:System.Security.SuppressUnmanagedCodeSecurityAttribute> attribute and mark the method with the <xref:System.Security.SecurityCriticalAttribute> or the <xref:System.Security.SecuritySafeCriticalAttribute> attribute.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Example
 [!code-csharp[FxCop.Security.CA2138.TransparentMethodsMustNotCallSuppressUnmanagedCodeSecurityMethods#1](../snippets/csharp/VS_Snippets_CodeAnalysis/fxcop.security.ca2138.transparentmethodsmustnotcallsuppressunmanagedcodesecuritymethods/cs/ca2138.cs#1)]
