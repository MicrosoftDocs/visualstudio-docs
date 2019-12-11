---
title: "CA1054: URI parameters should not be strings | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1054"
  - "UriParametersShouldNotBeStrings"
helpviewer_keywords:
  - "CA1054"
  - "UriParametersShouldNotBeStrings"
ms.assetid: 8e99d72b-a658-47a7-8dd5-9784ce2c30b8
caps.latest.revision: 16
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1054: URI parameters should not be strings
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|UriParametersShouldNotBeStrings|
|CheckId|CA1054|
|Category|Microsoft.Design|
|Breaking Change|Breaking|

## Cause
 A type declares a method with a string parameter whose name contains "uri", "Uri", "urn", "Urn", "url", or "Url" and the type does not declare a corresponding overload that takes a <xref:System.Uri?displayProperty=fullName> parameter.

## Rule Description
 This rule splits the parameter name into tokens based on the camel casing convention and checks whether each token equals "uri", "Uri", "urn", "Urn", "url", or "Url". If there is a match, the rule assumes that the parameter represents a uniform resource identifier (URI). A string representation of a URI is prone to parsing and encoding errors, and can lead to security vulnerabilities. If a method takes a string representation of a URI, a corresponding overload should be provided that takes an instance of the <xref:System.Uri> class, which provides these services in a safe and secure manner.

## How to Fix Violations
 To fix a violation of this rule, change the parameter to a <xref:System.Uri> type; this is a breaking change. Alternately, provide an overload of the method which takes a <xref:System.Uri> parameter; this is a nonbreaking change.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule if the parameter does not represent a URI.

## Example
 The following example shows a type, `ErrorProne`, that violates this rule, and a type, `SaferWay`, that satisfies the rule.

 [!code-cpp[FxCop.Design.UriNotString#1](../snippets/cpp/VS_Snippets_CodeAnalysis/FxCop.Design.UriNotString/cpp/FxCop.Design.UriNotString.cpp#1)]
 [!code-csharp[FxCop.Design.UriNotString#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.UriNotString/cs/FxCop.Design.UriNotString.cs#1)]
 [!code-vb[FxCop.Design.UriNotString#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Design.UriNotString/vb/FxCop.Design.UriNotString.vb#1)]

## Related Rules
 [CA1056: URI properties should not be strings](../code-quality/ca1056-uri-properties-should-not-be-strings.md)

 [CA1055: URI return values should not be strings](../code-quality/ca1055-uri-return-values-should-not-be-strings.md)

 [CA2234: Pass System.Uri objects instead of strings](../code-quality/ca2234-pass-system-uri-objects-instead-of-strings.md)

 [CA1057: String URI overloads call System.Uri overloads](../code-quality/ca1057-string-uri-overloads-call-system-uri-overloads.md)
