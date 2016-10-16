---
title: "CA2122: Do not indirectly expose methods with link demands"
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
  - "CA2122"
  - "DoNotIndirectlyExposeMethodsWithLinkDemands"
helpviewer_keywords: 
  - "DoNotIndirectlyExposeMethodsWithLinkDemands"
  - "CA2122"
ms.assetid: 3eda58e7-c6ec-41c3-8112-ae0841109c6a
caps.latest.revision: 17
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
# CA2122: Do not indirectly expose methods with link demands
|||  
|-|-|  
|TypeName|DoNotIndirectlyExposeMethodsWithLinkDemands|  
|CheckId|CA2122|  
|Category|Microsoft.Security|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A public or protected member has a [Link Demands](../Topic/Link%20Demands.md) and is called by a member that does not perform any security checks.  
  
## Rule Description  
 A link demand checks the permissions of the immediate caller only. If a member `X` makes no security demands of its callers, and calls code protected by a link demand, a caller without the necessary permission can use `X` to access the protected member.  
  
## How to Fix Violations  
 Add a security [Data and Modeling](../Topic/Data%20and%20Modeling%20in%20the%20.NET%20Framework.md) or link demand to the member so that it no longer provides unsecured access to the link demand-protected member.  
  
## When to Suppress Warnings  
 To safely suppress a warning from this rule, you must make sure that your code does not grant its callers access to operations or resources that can be used in a destructive manner.  
  
## Example  
 The following examples show a library that violates the rule, and an application that demonstrates the library's weakness. The sample library provides two methods that together violate the rule. The `EnvironmentSetting` method is secured by a link demand for unrestricted access to environment variables. The `DomainInformation` method makes no security demands of its callers before it calls `EnvironmentSetting`.  
  
 [!code[FxCop.Security.UnsecuredDoNotCall#1](../codequality/codesnippet/CSharp/ca2122--do-not-indirectly-expose-methods-with-link-demands_1.cs)]  
  
## Example  
 The following application calls the unsecured library member.  
  
 [!code[FxCop.Security.TestUnsecuredDoNot1#1](../codequality/codesnippet/CSharp/ca2122--do-not-indirectly-expose-methods-with-link-demands_2.cs)]  
  
 This example produces the following output.  
  
 **Value from unsecured member: seattle.corp.contoso.com**   
## See Also  
 [Secure Coding Guidelines](../Topic/Secure%20Coding%20Guidelines.md)   
 [Link Demands](../Topic/Link%20Demands.md)   
 [Data and Modeling](../Topic/Data%20and%20Modeling%20in%20the%20.NET%20Framework.md)