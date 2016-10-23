---
title: "CA1054: URI parameters should not be strings"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8e99d72b-a658-47a7-8dd5-9784ce2c30b8
caps.latest.revision: 14
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
# CA1054: URI parameters should not be strings
|||  
|-|-|  
|TypeName|UriParametersShouldNotBeStrings|  
|CheckId|CA1054|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 A type declares a method with a string parameter whose name contains "uri", "Uri", "urn", "Urn", "url", or "Url" and the type does not declare a corresponding overload that takes a <xref:System.Uri?qualifyHint=True> parameter.  
  
## Rule Description  
 This rule splits the parameter name into tokens based on the camel casing convention and checks whether each token equals "uri", "Uri", "urn", "Urn", "url", or "Url". If there is a match, the rule assumes that the parameter represents a uniform resource identifier (URI). A string representation of a URI is prone to parsing and encoding errors, and can lead to security vulnerabilities. If a method takes a string representation of a URI, a corresponding overload should be provided that takes an instance of the <xref:System.Uri?qualifyHint=False> class, which provides these services in a safe and secure manner.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the parameter to a <xref:System.Uri?qualifyHint=False> type; this is a breaking change. Alternately, provide an overload of the method which takes a <xref:System.Uri?qualifyHint=False> parameter; this is a nonbreaking change.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the parameter does not represent a URI.  
  
## Example  
 The following example shows a type, `ErrorProne`, that violates this rule, and a type, `SaferWay`, that satisfies the rule.  
  
 [!CODE [FxCop.Design.UriNotString#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Design.UriNotString#1)]  
  
## Related Rules  
 [CA1056: URI properties should not be strings](../VS_IDE/CA1056--URI-properties-should-not-be-strings.md)  
  
 [CA1055: URI return values should not be strings](../VS_IDE/CA1055--URI-return-values-should-not-be-strings.md)  
  
 [CA2234: Pass System.Uri objects instead of strings](../VS_IDE/CA2234--Pass-System.Uri-objects-instead-of-strings.md)  
  
 [CA1057: String URI overloads call System.Uri overloads](../VS_IDE/CA1057--String-URI-overloads-call-System.Uri-overloads.md)