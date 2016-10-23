---
title: "CA1055: URI return values should not be strings"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 40e39873-7872-4988-8195-9eb0ade9ece0
caps.latest.revision: 13
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
# CA1055: URI return values should not be strings
|||  
|-|-|  
|TypeName|UriReturnValuesShouldNotBeStrings|  
|CheckId|CA1055|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 The name of a method contains "uri", "Uri", "urn", "Urn", "url", or "Url", and the method returns a string.  
  
## Rule Description  
 This rule splits the method name into tokens based on the Pascal casing convention and checks whether each token equals "uri", "Uri", "urn", "Urn", "url", or "Url". If there is a match, the rule assumes that the method returns a uniform resource identifier (URI). A string representation of a URI is prone to parsing and encoding errors, and can lead to security vulnerabilities. The <xref:System.Uri?qualifyHint=True> class provides these services in a safe and secure manner.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the return type to a <xref:System.Uri?qualifyHint=False>.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the return value does not represent a URI.  
  
## Example  
 The following example shows a type, `ErrorProne`, that violates this rule, and a type, `SaferWay`, that satisfies the rule.  
  
 [!CODE [FxCop.Design.UriNotString#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Design.UriNotString#1)]  
  
## Related Rules  
 [CA1056: URI properties should not be strings](../VS_IDE/CA1056--URI-properties-should-not-be-strings.md)  
  
 [CA1054: URI parameters should not be strings](../VS_IDE/CA1054--URI-parameters-should-not-be-strings.md)  
  
 [CA2234: Pass System.Uri objects instead of strings](../VS_IDE/CA2234--Pass-System.Uri-objects-instead-of-strings.md)  
  
 [CA1057: String URI overloads call System.Uri overloads](../VS_IDE/CA1057--String-URI-overloads-call-System.Uri-overloads.md)