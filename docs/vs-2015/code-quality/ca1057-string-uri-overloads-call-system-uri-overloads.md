---
title: "CA1057: String URI overloads call System.Uri overloads | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1057"
  - "StringUriOverloadsCallSystemUriOverloads"
helpviewer_keywords:
  - "StringUriOverloadsCallSystemUriOverloads"
  - "CA1057"
ms.assetid: ef1e983e-9ca7-404b-82d7-65740ba0ce20
caps.latest.revision: 16
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1057: String URI overloads call System.Uri overloads
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|StringUriOverloadsCallSystemUriOverloads|
|CheckId|CA1057|
|Category|Microsoft.Design|
|Breaking Change|Non-breaking|

## Cause
 A type declares method overloads that differ only by the replacement of a string parameter with a <xref:System.Uri?displayProperty=fullName> parameter, and the overload that takes the string parameter does not call the overload that takes the <xref:System.Uri> parameter.

## Rule Description
 Because the overloads differ only by the string/<xref:System.Uri> parameter, the string is assumed to represent a uniform resource identifier (URI). A string representation of a URI is prone to parsing and encoding errors, and can lead to security vulnerabilities. The <xref:System.Uri> class provides these services in a safe and secure manner. To reap the benefits of the <xref:System.Uri> class, the string overload should call the <xref:System.Uri> overload using the string argument.

## How to Fix Violations
 Re-implement the method that uses the string representation of the URI so that it creates an instance of the <xref:System.Uri> class using the string argument, and then passes the <xref:System.Uri> object to the overload that has the <xref:System.Uri> parameter.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule if the string parameter does not represent a URI.

## Example
 The following example shows a correctly implemented string overload.

 [!code-cpp[FxCop.Design.CallUriOverload#1](../snippets/cpp/VS_Snippets_CodeAnalysis/FxCop.Design.CallUriOverload/cpp/FxCop.Design.CallUriOverload.cpp#1)]
 [!code-csharp[FxCop.Design.CallUriOverload#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.CallUriOverload/cs/FxCop.Design.CallUriOverload.cs#1)]
 [!code-vb[FxCop.Design.CallUriOverload#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Design.CallUriOverload/vb/FxCop.Design.CallUriOverload.vb#1)]

## Related Rules
 [CA2234: Pass System.Uri objects instead of strings](../code-quality/ca2234-pass-system-uri-objects-instead-of-strings.md)

 [CA1056: URI properties should not be strings](../code-quality/ca1056-uri-properties-should-not-be-strings.md)

 [CA1054: URI parameters should not be strings](../code-quality/ca1054-uri-parameters-should-not-be-strings.md)

 [CA1055: URI return values should not be strings](../code-quality/ca1055-uri-return-values-should-not-be-strings.md)
