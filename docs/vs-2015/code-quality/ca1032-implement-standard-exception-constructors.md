---
title: "CA1032: Implement standard exception constructors | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1032"
  - "ImplementStandardExceptionConstructors"
helpviewer_keywords:
  - "CA1032"
  - "ImplementStandardExceptionConstructors"
ms.assetid: a8623c56-273a-4c95-8d83-95911a042be7
caps.latest.revision: 18
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1032: Implement standard exception constructors
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|ImplementStandardExceptionConstructors|
|CheckId|CA1032|
|Category|Microsoft.Design|
|Breaking Change|Non-breaking|

## Cause
 A type extends <xref:System.Exception?displayProperty=fullName> and does not declare all the required constructors.

## Rule Description
 Exception types must implement the following constructors:

- public NewException()

- public NewException(string)

- public NewException(string, Exception)

- protected or private NewException(SerializationInfo, StreamingContext)

  Failure to provide the full set of constructors can make it difficult to correctly handle exceptions. For example, the constructor that has the signature `NewException(string, Exception)` is used to create exceptions that are caused by other exceptions. Without this constructor you cannot create and throw an instance of your custom exception that contains an inner (nested) exception, which is what managed code should do in such a situation. The first three exception constructors are public by convention. The fourth constructor is protected in unsealed classes, and private in sealed classes. For more information, see [CA2229: Implement serialization constructors](../code-quality/ca2229-implement-serialization-constructors.md)

## How to Fix Violations
 To fix a violation of this rule, add the missing constructors to the exception, and make sure that they have the correct accessibility.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule when the violation is caused by using a different access level for the public constructors.

## Example
 The following example contains an exception type that violates this rule and an exception type that is correctly implemented.

 [!code-csharp[FxCop.Design.ExceptionMultipleCtors#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.ExceptionMultipleCtors/cs/FxCop.Design.ExceptionMultipleCtors.cs#1)]
