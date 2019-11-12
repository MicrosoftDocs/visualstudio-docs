---
title: "CA2234: Pass System.Uri objects instead of strings | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "PassSystemUriObjectsInsteadOfStrings"
  - "CA2234"
helpviewer_keywords:
  - "CA2234"
  - "PassSystemUriObjectsInsteadOfStrings"
ms.assetid: 14616b37-74c4-4286-b051-115d00aceb5f
caps.latest.revision: 16
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2234: Pass System.Uri objects instead of strings
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|PassSystemUriObjectsInsteadOfStrings|
|CheckId|CA2234|
|Category|Microsoft.Usage|
|Breaking Change|Non Breaking|

## Cause
 A call is made to a method that has a string parameter whose name contains "uri", "Uri", "urn", "Urn", "url", or "Url"; and the declaring type of the method contains a corresponding method overload that has a <xref:System.Uri?displayProperty=fullName> parameter.

## Rule Description
 A parameter name is split into tokens based on the camel casing convention, and then each token is checked to see whether it equals "uri", "Uri", "urn", "Urn", "url", or "Url". If there is a match, the parameter is assumed to represent a uniform resource identifier (URI). A string representation of a URI is prone to parsing and encoding errors, and can lead to security vulnerabilities. The <xref:System.Uri> class provides these services in a safe and secure manner. When there is a choice between two overloads that differ only regarding the representation of a URI, the user should choose the overload that takes a <xref:System.Uri> argument.

## How to Fix Violations
 To fix a violation of this rule, call the overload that takes the <xref:System.Uri> argument.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule if the string parameter does not represent a URI.

## Example
 The following example shows a method, `ErrorProne`, which violates the rule and a method, `SaferWay`, which correctly calls the <xref:System.Uri> overload.

 [!code-cpp[FxCop.Usage.PassUri#1](../snippets/cpp/VS_Snippets_CodeAnalysis/FxCop.Usage.PassUri/cpp/FxCop.Usage.PassUri.cpp#1)]
 [!code-csharp[FxCop.Usage.PassUri#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.PassUri/cs/FxCop.Usage.PassUri.cs#1)]
 [!code-vb[FxCop.Usage.PassUri#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Usage.PassUri/vb/FxCop.Usage.PassUri.vb#1)]

## Related Rules
 [CA1057: String URI overloads call System.Uri overloads](../code-quality/ca1057-string-uri-overloads-call-system-uri-overloads.md)

 [CA1056: URI properties should not be strings](../code-quality/ca1056-uri-properties-should-not-be-strings.md)

 [CA1054: URI parameters should not be strings](../code-quality/ca1054-uri-parameters-should-not-be-strings.md)

 [CA1055: URI return values should not be strings](../code-quality/ca1055-uri-return-values-should-not-be-strings.md)
