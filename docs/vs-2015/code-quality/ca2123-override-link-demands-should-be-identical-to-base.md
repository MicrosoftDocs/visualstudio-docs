---
title: "CA2123: Override link demands should be identical to base | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "CA2123"
  - "OverrideLinkDemandsShouldBeIdenticalToBase"
helpviewer_keywords: 
  - "OverrideLinkDemandsShouldBeIdenticalToBase"
  - "CA2123"
ms.assetid: 4538ecd5-fc6f-4480-ab00-90b2ce4730db
caps.latest.revision: 20
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
---
# CA2123: Override link demands should be identical to base
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The latest version of this topic can be found at [CA2123: Override link demands should be identical to base](https://docs.microsoft.com/visualstudio/code-quality/ca2123-override-link-demands-should-be-identical-to-base).  
  
TypeName|OverrideLinkDemandsShouldBeIdenticalToBase|  
|CheckId|CA2123|  
|Category|Microsoft.Security|  
|Breaking Change|Breaking|  
  
## Cause  
 A public or protected method in a public type overrides a method or implements an interface, and does not have the same [Link Demands](../Topic/Link%20Demands.md) as the interface or virtual method.  
  
## Rule Description  
 This rule matches a method to its base method, which is either an interface or a virtual method in another type, and then compares the link demands on each. A violation is reported if either the method or the base method has a link demand and the other does not.  
  
 If this rule is violated, a malicious caller can bypass the link demand merely by calling the unsecured method.  
  
## How to Fix Violations  
 To fix a violation of this rule, apply the same link demand to the overide method or implementation. If this is not possible, mark the method with a full demand or remove the attribute altogether.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows various violations of this rule.  
  
 [!code-csharp[FxCop.Security.OverridesAndSecurity#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Security.OverridesAndSecurity/cs/FxCop.Security.OverridesAndSecurity.cs#1)]  
  
## See Also  
 [Secure Coding Guidelines](../Topic/Secure%20Coding%20Guidelines.md)   
 [Link Demands](../Topic/Link%20Demands.md)



