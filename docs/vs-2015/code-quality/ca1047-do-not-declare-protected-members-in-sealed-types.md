---
title: "CA1047: Do not declare protected members in sealed types | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "DoNotDeclareProtectedMembersInSealedTypes"
  - "CA1047"
helpviewer_keywords:
  - "CA1047"
  - "DoNotDeclareProtectedMembersInSealedTypes"
ms.assetid: 829033b5-a9d8-4f26-a719-45494c9dd035
caps.latest.revision: 18
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1047: Do not declare protected members in sealed types
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|DoNotDeclareProtectedMembersInSealedTypes|
|CheckId|CA1047|
|Category|Microsoft.Design|
|Breaking Change|Non-breaking|

## Cause
 A public type is `sealed` (`NotInheritable` in Visual basic) and declares a protected member or a protected nested type. This rule does not report violations for <xref:System.Object.Finalize%2A> methods, which must follow this pattern.

## Rule Description
 Types declare protected members so that inheriting types can access or override the member. By definition, you cannot inherit from a sealed type, which means that protected methods on sealed types cannot be called.

 The C# compiler issues a warning for this error.

## How to Fix Violations
 To fix a violation of this rule, change the access level of the member to private, or make the type inheritable.

## When to Suppress Warnings
 Do not suppress a warning from this rule. Leaving the type in its current state can cause maintenance issues and does not provide any benefits.

## Example
 The following example shows a type that violates this rule.

 [!code-csharp[FxCop.Design.SealedNoProtected#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.SealedNoProtected/cs/FxCop.Design.SealedNoProtected.cs#1)]
 [!code-vb[FxCop.Design.SealedNoProtected#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Design.SealedNoProtected/vb/FxCop.Design.SealedNoProtected.vb#1)]
