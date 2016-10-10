---
title: "CA1047: Do not declare protected members in sealed types"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 829033b5-a9d8-4f26-a719-45494c9dd035
caps.latest.revision: 16
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
# CA1047: Do not declare protected members in sealed types
|||  
|-|-|  
|TypeName|DoNotDeclareProtectedMembersInSealedTypes|  
|CheckId|CA1047|  
|Category|Microsoft.Design|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A public type is `sealed` (`NotInheritable` in Visual basic) and declares a protected member or a protected nested type. This rule does not report violations for <xref:System.Object.Finalize?qualifyHint=False> methods, which must follow this pattern.  
  
## Rule Description  
 Types declare protected members so that inheriting types can access or override the member. By definition, you cannot inherit from a sealed type, which means that protected methods on sealed types cannot be called.  
  
 The C# compiler issues a warning for this error.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the access level of the member to private, or make the type inheritable.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule. Leaving the type in its current state can cause maintenance issues and does not provide any benefits.  
  
## Example  
 The following example shows a type that violates this rule.  
  
 [!CODE [FxCop.Design.SealedNoProtected#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Design.SealedNoProtected#1)]