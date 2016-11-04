---
title: "CA2138: Transparent methods must not call methods with the SuppressUnmanagedCodeSecurity attribute | Microsoft Docs"
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
  - "CA2138"
ms.assetid: a14c4d32-f079-4f3a-956c-a1657cde0f66
caps.latest.revision: 12
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
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
# CA2138: Transparent methods must not call methods with the SuppressUnmanagedCodeSecurity attribute
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
 [!code-cs[FxCop.Security.CA2138.TransparentMethodsMustNotCallSuppressUnmanagedCodeSecurityMethods#1](../code-quality/codesnippet/CSharp/ca2138-transparent-methods-must-not-call-methods-with-the-suppressunmanagedcodesecurity-attribute_1.cs)]