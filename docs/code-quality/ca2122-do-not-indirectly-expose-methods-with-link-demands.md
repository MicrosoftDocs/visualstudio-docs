---
title: "CA2122: Do not indirectly expose methods with link demands | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-code-analysis"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "CA2122"
  - "DoNotIndirectlyExposeMethodsWithLinkDemands"
helpviewer_keywords: 
  - "DoNotIndirectlyExposeMethodsWithLinkDemands"
  - "CA2122"
ms.assetid: 3eda58e7-c6ec-41c3-8112-ae0841109c6a
caps.latest.revision: 17
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# CA2122: Do not indirectly expose methods with link demands
|||  
|-|-|  
|TypeName|DoNotIndirectlyExposeMethodsWithLinkDemands|  
|CheckId|CA2122|  
|Category|Microsoft.Security|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A public or protected member has a [Link Demands](/dotnet/framework/misc/link-demands) and is called by a member that does not perform any security checks.  
  
## Rule Description  
 A link demand checks the permissions of the immediate caller only. If a member `X` makes no security demands of its callers, and calls code protected by a link demand, a caller without the necessary permission can use `X` to access the protected member.  
  
## How to Fix Violations  
 Add a security [Data and Modeling](/dotnet/framework/data/index) or link demand to the member so that it no longer provides unsecured access to the link demand-protected member.  
  
## When to Suppress Warnings  
 To safely suppress a warning from this rule, you must make sure that your code does not grant its callers access to operations or resources that can be used in a destructive manner.  
  
## Example  
 The following examples show a library that violates the rule, and an application that demonstrates the library's weakness. The sample library provides two methods that together violate the rule. The `EnvironmentSetting` method is secured by a link demand for unrestricted access to environment variables. The `DomainInformation` method makes no security demands of its callers before it calls `EnvironmentSetting`.  
  
 [!code-csharp[FxCop.Security.UnsecuredDoNotCall#1](../code-quality/codesnippet/CSharp/ca2122-do-not-indirectly-expose-methods-with-link-demands_1.cs)]  
  
## Example  
 The following application calls the unsecured library member.  
  
 [!code-csharp[FxCop.Security.TestUnsecuredDoNot1#1](../code-quality/codesnippet/CSharp/ca2122-do-not-indirectly-expose-methods-with-link-demands_2.cs)]  
  
 This example produces the following output.  
  
 **Value from unsecured member: seattle.corp.contoso.com**   
## See Also  
 [Secure Coding Guidelines](/dotnet/standard/security/secure-coding-guidelines)   
 [Link Demands](/dotnet/framework/misc/link-demands)   
 [Data and Modeling](/dotnet/framework/data/index)