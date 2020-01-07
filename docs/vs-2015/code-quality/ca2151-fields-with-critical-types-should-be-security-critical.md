---
title: "CA2151: Fields with critical types should be security critical | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
ms.assetid: 09db9d25-7d58-4725-a252-4a07baadf046
caps.latest.revision: 6
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2151: Fields with critical types should be security critical
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName||
|CheckId|CA2151|
|Category|Microsoft.Security|
|Breaking Change|Breaking|

## Cause
 A security transparent field or a safe critical field is declared. Its type is specified as security critical. For example:

```csharp
[assembly: AllowPartiallyTrustedCallers]

   [SecurityCritical]
   class Type1 { } // Security Critical type

   class Type2 // Security transparent type
   {
      Type1 m_field; // CA2151, transparent field of critical type
   }
```

 In this example, `m_field` is a security transparent field of a type that is security critical.

## Rule Description
 To use security critical types, the code that references the type must be either security critical or security safe critical. This is true even if the reference is indirect. For example, when you reference a transparent field that has a critical type, your code must be either security critical or security safe. Therefore, having a security transparent or security safe critical field is misleading because transparent code will still be unable to access the field.

## How to Fix Violations
 To fix a violation of this rule, mark the field with the <xref:System.Security.SecurityCriticalAttribute> attribute, or make the type that is referenced by the field eith security transparent or safe critical.

```csharp
// Fix 1: Make the referencing field security critical
[assembly: AllowPartiallyTrustedCallers]

   [SecurityCritical]
   class Type1 { } // Security Critical type

   class Type2 // Security transparent type
   {
      [SecurityCritical]
      Type1 m_field; // Fixed: critical type, critical field
   }

// Fix 2: Make the referencing field security critical
[assembly: AllowPartiallyTrustedCallers]

   class Type1 { } // Type1 is now transparent

   class Type2 // Security transparent type
   {
      [SecurityCritical]
      Type1 m_field; // Fixed: critical type, critical field
   }
```

## When to Suppress Warnings
 Do not suppress a warning from this rule.

### Code
 [!code-csharp[FxCop.Security.CA2145.TransparentMethodsShouldNotUseSuppressUnmanagedCodeSecurity#1](../snippets/csharp/VS_Snippets_CodeAnalysis/fxcop.security.ca2145.transparentmethodsshouldnotusesuppressunmanagedcodesecurity/cs/ca2145.cs#1)]

### Comments
