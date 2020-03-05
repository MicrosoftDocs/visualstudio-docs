---
title: "CA2107: Review deny and permit only usage | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2107"
  - "ReviewDenyAndPermitOnlyUsage"
helpviewer_keywords:
  - "ReviewDenyAndPermitOnlyUsage"
  - "CA2107"
ms.assetid: 366f4a56-ae93-4882-81d0-bd0a55ebbc26
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2107: Review deny and permit only usage
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|ReviewDenyAndPermitOnlyUsage|
|CheckId|CA2107|
|Category|Microsoft.Security|
|Breaking Change|Breaking|

## Cause
 A method contains a security check that specifies the PermitOnly or Deny security action.

## Rule Description
 The [Using the PermitOnly Method](https://msdn.microsoft.com/8c7bdb7f-882f-45b7-908c-6cbaa1767649) and <xref:System.Security.CodeAccessPermission.Deny%2A?displayProperty=fullName> security actions should be used only by those who have an advanced knowledge of [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] security. Code that uses these security actions should undergo a security review.

 Deny alters the default behavior of the stack walk that occurs in response to a security demand. It lets you specify permissions that must not be granted for the duration of the denying method, regardless of the actual permissions of the callers in the call stack. If the stack walk detects a method that is secured by Deny, and if the demanded permission is included in the denied permissions, the stack walk fails. PermitOnly also alters the default behavior of the stack walk. It allows code to specify only those permissions that can be granted, regardless of the permissions of the callers. If the stack walk detects a method that is secured by PermitOnly, and if the demanded permission is not included in the permissions that are specified by the PermitOnly, the stack walk fails.

 Code that relies on these actions should be carefully evaluated for security vulnerabilities because of their limited usefulness and subtle behavior. Consider the following:

- [Link Demands](https://msdn.microsoft.com/library/a33fd5f9-2de9-4653-a4f0-d9df25082c4d) are not affected by Deny or PermitOnly.

- If the Deny or PermitOnly occurs in the same stack frame as the demand that causes the stack walk, the security actions have no effect.

- Values that are used to construct path-based permissions can usually be specified in multiple ways. Denying access to one form of the path does not deny access to all forms. For example, if a file share \\\Server\Share is mapped to a network drive X:, to deny access to a file on the share, you must deny \\\Server\Share\File, X:\File and every other path that accesses the file.

- An <xref:System.Security.CodeAccessPermission.Assert%2A?displayProperty=fullName> can terminate a stack walk before the Deny or PermitOnly is reached.

- If a Deny has any effect, namely, when a caller has a permission that is blocked by the Deny, the caller can access the protected resource directly, bypassing the Deny. Similarly, if the caller does not have the denied permission, the stack walk would fail without the Deny.

## How to Fix Violations
 Any use of these security actions will cause a violation. To fix a violation, do not use these security actions.

## When to Suppress Warnings
 Suppress a warning from this rule only after you complete a security review.

## Example
 The following example demonstrates some limitations of Deny.

 The following library contains a class that has two methods that are identical except for the security demands that protect them.

 [!code-csharp[FxCop.Security.PermitAndDeny#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Security.PermitAndDeny/cs/FxCop.Security.PermitAndDeny.cs#1)]

## Example
 The following application demonstrates the effects of Deny on the secured methods from the library.

 [!code-csharp[FxCop.Security.TestPermitAndDeny#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Security.TestPermitAndDeny/cs/FxCop.Security.TestPermitAndDeny.cs#1)]

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
 [Secure Coding Guidelines](https://msdn.microsoft.com/library/4f882d94-262b-4494-b0a6-ba9ba1f5f177)
 [Overriding Security Checks](https://msdn.microsoft.com/4acdeff5-fc05-41bf-8505-7387cdbfca28)
 [Using the PermitOnly Method](https://msdn.microsoft.com/8c7bdb7f-882f-45b7-908c-6cbaa1767649)
