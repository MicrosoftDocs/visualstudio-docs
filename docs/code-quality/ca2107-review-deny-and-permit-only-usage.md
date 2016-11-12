---
title: "CA2107: Review deny and permit only usage | Microsoft Docs"
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
  - "CA2107"
  - "ReviewDenyAndPermitOnlyUsage"
helpviewer_keywords: 
  - "ReviewDenyAndPermitOnlyUsage"
  - "CA2107"
ms.assetid: 366f4a56-ae93-4882-81d0-bd0a55ebbc26
caps.latest.revision: 19
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# CA2107: Review deny and permit only usage
|||  
|-|-|  
|TypeName|ReviewDenyAndPermitOnlyUsage|  
|CheckId|CA2107|  
|Category|Microsoft.Security|  
|Breaking Change|Breaking|  
  
## Cause  
 A method contains a security check that specifies the PermitOnly or Deny security action.  
  
## Rule Description  
 The [Using the PermitOnly Method](http://msdn.microsoft.com/en-us/8c7bdb7f-882f-45b7-908c-6cbaa1767649) and <xref:System.Security.CodeAccessPermission.Deny%2A?displayProperty=fullName> security actions should be used only by those who have an advanced knowledge of [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] security. Code that uses these security actions should undergo a security review.  
  
 Deny alters the default behavior of the stack walk that occurs in response to a security demand. It lets you specify permissions that must not be granted for the duration of the denying method, regardless of the actual permissions of the callers in the call stack. If the stack walk detects a method that is secured by Deny, and if the demanded permission is included in the denied permissions, the stack walk fails. PermitOnly also alters the default behavior of the stack walk. It allows code to specify only those permissions that can be granted, regardless of the permissions of the callers. If the stack walk detects a method that is secured by PermitOnly, and if the demanded permission is not included in the permissions that are specified by the PermitOnly, the stack walk fails.  
  
 Code that relies on these actions should be carefully evaluated for security vulnerabilities because of their limited usefulness and subtle behavior. Consider the following:  
  
-   [Link Demands](../Topic/Link%20Demands.md) are not affected by Deny or PermitOnly.  
  
-   If the Deny or PermitOnly occurs in the same stack frame as the demand that causes the stack walk, the security actions have no effect.  
  
-   Values that are used to construct path-based permissions can usually be specified in multiple ways. Denying access to one form of the path does not deny access to all forms. For example, if a file share \\\Server\Share is mapped to a network drive X:, to deny access to a file on the share, you must deny \\\Server\Share\File, X:\File and every other path that accesses the file.  
  
-   An <xref:System.Security.CodeAccessPermission.Assert%2A?displayProperty=fullName> can terminate a stack walk before the Deny or PermitOnly is reached.  
  
-   If a Deny has any effect, namely, when a caller has a permission that is blocked by the Deny, the caller can access the protected resource directly, bypassing the Deny. Similarly, if the caller does not have the denied permission, the stack walk would fail without the Deny.  
  
## How to Fix Violations  
 Any use of these security actions will cause a violation. To fix a violation, do not use these security actions.  
  
## When to Suppress Warnings  
 Suppress a warning from this rule only after you complete a security review.  
  
## Example  
 The following example demonstrates some limitations of Deny.  
  
 The following library contains a class that has two methods that are identical except for the security demands that protect them.  
  
 [!code-cs[FxCop.Security.PermitAndDeny#1](../code-quality/codesnippet/CSharp/ca2107-review-deny-and-permit-only-usage_1.cs)]  
  
## Example  
 The following application demonstrates the effects of Deny on the secured methods from the library.  
  
 [!code-cs[FxCop.Security.TestPermitAndDeny#1](../code-quality/codesnippet/CSharp/ca2107-review-deny-and-permit-only-usage_2.cs)]  
  
 This example produces the following output.  
  
 **Demand: Caller's Deny has no effect on Demand with the asserted permission.**  
**LinkDemand: Caller's Deny has no effect on LinkDemand with the asserted permission.**  
**LinkDemand: Caller's Deny has no effect with LinkDemand-protected code.**  
**LinkDemand: This Deny has no effect with LinkDemand-protected code.**   
## See Also  
 <xref:System.Security.CodeAccessPermission.PermitOnly%2A?displayProperty=fullName>   
 <xref:System.Security.CodeAccessPermission.Assert%2A?displayProperty=fullName>   
 <xref:System.Security.CodeAccessPermission.Deny%2A?displayProperty=fullName>   
 <xref:System.Security.IStackWalk.PermitOnly%2A?displayProperty=fullName>   
 [Secure Coding Guidelines](../Topic/Secure%20Coding%20Guidelines.md)   
 [Overriding Security Checks](http://msdn.microsoft.com/en-us/4acdeff5-fc05-41bf-8505-7387cdbfca28)   
 [Using the PermitOnly Method](http://msdn.microsoft.com/en-us/8c7bdb7f-882f-45b7-908c-6cbaa1767649)