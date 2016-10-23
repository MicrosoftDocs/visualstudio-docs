---
title: "CA1031: Do not catch general exception types"
ms.custom: na
ms.date: 10/04/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: cbc283ae-2a46-4ec0-940e-85aa189b118f
caps.latest.revision: 20
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# CA1031: Do not catch general exception types
|||  
|-|-|  
|TypeName|DoNotCatchGeneralExceptionTypes|  
|CheckId|CA1031|  
|Category|Microsoft.Design|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A general exception such as <xref:System.Exception?qualifyHint=True> or <xref:System.SystemException?qualifyHint=True> is caught in a `catch` statement, or a general catch clause such as `catch()` is used.  
  
## Rule Description  
 General exceptions should not be caught.  
  
## How to Fix Violations  
 To fix a violation of this rule, catch a more specific exception, or rethrow the general exception as the last statement in the `catch` block.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule. Catching general exception types can hide run-time problems from the library user and can make debugging more difficult.  
  
> [!NOTE]
>  Starting with the .NET Framework 4, the common language runtime (CLR) no longer delivers corrupted state exceptions that occur in the operating system and managed code, such as access violations in Windows, to be handled by managed code. If you want to compile an application in the .NET Framework 4 or later versions and maintain handling of corrupted state exceptions, you can apply the <xref:System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute?qualifyHint=False> attribute to the method that handles the corrupted state exception.  
  
## Example  
 The following example shows a type that violates this rule and a type that correctly implements the `catch` block.  
  
 [!CODE [FxCop.Design.ExceptionAndSystemException#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Design.ExceptionAndSystemException#1)]  
  
## Related Rules  
 [CA2200: Rethrow to preserve stack details](../VS_IDE/CA2200--Rethrow-to-preserve-stack-details.md)