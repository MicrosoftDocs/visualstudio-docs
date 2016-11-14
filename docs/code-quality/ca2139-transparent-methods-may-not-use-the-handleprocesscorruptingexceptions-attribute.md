---
title: "CA2139: Transparent methods may not use the HandleProcessCorruptingExceptions attribute | Microsoft Docs"
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
  - "CA2139"
ms.assetid: 45a0328a-add7-40f9-8934-dff59beb02b3
caps.latest.revision: 11
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
# CA2139: Transparent methods may not use the HandleProcessCorruptingExceptions attribute
|||  
|-|-|  
|TypeName|TransparentMethodsMustNotHandleProcessCorruptingExceptions|  
|CheckId|CA2139|  
|Category|Microsoft.Security|  
|Breaking Change|Breaking|  
  
## Cause  
 A transparent method is marked with the <xref:System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute> attribute.  
  
## Rule Description  
 This rule fires any method which is transparent and attempts to handle a process corrupting exception by using the <xref:System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute> attribute. A process corrupting exception is a CLR version 4.0 exception classification of exceptions such <xref:System.AccessViolationException>. The HandleProcessCorruptedStateExceptionsAttribute attribute may only be used by security critical methods, and will be ignored if it is applied to a transparent method. To handle process corrupting exceptions, this method must become security critical or security safe-critical.  
  
## How to Fix Violations  
 To fix a violation of this rule, remove the <xref:System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute> attribute, or mark the method with the <xref:System.Security.SecurityCriticalAttribute> or the <xref:System.Security.SecuritySafeCriticalAttribute> attribute.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 In this example, a transparent method is marked with the <xref:System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute> attribute and will fail the rule. The method should also be marked with the <xref:System.Security.SecurityCriticalAttribute> or the <xref:System.Security.SecuritySafeCriticalAttribute> attribute.  
  
 [!code-cs[FxCop.Security.CA2139.TransparentMethodsMustNotHandleProcessCorruptingExceptions#1](../code-quality/codesnippet/CSharp/ca2139-transparent-methods-may-not-use-the-handleprocesscorruptingexceptions-attribute_1.cs)]