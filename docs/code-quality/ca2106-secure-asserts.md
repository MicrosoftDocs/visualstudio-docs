---
title: "CA2106: Secure asserts | Microsoft Docs"
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
  - "CA2106"
  - "SecureAsserts"
helpviewer_keywords: 
  - "CA2106"
  - "SecureAsserts"
ms.assetid: 91feb36e-6e2c-436c-8272-5aee31f77e98
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
# CA2106: Secure asserts
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
 [Secure Coding Guidelines](../Topic/Secure%20Coding%20Guidelines.md)