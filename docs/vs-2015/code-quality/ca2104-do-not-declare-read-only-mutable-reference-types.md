---
title: "CA2104: Do not declare read only mutable reference types | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "DoNotDeclareReadOnlyMutableReferenceTypes"
  - "CA2104"
helpviewer_keywords:
  - "CA2104"
  - "DoNotDeclareReadOnlyMutableReferenceTypes"
ms.assetid: 81b83ee5-4db5-4be0-9f8d-90b53894ec3b
caps.latest.revision: 20
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2104: Do not declare read only mutable reference types
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|DoNotDeclareReadOnlyMutableReferenceTypes|
|CheckId|CA2104|
|Category|Microsoft.Security|
|Breaking Change|Non-breaking|

## Cause
 An externally visible type contains an externally visible read-only field that is a mutable reference type.

## Rule Description
 A mutable type is a type whose instance data can be modified. The <xref:System.Text.StringBuilder?displayProperty=fullName> class is an example of a mutable reference type. It contains members that can change the value of an instance of the class. An example of an immutable reference type is the <xref:System.String?displayProperty=fullName> class. After it has been instantiated, its value can never change.

 The read-only modifier ([readonly](https://msdn.microsoft.com/library/2f8081f6-0de2-4903-898d-99696c48d2f4) in C#, [ReadOnly](https://msdn.microsoft.com/library/e868185d-6142-4359-a2fd-a7965cadfce8) in [!INCLUDE[vbprvb](../includes/vbprvb-md.md)], and [const](https://msdn.microsoft.com/library/b21c0271-1ad0-40a0-b21c-5e812bba0318) in C++) on a reference type field (pointer in C++) prevents the field from being replaced by a different instance of the reference type. However, the modifier does not prevent the instance data of the field from being modified through the reference type.

 Read-only array fields are exempt from this rule but instead cause a violation of the [CA2105: Array fields should not be read only](../code-quality/ca2105-array-fields-should-not-be-read-only.md) rule.

## How to Fix Violations
 To fix a violation of this rule, remove the read-only modifier or, if a breaking change is acceptable, replace the field with an immutable type.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule if the field type is immutable.

## Example
 The following example shows a field declaration that causes a violation of this rule.

 [!code-cpp[FxCop.Security.MutableReferenceTypes#1](../snippets/cpp/VS_Snippets_CodeAnalysis/FxCop.Security.MutableReferenceTypes/cpp/FxCop.Security.MutableReferenceTypes.cpp#1)]
 [!code-csharp[FxCop.Security.MutableReferenceTypes#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Security.MutableReferenceTypes/cs/FxCop.Security.MutableReferenceTypes.cs#1)]
 [!code-vb[FxCop.Security.MutableReferenceTypes#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Security.MutableReferenceTypes/vb/FxCop.Security.MutableReferenceTypes.vb#1)]
