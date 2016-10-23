---
title: "CA2146: Types must be at least as critical as their base types and interfaces"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 241fb784-1f6b-46e5-8ceb-c438e341d38e
caps.latest.revision: 11
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
# CA2146: Types must be at least as critical as their base types and interfaces
|||  
|-|-|  
|TypeName|TypesMustBeAtLeastAsCriticalAsBaseTypes|  
|CheckId|CA2146|  
|Category|Microsoft.Security|  
|Breaking Change|Breaking|  
  
## Cause  
 A transparent type is derived from a type that is marked with the <xref:System.Security.SecuritySafeCriticalAttribute?qualifyHint=False> or the <xref:System.Security.SecurityCriticalAttribute?qualifyHint=False>, or a type that is marked with the <xref:System.Security.SecuritySafeCriticalAttribute?qualifyHint=False> attribute is derived from a type that is marked with the <xref:System.Security.SecurityCriticalAttribute?qualifyHint=False> attribute.  
  
## Rule Description  
 This rule fires when a derived type has a security transparency attribute that is not as critical as its base type or implemented interface. Only critical types can derive from critical base types or implement critical interfaces, and only critical or safe-critical types can derive from safe-critical base types or implement safe-critical interfaces. Violations of this rule in level 2 transparency result in a <xref:System.TypeLoadException?qualifyHint=False> for the derived type.  
  
## How to Fix Violations  
 To fix this violation, mark the derived or implementing type with a transparency attribute that is at least as critical as the base type or interface.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 [!CODE [FxCop.Security.CA2146.TypesMustBeAtLeastAsCriticalAsBaseTypes#1](../CodeSnippet/VS_Snippets_CodeAnalysis/fxcop.security.ca2146.typesmustbeatleastascriticalasbasetypes#1)]