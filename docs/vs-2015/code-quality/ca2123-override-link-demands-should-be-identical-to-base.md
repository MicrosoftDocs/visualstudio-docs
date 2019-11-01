---
title: "CA2123: Override link demands should be identical to base | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2123"
  - "OverrideLinkDemandsShouldBeIdenticalToBase"
helpviewer_keywords:
  - "OverrideLinkDemandsShouldBeIdenticalToBase"
  - "CA2123"
ms.assetid: 4538ecd5-fc6f-4480-ab00-90b2ce4730db
caps.latest.revision: 20
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2123: Override link demands should be identical to base
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|OverrideLinkDemandsShouldBeIdenticalToBase|
|CheckId|CA2123|
|Category|Microsoft.Security|
|Breaking Change|Breaking|

## Cause
 A public or protected method in a public type overrides a method or implements an interface, and does not have the same [Link Demands](https://msdn.microsoft.com/library/a33fd5f9-2de9-4653-a4f0-d9df25082c4d) as the interface or virtual method.

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
 [Secure Coding Guidelines](https://msdn.microsoft.com/library/4f882d94-262b-4494-b0a6-ba9ba1f5f177)
 [Link Demands](https://msdn.microsoft.com/library/a33fd5f9-2de9-4653-a4f0-d9df25082c4d)
