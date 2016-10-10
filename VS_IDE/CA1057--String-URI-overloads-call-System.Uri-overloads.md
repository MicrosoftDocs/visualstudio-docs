---
title: "CA1057: String URI overloads call System.Uri overloads"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: ef1e983e-9ca7-404b-82d7-65740ba0ce20
caps.latest.revision: 14
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# CA1057: String URI overloads call System.Uri overloads
|||  
|-|-|  
|TypeName|StringUriOverloadsCallSystemUriOverloads|  
|CheckId|CA1057|  
|Category|Microsoft.Design|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A type declares method overloads that differ only by the replacement of a string parameter with a <xref:System.Uri?qualifyHint=True> parameter, and the overload that takes the string parameter does not call the overload that takes the <xref:System.Uri?qualifyHint=False> parameter.  
  
## Rule Description  
 Because the overloads differ only by the string/<xref:System.Uri?qualifyHint=False> parameter, the string is assumed to represent a uniform resource identifier (URI). A string representation of a URI is prone to parsing and encoding errors, and can lead to security vulnerabilities. The <xref:System.Uri?qualifyHint=False> class provides these services in a safe and secure manner. To reap the benefits of the <xref:System.Uri?qualifyHint=False> class, the string overload should call the <xref:System.Uri?qualifyHint=False> overload using the string argument.  
  
## How to Fix Violations  
 Re-implement the method that uses the string representation of the URI so that it creates an instance of the <xref:System.Uri?qualifyHint=False> class using the string argument, and then passes the <xref:System.Uri?qualifyHint=False> object to the overload that has the <xref:System.Uri?qualifyHint=False> parameter.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the string parameter does not represent a URI.  
  
## Example  
 The following example shows a correctly implemented string overload.  
  
 [!CODE [FxCop.Design.CallUriOverload#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Design.CallUriOverload#1)]  
  
## Related Rules  
 [CA2234: Pass System.Uri objects instead of strings](../VS_IDE/CA2234--Pass-System.Uri-objects-instead-of-strings.md)  
  
 [CA1056: URI properties should not be strings](../VS_IDE/CA1056--URI-properties-should-not-be-strings.md)  
  
 [CA1054: URI parameters should not be strings](../VS_IDE/CA1054--URI-parameters-should-not-be-strings.md)  
  
 [CA1055: URI return values should not be strings](../VS_IDE/CA1055--URI-return-values-should-not-be-strings.md)