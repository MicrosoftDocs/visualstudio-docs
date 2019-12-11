---
title: "CA2134: Methods must keep consistent transparency when overriding base methods | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2134"
ms.assetid: 3b17e487-0326-442e-90e1-dc0ba9cdd3f2
caps.latest.revision: 11
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2134: Methods must keep consistent transparency when overriding base methods
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|MethodsMustOverrideWithConsistentTransparency|
|CheckId|CA2134|
|Category|Microsoft.Security|
|Breaking Change|Breaking|

## Cause
 This rule fires when a method marked with the <xref:System.Security.SecurityCriticalAttribute> overrides a method that is transparent or marked with the <xref:System.Security.SecuritySafeCriticalAttribute>. The rule also fires when a method that is transparent or marked with the <xref:System.Security.SecuritySafeCriticalAttribute> overrides a method that is marked with a <xref:System.Security.SecurityCriticalAttribute>.

 The rule is applied when overriding a virtual method or implementing an interface.

## Rule Description
 This rule fires on attempts to change the security accessibility of a method further up the inheritance chain. For example, if a virtual method in a base class is transparent or safe-critical, then the derived class must override it with a transparent or safe-critical method. Conversely, if the virtual is security critical, the derived class must override it with a security critical method. The same rule applies for implementing interface methods.

 Transparency rules are enforced when the code is JIT compiled instead of at runtime, so that the transparency calculation does not have dynamic type information. Therefore, the result of the transparency calculation must be able to be determined solely from the static types being JIT-compiled, regardless of the dynamic type.

## How to Fix Violations
 To fix a violation of this rule, change the transparency of the method that is overriding a virtual method or implementing an interface to match the transparency of the virtual or interface method.

## When to Suppress Warnings
 Do not suppress warnings from this rule. Violations of this rule will result in a runtime <xref:System.TypeLoadException> for assemblies that use level 2 transparency.

## Examples

### Code
 [!code-csharp[FxCop.Security.CA2134.MethodsMustOverrideWithConsistentTransparency#1](../snippets/csharp/VS_Snippets_CodeAnalysis/fxcop.security.ca2134.methodsmustoverridewithconsistenttransparency/cs/ca2134 - methodsmustoverridewithconsistenttransparency.cs#1)]

## See Also
 [Security-Transparent Code, Level 2](https://msdn.microsoft.com/library/4d05610a-0da6-4f08-acea-d54c9d6143c0)
