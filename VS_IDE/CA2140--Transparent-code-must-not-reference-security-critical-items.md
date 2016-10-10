---
title: "CA2140: Transparent code must not reference security critical items"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 251a12da-0557-47f5-a4f7-0229d590ae7b
caps.latest.revision: 17
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
# CA2140: Transparent code must not reference security critical items
|||  
|-|-|  
|TypeName|TransparentMethodsMustNotReferenceCriticalCode|  
|CheckId|CA2140|  
|Category|Microsoft.Security|  
|Breaking Change|Breaking|  
  
## Cause  
 A transparent method:  
  
-   handles a security critical security exception type  
  
-   has a parameter that is marked as a security critical type  
  
-   has a generic parameter with a security critical constraints  
  
-   has a local variable of a security critical type  
  
-   references a type that is marked as security critical  
  
-   calls a method that is marked as security critical  
  
-   references a field that is marked as security critical  
  
-   returns a type that is marked as security critical  
  
## Rule Description  
 A code element that is marked with the <xref:System.Security.SecurityCriticalAttribute?qualifyHint=False> attribute is security critical. A transparent method cannot use a security critical element. If a transparent type attempts to use a security critical type a <xref:System.TypeAccessException?qualifyHint=False>, <xref:System.MethodAccessException?qualifyHint=False> , or <xref:System.FieldAccessException?qualifyHint=False> is raised.  
  
## How to Fix Violations  
 To fix a violation of this rule, do one of the following:  
  
-   Mark the code element that uses the security critical code with the <xref:System.Security.SecurityCriticalAttribute?qualifyHint=False> attribute  
  
     \- or -  
  
-   Remove the <xref:System.Security.SecurityCriticalAttribute?qualifyHint=False> attribute from the code elements that are marked as security critical and instead mark them with the <xref:System.Security.SecuritySafeCriticalAttribute?qualifyHint=False> or <xref:System.Security.SecurityTransparentAttribute?qualifyHint=False> attribute.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 In the following examples, a transparent method attempts to reference a security critical generic collection, a security critical field, and a security critical method.  
  
 [!CODE [FxCop.Security.CA2140.TransparentMethodsMustNotReferenceCriticalCode#1](../CodeSnippet/VS_Snippets_CodeAnalysis/fxcop.security.ca2140.transparentmethodsmustnotreferencecriticalcode#1)]  
  
## See Also  
 <xref:System.Security.SecurityTransparentAttribute?qualifyHint=False>   
 <xref:System.Security.SecurityCriticalAttribute?qualifyHint=False>   
 <xref:System.Security.SecurityTransparentAttribute?qualifyHint=False>   
 <xref:System.Security.SecurityTreatAsSafeAttribute?qualifyHint=False>   
 <xref:System.Security?qualifyHint=True>