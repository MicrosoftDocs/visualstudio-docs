---
title: "CA2124: Wrap vulnerable finally clauses in outer try | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2124"
  - "WrapVulnerableFinallyClausesInOuterTry"
helpviewer_keywords:
  - "CA2124"
  - "WrapVulnerableFinallyClausesInOuterTry"
ms.assetid: 82efd224-9e60-4b88-a0f5-dfabcc49a254
caps.latest.revision: 22
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2124: Wrap vulnerable finally clauses in outer try
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|WrapVulnerableFinallyClausesInOuterTry|
|CheckId|CA2124|
|Category|Microsoft.Security|
|Breaking Change|Non Breaking|

## Cause
 In versions 1.0 and 1.1 of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)], a public or protected method contains a `try`/`catch`/`finally` block. The `finally` block appears to reset security state and is not enclosed in a `finally` block.

## Rule Description
 This rule locates `try`/`finally` blocks in code that targets versions 1.0 and 1.1 of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] that might be vulnerable to malicious exception filters present in the call stack. If sensitive operations such as impersonation occur in the try block, and an exception is thrown, the filter can execute before the `finally` block. For the impersonation example, this means that the filter would execute as the impersonated user. Filters are currently implementable only in Visual Basic.

> [!WARNING]
> In versions 2.0 and later of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)], the runtime automatically protects a `try`/`catch`/ `finally` block from malicious exception filters, if the reset occurs directly within the method that contains the exception block.

## How to Fix Violations
 Place the unwrapped `try`/`finally` in an outer try block. See the second example that follows. This forces the `finally` to execute before filter code.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Pseudo-code Example

### Description
 The following pseudo-code illustrates the pattern detected by this rule.

### Code

```
try {
   // Do some work.
   Impersonator imp = new Impersonator("John Doe");
   imp.AddToCreditCardBalance(100);
}
finally {
   // Reset security state.
   imp.Revert();
}
```

## Example
 The following pseudo-code shows the pattern that you can use to protect your code and satisfy this rule.

```
try {
     try {
        // Do some work.
     }
     finally {
        // Reset security state.
     }
}
catch()
{
    throw;
}
```
