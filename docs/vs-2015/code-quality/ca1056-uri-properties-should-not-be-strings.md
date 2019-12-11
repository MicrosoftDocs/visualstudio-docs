---
title: "CA1056: URI properties should not be strings | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "UriPropertiesShouldNotBeStrings"
  - "CA1056"
helpviewer_keywords:
  - "UriPropertiesShouldNotBeStrings"
  - "CA1056"
ms.assetid: fdc99d29-0904-4a65-baa8-4f76833c953e
caps.latest.revision: 14
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1056: URI properties should not be strings
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|UriPropertiesShouldNotBeStrings|
|CheckId|CA1056|
|Category|Microsoft.Design|
|Breaking Change|Breaking|

## Cause
 A type declares a string property whose name contains "uri", "Uri", "urn", "Urn", "url", or "Url".

## Rule Description
 This rule splits the property name into tokens based on the Pascal casing convention and checks whether each token equals "uri", "Uri", "urn", "Urn", "url", or "Url". If there is a match, the rule assumes that the property represents a uniform resource identifier (URI). A string representation of a URI is prone to parsing and encoding errors, and can lead to security vulnerabilities. The <xref:System.Uri?displayProperty=fullName> class provides these services in a safe and secure manner.

## How to Fix Violations
 To fix a violation of this rule, change the property to a <xref:System.Uri> type.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule if the property does not represent a URI.

## Example
 The following example shows a type, `ErrorProne`, that violates this rule, and a type, `SaferWay`, that satisfies the rule.

 [!code-cpp[FxCop.Design.UriNotString#1](../snippets/cpp/VS_Snippets_CodeAnalysis/FxCop.Design.UriNotString/cpp/FxCop.Design.UriNotString.cpp#1)]
 [!code-csharp[FxCop.Design.UriNotString#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.UriNotString/cs/FxCop.Design.UriNotString.cs#1)]
 [!code-vb[FxCop.Design.UriNotString#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Design.UriNotString/vb/FxCop.Design.UriNotString.vb#1)]

## Related Rules
 [CA1054: URI parameters should not be strings](../code-quality/ca1054-uri-parameters-should-not-be-strings.md)

 [CA1055: URI return values should not be strings](../code-quality/ca1055-uri-return-values-should-not-be-strings.md)

 [CA2234: Pass System.Uri objects instead of strings](../code-quality/ca2234-pass-system-uri-objects-instead-of-strings.md)

 [CA1057: String URI overloads call System.Uri overloads](../code-quality/ca1057-string-uri-overloads-call-system-uri-overloads.md)
