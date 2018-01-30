---
title: "CA2149: Transparent methods must not call into native code | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-code-analysis"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "CA2149"
ms.assetid: 28951bd7-f3db-4871-99aa-bad68d1ead80
caps.latest.revision: 11
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "cplusplus"
---
# CA2149: Transparent methods must not call into native code
|||  
|-|-|  
|TypeName|TransparentMethodsMustNotCallNativeCode|  
|CheckId|CA2149|  
|Category|Microsoft.Security|  
|Breaking Change|Breaking|  
  
## Cause  
 A method calls a native function through a method stub such as P/Invoke.  
  
## Rule Description  
 This rule fires on any transparent method which calls directly into native code, for example, through a P/Invoke. Violations of this rule lead to a <xref:System.MethodAccessException> in the level 2 transparency model, and a full demand for <xref:System.Security.Permissions.SecurityPermissionAttribute.UnmanagedCode%2A> in the level 1 transparency model.  
  
## How to Fix Violations  
 To fix a violation of this rule, mark the method that calls the native code with the <xref:System.Security.SecurityCriticalAttribute> or <xref:System.Security.SecuritySafeCriticalAttribute> attribute.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 [!code-csharp[FxCop.Security.CA2149.TransparentMethodsMustNotCallNativeCode#1](../code-quality/codesnippet/CSharp/ca2149-transparent-methods-must-not-call-into-native-code_1.cs)]