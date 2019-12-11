---
title: "CA2211: Non-constant fields should not be visible | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2211"
  - "NonConstantFieldsShouldNotBeVisible"
helpviewer_keywords:
  - "NonConstantFieldsShouldNotBeVisible"
  - "CA2211"
ms.assetid: e1e42c40-0acd-4312-af29-70133739a304
caps.latest.revision: 15
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2211: Non-constant fields should not be visible
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|NonConstantFieldsShouldNotBeVisible|
|CheckId|CA2211|
|Category|Microsoft.Usage|
|Breaking Change|Breaking|

## Cause
 A public or protected static field is not constant nor is it read-only.

## Rule Description
 Static fields that are neither constants nor read-only are not thread-safe. Access to such a field must be carefully controlled and requires advanced programming techniques for synchronizing access to the class object. Because these are difficult skills to learn and master, and testing such an object poses its own challenges, static fields are best used to store data that does not change. This rule applies to libraries; applications should not expose any fields.

## How to Fix Violations
 To fix a violation of this rule, make the static field constant or read-only. If this is not possible, redesign the type to use an alternative mechanism such as a thread-safe property that manages thread-safe access to the underlying field. Realize that issues such as lock contention and deadlocks might affect the performance and behavior of the library.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule if you are developing an application and therefore have full control over access to the type that contains the static field. Library designers should not suppress a warning from this rule; using non-constant static fields can make using the library difficult for developers to use correctly.

## Example
 The following example shows a type that violates this rule.

 [!code-csharp[FxCop.Usage.AvoidStaticNonConstants#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.AvoidStaticNonConstants/cs/FxCop.Usage.AvoidStaticNonConstants.cs#1)]
 [!code-vb[FxCop.Usage.AvoidStaticNonConstants#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Usage.AvoidStaticNonConstants/vb/FxCop.Usage.AvoidStaticNonConstants.vb#1)]
