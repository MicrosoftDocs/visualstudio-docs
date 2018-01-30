---
title: "CA2137: Transparent methods must contain only verifiable IL | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-code-analysis"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "CA2137"
ms.assetid: cbaeb0e1-56b6-43b4-812a-596b2859c329
caps.latest.revision: 13
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# CA2137: Transparent methods must contain only verifiable IL
|||  
|-|-|  
|TypeName|TransparentMethodsMustBeVerifiable|  
|CheckId|CA2137|  
|Category|Microsoft.Security|  
|Breaking Change|Breaking|  
  
## Cause  
 A method contains unverifiable code or returns a type by reference.  
  
## Rule Description  
 This rule fires on attempts by security transparent code to execute unverifiable MSIL (Microsoft Intermediate Language). However, the rule does not contain a full IL verifier, and instead uses heuristics to catch most violations of MSIL verification.  
  
 To be certain that your code contains only verifiable MSIL, run [Peverify.exe (PEVerify Tool)](/dotnet/framework/tools/peverify-exe-peverify-tool) on your assembly. Run PEVerify with the **/transparent** option which limits the output to only unverifiable transparent methods which would cause an error. If the /transparent option is not used, PEVerify also verifies critical methods that are allowed to contain unverifiable code.  
  
## How to Fix Violations  
 To fix a violation of this rule, mark the method with the <xref:System.Security.SecurityCriticalAttribute> or <xref:System.Security.SecuritySafeCriticalAttribute> attribute, or remove the unverifiable code.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The method in this example uses unverifiable code and should be marked with the <xref:System.Security.SecurityCriticalAttribute> or <xref:System.Security.SecuritySafeCriticalAttribute> attribute.  
  
 [!code-csharp[FxCop.Security.CA2137.TransparentMethodsMustBeVerifiable#1](../code-quality/codesnippet/CSharp/ca2137-transparent-methods-must-contain-only-verifiable-il_1.cs)]