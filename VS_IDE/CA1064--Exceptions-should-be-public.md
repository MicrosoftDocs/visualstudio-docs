---
title: "CA1064: Exceptions should be public"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 83eb224c-2456-4368-acf4-3b3378e67759
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
# CA1064: Exceptions should be public
|||  
|-|-|  
|TypeName|ExceptionsShouldBePublic|  
|CheckId|CA1064|  
|Category|Microsoft.Design|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A non-public exception derives directly from <xref:System.Exception?qualifyHint=False>, <xref:System.SystemException?qualifyHint=False>, or <xref:System.ApplicationException?qualifyHint=False>.  
  
## Rule Description  
 An internal exception is only visible inside its own internal scope. After the exception falls outside the internal scope, only the base exception can be used to catch the exception. If the internal exception is inherited from <xref:System.Exception?qualifyHint=False>, <xref:System.SystemException?qualifyHint=False>, or <xref:System.ApplicationException?qualifyHint=False>, the external code will not have sufficient information to know what to do with the exception.  
  
 But, if the code has a public exception that later is used as the base for a internal exception, it is reasonable to assume the code further out will be able to do something intelligent with the base exception. The public exception will have more information than what is provided by T:System.Exception, T:System.SystemException, or T:System.ApplicationException.  
  
## How to Fix Violations  
 Make the exception public, or derive the internal exception from a public exception that is not <xref:System.Exception?qualifyHint=False>, <xref:System.SystemException?qualifyHint=False>, or <xref:System.ApplicationException?qualifyHint=False>.  
  
## When to Suppress Warnings  
 Suppress a message from this rule if you are sure in all cases that the private exception will be caught within its own internal scope.  
  
## Example  
 This rule fires on the first example method, FirstCustomException because the exception class derives directly from Exception and is internal. The rule does not fire on the SecondCustomException class because although the class also derives directly from Exception, the class is declared public. The third class also does not fire the rule because it does not derive directly from <xref:System.Exception?qualifyHint=True>, <xref:System.SystemException?qualifyHint=True>, or <xref:System.ApplicationException?qualifyHint=True>.  
  
 [!CODE [FxCop.Design.ExceptionsShouldBePublic.CA1064#1](../CodeSnippet/VS_Snippets_CodeAnalysis/fxcop.design.exceptionsshouldbepublic.ca1064#1)]