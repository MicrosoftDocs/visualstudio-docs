---
title: "CA2109: Review visible event handlers | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2109"
  - "ReviewVisibleEventHandlers"
helpviewer_keywords:
  - "ReviewVisibleEventHandlers"
  - "CA2109"
ms.assetid: 8f8fa0ee-e94e-400e-b516-24d8727725d7
caps.latest.revision: 20
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2109: Review visible event handlers
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|ReviewVisibleEventHandlers|
|CheckId|CA2109|
|Category|Microsoft.Security|
|Breaking Change|Breaking|

## Cause
 A public or protected event-handling method was detected.

## Rule Description
 An externally visible event-handling method presents a security issue that requires review.

 Event-handling methods should not be exposed unless absolutely necessary. An event handler, a delegate type, that invokes the exposed method can be added to any event as long as the handler and event signatures match. Events can potentially be raised by any code, and are frequently raised by highly trusted system code in response to user actions such as clicking a button. Adding a security check to an event-handling method does not prevent code from registering an event handler that invokes the method.

 A demand cannot reliably protect a method invoked by an event handler. Security demands help protect code from untrusted callers by examining the callers on the call stack. Code that adds an event handler to an event is not necessarily present on the call stack when the event handler's methods run. Therefore, the call stack might have only highly trusted callers when the event handler method is invoked. This causes demands made by the event handler method to succeed. Also, the demanded permission might be asserted when the method is invoked. For these reasons, the risk of not fixing a violation of this rule can only be assessed after reviewing the event-handling method. When you review your code, consider the following issues:

- Does your event handler perform any operations that are dangerous or exploitable, such as asserting permissions or suppressing unmanaged code permission?

- What are the security threats to and from your code because it can run at any time with only highly trusted callers on the stack?

## How to Fix Violations
 To fix a violation of this rule, review the method and evaluate the following:

- Can you make the event-handling method non-public?

- Can you move all dangerous functionality out of the event handler?

- If a security demand is imposed, can this be accomplished in some other manner?

## When to Suppress Warnings
 Suppress a warning from this rule only after a careful security review to make sure that your code does not pose a security threat.

## Example
 The following code shows an event-handling method that can be misused by malicious code.

 [!code-csharp[FxCop.Security.EventSecLib#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Security.EventSecLib/cs/FxCop.Security.EventSecLib.cs#1)]

## See Also
 <xref:System.Security.CodeAccessPermission.Demand%2A?displayProperty=fullName>
 <xref:System.EventArgs?displayProperty=fullName>
 [Security Demands](https://msdn.microsoft.com/324c14f8-54ff-494d-9fd1-bfd20962c8ba)
