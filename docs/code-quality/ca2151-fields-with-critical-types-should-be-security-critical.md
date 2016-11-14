---
title: "CA2151: Fields with critical types should be security critical | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 09db9d25-7d58-4725-a252-4a07baadf046
caps.latest.revision: 4
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# CA2151: Fields with critical types should be security critical
|||  
|-|-|  
|TypeName||  
|CheckId|CA2151|  
|Category|Microsoft.Security|  
|Breaking Change|Breaking|  
  
## Cause  
 A security transparent field or a safe critical field is declared. Its type is specified as security critical. For example:  
  
```c#  
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
  
```c#  
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
 [!code-cs[FxCop.Security.CA2145.TransparentMethodsShouldNotUseSuppressUnmanagedCodeSecurity#1](../code-quality/codesnippet/CSharp/ca2151-fields-with-critical-types-should-be-security-critical_1.cs)]  
  
### Comments