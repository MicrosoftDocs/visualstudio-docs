---
title: "CA2106: Secure asserts | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2106"
  - "SecureAsserts"
helpviewer_keywords:
  - "CA2106"
  - "SecureAsserts"
ms.assetid: 91feb36e-6e2c-436c-8272-5aee31f77e98
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2106: Secure asserts
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|SecureAsserts|
|CheckId|CA2106|
|Category|Microsoft.Security|
|Breaking Change|Breaking|

## Cause
 A method asserts a permission and no security checks are performed on the caller.

## Rule Description
 Asserting a security permission without performing any security checks can leave an exploitable security weakness in your code. A security stack walk stops when a security permission is asserted. If you assert a permission without performing any checks on the caller, the caller could indirectly execute code by using your permissions. Asserts without security checks are permissible only when you are sure that the assert cannot be used in a harmful manner. An assert is harmless if the code you call is harmless, or users cannot pass arbitrary information to code that you call.

## How to Fix Violations
 To fix a violation of this rule, add a security demand to the method or its declaring type.

## When to Suppress Warnings
 Suppress a warning from this rule only after a careful security review.

## See Also
 <xref:System.Security.CodeAccessPermission.Assert%2A?displayProperty=fullName>
 [Secure Coding Guidelines](https://msdn.microsoft.com/library/4f882d94-262b-4494-b0a6-ba9ba1f5f177)
