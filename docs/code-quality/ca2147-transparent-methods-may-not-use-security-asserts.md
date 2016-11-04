---
title: "CA2147: Transparent methods may not use security asserts | Microsoft Docs"
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
  - "SecurityTransparentCodeShouldNotAssert"
  - "CA2147"
  - "CA2128"
helpviewer_keywords: 
  - "CA2128"
  - "SecurityTransparentCodeShouldNotAssert"
ms.assetid: 5d31e940-e599-4b23-9b28-1c336f8d910e
caps.latest.revision: 18
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
# CA2147: Transparent methods may not use security asserts
|||  
|-|-|  
|TypeName|SecurityTransparentCodeShouldNotAssert|  
|CheckId|CA2147|  
|Category|Microsoft.Security|  
|Breaking Change|Breaking|  
  
## Cause  
 Code that is marked as <xref:System.Security.SecurityTransparentAttribute> is not granted sufficient permissions to assert.  
  
## Rule Description  
 This rule analyzes all methods and types in an assembly which is either 100% transparent or mixed transparent/critical, and flags any declarative or imperative usage of <xref:System.Security.CodeAccessPermission.Assert%2A>.  
  
 At run time, any calls to <xref:System.Security.CodeAccessPermission.Assert%2A> from transparent code will cause a <xref:System.InvalidOperationException> to be thrown. This can occur in both 100% transparent assemblies, and also in mixed transparent/critical assemblies where a method or type is declared transparent, but includes a declarative or imperative Assert.  
  
 The [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] 2.0 introduced a feature named *transparency*. Individual methods, fields, interfaces, classes, and types can be either transparent or critical.  
  
 Transparent code is not allowed to elevate security privileges. Therefore, any permissions granted or demanded of it are automatically passed through the code to the caller or host application domain. Examples of elevations include Asserts, LinkDemands, SuppressUnmanagedCode, and `unsafe` code.  
  
## How to Fix Violations  
 To resolve the issue, either mark the code which calls the Assert with the <xref:System.Security.SecurityCriticalAttribute>, or remove the Assert.  
  
## When to Suppress Warnings  
 Do not suppress a message from this rule.  
  
## Example  
 This code will fail if `SecurityTestClass` is transparent, when the `Assert` method throws a <xref:System.InvalidOperationException>.  
  
 [!code-cs[FxCop.Security.CA2147.TransparentMethodsMustNotUseSecurityAsserts#1](../code-quality/codesnippet/CSharp/ca2147-transparent-methods-may-not-use-security-asserts_1.cs)]  
  
## Example  
 One option is to code review the SecurityTransparentMethod method in the example below, and if the method is considered safe for elevation, mark SecurityTransparentMethod with secure-critical This requires that a detailed, complete, and error-free security audit must be performed on the method together with any call-outs that occur within the method under the Assert:  
  
 [!code-cs[FxCop.Security.SecurityTransparentCode2#1](../code-quality/codesnippet/CSharp/ca2147-transparent-methods-may-not-use-security-asserts_2.cs)]  
  
 Another option is to remove the Assert from the code, and let any subsequent file I/O permission demands flow beyond SecurityTransparentMethod to the caller. This enables security checks. In this case, no security audit is generally needed, because the permission demands will flow to the caller and/or the application domain. Permission demands are closely controlled through security policy, hosting environment, and code-source permission grants.  
  
## See Also  
 [Security Warnings](../code-quality/security-warnings.md)