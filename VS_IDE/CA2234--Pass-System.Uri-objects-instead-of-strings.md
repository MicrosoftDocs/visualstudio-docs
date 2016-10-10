---
title: "CA2234: Pass System.Uri objects instead of strings"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 14616b37-74c4-4286-b051-115d00aceb5f
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
# CA2234: Pass System.Uri objects instead of strings
|||  
|-|-|  
|TypeName|PassSystemUriObjectsInsteadOfStrings|  
|CheckId|CA2234|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A call is made to a method that has a string parameter whose name contains "uri", "Uri", "urn", "Urn", "url", or "Url"; and the declaring type of the method contains a corresponding method overload that has a <xref:System.Uri?qualifyHint=True> parameter.  
  
## Rule Description  
 A parameter name is split into tokens based on the camel casing convention, and then each token is checked to see whether it equals "uri", "Uri", "urn", "Urn", "url", or "Url". If there is a match, the parameter is assumed to represent a uniform resource identifier (URI). A string representation of a URI is prone to parsing and encoding errors, and can lead to security vulnerabilities. The <xref:System.Uri?qualifyHint=False> class provides these services in a safe and secure manner. When there is a choice between two overloads that differ only regarding the representation of a URI, the user should choose the overload that takes a <xref:System.Uri?qualifyHint=False> argument.  
  
## How to Fix Violations  
 To fix a violation of this rule, call the overload that takes the <xref:System.Uri?qualifyHint=False> argument.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the string parameter does not represent a URI.  
  
## Example  
 The following example shows a method, `ErrorProne`, which violates the rule and a method, `SaferWay`, which correctly calls the <xref:System.Uri?qualifyHint=False> overload.  
  
 [!CODE [FxCop.Usage.PassUri#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.PassUri#1)]  
  
## Related Rules  
 [CA1057: String URI overloads call System.Uri overloads](../VS_IDE/CA1057--String-URI-overloads-call-System.Uri-overloads.md)  
  
 [CA1056: URI properties should not be strings](../VS_IDE/CA1056--URI-properties-should-not-be-strings.md)  
  
 [CA1054: URI parameters should not be strings](../VS_IDE/CA1054--URI-parameters-should-not-be-strings.md)  
  
 [CA1055: URI return values should not be strings](../VS_IDE/CA1055--URI-return-values-should-not-be-strings.md)