---
title: "CA1056: URI properties should not be strings"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: fdc99d29-0904-4a65-baa8-4f76833c953e
caps.latest.revision: 12
manager: douge
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
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
 This rule splits the property name into tokens based on the Pascal casing convention and checks whether each token equals "uri", "Uri", "urn", "Urn", "url", or "Url". If there is a match, the rule assumes that the property represents a uniform resource identifier (URI). A string representation of a URI is prone to parsing and encoding errors, and can lead to security vulnerabilities. The <xref:System.Uri?qualifyHint=True> class provides these services in a safe and secure manner.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the property to a <xref:System.Uri?qualifyHint=False> type.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the property does not represent a URI.  
  
## Example  
 The following example shows a type, `ErrorProne`, that violates this rule, and a type, `SaferWay`, that satisfies the rule.  
  
 [!CODE [FxCop.Design.UriNotString#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Design.UriNotString#1)]  
  
## Related Rules  
 [CA1054: URI parameters should not be strings](../VS_IDE/CA1054--URI-parameters-should-not-be-strings.md)  
  
 [CA1055: URI return values should not be strings](../VS_IDE/CA1055--URI-return-values-should-not-be-strings.md)  
  
 [CA2234: Pass System.Uri objects instead of strings](../VS_IDE/CA2234--Pass-System.Uri-objects-instead-of-strings.md)  
  
 [CA1057: String URI overloads call System.Uri overloads](../VS_IDE/CA1057--String-URI-overloads-call-System.Uri-overloads.md)