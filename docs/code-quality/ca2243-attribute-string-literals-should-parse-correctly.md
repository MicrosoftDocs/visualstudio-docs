---
title: "CA2243: Attribute string literals should parse correctly | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "CA2243"
  - "AttributeStringLiteralsShouldParseCorrectly"
helpviewer_keywords: 
  - "AttributeStringLiteralsShouldParseCorrectly"
  - "CA2243"
ms.assetid: bfadb366-379d-4ee4-b17b-c4a09bf1106b
caps.latest.revision: 10
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
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
# CA2243: Attribute string literals should parse correctly
|||  
|-|-|  
|TypeName|AttributeStringLiteralsShouldParseCorrectly|  
|CheckId|CA2243|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 An attribute's string literal parameter does not parse correctly for a URL, GUID, or Version.  
  
## Rule Description  
 Since attributes are derived from <xref:System.Attribute?displayProperty=fullName>, and attributes are used at compile time, only constant values can be passed to their constructors. Attribute parameters that must represent URLs, GUIDs and Versions cannot be typed as <xref:System.Uri?displayProperty=fullName>, <xref:System.Guid?displayProperty=fullName>, and <xref:System.Version?displayProperty=fullName>, because these types cannot be represented as constants. Instead, they must be represented by strings.  
  
 Because the parameter is typed as a string, it is possible that an incorrectly formatted parameter could be passed at compile time.  
  
 This rule uses a naming heuristic to find parameters that represent a uniform resource identifier (URI), a Globally Unique Identifier (GUID) or a Version and verifies that the passed value is correct.  
  
## How to Fix Violations  
 Change the parameter string to a correctly formed URL, GUID, or Version.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the parameter does not represent a URL, GUID, or Version.  
  
## Example  
 The following example shows code for the AssemblyFileVersionAttribute that violates this rule.  
  
 [!code-cs[FxCop.Usage.AttributeStringLiteralsShouldParseCorrectly#1](../code-quality/codesnippet/CSharp/ca2243-attribute-string-literals-should-parse-correctly_1.cs)]  
  
 The rule is triggered by the following:  
  
-   Parameters that contain ‘version’ and cannot be parsed to System.Version.  
  
-   Parameters that contain ‘guid’ and cannot be parsed to System.Guid.  
  
-   Parameters that contain ‘uri’, 'urn', or ‘url’ and cannot be parsed to System.Uri.  
  
## See Also  
 [CA1054: URI parameters should not be strings](../code-quality/ca1054-uri-parameters-should-not-be-strings.md)