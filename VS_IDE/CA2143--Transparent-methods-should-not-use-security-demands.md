---
title: "CA2143: Transparent methods should not use security demands"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 5d3923d7-cf40-4512-bc5c-0db0e0d6e25a
caps.latest.revision: 12
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# CA2143: Transparent methods should not use security demands
|||  
|-|-|  
|TypeName|TransparentMethodsShouldNotDemand|  
|CheckId|CA2143|  
|Category|Microsoft.Security|  
|Breaking Change|Breaking|  
  
## Cause  
 A tranparent type or method is declaratively marked with a <xref:System.Security.Permissions.SecurityAction?qualifyHint=True>`.Demand` demand or the method calls the <xref:System.Security.CodeAccessPermission.Demand?qualifyHint=True> method.  
  
## Rule Description  
 Security transparent code should not be responsible for verifying the security of an operation, and therefore should not demand permissions. Security transparent code should use full demands to make security decisions and safe-critical code should not rely on transparent code to have made the full demand. Any code that performs security checks, such as security demands, should be safe-critical instead.  
  
## How to Fix Violations  
 In general, to fix a violation of this rule, mark the method with the <xref:System.Security.SecuritySafeCriticalAttribute?qualifyHint=False> attribute. You can also remove the demand.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The rule files on the following code because a transparent method makes a declarative security demand.  
  
 [!CODE [FxCop.Security.CA2143.TransparentMethodsShouldNotDemand#1](../CodeSnippet/VS_Snippets_CodeAnalysis/fxcop.security.ca2143.transparentmethodsshouldnotdemand#1)]  
  
## See Also  
 [CA2142: Transparent code should not be protected with LinkDemands](../VS_IDE/CA2142--Transparent-code-should-not-be-protected-with-LinkDemands.md)