---
title: "CA1056: URI properties should not be strings"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "UriPropertiesShouldNotBeStrings"
  - "CA1056"
helpviewer_keywords: 
  - "UriPropertiesShouldNotBeStrings"
  - "CA1056"
ms.assetid: fdc99d29-0904-4a65-baa8-4f76833c953e
caps.latest.revision: 12
ms.author: "douge"
manager: "douge"
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
# CA1056: URI properties should not be strings
|||  
|-|-|  
|TypeName|UriPropertiesShouldNotBeStrings|  
|CheckId|CA1056|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 A type declares a string property whose name contains "uri", "Uri", "urn", "Urn", "url", or "Url".  
  
## Rule Description  
 This rule splits the property name into tokens based on the Pascal casing convention and checks whether each token equals "uri", "Uri", "urn", "Urn", "url", or "Url". If there is a match, the rule assumes that the property represents a uniform resource identifier (URI). A string representation of a URI is prone to parsing and encoding errors, and can lead to security vulnerabilities. The \<xref:System.Uri?displayProperty=fullName> class provides these services in a safe and secure manner.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the property to a \<xref:System.Uri> type.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the property does not represent a URI.  
  
## Example  
 The following example shows a type, `ErrorProne`, that violates this rule, and a type, `SaferWay`, that satisfies the rule.  
  
 [!code[FxCop.Design.UriNotString#1](../codequality/codesnippet/CSharp/ca1056--uri-properties-should-not-be-strings_1.cs)]
[!code[FxCop.Design.UriNotString#1](../codequality/codesnippet/VisualBasic/ca1056--uri-properties-should-not-be-strings_1.vb)]
[!code[FxCop.Design.UriNotString#1](../codequality/codesnippet/CPP/ca1056--uri-properties-should-not-be-strings_1.cpp)]  
  
## Related Rules  
 [CA1054: URI parameters should not be strings](../codequality/ca1054--uri-parameters-should-not-be-strings.md)  
  
 [CA1055: URI return values should not be strings](../codequality/ca1055--uri-return-values-should-not-be-strings.md)  
  
 [CA2234: Pass System.Uri objects instead of strings](../codequality/ca2234--pass-system.uri-objects-instead-of-strings.md)  
  
 [CA1057: String URI overloads call System.Uri overloads](../codequality/ca1057--string-uri-overloads-call-system.uri-overloads.md)