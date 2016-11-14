---
title: "CA1031: Do not catch general exception types | Microsoft Docs"
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
  - "CA1031"
  - "DoNotCatchGeneralExceptionTypes"
helpviewer_keywords: 
  - "CA1031"
  - "DoNotCatchGeneralExceptionTypes"
ms.assetid: cbc283ae-2a46-4ec0-940e-85aa189b118f
caps.latest.revision: 20
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
# CA1031: Do not catch general exception types
|||  
|-|-|  
|TypeName|DoNotCatchGeneralExceptionTypes|  
|CheckId|CA1031|  
|Category|Microsoft.Design|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A general exception such as <xref:System.Exception?displayProperty=fullName> or <xref:System.SystemException?displayProperty=fullName> is caught in a `catch` statement, or a general catch clause such as `catch()` is used.  
  
## Rule Description  
 General exceptions should not be caught.  
  
## How to Fix Violations  
 To fix a violation of this rule, catch a more specific exception, or rethrow the general exception as the last statement in the `catch` block.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule. Catching general exception types can hide run-time problems from the library user and can make debugging more difficult.  
  
> [!NOTE]
>  Starting with the [!INCLUDE[net_v40_long](../code-quality/includes/net_v40_long_md.md)], the common language runtime (CLR) no longer delivers corrupted state exceptions that occur in the operating system and managed code, such as access violations in [!INCLUDE[TLA#tla_mswin](../code-quality/includes/tlasharptla_mswin_md.md)], to be handled by managed code. If you want to compile an application in the [!INCLUDE[net_v40_short](../code-quality/includes/net_v40_short_md.md)] or later versions and maintain handling of corrupted state exceptions, you can apply the <xref:System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute> attribute to the method that handles the corrupted state exception.  
  
## Example  
 The following example shows a type that violates this rule and a type that correctly implements the `catch` block.  
  
 [!code-cpp[FxCop.Design.ExceptionAndSystemException#1](../code-quality/codesnippet/CPP/ca1031-do-not-catch-general-exception-types_1.cpp)]
 [!code-vb[FxCop.Design.ExceptionAndSystemException#1](../code-quality/codesnippet/VisualBasic/ca1031-do-not-catch-general-exception-types_1.vb)]
 [!code-cs[FxCop.Design.ExceptionAndSystemException#1](../code-quality/codesnippet/CSharp/ca1031-do-not-catch-general-exception-types_1.cs)]  
  
## Related Rules  
 [CA2200: Rethrow to preserve stack details](../code-quality/ca2200-rethrow-to-preserve-stack-details.md)