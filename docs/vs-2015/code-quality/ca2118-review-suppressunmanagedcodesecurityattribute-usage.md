---
title: "CA2118: Review SuppressUnmanagedCodeSecurityAttribute usage | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2118"
  - "ReviewSuppressUnmanagedCodeSecurityUsage"
helpviewer_keywords:
  - "ReviewSuppressUnmanagedCodeSecurityUsage"
  - "CA2118"
ms.assetid: 4cb8d2fc-4e44-4dc3-9b74-7f5838827d41
caps.latest.revision: 22
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2118: Review SuppressUnmanagedCodeSecurityAttribute usage
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|ReviewSuppressUnmanagedCodeSecurityUsage|
|CheckId|CA2118|
|Category|Microsoft.Security|
|Breaking Change|Breaking|

## Cause
 A public or protected type or member has the <xref:System.Security.SuppressUnmanagedCodeSecurityAttribute?displayProperty=fullName> attribute.

## Rule Description
 <xref:System.Security.SuppressUnmanagedCodeSecurityAttribute> changes the default security system behavior for members that execute unmanaged code using COM interop or platform invocation. Generally, the system makes a [Data and Modeling](https://msdn.microsoft.com/library/8c37635d-e2c1-4b64-a258-61d9e87405e6) for unmanaged code permission. This demand occurs at run time for every invocation of the member, and checks every caller in the call stack for permission. When the attribute is present, the system makes a [Link Demands](https://msdn.microsoft.com/library/a33fd5f9-2de9-4653-a4f0-d9df25082c4d) for the permission: the permissions of the immediate caller are checked when the caller is JIT-compiled.

 This attribute is primarily used to increase performance; however, the performance gains come with significant security risks. If you place the attribute on public members that call native methods, the callers in the call stack (other than the immediate caller) do not need unmanaged code permission to execute unmanaged code. Depending on the public member's actions and input handling, it might allow untrustworthy callers to access functionality normally restricted to trustworthy code.

 The [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] relies on security checks to prevent callers from gaining direct access to the current process's address space. Because this attribute bypasses normal security, your code poses a serious threat if it can be used to read or write to the process's memory. Note that the risk is not limited to methods that intentionally provide access to process memory; it is also present in any scenario where malicious code can achieve access by any means, for example, by providing surprising, malformed, or invalid input.

 The default security policy does not grant unmanaged code permission to an assembly unless it is executing from the local computer or is a member of one of the following groups:

- My Computer Zone Code Group

- Microsoft Strong Name Code Group

- ECMA Strong Name Code Group

## How to Fix Violations
 Carefully review your code to ensure that this attribute is absolutely necessary. If you are unfamiliar with managed code security, or do not understand the security implications of using this attribute, remove it from your code. If the attribute is required, you must ensure that callers cannot use your code maliciously. If your code does not have permission to execute unmanaged code, this attribute has no effect and should be removed.

## When to Suppress Warnings
 To safely suppress a warning from this rule, you must ensure that your code does not provide callers access to native operations or resources that can be used in a destructive manner.

## Example
 The following example violates the rule.

 [!code-csharp[FxCop.Security.TypesDoNotSuppress#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Security.TypesDoNotSuppress/cs/FxCop.Security.TypesDoNotSuppress.cs#1)]

## Example
 In the following example, the `DoWork` method provides a publicly accessible code path to the platform invocation method `FormatHardDisk`.

 [!code-csharp[FxCop.Security.PInvokeAndSuppress#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Security.PInvokeAndSuppress/cs/FxCop.Security.PInvokeAndSuppress.cs#1)]

## Example
 In the following example, the public method `DoDangerousThing` causes a violation. To resolve the violation, `DoDangerousThing` should be made private, and access to it should be through a public method secured by a security demand, as illustrated by the `DoWork` method.

 [!code-csharp[FxCop.Security.TypeInvokeAndSuppress#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Security.TypeInvokeAndSuppress/cs/FxCop.Security.TypeInvokeAndSuppress.cs#1)]

## See Also
 <xref:System.Security.SuppressUnmanagedCodeSecurityAttribute?displayProperty=fullName>
 [Secure Coding Guidelines](https://msdn.microsoft.com/library/4f882d94-262b-4494-b0a6-ba9ba1f5f177)
 [Security Optimizations](https://msdn.microsoft.com/cf255069-d85d-4de3-914a-e4625215a7c0)
 [Data and Modeling](https://msdn.microsoft.com/library/8c37635d-e2c1-4b64-a258-61d9e87405e6)
 [Link Demands](https://msdn.microsoft.com/library/a33fd5f9-2de9-4653-a4f0-d9df25082c4d)
